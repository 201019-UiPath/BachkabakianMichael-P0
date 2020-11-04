using System;
using JCDB;
using JCDB.Models;
using JCLib;
using System.Collections.Generic;

namespace JCUI.Menus
{
    public class ReplenishInventoryMenu : IMenu
    {
        private string userInput;
        private Product selectedProduct;
        private int selectedLocationId;
        private Inventory selectedItem;
        private User validUser;
        private JCContext context;
        private ILocationRepo locationRepo;
        private LocationServices locationServices;
        private IInventoryRepo inventoryRepo;
        private InventoryServices inventoryServices;
        private IProductRepo productRepo;
        private ProductServices productServices;

        public ReplenishInventoryMenu(User user, JCContext context, ILocationRepo locationRepo, IInventoryRepo inventoryRepo, IProductRepo productRepo) 
        {
            this.validUser = user;
            this.context = context;
            this.locationRepo = locationRepo;
            this.inventoryRepo = inventoryRepo;
            this.productRepo = productRepo;
            this.locationServices = new LocationServices(locationRepo);
            this.inventoryServices = new InventoryServices(inventoryRepo);
            this.productServices = new ProductServices(productRepo);
        }

        public void Start()
        {
            do {
                System.Console.WriteLine("Which location do you want to manage: ");

                List<Location> locations = locationServices.GetAllLocations();
                foreach(Location location in locations) 
                {
                    System.Console.WriteLine($"{location.LocationId} {location.LocationName}");
                }

                userInput = Console.ReadLine();
                selectedLocationId = Int32.Parse(userInput);

                switch(userInput) {
                    case "1":
                        EditInventory(1);
                        break;
                    case "2":
                        EditInventory(2);
                        break;
                    case "3":
                        EditInventory(3);
                        break;
                    case "4":
                        System.Console.WriteLine("Come back soon!");
                        break;
                    default:
                        System.Console.WriteLine("Put on your glasses and try again");
                        break;
                }
            } while (!userInput.Equals("4"));
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