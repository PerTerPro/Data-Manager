namespace WSS.Service.ReportProductAdsScoreError
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
            this.WSS_Service_ReportProductAdsScoreError = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller1
            // 
            this.serviceProcessInstaller1.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.serviceProcessInstaller1.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.WSS_Service_ReportProductAdsScoreError});
            this.serviceProcessInstaller1.Password = null;
            this.serviceProcessInstaller1.Username = null;
            // 
            // WSS_Service_ReportProductAdsScoreError
            // 
            this.WSS_Service_ReportProductAdsScoreError.Description = "WSS.Service.ReportProductAdsScoreError";
            this.WSS_Service_ReportProductAdsScoreError.DisplayName = "WSS.Service.ReportProductAdsScoreError";
            this.WSS_Service_ReportProductAdsScoreError.ServiceName = "WSS.Service.ReportProductAdsScoreError";
            this.WSS_Service_ReportProductAdsScoreError.StartType = System.ServiceProcess.ServiceStartMode.Automatic;
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.serviceProcessInstaller1});

        }

        #endregion

        private System.ServiceProcess.ServiceInstaller WSS_Service_ReportProductAdsScoreError;
        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller1;
    }
}