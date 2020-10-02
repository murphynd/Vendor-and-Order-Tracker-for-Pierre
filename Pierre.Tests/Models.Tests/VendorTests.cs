using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Pierre.Models;

namespace Pierre.Models
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
      string name = "Test Vendor";
      string description = "test Description";
      Vendor newVendor = new Vendor(name, description);
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }
    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "test Description";
      Vendor newVendor = new Vendor(name, description);
      //Act
      string result = newVendor.Name;
      //Assert
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor";
      string description = "test Description";
      Vendor newVendor = new Vendor(name, description);
      //Act
      int result = newVendor.Id;
      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name01 = "Bob";
      string description01 = "test Description";
      string name02 = "Susie";
      string description02 = "test Description";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      //Act
      List<Vendor> result = Vendor.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    public void Search_ReturnsSearchedVendorObjects_SearchVendor()
    {
      //Arrange
      string name01 = "Bob";
      string description01 = "test Description";
      string name02 = "Susie";
      string description02 = "test Description";
      Vendor newVendor1 = new Vendor(name01, description01);
      Vendor newVendor2 = new Vendor(name02, description02);
      //Act
      Vendor result = Vendor.SearchVendor("Bob");
      //Assert
      Assert.AreEqual(newVendor1, result);
    }
  }
}