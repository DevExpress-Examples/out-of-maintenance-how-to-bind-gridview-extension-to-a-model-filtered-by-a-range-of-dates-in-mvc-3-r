using System;

namespace Example.Models {
    public class OrdersModel {

        private readonly NorthwindTableAdapters.OrdersTableAdapter _data = new NorthwindTableAdapters.OrdersTableAdapter();

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Northwind.OrdersDataTable Data { get { return _data.GetDataByDate(StartDate, EndDate); } }

        public DateTime MinDate {
            get {
                return (DateTime?)_data.MinOrderDate() ?? new DateTime (1990, 1, 1);
            }
        }

        public DateTime MaxDate {
            get {
                return (DateTime?)_data.MaxOrderDate() ?? new DateTime(2011, 1, 1);
            }
        }
    }
}