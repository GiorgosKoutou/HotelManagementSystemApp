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
            /* Register of the DbContext DI*/
            service.AddDbContext<DataAccessLibrary.Context.HpmsDbContext>();

            /* Register of the DB Models DI */
            
            // Customer Model
            service.AddScoped<DataAccessLibrary.Models.Customer>();

            // Room Model
            service.AddScoped<DataAccessLibrary.Models.Room>();

            //TypeCategory Model
            service.AddScoped<DataAccessLibrary.Models.TypeCatgory>();

            /* Register of the Services DI */

            // Customer Services
            service.AddScoped<ModelServices.CustomerService>();

            // Room Services
            service.AddScoped<ModelServices.RoomService>();

            // TypeCategory Services
            service.AddScoped<ModelServices.CategoryService>();

            /* Register of the forms with the service collection */

            // Main Form
            service.AddScoped<Forms.MainForm>();

            // Customer Forms
            service.AddTransient<Forms.Customer.CustomerCrudForm>();
            service.AddTransient<Forms.Customer.CustomerListForm>();

            // Room Forms
            service.AddTransient<Forms.Room.RoomListForm>();
            service.AddTransient<Forms.Room.RoomCrudForm>();

            // Type Category Forms
            service.AddTransient<Forms.TypeCategories.CatrgoriesCrudForm>();
            service.AddTransient<Forms.TypeCategories.CategoriesListForm>();


            service.AddScoped<DataSeed>();
        }
    }
}