using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QT.Moduls.RatingCompany
{
    public class EnumRatting_BigStore
    {
        static EnumRatting_BigStore _instance;

        public static EnumRatting_BigStore Instance()
        {
            return (_instance == null) ? _instance = new EnumRatting_BigStore() : _instance;
        }

        DataTable _BigStore = null;
        DataTable _Scandal = null;

        public DataTable Scandal
        {
            get { return _Scandal; }
            set { _Scandal = value; }
        }
        DataTable _Quantity = null;

        public DataTable Quantity
        {
            get { return _Quantity; }
            set { _Quantity = value; }
        }
        DataTable _Genuine = null;

        public DataTable Genuine
        {
            get { return _Genuine; }
            set { _Genuine = value; }
        }
        private DataTable _Attitude = null;

        public DataTable Attitude
        {
            get { return _Attitude; }
            set { _Attitude = value; }
        }
        private DataTable _Delivery = null;

        public DataTable Delivery
        {
            get { return _Delivery; }
            set { _Delivery = value; }
        }
        private DataTable _Guarantee = null;

        public DataTable Guarantee
        {
            get { return _Guarantee; }
            set { _Guarantee = value; }
        }

        private DataTable _OldCustomer = null;

        public DataTable OldCustomer
        {
            get { return _OldCustomer; }
            set { _OldCustomer = value; }
        }

        private DataTable _Swap = null;

        public DataTable Swap
        {
            get { return _Swap; }
            set { _Swap = value; }
        }
        private DataTable _Price = null;
        private DataTable _Reputation;

        public DataTable Reputation
        {
            get { return _Reputation; }
            set { _Reputation = value; }
        }

        public DataTable Price
        {
            get { return _Price; }
            set { _Price = value; }
        }

        public EnumRatting_BigStore()
        {
            _BigStore = new DataTable();
            _BigStore.Columns.Add("Value", typeof(int));
            _BigStore.Columns.Add("Text", typeof(string));
            _BigStore.Rows.Add(0, "None");
            _BigStore.Rows.Add(1, "1");
            _BigStore.Rows.Add(2, "2");
            _BigStore.Rows.Add(3, "3");
            _BigStore.Rows.Add(4, "4");
            _BigStore.Rows.Add(5, "5");

            _OldCustomer = new DataTable();
            _OldCustomer.Columns.Add("Value", typeof(int));
            _OldCustomer.Columns.Add("Text", typeof(string));
            _OldCustomer.Rows.Add(0, "None");
            _OldCustomer.Rows.Add(1, "1");
            _OldCustomer.Rows.Add(2, "2");
            _OldCustomer.Rows.Add(3, "3");
            _OldCustomer.Rows.Add(4, "4");
            _OldCustomer.Rows.Add(5, "5");

            _Scandal = new DataTable();
            _Scandal.Columns.Add("Value", typeof(int));
            _Scandal.Columns.Add("Text", typeof(string));
            _Scandal.Rows.Add(0, "None");
            _Scandal.Rows.Add(1, "1");
            _Scandal.Rows.Add(2, "2");
            _Scandal.Rows.Add(3, "3");
            _Scandal.Rows.Add(4, "4");
            _Scandal.Rows.Add(5, "5");

            _Quantity = new DataTable();
            _Quantity.Columns.Add("Value", typeof(int));
            _Quantity.Columns.Add("Text", typeof(string));
            _Quantity.Rows.Add(0, "None");
            _Quantity.Rows.Add(1, "1");
            _Quantity.Rows.Add(2, "2");
            _Quantity.Rows.Add(3, "3");
            _Quantity.Rows.Add(4, "4");
            _Quantity.Rows.Add(5, "5");

            _Genuine = new DataTable();
            _Genuine.Columns.Add("Value", typeof(int));
            _Genuine.Columns.Add("Text", typeof(string));
            _Genuine.Rows.Add(0, "None");
            _Genuine.Rows.Add(1, "1");
            _Genuine.Rows.Add(2, "2");
            _Genuine.Rows.Add(3, "3");
            _Genuine.Rows.Add(4, "4");
            _Genuine.Rows.Add(5, "5");

            _Attitude = new DataTable();
            _Attitude.Columns.Add("Value", typeof(int));
            _Attitude.Columns.Add("Text", typeof(string));
            _Attitude.Rows.Add(0, "None");
            _Attitude.Rows.Add(1, "1");
            _Attitude.Rows.Add(2, "2");
            _Attitude.Rows.Add(3, "3");
            _Attitude.Rows.Add(4, "4");
            _Attitude.Rows.Add(5, "5");

            _Delivery = new DataTable();
            _Delivery.Columns.Add("Value", typeof(int));
            _Delivery.Columns.Add("Text", typeof(string));
            _Delivery.Rows.Add(0, "None");
            _Delivery.Rows.Add(1, "1");
            _Delivery.Rows.Add(2, "2");
            _Delivery.Rows.Add(3, "3");
            _Delivery.Rows.Add(4, "4");
            _Delivery.Rows.Add(5, "5");

            Reputation = new DataTable();
            Reputation.Columns.Add("Value", typeof(int));
            Reputation.Columns.Add("Text", typeof(string));
            Reputation.Rows.Add(0, "None");
            Reputation.Rows.Add(1, "1");
            Reputation.Rows.Add(2, "2");
            Reputation.Rows.Add(3, "3");
            Reputation.Rows.Add(4, "4");
            Reputation.Rows.Add(5, "5");

            _Guarantee = new DataTable();
            _Guarantee.Columns.Add("Value", typeof(int));
            _Guarantee.Columns.Add("Text", typeof(string));
            _Guarantee.Rows.Add(0, "None");
            _Guarantee.Rows.Add(1, "1");
            _Guarantee.Rows.Add(2, "2");
            _Guarantee.Rows.Add(3, "3");
            _Guarantee.Rows.Add(4, "4");
            _Guarantee.Rows.Add(5, "5");

            _Swap = new DataTable();
            _Swap.Columns.Add("Value", typeof(int));
            _Swap.Columns.Add("Text", typeof(string));
            _Swap.Rows.Add(0, "None");
            _Swap.Rows.Add(1, "1");
            _Swap.Rows.Add(2, "2");
            _Swap.Rows.Add(3, "3");
            _Swap.Rows.Add(4, "4");
            _Swap.Rows.Add(5, "5");

            _Price = new DataTable();
            _Price.Columns.Add("Value", typeof(int));
            _Price.Columns.Add("Text", typeof(string));
            _Price.Rows.Add(0, "None");
            _Price.Rows.Add(1, "1");
            _Price.Rows.Add(2, "2");
            _Price.Rows.Add(3, "3");
            _Price.Rows.Add(4, "4");
            _Price.Rows.Add(5, "5");
        }


        public DataTable BigStore
        {
            get
            {
                return _BigStore;
            }
        }
    }
}
