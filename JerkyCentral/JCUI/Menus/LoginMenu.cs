using System;
using JCDB;
using JCDB.Models;
using JCLib;
using System.Collections.Generic;
//using statements for menus.customer menu & menus.manager menu
//serilog stuff



namespace JCUI.Menus
{
    public class LoginMenu : IMenu
    {
        private string userInput;
        private User validUser; //user after their name and pw have been confirmed
        private Manager validManager;
        private JCContext context;
        private IUserRepo userRepo;
        private ILocationRepo locationRepo;
        private ICartRepo cartRepo;
        private UserServices userServices;
        private LocationServices locationServices;
        private CartServices cartServices;
        private ManagerMenu managerMenu;
        private CustomerMenu customerMenu;

        public LoginMenu(JCContext context, IUserRepo userRepo, ILocationRepo locationRepo, ICartRepo cartRepo)
        {
            this.context = context;
            this.userRepo = userRepo;
            this.locationRepo = locationRepo;
            this.cartRepo = cartRepo;
            this.userServices = new UserServices(userRepo);
            this.locationServices = new LocationServices(locationRepo);
            this.cartServices = new CartServices(cartRepo);
        }

        public void Start() 
        {
            do {
                System.Console.WriteLine("You've arrived at JerkyCentral! Are you a Customer or a Manager?");

                System.Console.WriteLine("Press [1] to Sign In As A Customer");
                System.Console.WriteLine("Press [2] to Sign In As A Manager");
                System.Console.WriteLine("Press [3] to Exit The Application");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        // User user = CustomerSignIn();
                        break;
                    case "2":
                        // Manager manager = ManagerSignIn();
                    case "3":
                        System.Console.WriteLine("Come back soon!");
                        break;
                    default:
                        System.Console.WriteLine("Put on your glasses and try again");
                        break;
                }

            } while(!userInput.Equals("3"));
        }


        // public User CustomerSignIn()
        // {
        //     string name;
        //     string password;
        //     User user = new User();

        //     Console.WriteLine("Enter your name: ");
        //     name = Console.ReadLine();

        //     Console.WriteLine("Enter your password: ");
        //     password = Console.ReadLine();

        //     try {
        //         user = userServices.GetUserByName(name);
        //         if(user.PassWord != password)
        //         {
        //             throw new System.ArgumentException();
        //         } else 
        //         {
        //             validUser = user;

        //             if(user.ManagerStatus == true)
        //             {
        //                 managerMenu = new ManagerMenu(validUser, context, new DBRepo(context), new DBRepo(context));
        //                 managerMenu.Start();
        //             } 
        //             if(user.ManagerStatus == false) 
        //             {
        //                 customerMenu = new CustomerMenu(validUser, context, new DBRepo(context), new DBRepo(context));
                        

        //                 try{
        //                     cartServices.DeleteCart(cartServices.GetCartByUserId(validUser.UserID));
        //                 } catch(InvalidOperationException) {}
        //                 finally
        //                 {
        //                     Cart sessionCart = new Cart();
        //                     sessionCart.UserId = validUser.UserID;
        //                     cartServices.AddCart(sessionCart);

        //                     customerMenu.Start();
        //                 }
        //             }

        //         }//more logging stuff and a return value around here
        //     } catch(ArgumentException){}return user;

            
        

    }
}