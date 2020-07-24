using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BakeryVendorTracker.Models;
using System;

namespace BakeryVendorTracker.Tests
{
  [TestClass]
  public class VendorTest : IDisosable
  {
    public void Dispose()
    {
      Category.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("Crestmont Croissant");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType);
    }
  }
}