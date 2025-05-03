using Microsoft.Extensions.DependencyInjection;

namespace HotelPmsUI
{
    internal static class Program
    {

        public static IServiceProvider? ServiceProvider { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Dependency Injection
            var serviceCollection = new ServiceCollection();
            ConfigurationServices(serviceCollection);
            ServiceProvider = serviceCollection.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(ServiceProvider.GetRequiredService<Forms.MainForm>());
        }

        private static void ConfigurationServices(ServiceCollection service)
        {
            /* Register of the DbContext with the service collection */
            service.AddDbContext<DataAccessLibrary.Context.HpmsDbContext>();

            /* Register of the CrudServices with the service collection */

            // Customer Services
            service.AddScoped<ModelServices.CustomerService>();

            /* Register of the forms with the service collection */

            // Main Form
            service.AddTransient<Forms.MainForm>();

            // Customer Forms
            service.AddTransient<Forms.Customer.CustomerCrudForm>();
            service.AddTransient<Forms.Customer.CustomerListForm>();


            service.AddScoped<DataSeed>();
        }
    }
}