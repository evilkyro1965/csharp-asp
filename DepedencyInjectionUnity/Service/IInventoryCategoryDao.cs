using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using simpleerp.model;

namespace simpleerp.service
{
    public interface IInventoryCategoryDao
    {
        void create(InventoryCategory inventoryCategory);
    }
}
