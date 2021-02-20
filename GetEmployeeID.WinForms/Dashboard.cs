using DRYDemoStandartLibrary;
using System;
using System.Windows.Forms;

namespace GetEmployeeID.WinForms
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void generateEmployeeIDButton_Click(object sender, EventArgs e)
        {
            EmployeeProcessor processor = new EmployeeProcessor();
            employeeIDTextBox.Text = processor.GenerateEmployeeID(firstNameTextBox.Text, lastNameTextBox.Text);
        }
    }
}
