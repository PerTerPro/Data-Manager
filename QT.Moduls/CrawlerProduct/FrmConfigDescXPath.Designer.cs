namespace QT.Moduls.CrawlerProduct
{
    partial class FrmConfigDescXPath
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfigDescXPath));
            System.Windows.Forms.Label shortDescriptionXPathLabel;
            System.Windows.Forms.Label specsXpathLabel;
            System.Windows.Forms.Label videoXpathLabel;
            System.Windows.Forms.Label fullDescXPathLabel;
            this.dB = new QT.Moduls.DB();
            this.configurationBindingSource = new System.Windows.Forms.BindingSource();
            this.configurationTableAdapter = new QT.Moduls.DBTableAdapters.ConfigurationTableAdapter();
            this.tableAdapterManager = new QT.Moduls.DBTableAdapters.TableAdapterManager();
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
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit3 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit4 = new DevExpress.XtraEditors.MemoEdit();
            this.btnTest = new System.Windows.Forms.Button();
            shortDescriptionXPathLabel = new System.Windows.Forms.Label();
            specsXpathLabel = new System.Windows.Forms.Label();
            videoXpathLabel = new System.Windows.Forms.Label();
            fullDescXPathLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingNavigator)).BeginInit();
            this.configurationBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shortDescriptionXPathMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specsXpathMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoXpathMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDescXPathMemoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit4.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dB
            // 
            this.dB.DataSetName = "DB";
            this.dB.EnforceConstraints = false;
            this.dB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // configurationBindingSource
            // 
            this.configurationBindingSource.DataMember = "Configuration";
            this.configurationBindingSource.DataSource = this.dB;
            // 
            // configurationTableAdapter
            // 
            this.configurationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClassificationTableAdapter = null;
            this.tableAdapterManager.Company_RattingTableAdapter = null;
            this.tableAdapterManager.Company_StatusTableAdapter = null;
            this.tableAdapterManager.CompanyTableAdapter = null;
            this.tableAdapterManager.Config_HaravanBizwebTableAdapter = null;
            this.tableAdapterManager.ConfigurationTableAdapter = this.configurationTableAdapter;
            this.tableAdapterManager.ListClassificationTableAdapter = null;
            this.tableAdapterManager.MapClassificationTableAdapter = null;
            this.tableAdapterManager.ProductID_PropertyTableAdapter = null;
            this.tableAdapterManager.ProductIDTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PropertyGroupTableAdapter = null;
            this.tableAdapterManager.PropertyTableAdapter = null;
            this.tableAdapterManager.PropertyValueTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.DBTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.configurationBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.configurationBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.configurationBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.configurationBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.configurationBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.configurationBindingNavigator.Name = "configurationBindingNavigator";
            this.configurationBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.configurationBindingNavigator.Size = new System.Drawing.Size(1068, 25);
            this.configurationBindingNavigator.TabIndex = 0;
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
            shortDescriptionXPathLabel.Location = new System.Drawing.Point(13, 51);
            shortDescriptionXPathLabel.Name = "shortDescriptionXPathLabel";
            shortDescriptionXPathLabel.Size = new System.Drawing.Size(123, 13);
            shortDescriptionXPathLabel.TabIndex = 1;
            shortDescriptionXPathLabel.Text = "Short Description XPath:";
            // 
            // shortDescriptionXPathMemoEdit
            // 
            this.shortDescriptionXPathMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "ShortDescriptionXPath", true));
            this.shortDescriptionXPathMemoEdit.Location = new System.Drawing.Point(142, 48);
            this.shortDescriptionXPathMemoEdit.Name = "shortDescriptionXPathMemoEdit";
            this.shortDescriptionXPathMemoEdit.Size = new System.Drawing.Size(299, 96);
            this.shortDescriptionXPathMemoEdit.TabIndex = 2;
            // 
            // specsXpathLabel
            // 
            specsXpathLabel.AutoSize = true;
            specsXpathLabel.Location = new System.Drawing.Point(65, 165);
            specsXpathLabel.Name = "specsXpathLabel";
            specsXpathLabel.Size = new System.Drawing.Size(71, 13);
            specsXpathLabel.TabIndex = 3;
            specsXpathLabel.Text = "Specs Xpath:";
            // 
            // specsXpathMemoEdit
            // 
            this.specsXpathMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "SpecsXpath", true));
            this.specsXpathMemoEdit.Location = new System.Drawing.Point(142, 162);
            this.specsXpathMemoEdit.Name = "specsXpathMemoEdit";
            this.specsXpathMemoEdit.Size = new System.Drawing.Size(299, 96);
            this.specsXpathMemoEdit.TabIndex = 4;
            // 
            // videoXpathLabel
            // 
            videoXpathLabel.AutoSize = true;
            videoXpathLabel.Location = new System.Drawing.Point(68, 267);
            videoXpathLabel.Name = "videoXpathLabel";
            videoXpathLabel.Size = new System.Drawing.Size(68, 13);
            videoXpathLabel.TabIndex = 5;
            videoXpathLabel.Text = "Video Xpath:";
            // 
            // videoXpathMemoEdit
            // 
            this.videoXpathMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "VideoXpath", true));
            this.videoXpathMemoEdit.Location = new System.Drawing.Point(142, 264);
            this.videoXpathMemoEdit.Name = "videoXpathMemoEdit";
            this.videoXpathMemoEdit.Size = new System.Drawing.Size(299, 96);
            this.videoXpathMemoEdit.TabIndex = 6;
            // 
            // fullDescXPathLabel
            // 
            fullDescXPathLabel.AutoSize = true;
            fullDescXPathLabel.Location = new System.Drawing.Point(50, 369);
            fullDescXPathLabel.Name = "fullDescXPathLabel";
            fullDescXPathLabel.Size = new System.Drawing.Size(86, 13);
            fullDescXPathLabel.TabIndex = 7;
            fullDescXPathLabel.Text = "Full Desc XPath:";
            // 
            // fullDescXPathMemoEdit
            // 
            this.fullDescXPathMemoEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "FullDescXPath", true));
            this.fullDescXPathMemoEdit.Location = new System.Drawing.Point(142, 366);
            this.fullDescXPathMemoEdit.Name = "fullDescXPathMemoEdit";
            this.fullDescXPathMemoEdit.Size = new System.Drawing.Size(299, 96);
            this.fullDescXPathMemoEdit.TabIndex = 8;
            // 
            // memoEdit1
            // 
            this.memoEdit1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "FullDescXPath", true));
            this.memoEdit1.Location = new System.Drawing.Point(480, 367);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(299, 96);
            this.memoEdit1.TabIndex = 12;
            // 
            // memoEdit2
            // 
            this.memoEdit2.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "VideoXpath", true));
            this.memoEdit2.Location = new System.Drawing.Point(480, 265);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Size = new System.Drawing.Size(299, 96);
            this.memoEdit2.TabIndex = 11;
            // 
            // memoEdit3
            // 
            this.memoEdit3.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "SpecsXpath", true));
            this.memoEdit3.Location = new System.Drawing.Point(480, 163);
            this.memoEdit3.Name = "memoEdit3";
            this.memoEdit3.Size = new System.Drawing.Size(299, 96);
            this.memoEdit3.TabIndex = 10;
            // 
            // memoEdit4
            // 
            this.memoEdit4.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configurationBindingSource, "ShortDescriptionXPath", true));
            this.memoEdit4.Location = new System.Drawing.Point(480, 49);
            this.memoEdit4.Name = "memoEdit4";
            this.memoEdit4.Size = new System.Drawing.Size(299, 96);
            this.memoEdit4.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(142, 468);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(158, 50);
            this.btnTest.TabIndex = 13;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // FrmConfigDescXPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 726);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.memoEdit2);
            this.Controls.Add(this.memoEdit3);
            this.Controls.Add(this.memoEdit4);
            this.Controls.Add(fullDescXPathLabel);
            this.Controls.Add(this.fullDescXPathMemoEdit);
            this.Controls.Add(videoXpathLabel);
            this.Controls.Add(this.videoXpathMemoEdit);
            this.Controls.Add(specsXpathLabel);
            this.Controls.Add(this.specsXpathMemoEdit);
            this.Controls.Add(shortDescriptionXPathLabel);
            this.Controls.Add(this.shortDescriptionXPathMemoEdit);
            this.Controls.Add(this.configurationBindingNavigator);
            this.Name = "FrmConfigDescXPath";
            this.Text = "FrmConfigDescXPath";
            this.Load += new System.EventHandler(this.FrmConfigDescXPath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.configurationBindingNavigator)).EndInit();
            this.configurationBindingNavigator.ResumeLayout(false);
            this.configurationBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shortDescriptionXPathMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specsXpathMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoXpathMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullDescXPathMemoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit4.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB dB;
        private System.Windows.Forms.BindingSource configurationBindingSource;
        private DBTableAdapters.ConfigurationTableAdapter configurationTableAdapter;
        private DBTableAdapters.TableAdapterManager tableAdapterManager;
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
        private DevExpress.XtraEditors.MemoEdit shortDescriptionXPathMemoEdit;
        private DevExpress.XtraEditors.MemoEdit specsXpathMemoEdit;
        private DevExpress.XtraEditors.MemoEdit videoXpathMemoEdit;
        private DevExpress.XtraEditors.MemoEdit fullDescXPathMemoEdit;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.MemoEdit memoEdit2;
        private DevExpress.XtraEditors.MemoEdit memoEdit3;
        private DevExpress.XtraEditors.MemoEdit memoEdit4;
        private System.Windows.Forms.Button btnTest;
    }
}