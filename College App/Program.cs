using Microsoft.Extensions.Configuration;

namespace College_App
{
    internal class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var cs = GetConnectionString();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new WelcomeForm(cs));
        }
        public static string GetConnectionString()
        {
            IConfiguration builder = new ConfigurationBuilder()
                .AddUserSecrets<Program>()
            .Build();
            // Read a value from the configuration
            return builder["Connection String"];
        }
    }
}