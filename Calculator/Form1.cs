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
        string operation = "";
        double firstnum,secondnum;

        public Cal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void NumericValue(object sender, EventArgs e)//passing values to the display start
        {
            Button b = (Button)sender;

            if (txtdisplay.Text == "0")
                txtdisplay.Text = "";
                
        if(b.Text == ".")
            {
                if (!txtdisplay.Text.Contains("."))
                    txtdisplay.Text = txtdisplay.Text + b.Text;
            }
            else
            {
                txtdisplay.Text = txtdisplay.Text + b.Text;
            }
        }
        //passing values to the display End
        private void btncle_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";
        }

        private void btnce_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "0";

            string f, s;
            s = Convert.ToString(secondnum);
            f = Convert.ToString(firstnum);

            s = "";
            f = "";

        }

        private void Operational_Funtions(object sender, EventArgs e)
        {

        }

        private void Operational_Funtion(object sender, EventArgs e)
        {
           
            Button b = (Button)sender;
            firstnum = Double.Parse(txtdisplay.Text);
            operation = b.Text;
            txtdisplay.Text = "";
        }

        private void btnBs_Click(object sender, EventArgs e)
        {
            if (txtdisplay.Text.Length > 0)
            {
                txtdisplay.Text = txtdisplay.Text.Remove(txtdisplay.Text.Length - 1, 1);
            }
            if (txtdisplay.Text== "")
            {
                txtdisplay.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtdisplay.Text.Contains("-"))
            {
                txtdisplay.Text = txtdisplay.Text.Remove(0, 1);
            }
            else
            {
                txtdisplay.Text = "-" + txtdisplay.Text;
            }
        }

        private void button18btnsum_Click(object sender, EventArgs e)
        {
            secondnum = Double.Parse(txtdisplay.Text);
            switch (operation)
            {
                case "+":
                    txtdisplay.Text = Convert.ToString(firstnum + secondnum);
                    break;
                case "-":
                    txtdisplay.Text = Convert.ToString(firstnum - secondnum);
                    break;
                case "*":
                    txtdisplay.Text = Convert.ToString(firstnum * secondnum);
                    break;
                case "/":
                    txtdisplay.Text = Convert.ToString(firstnum / secondnum);
                    break;
                default:
                    break;
            }
        }

        private void nevFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
                 MessageBox.Show("Press Ok And Close The Program\n DEVsoftlk PVT", "Attention!", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            this.Close();
        }

        private void sAVEYOURNOTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All Rights Reserved By The Author\n DEVsoftlk wiht Lahiru Udawaththa", "About Me", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //passing values to the display end
        private void btnoff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
