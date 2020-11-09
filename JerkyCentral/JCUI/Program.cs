using JCUI.Menus;
using JCDB;
using Serilog;

namespace JCUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.File("logs/log.txt",
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                .CreateLogger();


            JCContext context = new JCContext();
            DBRepo dBRepo = new DBRepo(context);

            IMenu LoginMenu = new LoginMenu(dBRepo);
            LoginMenu.Start();       
           
        }
    }
}
