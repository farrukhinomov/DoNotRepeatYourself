using DRYDemoStandartLibrary;
using System.Windows;

namespace GetEmployeeID
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void generateEmployeeIDButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeProcessor processor = new EmployeeProcessor();
            employeeIDTextBox.Text = processor.GenerateEmployeeID(firstNameTextBox.Text, lastNameTextBox.Text);
        }
    }
}
