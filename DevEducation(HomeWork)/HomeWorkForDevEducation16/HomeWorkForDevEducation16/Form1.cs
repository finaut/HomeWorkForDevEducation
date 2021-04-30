using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkForDevEducation16
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonOne.Text;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonThree.Text;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonTwo.Text;
        }
        
        private void buttonDot_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonDot.Text;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonZero.Text;
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBoxInput.Text = "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonPlus.Text;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonMinus.Text;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonSix.Text;
        }
        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonFive.Text;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonFour.Text;
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonMultiplication.Text;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonNine.Text;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonEight.Text;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonSeven.Text;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            textBoxInput.Text += buttonDivision.Text; 
        }
        private void buttonClearLast_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length != 0)
                textBoxInput.Text = textBoxInput.Text.Remove(textBoxInput.Text.Length - 1);
            else
                textBoxInput.Text = "";
        }
        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonEqually_Click(object sender, EventArgs e)
        {
            label1.Text = textBoxInput.Text;
        }
    }
}
