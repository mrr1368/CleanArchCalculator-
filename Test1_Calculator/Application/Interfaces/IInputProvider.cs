using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Calculator.Application.Interfaces
{

    /// <summary>
    /// Defines a contract for input providers that retrieve input as a string.
    /// Implementations can fetch input from various sources, such as UI components, 
    /// console input, API calls, or other sources.
    /// </summary>    
    public interface IInputProvider
    {
        /// <summary>
        ///Add a Character to the input data stored in the provider.
        ///this method is useful when the input provider needs to store input data.
        /// </summary>
        ///<param name="input">The character to add to the input data.</param>
        void AddInput(char input);

        /// <summary>
        /// Retrieves the input from a specific source.
        /// </summary>
        /// <returns>A string representing the input.</returns>        
        string GetInput();

        /// <summary>
        ///Cleared all input data stored in the provider.
        ///This method is useful when the input provider needs to be reset.
        ///</summary>
        void ClearInput();

        /// <summary>
        /// Removes the last character from the input data stored in the provider.
        /// This method simulates the backspace key on a keyboard, removing the last character entered.
        /// if the input data is empty, this method does nothing.
        /// </summary>
        void HandleBackspace();

        /// <summary>
        /// Handles the Enter key press,which is used to process the current input data and perform a desired action.
        /// This method is useful when the input provider needs to process the input data.
        /// </summary>
        void HandleEnter();

    }
}
