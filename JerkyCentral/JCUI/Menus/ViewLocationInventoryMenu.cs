using System;
using System.Collections.Generic;
using JCDB;
using JCDB.Models;
using JCLib;
using System.Text;
using Microsoft.Extensions.Caching.Memory;

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
            Console.WriteLine();

            System.Console.WriteLine("Which location do you want to View: ");

            //TODO: Needs validation
            List<Location> locations = locationServices.GetAllLocations();
            foreach (Location location in locations)
            {
                System.Console.WriteLine($"{location.LocationId} {location.LocationName}");
            }

            Console.WriteLine();

            string locationInput = Console.ReadLine();
            selectedLocationId = Int32.Parse(locationInput);

            Console.WriteLine();

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
                Console.WriteLine($"{item.Product.ProductId} {item.Product.ProductName} {item.QuantityOnHand}");
            }

            Console.WriteLine();

            //From here on is where the order taking process is implemented

            Console.WriteLine("Do you want to place an order from this location? (Y/N)");
            string yesorno = Console.ReadLine();

            Console.WriteLine();

            while (!InputValidator.ValidateYesOrNoInput(yesorno))
            {
                Console.WriteLine("Thats not a valid input. ");
                Console.WriteLine("Do you want to place an order from this location? Please enter either 'Y' or 'N' ");
                yesorno = Console.ReadLine();
            }

            if (yesorno.Equals("Y") || yesorno.Equals("y"))
            {
                Console.WriteLine("Select a product to add to your cart");

                Console.WriteLine();

                foreach (Inventory item in CurrentInventory)
                {
                    Console.WriteLine($"{item.Product.ProductId} {item.Product.ProductName} {item.QuantityOnHand}");
                }

                Console.WriteLine();

                string selectedItem = Console.ReadLine();

                switch (selectedItem)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    default:
                        break;
                }
            }


        }

        public List<Inventory> GetInventoryForLocation(int locationId)
        {
            List<Inventory> items = inventoryServices.GetAllInventoryItemsByLocationId(locationId);
            return items;
        }
    }
}
