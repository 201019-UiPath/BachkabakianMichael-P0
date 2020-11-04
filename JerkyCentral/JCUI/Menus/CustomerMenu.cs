using System;
using JCDB;
using JCDB.Models;
using JCLib;
using System.Collections.Generic;

namespace JCUI.Menus
{
    /// <summary>
    /// Menu that is displayed to customers
    /// </summary>
    public class CustomerMenu : IMenu
    {
        private string userInput;
        private User validUser; //user after their name and pw have been confirmed
        private IUserRepo userRepo;
        private ILocationRepo locationRepo;
        private UserServices userServices;
        private LocationServices locationServices;
        private IInventoryRepo inventoryRepo;
        private InventoryServices inventoryServices;


        public CustomerMenu(User user, JCContext context, IUserRepo userRepo, ILocationRepo locationRepo)
        {
            this.validUser = user;
            this.userRepo = userRepo;
            this.locationRepo = locationRepo;
            this.userServices = new UserServices(userRepo);
            this.locationServices = new LocationServices(locationRepo);
        }
        public void Start()
        {
            System.Console.WriteLine("Welcome back to JerkyCentral! What would you like to do?");
            //options
            System.Console.WriteLine("[1] Place An Order");
            System.Console.WriteLine("[2] View Order History");
            System.Console.WriteLine("[3] View Location Inventory");
            //take input
            string choice = System.Console.ReadLine();

            switch (choice)
            {
                case "1":
                    System.Console.WriteLine("You placed an order!");
                        break;
                case "2":
                    System.Console.WriteLine("You looked at your order history!");
                        break;
                case "3":
                    System.Console.WriteLine("For which location? ");
                    
                    do {
                        List<Location> locations = locationServices.GetAllLocations();
                        foreach(Location location in locations) 
                        {
                            System.Console.WriteLine($"{location.LocationId} {location.LocationName}");
                        }

                        userInput = Console.ReadLine();

                        switch(userInput) {
                            case "1":
                                GetInventoryForLocation(1);
                                break;
                            case "2":
                                GetInventoryForLocation(2);
                                break;
                            case "3":
                                GetInventoryForLocation(3);
                                break;
                            case "4":
                                System.Console.WriteLine("Come back soon!");
                                break;
                            default:
                                System.Console.WriteLine("Put on your glasses and try again");
                                break;
                        }
                    } while (!userInput.Equals("4"));

                        break;
                default:
                    System.Console.WriteLine("your an idiot");
                    break;
            }
        }

        public List<Inventory> GetInventoryForLocation(int locationId) 
        {
            List<Inventory> items = inventoryServices.GetAllInventoryItemsByLocationId(locationId);
            return items;
        }
    }
}