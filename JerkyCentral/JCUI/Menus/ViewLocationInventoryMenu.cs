using System;
using System.Collections.Generic;
using JCDB;
using JCDB.Models;
using JCLib;
using System.Text;

namespace JCUI.Menus
{
    class ViewLocationInventoryMenu : IMenu
    {
        private int selectedLocationId;
        private LocationServices locationServices;
        private InventoryServices inventoryServices;
        private ProductServices productServices;

        public ViewLocationInventoryMenu(DBRepo repo)
        {
            this.locationServices = new LocationServices(repo);
            this.inventoryServices = new InventoryServices(repo);
            this.productServices = new ProductServices(repo);
        }

        public void Start()
        {
            System.Console.WriteLine("Which location do you want to View: ");

            //TODO: Needs validation
            List<Location> locations = locationServices.GetAllLocations();
            foreach (Location location in locations)
            {
                System.Console.WriteLine($"{location.LocationId} {location.LocationName}");
            }

            string locationInput = Console.ReadLine();
            selectedLocationId = Int32.Parse(locationInput);

            List<Inventory> CurrentInventory = new List<Inventory>();

            foreach (Location location in locations)
            {
                if (selectedLocationId == location.LocationId)
                {
                    CurrentInventory = GetInventoryForLocation(selectedLocationId);
                }
            }

            foreach (Inventory item in CurrentInventory)
            {
                Console.WriteLine($"{item.Product.ProductName} {item.QuantityOnHand}");
            }
        }

        public List<Inventory> GetInventoryForLocation(int locationId)
        {
            List<Inventory> items = inventoryServices.GetAllInventoryItemsByLocationId(locationId);
            return items;
        }
    }
}
