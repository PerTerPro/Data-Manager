using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QT.Entities
{
    public partial class ctrPage : UserControl
    {
        private int _totalItem = 0;
        private int _currentPage = 1;
        private int _pageSize = 50;
        private int _totalPage = 1;

        public delegate void ChangedEventHandler(EventArgs e);
        public event ChangedEventHandler PageChanged;

        public ctrPage()
        {
            InitializeComponent();
        }

        public int GetTotalItem()
        {
            return _totalItem;
        }
        public void SetTotalItem(int totalItem)
        {
            _totalItem = totalItem;
            lbTotalItem.Text = totalItem.ToString();
            RefreshControl();
        }

        private void RefreshControl()
        {
            var totalPage = (int)_totalItem / GetPageSize() + 1;
            SetTotalPage(totalPage);
            SetCurrentPage(1);
            PageChanged(null);
        }
        private void SetTotalPage(int totalPage)
        {
            _totalPage = totalPage;
            txtTotalPage.Text = totalPage.ToString();
            if (_totalPage == 1)
                DisableAll();
        }

        public int GetPageSize()
        {
            return Common.Obj2Int(cboSize.EditValue);
        }


        public int GetCurrentPage()
        {
            return _currentPage;
        }

        private void SetCurrentPage(int currentPage)
        {
            if (currentPage <=1)
            {
                _currentPage = 1;
                SetFirstPage();
            }
            else if (currentPage >= _totalPage)
            {
                _currentPage = _totalPage;
                SetLastPage();
            }
            else
            {
                _currentPage = currentPage;
                EnableAll();
            }
            txtCurrentPage.Text = currentPage.ToString();
            PageChanged(null);
        }

        private void txtCurrentPage_EditValueChanged(object sender, EventArgs e)
        {
            var currentPage = Common.Obj2Int(txtCurrentPage.Text);
            if (currentPage == 0)
            {
                SetCurrentPage(1);
            }
            else if (currentPage >= _totalPage)
            {
                SetCurrentPage(_totalPage);
            }
            else
                SetCurrentPage(currentPage);
        }

        private void btNext_Click(object sender, EventArgs e)
        {
            SetCurrentPage(++_currentPage);
        }

        private void btEnd_Click(object sender, EventArgs e)
        {
            SetCurrentPage(_totalPage);
        }

        private void btPrevious_Click(object sender, EventArgs e)
        {
            SetCurrentPage(--_currentPage);
        }

        private void btFirst_Click(object sender, EventArgs e)
        {
            SetCurrentPage(1);
        }


        private void SetLastPage()
        {
            btNext.Enabled = false;
            btEnd.Enabled = false;
            btFirst.Enabled = true;
            btPrevious.Enabled = true;
        }
        private void SetFirstPage()
        {
            btNext.Enabled = true;
            btEnd.Enabled = true;
            btFirst.Enabled = false;
            btPrevious.Enabled = false;
        }

        private void EnableAll()
        {
            btNext.Enabled = true;
            btEnd.Enabled = true;
            btFirst.Enabled = true;
            btPrevious.Enabled = true;
        }
        private void DisableAll()
        {
            btNext.Enabled = false;
            btEnd.Enabled = false;
            btFirst.Enabled = false;
            btPrevious.Enabled = false;
        }
    }
}
