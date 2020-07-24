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
  }
}