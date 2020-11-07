using System;
using JCDB;
using JCDB.Models;
using JCLib;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace JCUI.Menus
{
    public class ReplenishInventoryMenu : IMenu
    {
        private string userInput;
        private int selectedLocationId;
        private Inventory selectedItem;
        private LocationServices locationServices;
        private InventoryServices inventoryServices;
        private ProductServices productServices;
        
        public ReplenishInventoryMenu(DBRepo repo) 
        {
            this.locationServices = new LocationServices(repo);
            this.inventoryServices = new InventoryServices(repo);
            this.productServices = new ProductServices(repo);
        }

        public void Start()
        {
            //1. get user input
            //2. validate it as a number
            //3. match it with existing location id 
            System.Console.WriteLine("Which location do you want to manage: ");

            List<Location> locations = locationServices.GetAllLocations();
            foreach(Location location in locations) 
            {
                System.Console.WriteLine($"{location.LocationId} {location.LocationName}");
            }
            //TODO: validate this input as a number
            userInput = Console.ReadLine();

            selectedLocationId = Int32.Parse(userInput);

            //TODO: think about giving the user a way out
            foreach(Location location in locations)
            {
                if(selectedLocationId == location.LocationId)
                {
                    EditInventory(selectedLocationId);
                }
            }
        }

        public List<Inventory> GetInventoryForLocation(int locationId) 
        {
            List<Inventory> items = inventoryServices.GetAllInventoryItemsByLocationId(locationId);
            return items;
        }

        public void EditInventory(int locationId)
        {
            string input;

            do {
                System.Console.WriteLine("Which item do you want to replenish? ");

                List<Inventory> items = GetInventoryForLocation(locationId);
                foreach(Inventory item in items) 
                {
                    Product product = productServices.GetProductById(item.ProductId);
                    Console.WriteLine($" {product.ProductId} {product.ProductName} {item.QuantityOnHand} ");
                }
                input = Console.ReadLine();
                switch(input) 
                {
                    case "1":
                        Replenish(1);
                        break;

                    case "2":
                        Replenish(2);
                        break;

                    case "3":
                        Replenish(3);
                        break;

                    case "4":
                        Replenish(4);            
                        break;

                    case "5":
                        Replenish(5);                     
                        break;

                    case "6":
                        break;

                    default:
                        System.Console.WriteLine("Put on your glasses and try again");
                        break;
                }
            } while(!input.Equals("6"));

        }

         public void Replenish(int ProductId) {
            selectedItem = inventoryServices.GetInventoryByLocationIdProductId(selectedLocationId, ProductId);
            Console.WriteLine("Replenish stock by how many items?");
            int plusStock = Int32.Parse(Console.ReadLine());

            selectedItem.QuantityOnHand = plusStock + selectedItem.QuantityOnHand;
            inventoryServices.UpdateInventory(selectedItem);

            Console.WriteLine("Stock Replenished!");
        }
    }
}