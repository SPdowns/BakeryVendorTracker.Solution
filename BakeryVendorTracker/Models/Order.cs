using System.Collections.Generic;

namespace BakeryVendorTracker.Models
{
  public class Order
  {
    public string OrderTitle { get; set; }

    public string OrderDescription { get; set; }

    public int OrderPrice { get; set; }

    public string OrderDate { get; set; }

    public int OrderId { get; }

    private static List<Order> _instances = new List<Order> {};

    public Order(string orderTitle, string orderDescription, string orderDate, int orderPrice)
    {
      OrderTitle = orderTitle;
      OrderDescription = orderDescription;
      OrderDate = orderDate;
      OrderPrice = orderPrice;
      _instances.Add(this);
      OrderId = _instances.Count;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }
    public static Vendor Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
  }
}