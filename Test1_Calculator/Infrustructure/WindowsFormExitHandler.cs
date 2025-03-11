using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1_Calculator.Application.Interfaces;

namespace Test1_Calculator.Infrustructure
{
    /// <summary>
    /// this class implements the <see cref="IExitHandler"/> interface to handle application exit events in a Windows Forms application.
    /// the responsibility of this class is to exit the application when the <see cref="ExitApplication"/> method is called.
    /// </summary>
    internal class WindowsFormExitHandler : IExitHandler
    {
        /// <summary>
        /// provides an implementation to exit the application in windows forms platform.
        /// this method is called when the application is ready to exit in windows forms platform.
        ///</summary>   
        public void ExitApplication()
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
