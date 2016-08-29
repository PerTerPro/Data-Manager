namespace WSS.Service.UpdateCountView
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
            this.WSS_Service_CacheCrawlerProduct_CheckDuplicateProduct = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller1
            // 
            this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstaller1.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.WSS_Service_CacheCrawlerProduct_CheckDuplicateProduct});
            this.serviceProcessInstaller1.Password = null;
            this.serviceProcessInstaller1.Username = null;
            // 
            // WSS_Service_CacheCrawlerProduct_CheckDuplicateProduct
            // 
            this.WSS_Service_CacheCrawlerProduct_CheckDuplicateProduct.Description = "WSS.Service.UpdateCountView";
            this.WSS_Service_CacheCrawlerProduct_CheckDuplicateProduct.DisplayName = "WSS.Service.UpdateCountView";
            this.WSS_Service_CacheCrawlerProduct_CheckDuplicateProduct.ServiceName = "WSS.Service.UpdateCountView";
            this.WSS_Service_CacheCrawlerProduct_CheckDuplicateProduct.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller1});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller1;
        private System.ServiceProcess.ServiceInstaller WSS_Service_CacheCrawlerProduct_CheckDuplicateProduct;
    }
}