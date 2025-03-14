using Test1_Calculator.Application.Servises;

namespace Test1_Calculator
{
    /// <summary>
    /// represents the main form of the calculator application.
    /// </summary>
    public partial class Form1 : Form
    {
        private readonly InputEventHandler _inputEventHandler;

        private readonly DisplayManager _displayManager;

        /// <summary>
        /// Initializes a new instance of the Form1 class.
        /// </summary>
        public Form1(InputEventHandler inputEventHandler , DisplayManager displayManager)
        {
            InitializeComponent();
            _inputEventHandler = inputEventHandler;
            _displayManager = displayManager;
            this.KeyPress += _inputEventHandler.HandleKeyPress;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtInput.Text = _displayManager.DisplayInputData();
            txtResult.Text = _displayManager.DisplayResultData();
        }
    }
}
