using DemoLibrary;
using System.Windows;

namespace WpfAppUI
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

        private void combineName_Click(object sender, RoutedEventArgs e)
        {
            string fullName = PersonProcessor.JoinName(firstNameTxt.Text, lastNameTxt.Text);
            string message = $"Your Full name is {fullName}";
            MessageBox.Show(message);
        }
    }
}
