using JCDB;
using JCDB.Models;
using System.Collections.Generic;

namespace JCLib
{
    public class InventoryServices
    {
        private IInventoryRepo repo;

        public InventoryServices(IInventoryRepo repo)
        {
            this.repo = repo;
        }
        public void AddInventory(Inventory inventory)
        {
            repo.AddInventory(inventory);
        }
        public void UpdateInventory(Inventory inventory)
        {
            repo.UpdateInventory(inventory);
        }
        public void DeleteInventory(Inventory inventory)
        {
            repo.DeleteInventory(inventory);
        }
        public Inventory GetInventoryByLocationIdProductId(int locationId, int productId) 
        {
             Inventory item = repo.GetInventoryByLocationIdProductId(locationId, productId);
             return item;
        }
        public List<Inventory> GetAllInventoryItemsByLocationId(int locationId) 
        {
             List<Inventory> items = repo.GetAllInventoryItemsByLocationId(locationId);
             return items;
        }
    }
}