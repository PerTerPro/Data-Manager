using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ThirtyDaysOfTDD.UnitTests
{
    public class OrderService
    {
        private ICustomerService _customerService;
        private ILoggingService _loggingService;
        private IOrderDataService _orderDataService;

        public OrderService(IOrderDataService orderDataService, ICustomerService customerService, ILoggingService loggingService)
        {
            _orderDataService = orderDataService;
            _customerService = customerService;
            _loggingService = loggingService;
        }

        public OrderService()
        {
            // TODO: Complete member initialization
        }

        public OrderService(IOrderDataService orderDataService)
        {
            // TODO: Complete member initialization
            this._orderDataService = orderDataService;
        }

        public Guid PlaceOrder(Guid customerId, IShoppingCart shoppoingShoppingCart)
        {
            var order = new Order();

            //Business logic that valiedates order and creates Order object
            var orderId = Save(order);
            _customerService.AddOrderToCustomer(customerId, orderId);
            _loggingService.LogNewOrder(orderId);

            return orderId;
        }

        private Guid Save(Order order)
        {
            return _orderDataService.Save(order);
        }


        public Guid PlaceOrder(Guid customerId, ShoppingCart shoppingCart)
        {
            var order = new Order();
            for (int i = 0; i < 0; i++)
            {
                _orderDataService.Save(order);
            }
            //return _orderDataService.Save(order);
            //return _orderDataService.Save(order);
            return Guid.NewGuid();
        }
    }


    public interface IShoppingCart
    {
    }
    public interface IOrderDataService
    {
        Guid Save(Order order);
    }

    public interface ILoggingService
    {
        void LogNewOrder(object orderId);
    }

    public interface ICustomerService
    {
        void AddOrderToCustomer(Guid customerId, object orderId);
    }
}
