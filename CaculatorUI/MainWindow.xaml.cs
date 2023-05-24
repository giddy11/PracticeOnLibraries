using MathLibrary;
using System.Windows;

namespace CaculatorUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The int.parse converts the string value to an interger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Solve_Click(object sender, RoutedEventArgs e)
        {
            int operand1 = int.Parse(txtBox1.Text);
            int operand2 = int.Parse(txtBox3.Text);
            char operation = txtBox2.Text.ToCharArray()[0];

            int result = 0;

            switch (operation)
            {
                case '+':
                    result = ArithmeticOperations.Add(operand1, operand2);
                    break;

                case '-':
                    result = ArithmeticOperations.Substract(operand1, operand2);
                    break;

                case '*':
                    result = ArithmeticOperations.Multiply(operand1, operand2);
                    break;

                case '/':
                    result = ArithmeticOperations.Divide(operand1, operand2);
                    break;

                default:
                    MessageBox.Show("Invalid operation");
                    break;
            }

            txtBox4.Text = result.ToString();
        }
    }
}
