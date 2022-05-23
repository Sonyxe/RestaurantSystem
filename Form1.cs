using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToLongTimeString();
        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void DiabloCb_CheckedChanged(object sender, EventArgs e)
        {
            if (DiabloCb.Checked == true)
            {
                DiabloTb.Enabled = true;
            }
            if (DiabloCb.Checked == false)
            {
                DiabloTb.Enabled = false;
                DiabloTb.Text = "0";
            }

        }

        private void TunaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TunaCb.Checked == true)
            {
                TunaTb.Enabled = true;
            }
            if (TunaCb.Checked == false)
            {
                TunaTb.Enabled = false;
                TunaTb.Text = "0";
            }
        }

        private void FiestaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (FiestaCb.Checked == true)
            {
                FiestaTb.Enabled = true;
            }
            if (FiestaCb.Checked == false)
            {
                FiestaTb.Enabled = false;
                FiestaTb.Text = "0";
            }
        }

        private void ColaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ColaCb.Checked == true)
            {
                ColaTb.Enabled = true;
            }
            if (ColaCb.Checked == false)
            {
                ColaTb.Enabled = false;
                ColaTb.Text = "0";
            }
        }

        private void JuiceCb_CheckedChanged(object sender, EventArgs e)
        {
            if (JuiceCb.Checked == true)
            {
                JuiceTb.Enabled = true;
            }
            if (JuiceCb.Checked == false)
            {
                JuiceTb.Enabled = false;
                JuiceTb.Text = "0";
            }
        }

        private void CoffeeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CoffeeCb.Checked == true)
            {
                CoffeeTb.Enabled = true;
            }
            if (CoffeeCb.Checked == false)
            {
                CoffeeTb.Enabled = false;
                CoffeeTb.Text = "0";
            }
        }

        private void Table1Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Table1Cb.Checked == true)
            {
                Table1Tb.Enabled = true;
            }
            if (Table1Cb.Checked == false)
            {
                Table1Tb.Enabled = false;
                Table1Tb.Text = "0";
            }
        }

        private void Table2Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Table2Cb.Checked == true)
            {
                Table2Tb.Enabled = true;
            }
            if (Table2Cb.Checked == false)
            {
                Table2Tb.Enabled = false;
                Table2Tb.Text = "0";
            }
        }

        private void Table3Cb_CheckedChanged(object sender, EventArgs e)
        {
            if (Table3Cb.Checked == true)
            {
                Table3Tb.Enabled = true;
            }
            if (Table3Cb.Checked == false)
            {
                Table3Tb.Enabled = false;
                Table3Tb.Text = "0";
            }
        }
    }
}
