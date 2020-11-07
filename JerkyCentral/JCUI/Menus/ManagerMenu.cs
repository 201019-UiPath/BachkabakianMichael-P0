using System;
using JCDB;
using JCDB.Models;
using JCLib;

namespace JCUI.Menus
{
    /// <summary>
    /// Menu that is displayed to managers
    /// </summary>
    public class ManagerMenu:IMenu
    {
        private string userInput;
        private DBRepo repo;
        private ManagerServices managerServices;
        private LocationServices locationServices;
        private ReplenishInventoryMenu replenishInventoryMenu;
        
        public ManagerMenu(DBRepo dBRepo)
        {
            this.managerServices = new ManagerServices(repo);
            this.locationServices = new LocationServices(repo);
            this.replenishInventoryMenu = new ReplenishInventoryMenu(repo);
        }
        public void Start()
        {
            do{
                System.Console.WriteLine("Entered Manager Console. What would you like to do?");

                System.Console.WriteLine("Press [1] to Replenish Inventory");
                System.Console.WriteLine("Press [2] to Exit The Application");

                userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "1":
                        replenishInventoryMenu.Start();
                        break;
                    case "2":
                        System.Console.WriteLine("Come back soon!");
                        break;                   
                    default:
                        System.Console.WriteLine("Put on your glasses and try again");
                        break;
                }


            } while(!userInput.Equals("2"));
        }
    }
}