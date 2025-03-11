using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Calculator.Application.Interfaces
{
    /// <summary>
    /// defines a contract for classes that handle application exit events.
    /// implementations can provide custom logic to handle application exit events,
    /// such as closing windows, saving data, or performing cleanup operations.
    /// </summary>
    internal interface IExitHandler
    {
        /// <summary>
        /// exits the application.
        /// this method should be called when the application is ready to exit.
        /// </summary>
        void ExitApplication();
    }
}
