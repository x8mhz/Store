using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;
using System.Collections.Generic;

namespace Store.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var category = new Category("Placa mãe");
            var product = new Product("Processador", "Intel I7", 1200, 5, 1);

            var order = new Order(new List<OrderItem>(), 1 );
            var orderItem = new OrderItem(1, 20);

            order.AddItem(orderItem);
            

            Assert.AreNotEqual(0, order.OrderItems);
            
        }
    }
}
