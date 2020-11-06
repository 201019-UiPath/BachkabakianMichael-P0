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
        private Manager validManager; //user after their name and pw have been confirmed
        private IManagerRepo managerRepo;
        private ILocationRepo locationRepo;
        private ManagerServices managerServices;
        private LocationServices locationServices;
        private ReplenishInventoryMenu replenishInventoryMenu;
        
        public ManagerMenu(Manager manager, JCContext context, IManagerRepo managerRepo, ILocationRepo locationRepo)
        {
            this.validManager = manager;
            this.managerRepo = managerRepo;
            this.locationRepo = locationRepo;
            this.managerServices = new ManagerServices(managerRepo);
            this.locationServices = new LocationServices(locationRepo);
            this.replenishInventoryMenu = new ReplenishInventoryMenu(validManager, context, new DBRepo(context), new DBRepo(context), new DBRepo(context));
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