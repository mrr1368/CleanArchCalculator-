using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Test1_Calculator.Application.Interfaces;
using Test1_Calculator.Application.Servises;
using Test1_Calculator.Domian;

namespace Test1_Calculator.Infrustructure
{

    /// <summary>
    /// This class is responsible for managing the dependency injection (DI) configuration for the entire calculator project.
    /// It provides methods to register services required by various layers of the application.
    /// </summary>

    public static class DependencyInjectionConfig
    {

        /// <summary>
        /// Registers the services required for the calculator project in the DI container.
        /// This includes the calculation engine and the main UI form of the application.
        /// </summary>
        /// <param name="service">
        /// The <see cref="IServiceCollection"/> to which services are added.
        /// </param>
        
        public static void AddDependency(this IServiceCollection service)
        {
            // Register the engine used to perform calculations.
            service.AddSingleton<ICalculatorEngine, DataTableEngine>();

            //register the main form of the application.
            service.AddSingleton<Form1>();

            //register the exit handler used to handle application exit events.
            service.AddSingleton<IExitHandler, WindowsFormExitHandler>();

            //register the input provider used to retrieve keyboard input.
            service.AddSingleton<IInputProvider, WindowsKeyboardInputProvider>();

            //register the input handler used to process input events.
            service.AddSingleton<InputEventHandler>();
        }
    }
}
