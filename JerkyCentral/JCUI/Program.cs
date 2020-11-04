using JCUI.Menus;
using JCDB;


namespace JCUI
{
    class Program
    {
        static void Main(string[] args)
        {   
            JCContext context = new JCContext();

            IMenu LoginMenu = new LoginMenu(context, new DBRepo(context), new DBRepo(context), new DBRepo(context));
            LoginMenu.Start();       
           
        }
    }
}
