namespace WSS.Crawler.Product.Report
{
    partial class FrmConfigDescription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigDescription));
            System.Windows.Forms.Label shortDescriptionXPathLabel;
            System.Windows.Forms.Label specsXpathLabel;
            System.Windows.Forms.Label videoXpathLabel;
            System.Windows.Forms.Label fullDescXPathLabel;
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.dsQT2 = new WSS.Crawler.Product.Report.DS.DsQT2();
            this.configurationBindingSource = new System.Windows.Forms.BindingSource();
            this.configurationTableAdapter = new WSS.Crawler.Product.Report.DS.DsQT2TableAdapters.ConfigurationTableAdapter();
            this.tableAdapterManager = new WSS.Crawler.Product.Report.DS.DsQT2TableAdapters.TableAdapterManager();
            this.configurationBindingNavigator = new System.Windows.Forms.BindingNavigator();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.configurationBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.shortDescriptionXPathMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.specsXpathMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.videoXpathMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.fullDescXPathMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.txtSpect = new DevExpress.XtraEditors.MemoEdit();
            this.txtVideo = new DevExpress.XtraEditors.MemoEdit();
            this.txtShortDescription = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.btnTest = new System.Windows.Forms.Button();
            shortDescriptionXPathLabel = new System.Windows.Forms.Label();
            specsXpathLabel = new System.Windows.Forms.Label();
            videoXpathLabel = new System.Windows.Forms.Label();
            fullDescXPathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsQT2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingNavigator)).BeginInit();
            this.configurationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shortDescriptionXPathMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specsXpathMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoXpathMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDescXPathMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpect.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVideo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShortDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnTest);
            this.panelControl3.Controls.Add(this.txtShortDescription);
            this.panelControl3.Controls.Add(shortDescriptionXPathLabel);
            this.panelControl3.Controls.Add(this.shortDescriptionXPathMemoEdit);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(0, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1084, 212);
            this.panelControl3.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtSpect);
            this.panelControl1.Controls.Add(specsXpathLabel);
            this.panelControl1.Controls.Add(this.specsXpathMemoEdit);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 212);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1084, 147);
            this.panelControl1.TabIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 359);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1084, 180);
            this.panelControl2.TabIndex = 4;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.txtVideo);
            this.panelControl4.Controls.Add(videoXpathLabel);
            this.panelControl4.Controls.Add(this.videoXpathMemoEdit);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(1080, 173);
            this.panelControl4.TabIndex = 5;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.memoEdit1);
            this.panelControl5.Controls.Add(fullDescXPathLabel);
            this.panelControl5.Controls.Add(this.fullDescXPathMemoEdit);
            this.panelControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl5.Location = new System.Drawing.Point(0, 539);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(1084, 180);
            this.panelControl5.TabIndex = 6;
            // 
            // dsQT2
            // 
            this.dsQT2.DataSetName = "DsQT2";
            this.dsQT2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // configurationBindingSource
            // 
            this.configurationBindingSource.DataMember = "Configuration";
            this.configurationBindingSource.DataSource = this.dsQT2;
            // 
            // configurationTableAdapter
            // 
            this.configurationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConfigurationTableAdapter = this.configurationTableAdapter;
            this.tableAdapterManager.UpdateOrder = WSS.Crawler.Product.Report.DS.DsQT2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // configurationBindingNavigator
            // 
            this.configurationBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.configurationBindingNavigator.BindingSource = this.configurationBindingSource;
            this.configurationBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.configurationBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.configurationBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.configurationBindingNavigatorSaveItem});
            this.configurationBindingNavigator.Location = new System.Drawing.Point(0, 719);
            this.configurationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.configurationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.configurationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.configurationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.configurationBindingNavigator.Name = "configurationBindingNavigator";
            this.configurationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.configurationBindingNavigator.Size = new System.Drawing.Size(1084, 25);
            this.configurationBindingNavigator.TabIndex = 7;
            this.configurationBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // configurationBindingNavigatorSaveItem
            // 
            this.configurationBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.configurationBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("configurationBindingNavigatorSaveItem.Image")));
            this.configurationBindingNavigatorSaveItem.Name = "configurationBindingNavigatorSaveItem";
            this.configurationBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.configurationBindingNavigatorSaveItem.Text = "Save Data";
            this.configurationBindingNavigatorSaveItem.Click += new System.EventHandler(this.configurationBindingNavigatorSaveItem_Click);
            // 
            // shortDescriptionXPathLabel
            // 
            shortDescriptionXPathLabel.AutoSize = true;
            shortDescriptionXPathLabel.Location = new System.Drawing.Point(2, 60);
            shortDescriptionXPathLabel.Name = "shortDescriptionXPathLabel";
            shortDescriptionXPathLabel.Size = new System.Drawing.Size(123, 13);
            shortDescriptionXPathLabel.TabIndex = 0;
            shortDescriptionXPathLabel.Text = "Short Description XPath:";
            // 
            // shortDescriptionXPathMemoEdit
            // 
            this.shortDescriptionXPathMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "ShortDescriptionXPath", true));
            this.shortDescriptionXPathMemoEdit.Location = new System.Drawing.Point(131, 57);
            this.shortDescriptionXPathMemoEdit.Name = "shortDescriptionXPathMemoEdit";
            this.shortDescriptionXPathMemoEdit.Size = new System.Drawing.Size(304, 96);
            this.shortDescriptionXPathMemoEdit.TabIndex = 1;
            // 
            // specsXpathLabel
            // 
            specsXpathLabel.AutoSize = true;
            specsXpathLabel.Location = new System.Drawing.Point(54, 24);
            specsXpathLabel.Name = "specsXpathLabel";
            specsXpathLabel.Size = new System.Drawing.Size(71, 13);
            specsXpathLabel.TabIndex = 0;
            specsXpathLabel.Text = "Specs Xpath:";
            // 
            // specsXpathMemoEdit
            // 
            this.specsXpathMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "SpecsXpath", true));
            this.specsXpathMemoEdit.Location = new System.Drawing.Point(131, 22);
            this.specsXpathMemoEdit.Name = "specsXpathMemoEdit";
            this.specsXpathMemoEdit.Size = new System.Drawing.Size(304, 96);
            this.specsXpathMemoEdit.TabIndex = 1;
            // 
            // videoXpathLabel
            // 
            videoXpathLabel.AutoSize = true;
            videoXpathLabel.Location = new System.Drawing.Point(55, 27);
            videoXpathLabel.Name = "videoXpathLabel";
            videoXpathLabel.Size = new System.Drawing.Size(68, 13);
            videoXpathLabel.TabIndex = 0;
            videoXpathLabel.Text = "Video Xpath:";
            // 
            // videoXpathMemoEdit
            // 
            this.videoXpathMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "VideoXpath", true));
            this.videoXpathMemoEdit.Location = new System.Drawing.Point(129, 24);
            this.videoXpathMemoEdit.Name = "videoXpathMemoEdit";
            this.videoXpathMemoEdit.Size = new System.Drawing.Size(304, 96);
            this.videoXpathMemoEdit.TabIndex = 1;
            // 
            // fullDescXPathLabel
            // 
            fullDescXPathLabel.AutoSize = true;
            fullDescXPathLabel.Location = new System.Drawing.Point(39, 15);
            fullDescXPathLabel.Name = "fullDescXPathLabel";
            fullDescXPathLabel.Size = new System.Drawing.Size(86, 13);
            fullDescXPathLabel.TabIndex = 0;
            fullDescXPathLabel.Text = "Full Desc XPath:";
            // 
            // fullDescXPathMemoEdit
            // 
            this.fullDescXPathMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "FullDescXPath", true));
            this.fullDescXPathMemoEdit.Location = new System.Drawing.Point(131, 12);
            this.fullDescXPathMemoEdit.Name = "fullDescXPathMemoEdit";
            this.fullDescXPathMemoEdit.Size = new System.Drawing.Size(304, 96);
            this.fullDescXPathMemoEdit.TabIndex = 1;
            // 
            // txtSpect
            // 
            this.txtSpect.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "FullDescXPath", true));
            this.txtSpect.Location = new System.Drawing.Point(588, 15);
            this.txtSpect.Name = "txtSpect";
            this.txtSpect.Size = new System.Drawing.Size(430, 96);
            this.txtSpect.TabIndex = 2;
            // 
            // txtVideo
            // 
            this.txtVideo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "VideoXpath", true));
            this.txtVideo.Location = new System.Drawing.Point(586, 24);
            this.txtVideo.Name = "txtVideo";
            this.txtVideo.Size = new System.Drawing.Size(430, 96);
            this.txtVideo.TabIndex = 3;
            // 
            // txtShortDescription
            // 
            this.txtShortDescription.Location = new System.Drawing.Point(588, 57);
            this.txtShortDescription.Name = "txtShortDescription";
            this.txtShortDescription.Size = new System.Drawing.Size(430, 96);
            this.txtShortDescription.TabIndex = 4;
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "VideoXpath", true));
            this.memoEdit1.Location = new System.Drawing.Point(588, 13);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(430, 96);
            this.memoEdit1.TabIndex = 4;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(12, 5);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // FrmConfigDescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 810);
            this.Controls.Add(this.configurationBindingNavigator);
            this.Controls.Add(this.panelControl5);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl3);
            this.Name = "FrmConfigDescription";
            this.Text = "FrmConfigDescription";
            this.Load += new System.EventHandler(this.FrmConfigDescription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            this.panelControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsQT2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingNavigator)).EndInit();
            this.configurationBindingNavigator.ResumeLayout(false);
            this.configurationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shortDescriptionXPathMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specsXpathMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoXpathMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDescXPathMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSpect.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVideo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtShortDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl5;
        private DS.DsQT2 dsQT2;
        private System.Windows.Forms.BindingSource configurationBindingSource;
        private DS.DsQT2TableAdapters.ConfigurationTableAdapter configurationTableAdapter;
        private DS.DsQT2TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator configurationBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton configurationBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnTest;
        private DevExpress.XtraEditors.MemoEdit txtShortDescription;
        private DevExpress.XtraEditors.MemoEdit shortDescriptionXPathMemoEdit;
        private DevExpress.XtraEditors.MemoEdit txtSpect;
        private DevExpress.XtraEditors.MemoEdit specsXpathMemoEdit;
        private DevExpress.XtraEditors.MemoEdit txtVideo;
        private DevExpress.XtraEditors.MemoEdit videoXpathMemoEdit;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.MemoEdit fullDescXPathMemoEdit;
    }
}