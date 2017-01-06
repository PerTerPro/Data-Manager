using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using QT.Moduls.CrawlerProduct;
using QT.Moduls.CrawlerProduct.Cache;
using WSS.Core.Crawler;

namespace WSS.Crawler.SyncApp
{
    internal class Worker
    {
        private log4net.ILog log = log4net.LogManager.GetLogger(typeof(Worker));

        public void Start()
        {
            List<Tuple<string, string>> lstRun = new List<Tuple<string, string>>();

            while (true)
            {
                try
                {
                    var redisVersion = RedisVersionAutoCrawler.Instance();
                    SettingRun[] settingRuns = this.GetSettingRun();
                    string localVersion = redisVersion.GetVersion(settingRuns[0].Runner);
                    var cacheVersion = redisVersion.GetCurrentVersion();

                    if (cacheVersion.Version == "0")
                    {
                        log.Info("Only stop app running");
                        StopApp(settingRuns[0].FileRun);
                    }
                    else if (localVersion == cacheVersion.Version)
                    {
                        log.Info("Not change version. Wait next");
                    }
                    else
                    {
                        try
                        {
                            log.Info("Start run syn new version");
                            log.Info(string.Format("Download new verrsion to temp file"));
                            string fileVersionDownload = DateTime.Now.ToString("yyyyMMddHHmmss.ZIP");
                            DownloadFile(cacheVersion.Url, @"Temp/" + fileVersionDownload);

                            settingRuns = (new RedisParameterCrlAdapter()).GetSettingRun(settingRuns[0].Runner);
                            log.Info("Stop current running!");
                            StopApp(settingRuns[0].FileRun);

                            foreach (var settingRun in settingRuns)
                            {
                                DirectoryInfo di = Directory.CreateDirectory(settingRun.PathApp);
                                DirectoryInfo dir1 = Directory.CreateDirectory("Temp");


                                log.Info("Extraction version to path");
                                ExtractionFile(@"Temp\" + fileVersionDownload, settingRun.PathApp);
                                log.Info("Run app");
                                var f = settingRun.PathApp + @"\" + settingRun.FileRun;
                                string paraAtRedis = settingRun.Parameter;
                                lstRun.Add(new Tuple<string, string>(f, paraAtRedis));

                                redisVersion.SetVersion(settingRun.Runner, cacheVersion.Version);
                            }
                            foreach (var VARIABLE in lstRun)
                            {
                                Process p = Process.Start(VARIABLE.Item1, VARIABLE.Item2);
                            }

                            lstRun.Clear();
                        }
                        catch (Exception ex1)
                        {
                            log.Error(ex1);
                        }
                    }
                    Thread.Sleep(1000 * 60);
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    Thread.Sleep(10000);
                }
            }

        }

        private string GetVersionCurrent(string pathApp)
        {
            if (!File.Exists(pathApp)) return "";
            else return Convert.ToString(File.ReadAllText(pathApp + @"\Version.txt"));
        }

        private SettingRun[] GetSettingRun()
        {
            return SettingRun.GetArFromJson(File.ReadAllText("SettingRun.txt"));
        }
        private void StopApp(string nameApp)
        {
            foreach (Process proc in Process.GetProcesses())
            {
                if (proc.ProcessName.Contains(nameApp.Trim().Replace(".exe", "")))
                    proc.Kill();
            }
        }
        private void ExtractionFile(string fileName, string pathToApp)
        {
            ZipFile zip = ZipFile.Read(fileName);
            Directory.CreateDirectory(pathToApp);
            foreach (ZipEntry e in zip)
            {
                e.Extract(pathToApp, ExtractExistingFileAction.OverwriteSilently);
            }
        }

        private void DownloadChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            log.Info(e.ProgressPercentage);
        }

        private void EventDownloadOK(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            log.Info("OK");
        }

        public void DownloadFile(string url, string fileName)
        {
            using (WebClient myWebClient = new WebClient())
            {
                myWebClient.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(EventDownloadOK);
                myWebClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(DownloadChanged);
                myWebClient.DownloadFile(url, fileName);
            }
        }

        private void clearFolder(string FolderName)
        {
            DirectoryInfo dir = new DirectoryInfo(FolderName);

            foreach (FileInfo fi in dir.GetFiles())
            {
                fi.Delete();
            }

            foreach (DirectoryInfo di in dir.GetDirectories())
            {
                clearFolder(di.FullName);
                di.Delete();
            }
        }
    }


}
