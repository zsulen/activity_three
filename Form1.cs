using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void jpan_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void phil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aust_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void othrs_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            textBox1.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void subB_Click(object sender, EventArgs e)
        {
            string str = " ";

            if (jpan.Checked == true)
            {
                str = str + jpan.Text;
                str += "\n";
            }

            if (phil.Checked == true)
            {
                str = str + phil.Text;
                str += "\n";
            }

            if (thai.Checked == true)
            {
                str = str + thai.Text;
                str += "\n";
            }

            if (aust.Checked == true)
            {
                str = str + aust.Text;
                str += "\n";
            }

            if (othrs.Checked == true)
            {
                str = str + textBox1.Text;
                str += "\n";
            }

            if (str != null)
            {
                MessageBox.Show("You Selected:\n\n" + str + "\nThank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void closeB_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
