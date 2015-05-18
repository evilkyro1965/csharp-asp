using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simpleerp.model;
using Microsoft.Practices.Unity;

namespace simpleerp.service
{
    public class InventoryCategoryDao:IInventoryCategoryDao
    {
        private DaoContext daoContext;

        [Dependency]
        public DaoContext DaoContext
        {
            get { return daoContext; }
            set { daoContext = value; }
        }

        public void create(InventoryCategory inventoryCategory)
        {
            daoContext.InventoryCategories.Add(inventoryCategory);
            daoContext.SaveChanges();
        }

    }
}
