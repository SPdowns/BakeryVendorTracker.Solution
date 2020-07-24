using System.Collections.Generic;

namespace BakeryVendorTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string VendorName { get; set; }
    public int VendorId { get; set; }
    public List<Order> Orders { get; set; }

    public Vendor(string vendorName)
    {
      VendorName = vendorName;
      _instances.Add(this);
      VendorId = _instances.Count;
      Orders = new List<Order>{};
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}