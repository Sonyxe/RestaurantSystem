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

        double diabloup = 10, tunaup = 11, fiestaup = 9;
        double colaup = 2, juiceup = 2, coffeeup = 2;
        private double diablotp, tunatp, fiestatp, colatp, juicetp, coffeetp;
        private double Subtotal = 0;
        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           diablotp = diabloup * Convert.ToDouble(DiabloTb.Text);
           tunatp = tunaup * Convert.ToDouble(TunaTb.Text);
           fiestatp = fiestaup * Convert.ToDouble(FiestaTb.Text);

           colatp = colaup * Convert.ToDouble(ColaTb.Text);
           juicetp = juiceup * Convert.ToDouble(JuiceTb.Text);
           coffeetp = coffeeup * Convert.ToDouble(CoffeeTb.Text);

            FoodRepository food = new FoodRepository();   
            food.diablotp= diabloup * Convert.ToDouble(DiabloTb.Text);
            food.tunatp= tunaup * Convert.ToDouble(TunaTb.Text);
            food.fiestatp= fiestaup * Convert.ToDouble(FiestaTb.Text);

            ReceiptTb.Clear();
            ReceiptTb.AppendText("\t\t\t\t\tPIZZA JAZZ" + Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t *****************" + Environment.NewLine);

            if (DiabloCb.Checked == true)
            {
                ReceiptTb.AppendText("\tDiablo:\t" + diablotp + Environment.NewLine);
                Subtotal = Subtotal + diablotp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (TunaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tTuna:\t" + tunatp + Environment.NewLine);
                Subtotal = Subtotal + tunatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (FiestaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tFiesta:\t" + fiestatp + Environment.NewLine);
                Subtotal = Subtotal + fiestatp;
                Subtotallbl.Text = "" + Subtotal;
             }
            if (ColaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCola:\t" + colatp + Environment.NewLine);
                Subtotal = Subtotal + colatp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (JuiceCb.Checked == true)
            {
                ReceiptTb.AppendText("\tJuice:\t" + juicetp + Environment.NewLine);
                Subtotal = Subtotal + juicetp;
                Subtotallbl.Text = "" + Subtotal;
            }
            if (CoffeeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCoffee:\t" + coffeetp + Environment.NewLine);
                Subtotal = Subtotal + coffeetp;
                Subtotallbl.Text = "" + Subtotal;

            }





        }
    }
}
