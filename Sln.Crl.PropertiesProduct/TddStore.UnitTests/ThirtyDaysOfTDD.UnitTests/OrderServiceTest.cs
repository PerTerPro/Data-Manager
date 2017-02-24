using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Telerik.JustMock;
using Telerik.JustMock.AutoMock.Ninject;

namespace ThirtyDaysOfTDD.UnitTests
{
    [TestFixture]
    public  class OrderServiceTest
    {
        [Test]
        public void WhenUserPacesACorrectOrderThenAnOrderNumberShouldBeReturned()
        {
           //Arrange
            var shoppingCart = new ShoppingCart();
            shoppingCart.Items.Add(new ShoppingCartItem
            {
                ItemId = Guid.NewGuid(),
                Quantity = 1
            });
            var customerId = Guid.NewGuid();
            var expectedOrderId = Guid.NewGuid();

            var orderDataService = Mock.Create<IOrderDataService>();
            Mock.Arrange(() => orderDataService.Save(Arg.IsAny<Order>())).Returns(expectedOrderId).OccursAtLeast(2);
            var orderSErvice = new OrderService(orderDataService);

            //Act
            var result = orderSErvice.PlaceOrder(customerId, shoppingCart);

            //Assert
            Assert.AreEqual(expectedOrderId, result);
            Mock.Assert(orderDataService);

           
        }
    }
}
