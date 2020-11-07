using JCUI.Menus;
using JCDB;


namespace JCUI
{
    class Program
    {
        static void Main(string[] args)
        {   
            JCContext context = new JCContext();
            DBRepo dBRepo = new DBRepo(context);

            IMenu LoginMenu = new LoginMenu(dBRepo);
            LoginMenu.Start();       
           
        }
    }
}
