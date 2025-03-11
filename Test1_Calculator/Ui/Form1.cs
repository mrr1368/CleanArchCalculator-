using Test1_Calculator.Application.Servises;

namespace Test1_Calculator
{
    /// <summary>
    /// represents the main form of the calculator application.
    /// </summary>
    public partial class Form1 : Form
    {
        private readonly InputEventHandler _inputEventHandler;

        /// <summary>
        /// Initializes a new instance of the Form1 class.
        /// </summary>
        public Form1(InputEventHandler inputEventHandler)
        {
            InitializeComponent();
            _inputEventHandler = inputEventHandler;
            this.KeyPress += _inputEventHandler.HandleKeyPress;
        }
    }
}
