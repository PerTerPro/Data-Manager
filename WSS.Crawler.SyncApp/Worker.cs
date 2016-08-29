using Ionic.Zip;
using QT.Moduls.CrawlerProduct.Cache;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WSS.Crawler.SyncApp
{
    class Worker
    {
        log4net.ILog log = log4net.LogManager.GetLogger(typeof(Worker));public void Start ()
        {
            while (true)
            {
                try
                {
                    SettingRun settingRun = this.GetSettingRun();
                    Directory.CreateDirectory(settingRun.PathApp);
                    string fileName = DateTime.Now.ToString("yyyyMMddHHmmss.ZIP");
                    string versionCurrent = settingRun.VersionCurrent;
                    var redisVersion = RedisVersionAutoCrawler.Instance();
                    var cacheVersion = redisVersion.GetCurrentVersion();
                    log.Info(string.Format("CurrentVersion:{0} NewVersion:{1}", versionCurrent, cacheVersion.Version));
                    if (cacheVersion.Version == "0")
                    {
                        StopApp(settingRun.FileRun);
                    }
                    else if (cacheVersion.Version != versionCurrent)
                    {
                        log.Info("Stop current running!");
                        StopApp(settingRun.FileRun);

                        log.Info(string.Format("Download new verrsion to temp file"));
                        DownloadFile(cacheVersion.Url, fileName);

                        log.Info("Extraction version to path");
                        ExtractionFile(fileName, settingRun.PathApp);

                        log.Info("Run app");

                        for (int i = 0; i < settingRun.NumberApp; i++)
                        {

                            var info =
                                new ProcessStartInfo(settingRun.PathApp + @"\" +
                                                     settingRun.FileRun, settingRun.Parameter);
                            info.CreateNoWindow = true;
                            info.UseShellExecute = true;
                            info.WindowStyle = ProcessWindowStyle.Normal;
                            Process p = Process.Start(info);
                        }

                        settingRun.VersionCurrent = cacheVersion.Version;
                        File.WriteAllText("SettingRun.txt", settingRun.GetJSON());
                    }
                    else
                    {
                        log.Info("Not change version. Sleep 1s");
                    }
                    Thread.Sleep(1000 * 60);
                }
                catch (Exception ex)
                {log.Error(ex);
                    Thread.Sleep(10000);
                }}
        }

        private SettingRun GetSettingRun()
        {
            return  SettingRun.FromJSON(File.ReadAllText("SettingRun.txt"));
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

        public void DownloadFile (string url, string fileName)
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
