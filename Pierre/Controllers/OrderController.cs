using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Pierre.Models;

namespace Pierre.Controllers
{
  public class OrderController : Controller
  {

    [HttpGet("/vendors/{vendorId}/orders/new")]
    public ActionResult New(int vendorId)
    {
      Vendor vendor = Vendor.Find(vendorId);
      return View(vendor);
    }
    [HttpGet("/vendor/{categoryId}/orders/{itemId}")]
    public ActionResult Show(int orderId, int vendorId)
    {
      Order order = Order.Find(orderId);
      Vendor vendor = Vendor.Find(vendorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", order);
      model.Add("vendor", vendor);
      return View(model);
    }

    [HttpPost("/orders/delete")]
    public ActionResult DeleteAll()
    {
      Order.ClearAll();
      return View();
    }
  }
}