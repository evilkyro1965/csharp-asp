using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Practices.Unity;
using simpleerp.model;
using System.Data.Entity;
using simpleerp.service;

namespace ServiceTest
{
    [TestClass]
    public class UnitTest1
    {
        private IUnityContainer container;
        private IInventoryCategoryDao inventoryCategoryDao;

        [TestInitialize()]
        public void initialize()
        {
            container = new UnityContainer();
            DaoContext dao = new DaoContext();
            container.RegisterInstance<DbContext>(dao);
            inventoryCategoryDao = container.Resolve<InventoryCategoryDao>();
        }

        [TestMethod]
        public void TestMethod1()
        {
            InventoryCategory inventoryCategory = new InventoryCategory();
            inventoryCategory.Name = "testing1";

            inventoryCategoryDao.create(inventoryCategory);
        }
    }
}
