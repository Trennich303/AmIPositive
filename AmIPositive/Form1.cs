using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmIPositive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double Value;
        private void IntergerButton_Click(object sender, EventArgs e)
        {
            Value = Convert.ToInt32(InputTextBox.Text);

            if (Value > 0)
            {
                OutputTextBox1.Text = $" {Value} is a postive number";
            }
            else if (Value < 0)
            {
                OutputTextBox1.Text = $"{Value} is a negative number";
            }
            else
            {
                OutputTextBox1.Text = $" The value is {Value}";
            }

            if ( Value % 7 == 0)
            {
                OutputTextBox2.Text = $"{Value} is divisible by 7";
            }
            else
            {
                OutputTextBox2.Text = $"{Value} is not divisible by 7";
            }

            
           

            

            

            
}
    }
}
