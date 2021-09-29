using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using JobList.Models;
using System;

namespace JobList.Tests
{
  [TestClass]
  public class OpeningTests : IDisposable
  {

    public void Dispose()
    {
      Opening.ClearAll();
    }

    [TestMethod]
    public void OpeningConstructor_CreatesInstanceOfOpening_Opening()
    {
      Opening newOpening = new Opening("test - title", "test - description", "test - contactInfo");
      Assert.AreEqual(typeof(Opening), newOpening.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      //Arrange
      string title = "Janitor";
      string description = "Mop the floors and clean the toilets";
      string contactInfo = "1-800-555-1234";

      //Act
      Opening newOpening = new Opening(title, description, contactInfo);
      string result1 = newOpening.Title;
      string result2 = newOpening.Description;
      string result3 = newOpening.ContactInfo;

      //Assert
      Assert.AreEqual(title, result1);
      Assert.AreEqual(description, result2);
      Assert.AreEqual(contactInfo, result3);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string title = "Janitor..";
      string description = "Mop the floors and clean the toilets.";
      string contactInfo = "12345";
      Opening newOpening = new Opening(title, description, contactInfo);

      //Act
      string updatedTitle = "CHIEF Janitor.";
      string updatedDescription = "Take out the trash.";
      string updatedContactInfo = "56788";
      newOpening.Title = updatedTitle;
      newOpening.Description = updatedDescription;
      newOpening.ContactInfo = updatedContactInfo;
      string result1 = newOpening.Title;
      string result2 = newOpening.Description;
      string result3 = newOpening.ContactInfo;

      //Assert
      Assert.AreEqual(updatedTitle, result1);
      Assert.AreEqual(updatedDescription, result2);
      Assert.AreEqual(updatedContactInfo, result3);
    }

    // [TestMethod]
    // public void GetAll_ReturnsEmptyList_ItemList()
    // {
    //   // Arrange
    //   List<Item> newList = new List<Item> { };

    //   // Act
    //   List<Item> result = Item.GetAll();

    //   // Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }

    // [TestMethod]
    // public void GetAll_ReturnsItems_ItemList()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Item newItem1 = new Item(description01);
    //   Item newItem2 = new Item(description02);
    //   List<Item> newList = new List<Item> { newItem1, newItem2 };

    //   //Act
    //   List<Item> result = Item.GetAll();

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }
    // [TestMethod]
    // public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Item newItem = new Item(description);

    //   //Act
    //   int result = newItem.Id;

    //   //Assert
    //   Assert.AreEqual(1, result);
    // }
    // [TestMethod]
    // public void Find_ReturnsCorrectItem_Item()
    // {
    //   //Arrange
    //   string description01 = "Walk the dog";
    //   string description02 = "Wash the dishes";
    //   Item newItem1 = new Item(description01);
    //   Item newItem2 = new Item(description02);

    //   //Act
    //   Item result = Item.Find(2);

    //   //Assert
    //   Assert.AreEqual(newItem2, result);
    // }
  }
}