using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using BakeryVendorTracker.Models;

namespace BakeryVendorTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }
    [HttpGet("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors.{id}")]
    public ActionResult Show(int vendorId)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(vendorId);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("vendor", selectedVendor);
      model.Add("orders", vendorOrders);
      return View(model);
    }
    [HttpGet("/vendors/vendorId/orders")]
    public ActionResult Create(int vendorId, string orderTitle, string orderDescription, string orderDate, int orderPrice)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor foundVendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice);
      foundVendor.AddOrder(newOrder);
      List<Order> vendorOrders = foundVendor.Orders;
      model.Add("orders", vendorOrders);
      model.Add("vendors", foundVendor);
      return View("Show", model);
    }
  }
}