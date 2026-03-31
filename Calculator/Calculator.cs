using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorGUI : Form
    {
        private string currentCalculation = "";
        public CalculatorGUI()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;
            txtOutput.Text = currentCalculation;
        }   

        private void buttonEqualsClick(object sender, EventArgs e)
        {
            try
            {
                var result = new DataTable().Compute(currentCalculation, null);
                txtOutput.Text = result.ToString();
                currentCalculation = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in calculation: " + ex.Message);
                currentCalculation = "";
                txtOutput.Text = "";
            }
        }

        private void buttonClearClick(object sender, EventArgs e)
        {
            currentCalculation = "";
            txtOutput.Text = "";
        }

        private void buttonClearEntryClick(object sender, EventArgs e)
        {
            if(currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }
            txtOutput.Text = currentCalculation;
        }

        private void CalculatorGUI_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
