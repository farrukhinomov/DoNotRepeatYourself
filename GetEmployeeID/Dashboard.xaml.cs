using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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
            generateEmployeeID();
        }

        private void generateEmployeeID()
        {
            string employeeId = $@"{firstNameTextBox.Text.Substring(0, 4)}{lastNameTextBox.Text.Substring(0, 4)}{DateTime.Now.Millisecond}";
            employeeIDTextBox.Text = employeeId;
        }
    }
}
