using System.Collections.Generic;
using System.Globalization;
using System;

namespace Pierre.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Price { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> { };

    public Order(string orderTitle, string orderDescription, string orderPrice)
    {
      Title = orderTitle;
      Description = orderDescription;
      Price = orderPrice;
      _instances.Add(this);
      Id = _instances.Count;
      DateTime now = DateTime.Now;
      Date = now;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId - 1];
    }
  }
}