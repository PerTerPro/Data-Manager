namespace QT.Moduls.Tool
{
    partial class frmAnanyticTradeSQL
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnanyticTradeSQL));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.tempTradeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBTool3 = new QT.Moduls.Tool.DBTool3();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colRowNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEventClass = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTextData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApplicationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNTUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoginName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCPU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReads = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colWrites = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDuration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClientProcessID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBinaryData = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tempTradeTableAdapter = new QT.Moduls.Tool.DBTool3TableAdapters.TempTradeTableAdapter();
            this.tableAdapterManager = new QT.Moduls.Tool.DBTool3TableAdapters.TableAdapterManager();
            this.tempTradeBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempTradeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTool3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempTradeBindingNavigator)).BeginInit();
            this.tempTradeBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.DataSource = this.tempTradeBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(0, 28);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1178, 604);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // tempTradeBindingSource
            // 
            this.tempTradeBindingSource.DataMember = "TempTrade";
            this.tempTradeBindingSource.DataSource = this.dBTool3;
            // 
            // dBTool3
            // 
            this.dBTool3.DataSetName = "DBTool3";
            this.dBTool3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colRowNumber,
            this.colEventClass,
            this.colTextData,
            this.colApplicationName,
            this.colNTUserName,
            this.colLoginName,
            this.colCPU,
            this.colReads,
            this.colWrites,
            this.colDuration,
            this.colClientProcessID,
            this.colSPID,
            this.colStartTime,
            this.colEndTime,
            this.colBinaryData});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TextData", null, "")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colTextData, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colRowNumber
            // 
            this.colRowNumber.FieldName = "RowNumber";
            this.colRowNumber.Name = "colRowNumber";
            this.colRowNumber.OptionsColumn.ReadOnly = true;
            this.colRowNumber.Visible = true;
            this.colRowNumber.VisibleIndex = 0;
            // 
            // colEventClass
            // 
            this.colEventClass.FieldName = "EventClass";
            this.colEventClass.Name = "colEventClass";
            this.colEventClass.Visible = true;
            this.colEventClass.VisibleIndex = 1;
            // 
            // colTextData
            // 
            this.colTextData.FieldName = "TextData";
            this.colTextData.Name = "colTextData";
            this.colTextData.Visible = true;
            this.colTextData.VisibleIndex = 2;
            // 
            // colApplicationName
            // 
            this.colApplicationName.FieldName = "ApplicationName";
            this.colApplicationName.Name = "colApplicationName";
            this.colApplicationName.Visible = true;
            this.colApplicationName.VisibleIndex = 2;
            // 
            // colNTUserName
            // 
            this.colNTUserName.FieldName = "NTUserName";
            this.colNTUserName.Name = "colNTUserName";
            this.colNTUserName.Visible = true;
            this.colNTUserName.VisibleIndex = 3;
            // 
            // colLoginName
            // 
            this.colLoginName.FieldName = "LoginName";
            this.colLoginName.Name = "colLoginName";
            this.colLoginName.Visible = true;
            this.colLoginName.VisibleIndex = 4;
            // 
            // colCPU
            // 
            this.colCPU.FieldName = "CPU";
            this.colCPU.Name = "colCPU";
            this.colCPU.Visible = true;
            this.colCPU.VisibleIndex = 5;
            // 
            // colReads
            // 
            this.colReads.FieldName = "Reads";
            this.colReads.Name = "colReads";
            this.colReads.Visible = true;
            this.colReads.VisibleIndex = 6;
            // 
            // colWrites
            // 
            this.colWrites.FieldName = "Writes";
            this.colWrites.Name = "colWrites";
            this.colWrites.Visible = true;
            this.colWrites.VisibleIndex = 7;
            // 
            // colDuration
            // 
            this.colDuration.FieldName = "Duration";
            this.colDuration.Name = "colDuration";
            this.colDuration.Visible = true;
            this.colDuration.VisibleIndex = 8;
            // 
            // colClientProcessID
            // 
            this.colClientProcessID.FieldName = "ClientProcessID";
            this.colClientProcessID.Name = "colClientProcessID";
            this.colClientProcessID.Visible = true;
            this.colClientProcessID.VisibleIndex = 9;
            // 
            // colSPID
            // 
            this.colSPID.FieldName = "SPID";
            this.colSPID.Name = "colSPID";
            this.colSPID.Visible = true;
            this.colSPID.VisibleIndex = 10;
            // 
            // colStartTime
            // 
            this.colStartTime.DisplayFormat.FormatString = "hh:mm:ss:zzz";
            this.colStartTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colStartTime.FieldName = "StartTime";
            this.colStartTime.Name = "colStartTime";
            this.colStartTime.Visible = true;
            this.colStartTime.VisibleIndex = 11;
            // 
            // colEndTime
            // 
            this.colEndTime.DisplayFormat.FormatString = "hh:mm:ss:zzz";
            this.colEndTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colEndTime.FieldName = "EndTime";
            this.colEndTime.Name = "colEndTime";
            this.colEndTime.Visible = true;
            this.colEndTime.VisibleIndex = 12;
            // 
            // colBinaryData
            // 
            this.colBinaryData.FieldName = "BinaryData";
            this.colBinaryData.Name = "colBinaryData";
            this.colBinaryData.Visible = true;
            this.colBinaryData.VisibleIndex = 13;
            // 
            // tempTradeTableAdapter
            // 
            this.tempTradeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Product_LogsAddProductTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.TempTradeTableAdapter = this.tempTradeTableAdapter;
            this.tableAdapterManager.UpdateOrder = QT.Moduls.Tool.DBTool3TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tempTradeBindingNavigator
            // 
            this.tempTradeBindingNavigator.AddNewItem = null;
            this.tempTradeBindingNavigator.BindingSource = this.tempTradeBindingSource;
            this.tempTradeBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tempTradeBindingNavigator.DeleteItem = null;
            this.tempTradeBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.tempTradeBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tempTradeBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tempTradeBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tempTradeBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tempTradeBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tempTradeBindingNavigator.Name = "tempTradeBindingNavigator";
            this.tempTradeBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tempTradeBindingNavigator.Size = new System.Drawing.Size(1178, 25);
            this.tempTradeBindingNavigator.TabIndex = 1;
            this.tempTradeBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // frmAnanyticTradeSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 630);
            this.Controls.Add(this.tempTradeBindingNavigator);
            this.Controls.Add(this.gridControl1);
            this.Name = "frmAnanyticTradeSQL";
            this.Load += new System.EventHandler(this.frmAnanyticTradeSQL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempTradeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBTool3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempTradeBindingNavigator)).EndInit();
            this.tempTradeBindingNavigator.ResumeLayout(false);
            this.tempTradeBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DBTool3 dBTool3;
        private System.Windows.Forms.BindingSource tempTradeBindingSource;
        private DBTool3TableAdapters.TempTradeTableAdapter tempTradeTableAdapter;
        private DBTool3TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tempTradeBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private DevExpress.XtraGrid.Columns.GridColumn colRowNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colEventClass;
        private DevExpress.XtraGrid.Columns.GridColumn colTextData;
        private DevExpress.XtraGrid.Columns.GridColumn colApplicationName;
        private DevExpress.XtraGrid.Columns.GridColumn colNTUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colLoginName;
        private DevExpress.XtraGrid.Columns.GridColumn colCPU;
        private DevExpress.XtraGrid.Columns.GridColumn colReads;
        private DevExpress.XtraGrid.Columns.GridColumn colWrites;
        private DevExpress.XtraGrid.Columns.GridColumn colDuration;
        private DevExpress.XtraGrid.Columns.GridColumn colClientProcessID;
        private DevExpress.XtraGrid.Columns.GridColumn colSPID;
        private DevExpress.XtraGrid.Columns.GridColumn colStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn colEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn colBinaryData;
    }
}
