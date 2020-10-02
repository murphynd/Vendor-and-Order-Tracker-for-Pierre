using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Pierre.Models;

namespace Pierre.Controllers
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
    [HttpPost("/vendors")]
    public ActionResult Create(string Name)
    {
      Vendor newVendor = new Vendor(Name);
      return RedirectToAction("Index");
    }

  }
}
