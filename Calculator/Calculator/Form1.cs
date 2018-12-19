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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numInput1_ValueChanged(object sender, EventArgs e)
        {
            calc(int.Parse(numInput1.Value.ToString()), int.Parse(numInput2.Value.ToString()));





        }

        private void numInput2_ValueChanged(object sender, EventArgs e)
        {
            calc(int.Parse(numInput1.Value.ToString()), int.Parse(numInput2.Value.ToString()));
        }

        private void rbPlus_CheckedChanged(object sender, EventArgs e)
        {
            calc(int.Parse(numInput1.Value.ToString()), int.Parse(numInput2.Value.ToString()));
        }

        private void rbMin_CheckedChanged(object sender, EventArgs e)
        {
            calc(int.Parse(numInput1.Value.ToString()), int.Parse(numInput2.Value.ToString()));
        }

        private void rbX_CheckedChanged(object sender, EventArgs e)
        {
            calc(int.Parse(numInput1.Value.ToString()), int.Parse(numInput2.Value.ToString()));
        }

        private void rbDiv_CheckedChanged(object sender, EventArgs e)
        {
            calc(int.Parse(numInput1.Value.ToString()), int.Parse(numInput2.Value.ToString()));
        }

        public void calc(int input1, int input2)
        {
            if(rbPlus.Checked == true)
            {
                txtOutput.Text = (input1 + input2).ToString();
            }else if(rbMin.Checked == true)
            {
                txtOutput.Text = (input1 - input2).ToString();
            }
            else if(rbX.Checked == true)
            {
                txtOutput.Text = (input1 * input2).ToString();
            }
            else if(rbDiv.Checked == true)
            {
                txtOutput.Text = (input1 / input2).ToString();
            }
        }

       
    }
}
