using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;
using QT.Entities;

namespace QT.Moduls.Maps
{
    
    public partial class ctrTree : UserControl
    {

        TreeListNode nodeParent;


        public ctrTree()
        {
            InitializeComponent();
        }

        public void InitData()
        {
            this.listClassificationTableAdapter.Connection.ConnectionString = QT.Entities.Server.ConnectionString;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            SetParentNode();
            AddRoot("");
        }

        public void AddRoot(String tenChuyenMuc)
        {
            this.tlClassification.FocusedNode = tlClassification.AppendNode(tenChuyenMuc, null);
            this.nameLabel1.Text = tenChuyenMuc;
            this.listClassificationBindingSource.EndEdit();
        }
        public void AddChild(String tenChuyenMuc)
        {
            if (tlClassification.FocusedNode != null)
            {
                tlClassification.FocusedNode = tlClassification.AppendNode(tenChuyenMuc, nodeParent);
                this.nameLabel1.Text = tenChuyenMuc;
                this.listClassificationBindingSource.EndEdit();
            }
        }
        public int GetIDClassification()
        {
            return Common.Obj2Int(this.iDLabel1.Text);
        }
        public string GetNameClassification()
        {
            return this.nameLabel1.Text;
        }
        public string GetListIDSearch()
        {
            return this.ListIDSearchLabelControl.Text;
        }
        private void btRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            this.listClassificationTableAdapter.Fill(dB.ListClassification);
            this.tlClassification.ExpandAll();
        }
        public void Save()
        {
            this.listClassificationBindingSource.EndEdit();
            this.listClassificationTableAdapter.Update(dB.ListClassification);
        }
        private void btAddChild_Click(object sender, EventArgs e)
        {
            SetParentNode();
            AddChild("");
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            if (listClassificationBindingSource.Count > 0)
            {
                listClassificationBindingSource.RemoveCurrent();
            }
        }

        public void SetParentNode()
        {
            nodeParent = tlClassification.FocusedNode;
        }

        private void tlClassification_DragDrop(object sender, DragEventArgs e)
        {
           
            //TreeListHitInfo hi = tlClassification.CalcHitInfo(tlClassification.PointToClient(new Point(e.X, e.Y)));
            //DragObject dobj = GetDragObject(e.Data);
            //if (dobj != null)
            //{
            //    TreeListNode node = hi.Node;
            //    if (hi.HitInfoType == HitInfoType.Empty || node != null)
            //    {
            //        node = tlClassification.AppendNode(dobj.DragData, node);
            //        node.StateImageIndex = dobj.ImageIndex;
            //        tlClassification.MakeNodeVisible(node);
            //        TreeListNode parentNode = node.ParentNode;
            //        if (parentNode != null && (e.KeyState & 4) != 0)
            //        {
            //            int index = -1;
            //            if (parentNode.ParentNode != null)
            //                index = parentNode.ParentNode.Nodes.IndexOf(parentNode);
            //            tlClassification.MoveNode(node, parentNode.ParentNode);
            //            tlClassification.SetNodeIndex(node, index);
            //        }
            //    }
            //}
            //SetDefaultCursor();
        }

        private void tlClassification_DragObjectDrop(object sender, DragObjectDropEventArgs e)
        {
            
        }

        private void tlClassification_AfterDragNode(object sender, NodeEventArgs e)
        {
            try
            {
                TreeListNode node = tlClassification.FocusedNode;
                TreeListNode nodeParent = node.ParentNode;
                node.SetValue("ParentID", nodeParent.GetValue("ID"));
            }
            catch (Exception)
            {
            }
            
        }

        private String GetListCatID(int catID)
        {
            String r = "";
            DBMap.ListClassificationDataTable dt = new DBMap.ListClassificationDataTable();
            DBMapTableAdapters.ListClassificationTableAdapter adt = new DBMapTableAdapters.ListClassificationTableAdapter();
            adt.Connection.ConnectionString = Server.ConnectionString;
            int id = catID;
            for (int i = 0; i < 10; i++)
            {
                adt.FillBy_ID(dt, id);
                if (dt.Rows.Count > 0)
                {
                    id = Common.Obj2Int(dt.Rows[0]["ParentID"]);
                    if (id == 0)
                    {
                        break;
                    }
                    r += "c" + id.ToString("D3") + " ";
                }
            }
            return r;
        }


        private void btMapIDSearch_Click(object sender, EventArgs e)
        {
            DBMap.ListClassificationDataTable dt = new DBMap.ListClassificationDataTable();
            DBMapTableAdapters.ListClassificationTableAdapter adt = new DBMapTableAdapters.ListClassificationTableAdapter();
            adt.Connection.ConnectionString = Server.ConnectionString;
            adt.Fill(dt);
            foreach (DBMap.ListClassificationRow dr in dt)
            {
                //Sửa lại ListIdSearch trong ListClassification
                String listcat = "c"+dr.ID.ToString("D3");
                listcat = listcat + " "+ GetListCatID(dr.ID);
                adt.UpdateQuery_ListIDSearch(listcat, dr.ID);
            }
        }
        private bool expand = false;
        private void btExpan_Click(object sender, EventArgs e)
        {
            if (expand)
            {
                tlClassification.CollapseAll();
                expand = false;
            }
            else
            {
                this.tlClassification.ExpandAll();
                expand = true;
            }
            
        }
        
    }
}
