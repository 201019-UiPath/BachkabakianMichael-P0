using System;
using JCDB;
using JCDB.Models;
using JCLib;
using System.Collections.Generic;

namespace JCUI.Menus
{
    /// <summary>
    /// Menu that is displayed to managers
    /// </summary>
    public class ManagerMenu:IMenu
    {
        private string userInput;
        private DBRepo repo;
        private LocationServices locationServices;
        private InventoryServices inventoryServices;
        private ReplenishInventoryMenu replenishInventoryMenu;
        private ViewLocationInventoryMenu viewLocationInventoryMenu;
        
        public ManagerMenu(DBRepo dBRepo)
        {
            this.repo = dBRepo;
            this.locationServices = new LocationServices(repo);
            this.inventoryServices = new InventoryServices(repo);
            this.replenishInventoryMenu = new ReplenishInventoryMenu(repo);
            this.viewLocationInventoryMenu = new ViewLocationInventoryMenu(repo);
        }

        public void Start()
        {
            
                System.Console.WriteLine("Entered Manager Console. What would you like to do?");

                System.Console.WriteLine("Press [1] to Replenish Inventory");
                System.Console.WriteLine("Press [2] to View location Inventory");
                System.Console.WriteLine("Press [3] to Exit The Application");

                userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "1":
                        replenishInventoryMenu.Start();
                        break;
                    case "2":
                        viewLocationInventoryMenu.Start();
                        break;
                    case "3":
                        Console.WriteLine("Come Back Soon!");
                        break;
                    default:
                        System.Console.WriteLine("Put on your glasses and try again");
                        break;
                }   
        }
    }
}