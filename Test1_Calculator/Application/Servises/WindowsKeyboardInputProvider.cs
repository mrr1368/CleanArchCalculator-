﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1_Calculator.Application.Interfaces;

namespace Test1_Calculator.Application.Servises
{
    /// <summary>
    /// presents a class that handles keyboard input for the calculator application.
    /// this class implements the IInputProvider interface.
    /// </summary>
    internal class WindowsKeyboardInputProvider(IExitHandler exitHandler) : IInputProvider
    {
        /// <summary>
        /// The exit handler used to exit the application.
        /// </summary>
        private readonly IExitHandler _exitHandler = exitHandler;

        /// <summary>
        /// the input data stored in the provider.
        /// </summary>
        private StringBuilder _input = new();

        /// <summary>
        /// this method is called when a key is pressed and handles the input accordingly.
        /// </summary>
        public void AddInput(char input)
        {
            if(_input.Length <= 20)
            switch (_input) 
            {
                // if the input is a digit, add it to the input data.
                case char _ when char.IsDigit(input):
                    _input.Append(input);
                    break;

                // if the input is a decimal point, add it to the input data if it does not already contain a decimal point.
                case '.' when !_input.ToString().Contains('.'):
                    _input.Append(input);
                    break;

                // if the input is an operator '+' or '-' or '*' or '/', add it to the input data.
                case '+' or '-' or '*' or '/':
                    _input.Append(input);
                    break;

                // if the input is a delete key, clear the input data.
                case '\u007F':
                    ClearInput();
                    break;

                // if the input is a backspace key, remove the last character from the input data.
                case '\b':
                    HandleBackspace();
                    break;

                // if the input is an enter key, handle the enter key press.
                case '\r':
                    HandleEnter();
                    break;

                // if the input is an escape key, handle the escape key press.
                case '\u001b':
                    HandleEscape();
                    break;

                // if the input is any other key, do nothing.
                default:
                    break;
            }
        }

        public string GetInput()
        {
            return string.Empty;
        }

        /// <summary>
        /// Clears all input data stored in the provider.
        /// </summary>
        public void ClearInput()
        {
            _input.Clear();
        }

        /// <summary>
        /// removes the last character from the input data stored in the provider.
        /// </summary>
        public void HandleBackspace()
        {
            if (_input.Length > 0)
            {
                _input.Remove(_input.Length - 1, 1);
            }
        }

        /// <summary>
        /// this method is called when the enter key is pressed and processes the current input data.
        /// </summary>
        public void HandleEnter()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///this method is called when the escape key is pressed and exits the application.
        /// </summary>
        public void HandleEscape() 
        {
            _exitHandler.ExitApplication();
        }


    }
}
