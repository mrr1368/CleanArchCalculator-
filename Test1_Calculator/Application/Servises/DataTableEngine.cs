using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1_Calculator.Domian;

namespace Test1_Calculator.Application.Servises
{
    /// <summary>
    /// <para>
    /// This class serves as the computational engine in application layer, implementing the main interface (ICalculatorEngine) 
    /// for processing mathematical expressions in the domain layer.
    /// </para>
    /// <para>
    /// The responsibility of this class is to evaluate mathematical expressions and support the following 
    /// fundamental operations:
    /// </para>
    /// <para>
    /// ✅ Sum (+)  
    /// ✅ Subtraction (-)  
    /// ✅ Multiplication (*)  
    /// ✅ Division (/)  
    /// </para>
    /// <para>
    /// This class utilizes <see cref="DataTable"/> to perform calculations.
    /// </para>
    /// </summary>

    public class DataTableEngine : ICalculatorEngine
    {

        /// <summary>
        /// Evaluates a given mathematical expression and returns the computed result.
        /// The input must be a valid mathematical expression in string format, containing only numbers, 
        /// basic arithmetic operators (+, -, *, /), and parentheses.
        /// </summary>
        /// <param name="expression">
        /// A non-empty string representing the mathematical expression to be evaluated.
        /// The expression must not contain any letters, special characters, or unsupported operators.
        /// </param>
        /// <returns>
        /// The computed result as a string if the input is valid.
        /// If the input is null, empty, or contains an invalid expression, an appropriate error message is returned.
        /// </returns>
        /// <exception cref="ArgumentNullException">
        /// Thrown if the input expression is null.
        /// </exception>
        /// <remarks>
        /// This method utilizes <see cref="DataTable.Compute"/> to process the mathematical expression.
        /// It supports basic arithmetic operations and parentheses but does not support advanced functions or custom operators.
        /// </remarks>


        public string Evaluate(string expression)
        {
            if (string.IsNullOrEmpty(expression))
            {
                return "Error : Input must be non-empty string.";
            }
            try
            {
                var result = new DataTable().Compute(expression, null);
                return result?.ToString() ?? "Calculation result in a null value";
            }
            catch (Exception ex)
            {

                return $"error in calculation or expresion {ex.Message}";
            }
        }
    }
}
