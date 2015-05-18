using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using simpleerp.model;

namespace ModelTest
{
    [TestClass]
    public class TestAddInventoryCategory
    {
        [TestMethod]
        public void TestMethod1()
        {
            DaoContext dao = new DaoContext();

            InventoryCategory inventoryCat = new InventoryCategory();
            inventoryCat.Name = "testing";

            dao.InventoryCategories.Add(inventoryCat);
            dao.SaveChanges();
        }
    }
}
