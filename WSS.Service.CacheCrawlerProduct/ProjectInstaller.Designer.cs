﻿namespace WSS.Service.Crawler.Cache.Product
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.serviceProcessInstaller1 = new System.ServiceProcess.ServiceProcessInstaller();
            this.WSS_Service_CacheCrawlerProduct_Install = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller1
            // 
            this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstaller1.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.WSS_Service_CacheCrawlerProduct_Install});
            this.serviceProcessInstaller1.Password = null;
            this.serviceProcessInstaller1.Username = null;
            // 
            // WSS_Service_CacheCrawlerProduct_Install
            // 
            this.WSS_Service_CacheCrawlerProduct_Install.Description = "WSS.Service.Crawler.Cache.Product";
            this.WSS_Service_CacheCrawlerProduct_Install.DisplayName = "WSS.Service.Crawler.Cache.Product";
            this.WSS_Service_CacheCrawlerProduct_Install.ServiceName = "WSS.Service.Crawler.Cache.Product";
            this.WSS_Service_CacheCrawlerProduct_Install.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller1});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller1;
        private System.ServiceProcess.ServiceInstaller WSS_Service_CacheCrawlerProduct_Install;
    }
}