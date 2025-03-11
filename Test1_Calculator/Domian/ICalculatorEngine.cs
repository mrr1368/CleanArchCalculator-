using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Calculator.Domian
{
    /// <summary>
    /// Defines the contract for an engine that processes and evaluates mathematical expressions.
    /// Implementing classes should provide the logic for parsing and computing the expressions.
    /// </summary>
    
    internal interface ICalculatorEngine
    {

        /// <summary>
        /// Evaluates the given mathematical expression and returns the computed result.
        /// </summary>
        /// <param name="expression">
        /// A string representing a mathematical expression.
        /// The format and supported operations depend on the implementing class.
        /// </param>

        string Evaluate(string expression);
    }
}
