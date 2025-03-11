using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1_Calculator.Application.Interfaces;

namespace Test1_Calculator.Application.Servises
{
    /// <summary>
    /// Represents a class that handles input events.
    /// </summary>
    public class InputEventHandler(IInputProvider inputProvider)
    {
        /// <summary>
        /// The input provider used to retrieve input data.
        /// </summary>
        private readonly IInputProvider _inputProvider = inputProvider;

        /// <summary>
        /// this method is called when a key is pressed.
        /// </summary>
        public void HandleKeyPress(object?  sender, KeyPressEventArgs e)
        {
            _inputProvider.AddInput(e.KeyChar);
        }

    }
}
