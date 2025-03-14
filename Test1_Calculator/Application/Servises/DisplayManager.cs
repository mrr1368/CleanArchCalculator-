using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Test1_Calculator.Application.Interfaces;

namespace Test1_Calculator.Application.Servises
{
    public class DisplayManager(IInputProvider inputProvider)
    {
        private readonly IInputProvider _inputProvider = inputProvider;

        public string DisplayInputData()
        {
            string inputData = _inputProvider.GetInput();
            return inputData;
        }

        public string DisplayResultData()
        {
            string resultData = _inputProvider.HandleEnter();
            return resultData;
        }
    }
}
