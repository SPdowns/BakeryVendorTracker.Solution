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
  }
}