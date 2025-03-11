using Test1_Calculator.Application.Servises;

namespace TestProjec_Calculator.Tests.Application
{

    /// <summary>
    /// Unit tests for the DataTableEngine class.
    /// </summary>
    
    public class DataTableEngineTest
    {

        /// <summary>
        /// Tests that the Evaluate method correctly calculates a valid mathematical expression.
        /// </summary>
        
        [Fact] // این تست یک سناریوی مشخص رو بررسی می‌کنه
        public void Calculate_ValidExpression_ReturnCorectResult()
        {

            // Arrange (آماده‌سازی)
            var engine = new DataTableEngine();
            var expression = "2+2*2";

            // Act (اجرا)
            var result = engine.Evaluate(expression);

            // Assert (بررسی)
            Assert.Equal("6", result);
        }
    }
}
