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
      Vendor newVendor = new Vendor("Crestmont Croissant");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_ReturnsVendorName_String()
    {
      string vendorName = "Crestmont Croissant";
      Vendor newVendor = new Vendor(vendorName);
      string returnValue = newVendor.VendorName;
      Assert.AreEqual(vendorName, returnValue);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string vendorName = "Crestmont Croissant";
      Vendor newVendor = new Vendor(vendorName);
      int returnValue = newVendor.VendorId;
      Assert.AreEqual(1, returnValue);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string vendorName01 = "Crestmont Croissant";
      string vendorName02 = "Ted's Bread's";
      Vendor newVendor01 = new Vendor(vendorName01);
      Vendor newVendor02 = new Vendor(vendorName02);
      List<Vendor> newVendorList = new List<Vendor> { newVendor01, newVendor02 };
      List<Vendor> returnValue = Vendor.GetAll();
      CollectionAssert.AreEqual(newVendorList, returnValue);
    }
  }
}