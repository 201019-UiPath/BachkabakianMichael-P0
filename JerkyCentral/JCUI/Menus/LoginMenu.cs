using System;
using JCDB;
using JCDB.Models;
using JCLib;
using System.Collections.Generic;
using Serilog;
//using statements for menus.customer menu & menus.manager menu
//serilog stuff



namespace JCUI.Menus
{
    public class LoginMenu : IMenu
    {
        private string userInput;
        private User signedInUser;
        private ManagerServices managerServices;
        private UserServices userServices;
        private ManagerMenu managerMenu;
        private CustomerMenu customerMenu;
        private DBRepo repo;

        public LoginMenu(DBRepo DbRepo)
        {

            this.repo = DbRepo;
            this.managerServices = new ManagerServices(repo);
            this.userServices = new UserServices(repo);
        }

        public void Start() 
        {
            //TODO: customer & manager sign throws an exception if they spell their name wrong, add try cath blocks
            do {
                System.Console.WriteLine("You've arrived at JerkyCentral! Are you a Customer or a Manager?");

                System.Console.WriteLine("Press [1] to Sign In As A Customer");
                System.Console.WriteLine("Press [2] to Sign In As A Manager");
                System.Console.WriteLine("Press [3] to Exit The Application");

                Console.WriteLine();

                userInput = Console.ReadLine().Trim();

                Console.WriteLine();

                switch (userInput)
                {
                    case "1":
                        CustomerSignIn();
                        break;
                    case "2":
                        ManagerSignIn();
                        break;
                    case "3":
                        System.Console.WriteLine("Come back soon!");
                        Environment.Exit(0);
                        break;
                    default:
                        System.Console.WriteLine("Put on your glasses and try again");
                        break;
                }

            } while(!userInput.Equals("3"));
        }

        public void ManagerSignIn()
        {
            string name;
            string password;
            Manager manager;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            while(!InputValidator.ValidateNameInput(name))
            {
                Console.WriteLine("Thats not a valid name, try again");
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            }
            try
            {
                manager = managerServices.GetManagerByName(name);
            } catch (Exception e)
            {
                Console.WriteLine("That name was not found in the manager database");
                Console.WriteLine();
                return;
            }
            Console.WriteLine();

            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();

            Console.WriteLine();

            while (!InputValidator.ValidatePasswordInput(password))
            {
                Console.WriteLine("Thats not a valid password, try again");
                Console.WriteLine("Enter your password: ");
                password = Console.ReadLine();
            }

            while (manager.PassWord != password)
            {
                Console.WriteLine("That password is incorrect");
                //TODO: I could add validation here
                Console.WriteLine("Enter your password: ");
                password = Console.ReadLine();
            }
                            
                managerMenu = new ManagerMenu(repo, signedInUser);
                Log.Logger.Information("Manager is Signed In");
                managerMenu.Start();

            
        }

        public void CustomerSignIn()
        {
            string name;
            string password;
            User user;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            while (!InputValidator.ValidateNameInput(name))
            {
                Console.WriteLine("Thats not a valid name, try again");
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            }

            try
            {
                user = userServices.GetUserByName(name);
            } catch (Exception e)
            {
                Console.WriteLine("That name was not found in the customer database");
                Console.WriteLine();
                return;
            }
            Console.WriteLine();

            Console.WriteLine("Enter your password: ");
            password = Console.ReadLine();

            Console.WriteLine();

            while (!InputValidator.ValidatePasswordInput(password))
            {
                Console.WriteLine("Thats not a valid password, try again");
                Console.WriteLine("Enter your password: ");
                password = Console.ReadLine();
            }

            while (user.PassWord != password)
            {
                Console.WriteLine("That password is incorrect");
                //TODO: I could add validation here
                Console.WriteLine("Enter your password: ");
                password = Console.ReadLine();
            }

            signedInUser = userServices.GetUserByName(name);
            customerMenu = new CustomerMenu(repo, signedInUser);
            Log.Logger.Information("Customer is Signed In");
            customerMenu.Start();

        }
            }
}