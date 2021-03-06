using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendorTracker.Models;
using System;

namespace BakeryVendorTracker.Tests
{
  [TestClass]
  public class OrdersTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("order title", "order description", "order date", 10);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetOrderTitle_ReturnsOrderTitle_String()
    {
      string orderTitle = "Ted's Bread Order01";
      string orderDescription = "10 loaves of Soughdough";
      string orderDate = "07/25/2020";
      int orderPrice = 2;
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice);
      string returnValue = newOrder.OrderTitle;
      Assert.AreEqual(orderTitle, returnValue);
    }
    [TestMethod]
    public void GetOrderDescription_ReturnsOrderDescription_String()
    {
      string orderTitle = "Ted's Bread Order01";
      string orderDescription = "10 loaves of Soughdough";
      string orderDate = "07/25/2020";
      int orderPrice = 2;
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice);
      string returnValue = newOrder.OrderDescription;
      Assert.AreEqual(orderDescription, returnValue);
    }
    [TestMethod]
    public void GetOrderDate_ReturnsOrderDate_String()
    {
      string orderTitle = "Ted's Bread Order01";
      string orderDescription = "10 loaves of Soughdough";
      string orderDate = "07/25/2020";
      int orderPrice = 2;
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice);
      string returnValue = newOrder.OrderDate;
      Assert.AreEqual(orderDate, returnValue);
    }
    [TestMethod]
    public void GetOrderPrice_ReturnsOrderPrice_Int()
    {
      string orderTitle = "Ted's Bread Order01";
      string orderDescription = "10 loaves of Soughdough";
      string orderDate = "07/25/2020";
      int orderPrice = 2;
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice);
      int returnValue = newOrder.OrderPrice;
      Assert.AreEqual(orderPrice, returnValue);
    }
    [TestMethod]
    public void SetOrderTitle_SetOrderTitle_String()
    {
      string orderTitle = "Ted's Bread Order01";
      string orderDescription = "10 loaves of Soughdough";
      string orderDate = "07/25/2020";
      int orderPrice = 2;
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice);
      string updateOrderTitle = "Ted's Bread Order01";
      newOrder.OrderTitle = updateOrderTitle;
      string returnValue = newOrder.OrderTitle;
      Assert.AreEqual(updateOrderTitle, returnValue);
    }
    [TestMethod]
    public void SetOrderDescription_SetOrderDescription_String()
    {
      string orderTitle = "Ted's Bread Order01";
      string orderDescription = "10 loaves of Soughdough";
      string orderDate = "07/25/2020";
      int orderPrice = 2;
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice);
      string updateOrderDescription = "5 loaves of Soughdough";
      newOrder.OrderDescription = updateOrderDescription;
      string returnValue = newOrder.OrderDescription;
      Assert.AreEqual(updateOrderDescription, returnValue);
    }
    [TestMethod]
    public void SetOrderDate_SetOrderDate_String()
    {
      string orderTitle = "Ted's Bread Order01";
      string orderDescription = "10 loaves of Soughdough";
      string orderDate = "07/25/2020";
      int orderPrice = 2;
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice);
      string updateOrderDate = "07/26/2020";
      newOrder.OrderDate = updateOrderDate;
      string returnValue = newOrder.OrderDate;
      Assert.AreEqual(updateOrderDate, returnValue);
    }
    [TestMethod]
    public void SetOrderPrice_SetOrderPrice_Int()
    {
      string orderTitle = "Ted's Bread Order01";
      string orderDescription = "10 loaves of Soughdough";
      string orderDate = "07/25/2020";
      int orderPrice = 2;
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice);
      int updateOrderPrice = 105;
      newOrder.OrderPrice = updateOrderPrice;
      int returnValue = newOrder.OrderPrice;
      Assert.AreEqual(updateOrderPrice, returnValue);
    }
    [TestMethod]
    public void GetAllOrders_ReturnsAllInstancesOfOrder_OrderList()
    {
      string orderTitle01 = "Ted's Bread Order01";
      string orderDescription01 = "10 loaves of Soughdough";
      string orderDate01 = "07/25/2020";
      int orderPrice01 = 2;
      string orderTitle02 = "Crestmont Croissant01";
      string orderDescription02 = "23 Croissants";
      string orderDate02 = "07/25/2020";
      int orderPrice02 = 12;
      Order newOrder01 = new Order(orderTitle01, orderDescription01, orderDate01, orderPrice01);
      Order newOrder02 = new Order(orderTitle02, orderDescription02, orderDate02, orderPrice02);
      List<Order> newOrderList = new List<Order> { newOrder01, newOrder02 };
      List<Order> returnResult = Order.GetAll();
      CollectionAssert.AreEqual(newOrderList, returnResult);
    }
    [TestMethod]
    public void GetAllOrders_ReturnsAnEmptyList_OrderList()
    {
      List<Order> newOrderList = new List<Order>{};
      List<Order> returnResult = Order.GetAll();
      CollectionAssert.AreEqual(newOrderList, returnResult);
    }
  }
}