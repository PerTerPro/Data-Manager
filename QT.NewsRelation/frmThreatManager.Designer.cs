namespace QT.NewsRelation
{
    partial class frmThreatManager
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label sapoLabel;
            System.Windows.Forms.Label textContentLabel;
            System.Windows.Forms.Label imageLabel;
            System.Windows.Forms.Label titleUrlLabel;
            System.Windows.Forms.Label tagLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label categoryMapLabel;
            System.Windows.Forms.Label viewMonthLabel;
            System.Windows.Forms.Label viewWeekLabel;
            System.Windows.Forms.Label viewYearLabel;
            System.Windows.Forms.Label viewAllLabel;
            System.Windows.Forms.Label countCommentLabel;
            System.Windows.Forms.Label voteGoodLabel;
            System.Windows.Forms.Label voteBadLabel;
            System.Windows.Forms.Label lastChangeContentLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label iDLabel1;
            System.Windows.Forms.Label iDThreatLabel;
            System.Windows.Forms.Label lastUpdateLabel;
            System.Windows.Forms.Label rankTypeLabel;
            System.Windows.Forms.Label iDLabel2;
            System.Windows.Forms.Label iDLabel3;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThreatManager));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btPhanTich = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.grvContent = new DevExpress.XtraGrid.GridControl();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIntro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTextContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHtmlContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPublishTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTags = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBreadCrumb = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuplicate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.rankTypeTextBox = new System.Windows.Forms.TextBox();
            this.threatConfigBindingSource = new System.Windows.Forms.BindingSource();
            this.dB = new QT.NewsRelation.DB();
            this.lastUpdate_in_ThreadconfigDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.iDThread_inConfig_TextBox = new System.Windows.Forms.TextBox();
            this.iDConfigTextBox = new System.Windows.Forms.TextBox();
            this.btGetNewID = new System.Windows.Forms.Button();
            this.laNewID = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.threatBindingSource = new System.Windows.Forms.BindingSource();
            this.sapoTextBox = new System.Windows.Forms.TextBox();
            this.textContentTextBox = new System.Windows.Forms.TextBox();
            this.imageTextBox = new System.Windows.Forms.TextBox();
            this.titleUrlTextBox = new System.Windows.Forms.TextBox();
            this.tagTextBox = new System.Windows.Forms.TextBox();
            this.categoryIDTextBox = new System.Windows.Forms.TextBox();
            this.categoryMapTextBox = new System.Windows.Forms.TextBox();
            this.viewMonthTextBox = new System.Windows.Forms.TextBox();
            this.viewWeekTextBox = new System.Windows.Forms.TextBox();
            this.viewYearTextBox = new System.Windows.Forms.TextBox();
            this.viewAllTextBox = new System.Windows.Forms.TextBox();
            this.countCommentTextBox = new System.Windows.Forms.TextBox();
            this.voteGoodTextBox = new System.Windows.Forms.TextBox();
            this.voteBadTextBox = new System.Windows.Forms.TextBox();
            this.lastChangeContentDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingNavigator3 = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.threatConfigOrContainBindingSource = new System.Windows.Forms.BindingSource();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colContain1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRatio1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.threatConfigContainBindingSource = new System.Windows.Forms.BindingSource();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btUpdate_Contain = new System.Windows.Forms.ToolStripButton();
            this.btRefreshContain = new System.Windows.Forms.ToolStripButton();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colContain = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRatio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iD_ThreadConfig_ContainTextBox = new System.Windows.Forms.TextBox();
            this.iD_ThreadConfig_NotContainTextBox = new System.Windows.Forms.TextBox();
            this.threatConfigNotContainBindingSource = new System.Windows.Forms.BindingSource();
            this.label4 = new System.Windows.Forms.Label();
            this.bindingNavigator4 = new System.Windows.Forms.BindingNavigator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.threatConfigOrNotContainBindingSource = new System.Windows.Forms.BindingSource();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.label5 = new System.Windows.Forms.Label();
            this.gridControl4 = new DevExpress.XtraGrid.GridControl();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bindingNavigator5 = new System.Windows.Forms.BindingNavigator();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton16 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox3 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton17 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.btUpdateNotContain = new System.Windows.Forms.ToolStripButton();
            this.btRefreshNotContain = new System.Windows.Forms.ToolStripButton();
            this.gridControl5 = new DevExpress.XtraGrid.GridControl();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iDThreadTextBox = new System.Windows.Forms.TextBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btUpdate = new System.Windows.Forms.ToolStripButton();
            this.btReload = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSapo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewMonth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colViewAll = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCountComment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoteGood = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVoteBad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastChangeContent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.threatTableAdapter = new QT.NewsRelation.DBTableAdapters.ThreatTableAdapter();
            this.tableAdapterManager = new QT.NewsRelation.DBTableAdapters.TableAdapterManager();
            this.threatConfig_ContainTableAdapter = new QT.NewsRelation.DBTableAdapters.ThreatConfig_ContainTableAdapter();
            this.threatConfig_OrContainTableAdapter = new QT.NewsRelation.DBTableAdapters.ThreatConfig_OrContainTableAdapter();
            this.threatConfig_NotContainTableAdapter = new QT.NewsRelation.DBTableAdapters.ThreatConfig_NotContainTableAdapter();
            this.threatConfig_OrNotContainTableAdapter = new QT.NewsRelation.DBTableAdapters.ThreatConfig_OrNotContainTableAdapter();
            this.threatConfigTableAdapter = new QT.NewsRelation.DBTableAdapters.ThreatConfigTableAdapter();
            this.iDThreatTextBox = new System.Windows.Forms.TextBox();
            iDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            sapoLabel = new System.Windows.Forms.Label();
            textContentLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            titleUrlLabel = new System.Windows.Forms.Label();
            tagLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            categoryMapLabel = new System.Windows.Forms.Label();
            viewMonthLabel = new System.Windows.Forms.Label();
            viewWeekLabel = new System.Windows.Forms.Label();
            viewYearLabel = new System.Windows.Forms.Label();
            viewAllLabel = new System.Windows.Forms.Label();
            countCommentLabel = new System.Windows.Forms.Label();
            voteGoodLabel = new System.Windows.Forms.Label();
            voteBadLabel = new System.Windows.Forms.Label();
            lastChangeContentLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            iDLabel1 = new System.Windows.Forms.Label();
            iDThreatLabel = new System.Windows.Forms.Label();
            lastUpdateLabel = new System.Windows.Forms.Label();
            rankTypeLabel = new System.Windows.Forms.Label();
            iDLabel2 = new System.Windows.Forms.Label();
            iDLabel3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threatConfigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threatBindingSource)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).BeginInit();
            this.bindingNavigator3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threatConfigOrContainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threatConfigContainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.threatConfigNotContainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).BeginInit();
            this.bindingNavigator4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threatConfigOrNotContainBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).BeginInit();
            this.bindingNavigator5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(13, 15);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 0;
            iDLabel.Text = "ID:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(8, 32);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(30, 13);
            titleLabel.TabIndex = 2;
            titleLabel.Text = "Title:";
            // 
            // sapoLabel
            // 
            sapoLabel.AutoSize = true;
            sapoLabel.Location = new System.Drawing.Point(8, 58);
            sapoLabel.Name = "sapoLabel";
            sapoLabel.Size = new System.Drawing.Size(35, 13);
            sapoLabel.TabIndex = 4;
            sapoLabel.Text = "Sapo:";
            // 
            // textContentLabel
            // 
            textContentLabel.AutoSize = true;
            textContentLabel.Location = new System.Drawing.Point(8, 111);
            textContentLabel.Name = "textContentLabel";
            textContentLabel.Size = new System.Drawing.Size(71, 13);
            textContentLabel.TabIndex = 6;
            textContentLabel.Text = "Text Content:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(79, 137);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(39, 13);
            imageLabel.TabIndex = 8;
            imageLabel.Text = "Image:";
            // 
            // titleUrlLabel
            // 
            titleUrlLabel.AutoSize = true;
            titleUrlLabel.Location = new System.Drawing.Point(408, 6);
            titleUrlLabel.Name = "titleUrlLabel";
            titleUrlLabel.Size = new System.Drawing.Size(46, 13);
            titleUrlLabel.TabIndex = 10;
            titleUrlLabel.Text = "Title Url:";
            // 
            // tagLabel
            // 
            tagLabel.AutoSize = true;
            tagLabel.Location = new System.Drawing.Point(8, 162);
            tagLabel.Name = "tagLabel";
            tagLabel.Size = new System.Drawing.Size(29, 13);
            tagLabel.TabIndex = 12;
            tagLabel.Text = "Tag:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(8, 188);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(66, 13);
            categoryIDLabel.TabIndex = 14;
            categoryIDLabel.Text = "Category ID:";
            // 
            // categoryMapLabel
            // 
            categoryMapLabel.AutoSize = true;
            categoryMapLabel.Location = new System.Drawing.Point(8, 214);
            categoryMapLabel.Name = "categoryMapLabel";
            categoryMapLabel.Size = new System.Drawing.Size(76, 13);
            categoryMapLabel.TabIndex = 16;
            categoryMapLabel.Text = "Category Map:";
            // 
            // viewMonthLabel
            // 
            viewMonthLabel.AutoSize = true;
            viewMonthLabel.Location = new System.Drawing.Point(8, 240);
            viewMonthLabel.Name = "viewMonthLabel";
            viewMonthLabel.Size = new System.Drawing.Size(66, 13);
            viewMonthLabel.TabIndex = 18;
            viewMonthLabel.Text = "View Month:";
            // 
            // viewWeekLabel
            // 
            viewWeekLabel.AutoSize = true;
            viewWeekLabel.Location = new System.Drawing.Point(8, 266);
            viewWeekLabel.Name = "viewWeekLabel";
            viewWeekLabel.Size = new System.Drawing.Size(65, 13);
            viewWeekLabel.TabIndex = 20;
            viewWeekLabel.Text = "View Week:";
            // 
            // viewYearLabel
            // 
            viewYearLabel.AutoSize = true;
            viewYearLabel.Location = new System.Drawing.Point(8, 292);
            viewYearLabel.Name = "viewYearLabel";
            viewYearLabel.Size = new System.Drawing.Size(58, 13);
            viewYearLabel.TabIndex = 22;
            viewYearLabel.Text = "View Year:";
            // 
            // viewAllLabel
            // 
            viewAllLabel.AutoSize = true;
            viewAllLabel.Location = new System.Drawing.Point(8, 318);
            viewAllLabel.Name = "viewAllLabel";
            viewAllLabel.Size = new System.Drawing.Size(47, 13);
            viewAllLabel.TabIndex = 24;
            viewAllLabel.Text = "View All:";
            // 
            // countCommentLabel
            // 
            countCommentLabel.AutoSize = true;
            countCommentLabel.Location = new System.Drawing.Point(375, 165);
            countCommentLabel.Name = "countCommentLabel";
            countCommentLabel.Size = new System.Drawing.Size(85, 13);
            countCommentLabel.TabIndex = 26;
            countCommentLabel.Text = "Count Comment:";
            // 
            // voteGoodLabel
            // 
            voteGoodLabel.AutoSize = true;
            voteGoodLabel.Location = new System.Drawing.Point(375, 191);
            voteGoodLabel.Name = "voteGoodLabel";
            voteGoodLabel.Size = new System.Drawing.Size(61, 13);
            voteGoodLabel.TabIndex = 28;
            voteGoodLabel.Text = "Vote Good:";
            // 
            // voteBadLabel
            // 
            voteBadLabel.AutoSize = true;
            voteBadLabel.Location = new System.Drawing.Point(375, 217);
            voteBadLabel.Name = "voteBadLabel";
            voteBadLabel.Size = new System.Drawing.Size(54, 13);
            voteBadLabel.TabIndex = 30;
            voteBadLabel.Text = "Vote Bad:";
            // 
            // lastChangeContentLabel
            // 
            lastChangeContentLabel.AutoSize = true;
            lastChangeContentLabel.Location = new System.Drawing.Point(375, 244);
            lastChangeContentLabel.Name = "lastChangeContentLabel";
            lastChangeContentLabel.Size = new System.Drawing.Size(110, 13);
            lastChangeContentLabel.TabIndex = 32;
            lastChangeContentLabel.Text = "Last Change Content:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(253, 6);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(45, 13);
            label2.TabIndex = 0;
            label2.Text = "NewsID";
            // 
            // iDLabel1
            // 
            iDLabel1.AutoSize = true;
            iDLabel1.Location = new System.Drawing.Point(949, 193);
            iDLabel1.Name = "iDLabel1";
            iDLabel1.Size = new System.Drawing.Size(21, 13);
            iDLabel1.TabIndex = 37;
            iDLabel1.Text = "ID:";
            // 
            // iDThreatLabel
            // 
            iDThreatLabel.AutoSize = true;
            iDThreatLabel.Location = new System.Drawing.Point(918, 220);
            iDThreatLabel.Name = "iDThreatLabel";
            iDThreatLabel.Size = new System.Drawing.Size(52, 13);
            iDThreatLabel.TabIndex = 39;
            iDThreatLabel.Text = "IDThreat:";
            // 
            // lastUpdateLabel
            // 
            lastUpdateLabel.AutoSize = true;
            lastUpdateLabel.Location = new System.Drawing.Point(903, 248);
            lastUpdateLabel.Name = "lastUpdateLabel";
            lastUpdateLabel.Size = new System.Drawing.Size(68, 13);
            lastUpdateLabel.TabIndex = 41;
            lastUpdateLabel.Text = "Last Update:";
            // 
            // rankTypeLabel
            // 
            rankTypeLabel.AutoSize = true;
            rankTypeLabel.Location = new System.Drawing.Point(907, 273);
            rankTypeLabel.Name = "rankTypeLabel";
            rankTypeLabel.Size = new System.Drawing.Size(63, 13);
            rankTypeLabel.TabIndex = 43;
            rankTypeLabel.Text = "Rank Type:";
            // 
            // iDLabel2
            // 
            iDLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            iDLabel2.AutoSize = true;
            iDLabel2.Location = new System.Drawing.Point(5, 297);
            iDLabel2.Name = "iDLabel2";
            iDLabel2.Size = new System.Drawing.Size(21, 13);
            iDLabel2.TabIndex = 2;
            iDLabel2.Text = "ID:";
            // 
            // iDLabel3
            // 
            iDLabel3.AutoSize = true;
            iDLabel3.Location = new System.Drawing.Point(10, 364);
            iDLabel3.Name = "iDLabel3";
            iDLabel3.Size = new System.Drawing.Size(21, 13);
            iDLabel3.TabIndex = 13;
            iDLabel3.Text = "ID:";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel1.Controls.Add(this.btPhanTich);
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.iDThreadTextBox);
            this.splitContainerControl1.Panel1.Controls.Add(iDLabel);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.bindingNavigator1);
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1229, 679);
            this.splitContainerControl1.SplitterPosition = 441;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(1151, 215);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 192);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "Update";
            this.simpleButton1.Click += new System.EventHandler(this.btPhanTich_Click);
            // 
            // btPhanTich
            // 
            this.btPhanTich.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btPhanTich.Location = new System.Drawing.Point(1151, 17);
            this.btPhanTich.Name = "btPhanTich";
            this.btPhanTich.Size = new System.Drawing.Size(75, 192);
            this.btPhanTich.TabIndex = 1;
            this.btPhanTich.Text = "Phân tích";
            this.btPhanTich.Click += new System.EventHandler(this.btPhanTich_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(3, 72);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage3;
            this.xtraTabControl1.Size = new System.Drawing.Size(1142, 371);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.grvContent);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1134, 342);
            this.xtraTabPage3.Text = "Nội dung liên quan";
            // 
            // grvContent
            // 
            this.grvContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvContent.Location = new System.Drawing.Point(7, 3);
            this.grvContent.MainView = this.gridView6;
            this.grvContent.Name = "grvContent";
            this.grvContent.Size = new System.Drawing.Size(1124, 405);
            this.grvContent.TabIndex = 2;
            this.grvContent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView6});
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID1,
            this.colHost,
            this.colUri,
            this.colTitle1,
            this.colIntro,
            this.colTextContent,
            this.colHtmlContent,
            this.colPublishTime,
            this.colImage1,
            this.colTags,
            this.colBreadCrumb,
            this.colDuplicate});
            this.gridView6.GridControl = this.grvContent;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID1
            // 
            this.colID1.FieldName = "ID";
            this.colID1.Name = "colID1";
            // 
            // colHost
            // 
            this.colHost.FieldName = "Host";
            this.colHost.Name = "colHost";
            // 
            // colUri
            // 
            this.colUri.FieldName = "Uri";
            this.colUri.Name = "colUri";
            // 
            // colTitle1
            // 
            this.colTitle1.FieldName = "Title";
            this.colTitle1.Name = "colTitle1";
            this.colTitle1.Visible = true;
            this.colTitle1.VisibleIndex = 0;
            this.colTitle1.Width = 342;
            // 
            // colIntro
            // 
            this.colIntro.FieldName = "Intro";
            this.colIntro.Name = "colIntro";
            this.colIntro.Visible = true;
            this.colIntro.VisibleIndex = 1;
            this.colIntro.Width = 437;
            // 
            // colTextContent
            // 
            this.colTextContent.FieldName = "TextContent";
            this.colTextContent.Name = "colTextContent";
            // 
            // colHtmlContent
            // 
            this.colHtmlContent.FieldName = "HtmlContent";
            this.colHtmlContent.Name = "colHtmlContent";
            // 
            // colPublishTime
            // 
            this.colPublishTime.FieldName = "PublishTime";
            this.colPublishTime.Name = "colPublishTime";
            this.colPublishTime.OptionsColumn.FixedWidth = true;
            this.colPublishTime.Visible = true;
            this.colPublishTime.VisibleIndex = 2;
            this.colPublishTime.Width = 80;
            // 
            // colImage1
            // 
            this.colImage1.FieldName = "Image";
            this.colImage1.Name = "colImage1";
            this.colImage1.OptionsColumn.FixedWidth = true;
            this.colImage1.Visible = true;
            this.colImage1.VisibleIndex = 3;
            this.colImage1.Width = 80;
            // 
            // colTags
            // 
            this.colTags.FieldName = "Tags";
            this.colTags.Name = "colTags";
            this.colTags.OptionsColumn.FixedWidth = true;
            this.colTags.Visible = true;
            this.colTags.VisibleIndex = 4;
            this.colTags.Width = 80;
            // 
            // colBreadCrumb
            // 
            this.colBreadCrumb.FieldName = "BreadCrumb";
            this.colBreadCrumb.Name = "colBreadCrumb";
            this.colBreadCrumb.OptionsColumn.FixedWidth = true;
            this.colBreadCrumb.Visible = true;
            this.colBreadCrumb.VisibleIndex = 5;
            this.colBreadCrumb.Width = 85;
            // 
            // colDuplicate
            // 
            this.colDuplicate.FieldName = "Duplicate";
            this.colDuplicate.Name = "colDuplicate";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.Controls.Add(rankTypeLabel);
            this.xtraTabPage1.Controls.Add(this.rankTypeTextBox);
            this.xtraTabPage1.Controls.Add(lastUpdateLabel);
            this.xtraTabPage1.Controls.Add(this.lastUpdate_in_ThreadconfigDateTimePicker);
            this.xtraTabPage1.Controls.Add(iDThreatLabel);
            this.xtraTabPage1.Controls.Add(this.iDThread_inConfig_TextBox);
            this.xtraTabPage1.Controls.Add(iDLabel1);
            this.xtraTabPage1.Controls.Add(this.iDConfigTextBox);
            this.xtraTabPage1.Controls.Add(this.btGetNewID);
            this.xtraTabPage1.Controls.Add(this.laNewID);
            this.xtraTabPage1.Controls.Add(label2);
            this.xtraTabPage1.Controls.Add(titleLabel);
            this.xtraTabPage1.Controls.Add(this.titleTextBox);
            this.xtraTabPage1.Controls.Add(sapoLabel);
            this.xtraTabPage1.Controls.Add(this.sapoTextBox);
            this.xtraTabPage1.Controls.Add(textContentLabel);
            this.xtraTabPage1.Controls.Add(this.textContentTextBox);
            this.xtraTabPage1.Controls.Add(imageLabel);
            this.xtraTabPage1.Controls.Add(this.imageTextBox);
            this.xtraTabPage1.Controls.Add(titleUrlLabel);
            this.xtraTabPage1.Controls.Add(this.titleUrlTextBox);
            this.xtraTabPage1.Controls.Add(tagLabel);
            this.xtraTabPage1.Controls.Add(this.tagTextBox);
            this.xtraTabPage1.Controls.Add(categoryIDLabel);
            this.xtraTabPage1.Controls.Add(this.categoryIDTextBox);
            this.xtraTabPage1.Controls.Add(categoryMapLabel);
            this.xtraTabPage1.Controls.Add(this.categoryMapTextBox);
            this.xtraTabPage1.Controls.Add(viewMonthLabel);
            this.xtraTabPage1.Controls.Add(this.viewMonthTextBox);
            this.xtraTabPage1.Controls.Add(viewWeekLabel);
            this.xtraTabPage1.Controls.Add(this.viewWeekTextBox);
            this.xtraTabPage1.Controls.Add(viewYearLabel);
            this.xtraTabPage1.Controls.Add(this.viewYearTextBox);
            this.xtraTabPage1.Controls.Add(viewAllLabel);
            this.xtraTabPage1.Controls.Add(this.viewAllTextBox);
            this.xtraTabPage1.Controls.Add(countCommentLabel);
            this.xtraTabPage1.Controls.Add(this.countCommentTextBox);
            this.xtraTabPage1.Controls.Add(voteGoodLabel);
            this.xtraTabPage1.Controls.Add(this.voteGoodTextBox);
            this.xtraTabPage1.Controls.Add(voteBadLabel);
            this.xtraTabPage1.Controls.Add(this.voteBadTextBox);
            this.xtraTabPage1.Controls.Add(lastChangeContentLabel);
            this.xtraTabPage1.Controls.Add(this.lastChangeContentDateTimePicker);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1134, 342);
            this.xtraTabPage1.Text = "Chi tiết";
            // 
            // rankTypeTextBox
            // 
            this.rankTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatConfigBindingSource, "RankType", true));
            this.rankTypeTextBox.Location = new System.Drawing.Point(976, 270);
            this.rankTypeTextBox.Name = "rankTypeTextBox";
            this.rankTypeTextBox.Size = new System.Drawing.Size(100, 20);
            this.rankTypeTextBox.TabIndex = 44;
            // 
            // threatConfigBindingSource
            // 
            this.threatConfigBindingSource.DataMember = "ThreatConfig";
            this.threatConfigBindingSource.DataSource = this.dB;
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lastUpdate_in_ThreadconfigDateTimePicker
            // 
            this.lastUpdate_in_ThreadconfigDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.threatConfigBindingSource, "LastUpdate", true));
            this.lastUpdate_in_ThreadconfigDateTimePicker.Location = new System.Drawing.Point(977, 244);
            this.lastUpdate_in_ThreadconfigDateTimePicker.Name = "lastUpdate_in_ThreadconfigDateTimePicker";
            this.lastUpdate_in_ThreadconfigDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastUpdate_in_ThreadconfigDateTimePicker.TabIndex = 42;
            // 
            // iDThread_inConfig_TextBox
            // 
            this.iDThread_inConfig_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatConfigBindingSource, "IDThreat", true));
            this.iDThread_inConfig_TextBox.Location = new System.Drawing.Point(976, 217);
            this.iDThread_inConfig_TextBox.Name = "iDThread_inConfig_TextBox";
            this.iDThread_inConfig_TextBox.Size = new System.Drawing.Size(100, 20);
            this.iDThread_inConfig_TextBox.TabIndex = 40;
            // 
            // iDConfigTextBox
            // 
            this.iDConfigTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatConfigBindingSource, "ID", true));
            this.iDConfigTextBox.Location = new System.Drawing.Point(976, 190);
            this.iDConfigTextBox.Name = "iDConfigTextBox";
            this.iDConfigTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDConfigTextBox.TabIndex = 38;
            this.iDConfigTextBox.TextChanged += new System.EventHandler(this.iDConfigTextBox_TextChanged);
            // 
            // btGetNewID
            // 
            this.btGetNewID.Location = new System.Drawing.Point(221, 1);
            this.btGetNewID.Name = "btGetNewID";
            this.btGetNewID.Size = new System.Drawing.Size(28, 23);
            this.btGetNewID.TabIndex = 35;
            this.btGetNewID.Text = "<--";
            this.btGetNewID.UseVisualStyleBackColor = true;
            // 
            // laNewID
            // 
            this.laNewID.AutoSize = true;
            this.laNewID.Location = new System.Drawing.Point(305, 6);
            this.laNewID.Name = "laNewID";
            this.laNewID.Size = new System.Drawing.Size(35, 13);
            this.laNewID.TabIndex = 34;
            this.laNewID.Text = "label3";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(124, 29);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(1348, 20);
            this.titleTextBox.TabIndex = 3;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // threatBindingSource
            // 
            this.threatBindingSource.DataMember = "Threat";
            this.threatBindingSource.DataSource = this.dB;
            // 
            // sapoTextBox
            // 
            this.sapoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sapoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "Sapo", true));
            this.sapoTextBox.Location = new System.Drawing.Point(124, 55);
            this.sapoTextBox.Multiline = true;
            this.sapoTextBox.Name = "sapoTextBox";
            this.sapoTextBox.Size = new System.Drawing.Size(1348, 47);
            this.sapoTextBox.TabIndex = 5;
            // 
            // textContentTextBox
            // 
            this.textContentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textContentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "TextContent", true));
            this.textContentTextBox.Location = new System.Drawing.Point(124, 108);
            this.textContentTextBox.Name = "textContentTextBox";
            this.textContentTextBox.Size = new System.Drawing.Size(1348, 20);
            this.textContentTextBox.TabIndex = 7;
            // 
            // imageTextBox
            // 
            this.imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "Image", true));
            this.imageTextBox.Location = new System.Drawing.Point(124, 134);
            this.imageTextBox.Name = "imageTextBox";
            this.imageTextBox.Size = new System.Drawing.Size(768, 20);
            this.imageTextBox.TabIndex = 9;
            // 
            // titleUrlTextBox
            // 
            this.titleUrlTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "TitleUrl", true));
            this.titleUrlTextBox.Location = new System.Drawing.Point(460, 3);
            this.titleUrlTextBox.Name = "titleUrlTextBox";
            this.titleUrlTextBox.Size = new System.Drawing.Size(396, 20);
            this.titleUrlTextBox.TabIndex = 11;
            // 
            // tagTextBox
            // 
            this.tagTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "Tag", true));
            this.tagTextBox.Location = new System.Drawing.Point(124, 159);
            this.tagTextBox.Name = "tagTextBox";
            this.tagTextBox.Size = new System.Drawing.Size(200, 20);
            this.tagTextBox.TabIndex = 13;
            // 
            // categoryIDTextBox
            // 
            this.categoryIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "CategoryID", true));
            this.categoryIDTextBox.Location = new System.Drawing.Point(124, 185);
            this.categoryIDTextBox.Name = "categoryIDTextBox";
            this.categoryIDTextBox.Size = new System.Drawing.Size(200, 20);
            this.categoryIDTextBox.TabIndex = 15;
            // 
            // categoryMapTextBox
            // 
            this.categoryMapTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "CategoryMap", true));
            this.categoryMapTextBox.Location = new System.Drawing.Point(124, 211);
            this.categoryMapTextBox.Name = "categoryMapTextBox";
            this.categoryMapTextBox.Size = new System.Drawing.Size(200, 20);
            this.categoryMapTextBox.TabIndex = 17;
            // 
            // viewMonthTextBox
            // 
            this.viewMonthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "ViewMonth", true));
            this.viewMonthTextBox.Location = new System.Drawing.Point(124, 237);
            this.viewMonthTextBox.Name = "viewMonthTextBox";
            this.viewMonthTextBox.Size = new System.Drawing.Size(52, 20);
            this.viewMonthTextBox.TabIndex = 19;
            // 
            // viewWeekTextBox
            // 
            this.viewWeekTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "ViewWeek", true));
            this.viewWeekTextBox.Location = new System.Drawing.Point(124, 263);
            this.viewWeekTextBox.Name = "viewWeekTextBox";
            this.viewWeekTextBox.Size = new System.Drawing.Size(52, 20);
            this.viewWeekTextBox.TabIndex = 21;
            // 
            // viewYearTextBox
            // 
            this.viewYearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "ViewYear", true));
            this.viewYearTextBox.Location = new System.Drawing.Point(124, 289);
            this.viewYearTextBox.Name = "viewYearTextBox";
            this.viewYearTextBox.Size = new System.Drawing.Size(52, 20);
            this.viewYearTextBox.TabIndex = 23;
            // 
            // viewAllTextBox
            // 
            this.viewAllTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "ViewAll", true));
            this.viewAllTextBox.Location = new System.Drawing.Point(124, 315);
            this.viewAllTextBox.Name = "viewAllTextBox";
            this.viewAllTextBox.Size = new System.Drawing.Size(52, 20);
            this.viewAllTextBox.TabIndex = 25;
            // 
            // countCommentTextBox
            // 
            this.countCommentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "CountComment", true));
            this.countCommentTextBox.Location = new System.Drawing.Point(491, 162);
            this.countCommentTextBox.Name = "countCommentTextBox";
            this.countCommentTextBox.Size = new System.Drawing.Size(52, 20);
            this.countCommentTextBox.TabIndex = 27;
            // 
            // voteGoodTextBox
            // 
            this.voteGoodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "VoteGood", true));
            this.voteGoodTextBox.Location = new System.Drawing.Point(491, 188);
            this.voteGoodTextBox.Name = "voteGoodTextBox";
            this.voteGoodTextBox.Size = new System.Drawing.Size(52, 20);
            this.voteGoodTextBox.TabIndex = 29;
            // 
            // voteBadTextBox
            // 
            this.voteBadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "VoteBad", true));
            this.voteBadTextBox.Location = new System.Drawing.Point(491, 214);
            this.voteBadTextBox.Name = "voteBadTextBox";
            this.voteBadTextBox.Size = new System.Drawing.Size(52, 20);
            this.voteBadTextBox.TabIndex = 31;
            // 
            // lastChangeContentDateTimePicker
            // 
            this.lastChangeContentDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.threatBindingSource, "LastChangeContent", true));
            this.lastChangeContentDateTimePicker.Location = new System.Drawing.Point(491, 240);
            this.lastChangeContentDateTimePicker.Name = "lastChangeContentDateTimePicker";
            this.lastChangeContentDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.lastChangeContentDateTimePicker.TabIndex = 33;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.AutoScroll = true;
            this.xtraTabPage2.Controls.Add(this.splitContainerControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1134, 342);
            this.xtraTabPage2.Text = "Thiết lập";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.label3);
            this.splitContainerControl2.Panel1.Controls.Add(this.bindingNavigator3);
            this.splitContainerControl2.Panel1.Controls.Add(this.label1);
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControl3);
            this.splitContainerControl2.Panel1.Controls.Add(this.bindingNavigator2);
            this.splitContainerControl2.Panel1.Controls.Add(this.gridControl2);
            this.splitContainerControl2.Panel1.Controls.Add(iDLabel2);
            this.splitContainerControl2.Panel1.Controls.Add(this.iD_ThreadConfig_ContainTextBox);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(iDLabel3);
            this.splitContainerControl2.Panel2.Controls.Add(this.iD_ThreadConfig_NotContainTextBox);
            this.splitContainerControl2.Panel2.Controls.Add(this.label4);
            this.splitContainerControl2.Panel2.Controls.Add(this.bindingNavigator4);
            this.splitContainerControl2.Panel2.Controls.Add(this.label5);
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControl4);
            this.splitContainerControl2.Panel2.Controls.Add(this.bindingNavigator5);
            this.splitContainerControl2.Panel2.Controls.Add(this.gridControl5);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1134, 342);
            this.splitContainerControl2.SplitterPosition = 595;
            this.splitContainerControl2.TabIndex = 5;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(298, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Từ đồng nghĩa";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bindingNavigator3
            // 
            this.bindingNavigator3.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingNavigator3.BindingSource = this.threatConfigOrContainBindingSource;
            this.bindingNavigator3.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator3.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator3.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator3.Location = new System.Drawing.Point(299, 291);
            this.bindingNavigator3.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator3.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator3.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator3.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator3.Name = "bindingNavigator3";
            this.bindingNavigator3.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator3.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator3.TabIndex = 6;
            this.bindingNavigator3.Text = "bindingNavigator3";
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem1";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Add new";
            // 
            // threatConfigOrContainBindingSource
            // 
            this.threatConfigOrContainBindingSource.DataMember = "ThreatConfig_OrContain";
            this.threatConfigOrContainBindingSource.DataSource = this.dB;
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem1";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem1.Text = "of {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem1";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator3";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Position";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem1";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator4";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator5";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nội dung bắt buộc phải có";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridControl3
            // 
            this.gridControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl3.DataSource = this.threatConfigOrContainBindingSource;
            this.gridControl3.Location = new System.Drawing.Point(298, 19);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(297, 269);
            this.gridControl3.TabIndex = 0;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colContain1,
            this.colRatio1,
            this.colSTT1});
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colContain1
            // 
            this.colContain1.FieldName = "Contain";
            this.colContain1.Name = "colContain1";
            this.colContain1.Visible = true;
            this.colContain1.VisibleIndex = 0;
            // 
            // colRatio1
            // 
            this.colRatio1.DisplayFormat.FormatString = "d2";
            this.colRatio1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRatio1.FieldName = "Ratio";
            this.colRatio1.Name = "colRatio1";
            this.colRatio1.OptionsColumn.FixedWidth = true;
            this.colRatio1.Visible = true;
            this.colRatio1.VisibleIndex = 1;
            // 
            // colSTT1
            // 
            this.colSTT1.FieldName = "STT";
            this.colSTT1.Name = "colSTT1";
            this.colSTT1.OptionsColumn.FixedWidth = true;
            this.colSTT1.Visible = true;
            this.colSTT1.VisibleIndex = 2;
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = this.toolStripButton1;
            this.bindingNavigator2.BindingSource = this.threatConfigContainBindingSource;
            this.bindingNavigator2.CountItem = this.toolStripLabel1;
            this.bindingNavigator2.DeleteItem = this.toolStripButton2;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.btUpdate_Contain,
            this.btRefreshContain});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 317);
            this.bindingNavigator2.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator2.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator2.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator2.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator2.Size = new System.Drawing.Size(595, 25);
            this.bindingNavigator2.TabIndex = 4;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Add new";
            // 
            // threatConfigContainBindingSource
            // 
            this.threatConfigContainBindingSource.DataMember = "ThreatConfig_Contain";
            this.threatConfigContainBindingSource.DataSource = this.dB;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Delete";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btUpdate_Contain
            // 
            this.btUpdate_Contain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btUpdate_Contain.Image = ((System.Drawing.Image)(resources.GetObject("btUpdate_Contain.Image")));
            this.btUpdate_Contain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btUpdate_Contain.Name = "btUpdate_Contain";
            this.btUpdate_Contain.Size = new System.Drawing.Size(49, 22);
            this.btUpdate_Contain.Text = "Update";
            this.btUpdate_Contain.Click += new System.EventHandler(this.btUpdate_Contain_Click);
            // 
            // btRefreshContain
            // 
            this.btRefreshContain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btRefreshContain.Image = ((System.Drawing.Image)(resources.GetObject("btRefreshContain.Image")));
            this.btRefreshContain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRefreshContain.Name = "btRefreshContain";
            this.btRefreshContain.Size = new System.Drawing.Size(50, 22);
            this.btRefreshContain.Text = "Refresh";
            this.btRefreshContain.Click += new System.EventHandler(this.btRefreshContain_Click);
            // 
            // gridControl2
            // 
            this.gridControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl2.DataSource = this.threatConfigContainBindingSource;
            this.gridControl2.Location = new System.Drawing.Point(0, 19);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(292, 269);
            this.gridControl2.TabIndex = 0;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colContain,
            this.colRatio,
            this.colSTT});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // colContain
            // 
            this.colContain.FieldName = "Contain";
            this.colContain.Name = "colContain";
            this.colContain.Visible = true;
            this.colContain.VisibleIndex = 0;
            this.colContain.Width = 69;
            // 
            // colRatio
            // 
            this.colRatio.DisplayFormat.FormatString = "d2";
            this.colRatio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colRatio.FieldName = "Ratio";
            this.colRatio.Name = "colRatio";
            this.colRatio.OptionsColumn.FixedWidth = true;
            this.colRatio.Visible = true;
            this.colRatio.VisibleIndex = 1;
            this.colRatio.Width = 69;
            // 
            // colSTT
            // 
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.FixedWidth = true;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 2;
            this.colSTT.Width = 69;
            // 
            // iD_ThreadConfig_ContainTextBox
            // 
            this.iD_ThreadConfig_ContainTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iD_ThreadConfig_ContainTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatConfigContainBindingSource, "ID", true));
            this.iD_ThreadConfig_ContainTextBox.Location = new System.Drawing.Point(32, 294);
            this.iD_ThreadConfig_ContainTextBox.Name = "iD_ThreadConfig_ContainTextBox";
            this.iD_ThreadConfig_ContainTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ThreadConfig_ContainTextBox.TabIndex = 3;
            this.iD_ThreadConfig_ContainTextBox.TextChanged += new System.EventHandler(this.iD_ThreadConfig_ContainTextBox_TextChanged);
            // 
            // iD_ThreadConfig_NotContainTextBox
            // 
            this.iD_ThreadConfig_NotContainTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatConfigNotContainBindingSource, "ID", true));
            this.iD_ThreadConfig_NotContainTextBox.Location = new System.Drawing.Point(37, 361);
            this.iD_ThreadConfig_NotContainTextBox.Name = "iD_ThreadConfig_NotContainTextBox";
            this.iD_ThreadConfig_NotContainTextBox.Size = new System.Drawing.Size(100, 20);
            this.iD_ThreadConfig_NotContainTextBox.TabIndex = 14;
            this.iD_ThreadConfig_NotContainTextBox.TextChanged += new System.EventHandler(this.iD_ThreadConfig_NotContainTextBox_TextChanged);
            // 
            // threatConfigNotContainBindingSource
            // 
            this.threatConfigNotContainBindingSource.DataMember = "ThreatConfig_NotContain";
            this.threatConfigNotContainBindingSource.DataSource = this.dB;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(233, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Từ đồng nghĩa";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bindingNavigator4
            // 
            this.bindingNavigator4.AddNewItem = this.toolStripButton7;
            this.bindingNavigator4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bindingNavigator4.BindingSource = this.threatConfigOrNotContainBindingSource;
            this.bindingNavigator4.CountItem = this.toolStripLabel2;
            this.bindingNavigator4.DeleteItem = this.toolStripButton8;
            this.bindingNavigator4.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripButton10,
            this.toolStripSeparator4,
            this.toolStripTextBox2,
            this.toolStripLabel2,
            this.toolStripSeparator5,
            this.toolStripButton11,
            this.toolStripButton12,
            this.toolStripSeparator6,
            this.toolStripButton7,
            this.toolStripButton8});
            this.bindingNavigator4.Location = new System.Drawing.Point(233, 292);
            this.bindingNavigator4.MoveFirstItem = this.toolStripButton9;
            this.bindingNavigator4.MoveLastItem = this.toolStripButton12;
            this.bindingNavigator4.MoveNextItem = this.toolStripButton11;
            this.bindingNavigator4.MovePreviousItem = this.toolStripButton10;
            this.bindingNavigator4.Name = "bindingNavigator4";
            this.bindingNavigator4.PositionItem = this.toolStripTextBox2;
            this.bindingNavigator4.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator4.TabIndex = 12;
            this.bindingNavigator4.Text = "bindingNavigator4";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.RightToLeftAutoMirrorImage = true;
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "Add new";
            // 
            // threatConfigOrNotContainBindingSource
            // 
            this.threatConfigOrNotContainBindingSource.DataMember = "ThreatConfig_OrNotContain";
            this.threatConfigOrNotContainBindingSource.DataSource = this.dB;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel2.Text = "of {0}";
            this.toolStripLabel2.ToolTipText = "Total number of items";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.RightToLeftAutoMirrorImage = true;
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "Delete";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.RightToLeftAutoMirrorImage = true;
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "Move first";
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.RightToLeftAutoMirrorImage = true;
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "Move previous";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.AccessibleName = "Position";
            this.toolStripTextBox2.AutoSize = false;
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox2.Text = "0";
            this.toolStripTextBox2.ToolTipText = "Current position";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.RightToLeftAutoMirrorImage = true;
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "Move next";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.RightToLeftAutoMirrorImage = true;
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "Move last";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nội dung bắt buộc không có";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridControl4
            // 
            this.gridControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl4.DataSource = this.threatConfigOrNotContainBindingSource;
            this.gridControl4.Location = new System.Drawing.Point(233, 19);
            this.gridControl4.MainView = this.gridView4;
            this.gridControl4.Name = "gridControl4";
            this.gridControl4.Size = new System.Drawing.Size(297, 269);
            this.gridControl4.TabIndex = 8;
            this.gridControl4.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridView4.GridControl = this.gridControl4;
            this.gridView4.Name = "gridView4";
            this.gridView4.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "Contain";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.DisplayFormat.FormatString = "d2";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn2.FieldName = "Ratio";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.FixedWidth = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "STT";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.FixedWidth = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // bindingNavigator5
            // 
            this.bindingNavigator5.AddNewItem = this.toolStripButton13;
            this.bindingNavigator5.BindingSource = this.threatConfigNotContainBindingSource;
            this.bindingNavigator5.CountItem = this.toolStripLabel3;
            this.bindingNavigator5.DeleteItem = this.toolStripButton14;
            this.bindingNavigator5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton15,
            this.toolStripButton16,
            this.toolStripSeparator7,
            this.toolStripTextBox3,
            this.toolStripLabel3,
            this.toolStripSeparator8,
            this.toolStripButton17,
            this.toolStripButton18,
            this.toolStripSeparator9,
            this.toolStripButton13,
            this.toolStripButton14,
            this.btUpdateNotContain,
            this.btRefreshNotContain});
            this.bindingNavigator5.Location = new System.Drawing.Point(0, 317);
            this.bindingNavigator5.MoveFirstItem = this.toolStripButton15;
            this.bindingNavigator5.MoveLastItem = this.toolStripButton18;
            this.bindingNavigator5.MoveNextItem = this.toolStripButton17;
            this.bindingNavigator5.MovePreviousItem = this.toolStripButton16;
            this.bindingNavigator5.Name = "bindingNavigator5";
            this.bindingNavigator5.PositionItem = this.toolStripTextBox3;
            this.bindingNavigator5.Size = new System.Drawing.Size(531, 25);
            this.bindingNavigator5.TabIndex = 10;
            this.bindingNavigator5.Text = "bindingNavigator5";
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.RightToLeftAutoMirrorImage = true;
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "Add new";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(35, 22);
            this.toolStripLabel3.Text = "of {0}";
            this.toolStripLabel3.ToolTipText = "Total number of items";
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.RightToLeftAutoMirrorImage = true;
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "Delete";
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.RightToLeftAutoMirrorImage = true;
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "Move first";
            // 
            // toolStripButton16
            // 
            this.toolStripButton16.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton16.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton16.Image")));
            this.toolStripButton16.Name = "toolStripButton16";
            this.toolStripButton16.RightToLeftAutoMirrorImage = true;
            this.toolStripButton16.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton16.Text = "Move previous";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripTextBox3
            // 
            this.toolStripTextBox3.AccessibleName = "Position";
            this.toolStripTextBox3.AutoSize = false;
            this.toolStripTextBox3.Name = "toolStripTextBox3";
            this.toolStripTextBox3.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox3.Text = "0";
            this.toolStripTextBox3.ToolTipText = "Current position";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton17
            // 
            this.toolStripButton17.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton17.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton17.Image")));
            this.toolStripButton17.Name = "toolStripButton17";
            this.toolStripButton17.RightToLeftAutoMirrorImage = true;
            this.toolStripButton17.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton17.Text = "Move next";
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton18.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton18.Image")));
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.RightToLeftAutoMirrorImage = true;
            this.toolStripButton18.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton18.Text = "Move last";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // btUpdateNotContain
            // 
            this.btUpdateNotContain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btUpdateNotContain.Image = ((System.Drawing.Image)(resources.GetObject("btUpdateNotContain.Image")));
            this.btUpdateNotContain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btUpdateNotContain.Name = "btUpdateNotContain";
            this.btUpdateNotContain.Size = new System.Drawing.Size(49, 22);
            this.btUpdateNotContain.Text = "Update";
            this.btUpdateNotContain.Click += new System.EventHandler(this.btUpdateNotContain_Click);
            // 
            // btRefreshNotContain
            // 
            this.btRefreshNotContain.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btRefreshNotContain.Image = ((System.Drawing.Image)(resources.GetObject("btRefreshNotContain.Image")));
            this.btRefreshNotContain.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btRefreshNotContain.Name = "btRefreshNotContain";
            this.btRefreshNotContain.Size = new System.Drawing.Size(50, 22);
            this.btRefreshNotContain.Text = "Refresh";
            // 
            // gridControl5
            // 
            this.gridControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl5.DataSource = this.threatConfigNotContainBindingSource;
            this.gridControl5.Location = new System.Drawing.Point(0, 19);
            this.gridControl5.MainView = this.gridView5;
            this.gridControl5.Name = "gridControl5";
            this.gridControl5.Size = new System.Drawing.Size(227, 269);
            this.gridControl5.TabIndex = 9;
            this.gridControl5.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView5});
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView5.GridControl = this.gridControl5;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "Contain";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 69;
            // 
            // gridColumn5
            // 
            this.gridColumn5.DisplayFormat.FormatString = "d2";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn5.FieldName = "Ratio";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.FixedWidth = true;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 69;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "STT";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.FixedWidth = true;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 69;
            // 
            // iDThreadTextBox
            // 
            this.iDThreadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatBindingSource, "ID", true));
            this.iDThreadTextBox.Location = new System.Drawing.Point(129, 12);
            this.iDThreadTextBox.Name = "iDThreadTextBox";
            this.iDThreadTextBox.Size = new System.Drawing.Size(91, 20);
            this.iDThreadTextBox.TabIndex = 1;
            this.iDThreadTextBox.TextChanged += new System.EventHandler(this.iDThreadTextBox_TextChanged);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.threatBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.btUpdate,
            this.btReload});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 205);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1229, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btUpdate
            // 
            this.btUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btUpdate.Image")));
            this.btUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(49, 22);
            this.btUpdate.Text = "Update";
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btReload
            // 
            this.btReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btReload.Image = ((System.Drawing.Image)(resources.GetObject("btReload.Image")));
            this.btReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btReload.Name = "btReload";
            this.btReload.Size = new System.Drawing.Size(50, 22);
            this.btReload.Text = "Refresh";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.threatBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(2, 2);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1227, 200);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTitle,
            this.colSapo,
            this.colImage,
            this.colCategoryID,
            this.colViewMonth,
            this.colViewWeek,
            this.colViewYear,
            this.colViewAll,
            this.colCountComment,
            this.colVoteGood,
            this.colVoteBad,
            this.colLastChangeContent});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 1;
            // 
            // colTitle
            // 
            this.colTitle.FieldName = "Title";
            this.colTitle.Name = "colTitle";
            this.colTitle.Visible = true;
            this.colTitle.VisibleIndex = 2;
            // 
            // colSapo
            // 
            this.colSapo.FieldName = "Sapo";
            this.colSapo.Name = "colSapo";
            this.colSapo.Visible = true;
            this.colSapo.VisibleIndex = 3;
            // 
            // colImage
            // 
            this.colImage.FieldName = "Image";
            this.colImage.Name = "colImage";
            this.colImage.Visible = true;
            this.colImage.VisibleIndex = 4;
            // 
            // colCategoryID
            // 
            this.colCategoryID.FieldName = "CategoryID";
            this.colCategoryID.Name = "colCategoryID";
            this.colCategoryID.Visible = true;
            this.colCategoryID.VisibleIndex = 0;
            // 
            // colViewMonth
            // 
            this.colViewMonth.FieldName = "ViewMonth";
            this.colViewMonth.Name = "colViewMonth";
            this.colViewMonth.Visible = true;
            this.colViewMonth.VisibleIndex = 5;
            // 
            // colViewWeek
            // 
            this.colViewWeek.FieldName = "ViewWeek";
            this.colViewWeek.Name = "colViewWeek";
            this.colViewWeek.Visible = true;
            this.colViewWeek.VisibleIndex = 6;
            // 
            // colViewYear
            // 
            this.colViewYear.FieldName = "ViewYear";
            this.colViewYear.Name = "colViewYear";
            this.colViewYear.Visible = true;
            this.colViewYear.VisibleIndex = 7;
            // 
            // colViewAll
            // 
            this.colViewAll.FieldName = "ViewAll";
            this.colViewAll.Name = "colViewAll";
            this.colViewAll.Visible = true;
            this.colViewAll.VisibleIndex = 8;
            // 
            // colCountComment
            // 
            this.colCountComment.FieldName = "CountComment";
            this.colCountComment.Name = "colCountComment";
            this.colCountComment.Visible = true;
            this.colCountComment.VisibleIndex = 9;
            // 
            // colVoteGood
            // 
            this.colVoteGood.FieldName = "VoteGood";
            this.colVoteGood.Name = "colVoteGood";
            this.colVoteGood.Visible = true;
            this.colVoteGood.VisibleIndex = 10;
            // 
            // colVoteBad
            // 
            this.colVoteBad.FieldName = "VoteBad";
            this.colVoteBad.Name = "colVoteBad";
            this.colVoteBad.Visible = true;
            this.colVoteBad.VisibleIndex = 11;
            // 
            // colLastChangeContent
            // 
            this.colLastChangeContent.FieldName = "LastChangeContent";
            this.colLastChangeContent.Name = "colLastChangeContent";
            this.colLastChangeContent.Visible = true;
            this.colLastChangeContent.VisibleIndex = 12;
            // 
            // threatTableAdapter
            // 
            this.threatTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.Threat_ContentTableAdapter = null;
            this.tableAdapterManager.ThreatConfig_ContainTableAdapter = null;
            this.tableAdapterManager.ThreatConfig_NotContainTableAdapter = null;
            this.tableAdapterManager.ThreatConfig_OrContainTableAdapter = null;
            this.tableAdapterManager.ThreatConfig_OrNotContainTableAdapter = null;
            this.tableAdapterManager.ThreatConfig_WebTableAdapter = null;
            this.tableAdapterManager.ThreatConfigTableAdapter = null;
            this.tableAdapterManager.ThreatTableAdapter = this.threatTableAdapter;
            this.tableAdapterManager.ThreatViewTableAdapter = null;
            this.tableAdapterManager.ThreatViewTypeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.NewsRelation.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserPersonTableAdapter = null;
            this.tableAdapterManager.UserPersonTypeTableAdapter = null;
            // 
            // threatConfig_ContainTableAdapter
            // 
            this.threatConfig_ContainTableAdapter.ClearBeforeFill = true;
            // 
            // threatConfig_OrContainTableAdapter
            // 
            this.threatConfig_OrContainTableAdapter.ClearBeforeFill = true;
            // 
            // threatConfig_NotContainTableAdapter
            // 
            this.threatConfig_NotContainTableAdapter.ClearBeforeFill = true;
            // 
            // threatConfig_OrNotContainTableAdapter
            // 
            this.threatConfig_OrNotContainTableAdapter.ClearBeforeFill = true;
            // 
            // threatConfigTableAdapter
            // 
            this.threatConfigTableAdapter.ClearBeforeFill = true;
            // 
            // iDThreatTextBox
            // 
            this.iDThreatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.threatConfigBindingSource, "IDThreat", true));
            this.iDThreatTextBox.Location = new System.Drawing.Point(976, 217);
            this.iDThreatTextBox.Name = "iDThreatTextBox";
            this.iDThreatTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDThreatTextBox.TabIndex = 40;
            // 
            // frmThreatManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1229, 679);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "frmThreatManager";
            this.Load += new System.EventHandler(this.frmThreatManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threatConfigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threatBindingSource)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator3)).EndInit();
            this.bindingNavigator3.ResumeLayout(false);
            this.bindingNavigator3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threatConfigOrContainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threatConfigContainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.threatConfigNotContainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator4)).EndInit();
            this.bindingNavigator4.ResumeLayout(false);
            this.bindingNavigator4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.threatConfigOrNotContainBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator5)).EndInit();
            this.bindingNavigator5.ResumeLayout(false);
            this.bindingNavigator5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DB dB;
        private System.Windows.Forms.BindingSource threatBindingSource;
        private DBTableAdapters.ThreatTableAdapter threatTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle;
        private DevExpress.XtraGrid.Columns.GridColumn colSapo;
        private DevExpress.XtraGrid.Columns.GridColumn colImage;
        private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
        private DevExpress.XtraGrid.Columns.GridColumn colViewMonth;
        private DevExpress.XtraGrid.Columns.GridColumn colViewWeek;
        private DevExpress.XtraGrid.Columns.GridColumn colViewYear;
        private DevExpress.XtraGrid.Columns.GridColumn colViewAll;
        private DevExpress.XtraGrid.Columns.GridColumn colCountComment;
        private DevExpress.XtraGrid.Columns.GridColumn colVoteGood;
        private DevExpress.XtraGrid.Columns.GridColumn colVoteBad;
        private DevExpress.XtraGrid.Columns.GridColumn colLastChangeContent;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.TextBox iDThreadTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox sapoTextBox;
        private System.Windows.Forms.TextBox textContentTextBox;
        private System.Windows.Forms.TextBox imageTextBox;
        private System.Windows.Forms.TextBox titleUrlTextBox;
        private System.Windows.Forms.TextBox tagTextBox;
        private System.Windows.Forms.TextBox categoryIDTextBox;
        private System.Windows.Forms.TextBox categoryMapTextBox;
        private System.Windows.Forms.TextBox viewMonthTextBox;
        private System.Windows.Forms.TextBox viewWeekTextBox;
        private System.Windows.Forms.TextBox viewYearTextBox;
        private System.Windows.Forms.TextBox viewAllTextBox;
        private System.Windows.Forms.TextBox countCommentTextBox;
        private System.Windows.Forms.TextBox voteGoodTextBox;
        private System.Windows.Forms.TextBox voteBadTextBox;
        private System.Windows.Forms.DateTimePicker lastChangeContentDateTimePicker;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton btUpdate;
        private System.Windows.Forms.ToolStripButton btReload;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.BindingSource threatConfigContainBindingSource;
        private DBTableAdapters.ThreatConfig_ContainTableAdapter threatConfig_ContainTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colContain;
        private DevExpress.XtraGrid.Columns.GridColumn colRatio;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private System.Windows.Forms.BindingSource threatConfigOrContainBindingSource;
        private DBTableAdapters.ThreatConfig_OrContainTableAdapter threatConfig_OrContainTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colContain1;
        private DevExpress.XtraGrid.Columns.GridColumn colRatio1;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT1;
        private System.Windows.Forms.BindingSource threatConfigNotContainBindingSource;
        private DBTableAdapters.ThreatConfig_NotContainTableAdapter threatConfig_NotContainTableAdapter;
        private System.Windows.Forms.BindingSource threatConfigOrNotContainBindingSource;
        private DBTableAdapters.ThreatConfig_OrNotContainTableAdapter threatConfig_OrNotContainTableAdapter;
        private System.Windows.Forms.Label laNewID;
        private System.Windows.Forms.Button btGetNewID;
        private System.Windows.Forms.BindingSource threatConfigBindingSource;
        private DBTableAdapters.ThreatConfigTableAdapter threatConfigTableAdapter;
        private System.Windows.Forms.TextBox rankTypeTextBox;
        private System.Windows.Forms.DateTimePicker lastUpdate_in_ThreadconfigDateTimePicker;
        private System.Windows.Forms.TextBox iDThread_inConfig_TextBox;
        private System.Windows.Forms.TextBox iDConfigTextBox;
        private System.Windows.Forms.TextBox iDThreatTextBox;
        private System.Windows.Forms.TextBox iD_ThreadConfig_ContainTextBox;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btUpdate_Contain;
        private System.Windows.Forms.ToolStripButton btRefreshContain;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator3;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingNavigator bindingNavigator4;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.GridControl gridControl4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.BindingNavigator bindingNavigator5;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.ToolStripButton toolStripButton16;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton toolStripButton17;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton btUpdateNotContain;
        private System.Windows.Forms.ToolStripButton btRefreshNotContain;
        private DevExpress.XtraGrid.GridControl gridControl5;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private System.Windows.Forms.TextBox iD_ThreadConfig_NotContainTextBox;
        private DevExpress.XtraEditors.SimpleButton btPhanTich;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl grvContent;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.Columns.GridColumn colID1;
        private DevExpress.XtraGrid.Columns.GridColumn colHost;
        private DevExpress.XtraGrid.Columns.GridColumn colUri;
        private DevExpress.XtraGrid.Columns.GridColumn colTitle1;
        private DevExpress.XtraGrid.Columns.GridColumn colIntro;
        private DevExpress.XtraGrid.Columns.GridColumn colTextContent;
        private DevExpress.XtraGrid.Columns.GridColumn colHtmlContent;
        private DevExpress.XtraGrid.Columns.GridColumn colPublishTime;
        private DevExpress.XtraGrid.Columns.GridColumn colImage1;
        private DevExpress.XtraGrid.Columns.GridColumn colTags;
        private DevExpress.XtraGrid.Columns.GridColumn colBreadCrumb;
        private DevExpress.XtraGrid.Columns.GridColumn colDuplicate;
    }
}
