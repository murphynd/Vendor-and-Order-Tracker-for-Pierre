using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Pierre.Models;

namespace Pierre.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()

    {
      Order.ClearAll();
    }
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      string title = "New Order";
      string description = "New Order Description";
      Order newOrder = new Order(title, description);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitile_String()
    { //arange
      string title = "New Order";
      string description = "New Order Description";
      Order newOrder = new Order(title, description);
      //Act
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "New Order";
      string description = "New Order Description";
      Order newOrder = new Order(title, description);
      //Act
      string updatedTitle = "Order 3";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(updatedTitle, result);
    }
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };
      // Act
      List<Order> result = Order.GetAll();
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string title = "New Order";
      string description = "New Order Description";
      Order newOrder = new Order(title, description);
      //Act
      int result = newOrder.Id;
      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange

      string title01 = "Order 1";
      string title02 = "Order 2";
      string description01 = "New Order Description";
      string description02 = "New Order Description";
      Order newOrder1 = new Order(title01, description01);
      Order newOrder2 = new Order(title02, description02);
      //Act
      Order result = Order.Find(2);
      //Assert
      Assert.AreEqual(newOrder2, result);
    }

  }
}