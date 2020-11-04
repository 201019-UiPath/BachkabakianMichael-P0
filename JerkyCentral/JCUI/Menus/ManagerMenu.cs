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
        private User validUser; //user after their name and pw have been confirmed
        private IUserRepo userRepo;
        private ILocationRepo locationRepo;
        private UserServices userServices;
        private LocationServices locationServices;
        private ReplenishInventoryMenu replenishInventoryMenu;
        
        public ManagerMenu(User user, JCContext context, IUserRepo userRepo, ILocationRepo locationRepo)
        {
            this.validUser = user;
            this.userRepo = userRepo;
            this.locationRepo = locationRepo;
            this.userServices = new UserServices(userRepo);
            this.locationServices = new LocationServices(locationRepo);
            this.replenishInventoryMenu = new ReplenishInventoryMenu(validUser, context, new DBRepo(context), new DBRepo(context), new DBRepo(context));
        }
        public void Start()
        {
            do{
                System.Console.WriteLine("Entered Manager Console. What would you like to do?");

                System.Console.WriteLine("Press [0] to Replenish Inventory");
                System.Console.WriteLine("Press [1] to Exit The Application");

                userInput = Console.ReadLine();

                switch(userInput)
                {
                    case "0":
                        replenishInventoryMenu.Start();
                        break;
                    case "1":
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