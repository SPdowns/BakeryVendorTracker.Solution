using Microsoft.AspNetCore.Mvc;
using BakeryVendorTracker.Models;
using System.Collections.Generic;

namespace BakeryVendorTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{vendorsId}/orders/{orderId}")]
    public ActionResult Show(int vendorId, int orderId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      Order order = Order.Find(orderId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }
    [HttpGet("/orders/new")]
    public ActionResult CreateForm()
    {
      return View();
    }
    [HttpGet("/orders")]
    public ActionResult Create(string orderTitle, string orderDescription, string orderDate, int orderPrice)
    {
      Order newOrder = new Order(orderTitle, orderDescription, orderDate, orderPrice);
      return RedirectToAction("Index");
    }
    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
  }
}