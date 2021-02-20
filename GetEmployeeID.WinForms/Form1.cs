using DRYDemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetEmployeeID.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
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
