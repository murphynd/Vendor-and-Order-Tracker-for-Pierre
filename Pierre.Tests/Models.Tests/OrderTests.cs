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
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetTitle_ReturnsTitile_String()
    { //arange
      string title = "The Earth is Not a Cold Dead Place";
      Order newOrder = new Order(title);
      //Act
      string result = newOrder.Title;
      //Assert
      Assert.AreEqual(title, result);
    }
    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "The Earth is Not a Cold Dead Place.";
      Order newOrder = new Order(title);

      //Act
      string updatedTitle = "Do the dishes";
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
      // foreach (Order thisOrder in result)
      // {
      //   Console.WriteLine("Output from empty list GetAll test: " + thisItem.Description);  
      // }

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_OrderInstantiateWithAnIdAndGetterReturns_Int()
    {
      string title = "The Earth is Not a Cold Dead Place";
      Order newOrder = new Order(title);

      int result = newOrder.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string title01 = "The Earth is Not a Cold Dead Place";
      string title02 = "Wash the dishes";
      Order newOrder1 = new Order(title01);
      Order newOrder2 = new Order(title02);

      //Act
      Order result = Order.Find(2);

      //Assert
      Assert.AreEqual(newOrder2, result);
    }

  }
}