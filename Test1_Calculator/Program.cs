using Microsoft.Extensions.DependencyInjection;
using Test1_Calculator.Infrustructure;

namespace Test1_Calculator
{
    /// <summary>
    ///  The main entry point for the application.
    ///  this class initializes the application and , sets up services and runs the main form
    /// </summary>
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  this method is responsible for initializing the application configuration , setting up dependency injection services and running the main ui form
        /// </summary>
        [STAThread]
        static void Main()
        {
          
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // The ServiceCollection is used to configure and store dependencies.
            var services = new ServiceCollection();

            // ثبت سرویس‌های مورد نیاز برنامه
            services.AddDependency();


            // ایجاد ServiceProvider برای دسترسی به سرویس‌های ثبت شده
            using (var serviceProvider = services.BuildServiceProvider())
            {

                // ایجاد یک نمونه از فرم اصلی برنامه
                var form = serviceProvider.GetRequiredService<Form1>();

                // اجرای برنامه
                System.Windows.Forms.Application.Run(form);

            }
        }
    }
}