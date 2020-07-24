using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendorTracker.Models;
using System;

namespace BakeryVendorTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Crestmont Croissant", "Very Good Croissants");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "Crestmont Croissant";
      string vendorDescription = "Very Good Croissants";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      string returnValue = newVendor.VendorName;
      Assert.AreEqual(vendorName, returnValue);
    }

    [TestMethod]
    public void GetVendorDescription_ReturnsVendorDescription_String()
    {
      string vendorName = "Crestmont Croissant";
      string vendorDescription = "Very Good Croissants";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      string returnValue = newVendor.VendorDescription;
      Assert.AreEqual(vendorDescription, returnValue);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string vendorName = "Crestmont Croissant";
      string vendorDescription = "Very Good Croissants";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      int returnValue = newVendor.VendorId;
      Assert.AreEqual(1, returnValue);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName01 = "Crestmont Croissant";
      string vendorDescription01 = "Very Good Croissants";
      string vendorName02 = "Ted's Bread's";
      string vendorDescription02 = "Very Good Breads";
      Vendor newVendor01 = new Vendor(vendorName01, vendorDescription01);
      Vendor newVendor02 = new Vendor(vendorName02, vendorDescription02);
      List<Vendor> newVendorList = new List<Vendor> { newVendor01, newVendor02 };
      List<Vendor> returnValue = Vendor.GetAll();
      CollectionAssert.AreEqual(newVendorList, returnValue);
    }

    [TestMethod]
    public void VendorFind_ReturnsCorrespsondingVendorById_Vendor()
    {
      string vendorName01 = "Crestmont Croissant";
      string vendorDescription01 = "Very Good Croissants";
      string vendorName02 = "Ted's Bread's";
      string vendorDescription02 = "Very Good Breads";
      Vendor newVendor01 = new Vendor(vendorName01, vendorDescription01);
      Vendor newVendor02 = new Vendor(vendorName02, vendorDescription02);
      Vendor returnValue = Vendor.Find(2);
      Assert.AreEqual(newVendor02, returnValue);
    }

    [TestMethod]

    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      string orderItems = "10 loaves of Soughdough";
      Order newOrder = new List<Order> { orderItems };
      string vendorName = "Ted's Breads";
      string vendorDescription = "Very Good Breads";
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      newVendor.AddOrder(newOrder);
    }
  }
}