using System.Collections.Generic;
using JCDB.Models;

namespace JCDB
{
    /// <summary>
    /// Data access interface for location inventories
    /// </summary>
    public interface IInventoryRepo
    {
        void AddInventoryAsync(Inventory inventory);
        void UpdateInventory(Inventory inventory);
        void DeleteInventory(Inventory inventory);
        Inventory GetInventoryById(int id);
        Inventory GetInventoryByLocationIdProductId(int locationId, int productId);
        List<Inventory> GetAllInventoryItemsByLocationId(int locationId);
        List<Inventory> GetAllInventoryById(int id);
    }
}