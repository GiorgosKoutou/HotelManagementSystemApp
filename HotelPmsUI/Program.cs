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
            
            service.AddScoped<DataAccessLibrary.Models.Customer>();
            service.AddScoped<DataAccessLibrary.Models.Room>();
            service.AddScoped<DataAccessLibrary.Models.TypeCatgory>();
            service.AddScoped<DataAccessLibrary.Models.User>();

            /* Register of the Services DI */

            service.AddScoped<ModelServices.CustomerService>();
            service.AddScoped<ModelServices.RoomService>();
            service.AddScoped<ModelServices.CategoryService>();
            service.AddScoped<ModelServices.UserService>();

            /* Register of the Forms DI */

            service.AddScoped<Forms.MainForm>();
            service.AddTransient<Forms.Customer.CustomerCrudForm>();
            service.AddTransient<Forms.Customer.CustomerListForm>();
            service.AddTransient<Forms.Room.RoomListForm>();
            service.AddTransient<Forms.Room.RoomCrudForm>();
            service.AddTransient<Forms.TypeCategories.CatrgoriesCrudForm>();
            service.AddTransient<Forms.TypeCategories.CategoriesListForm>();
            service.AddTransient<Forms.User.UserCrudForm>();
            service.AddTransient<Forms.User.UserListForm>();


            service.AddScoped<DataSeed>();
        }
    }
}