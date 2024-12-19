using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Pizza_Project
{
    public partial class orderPage : Form
    {
        public orderPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       

        private void label1_Click(object sender, EventArgs e)
        {

        }
        float GetSelectedSizePrice()
        {
            if (RbSmall.Checked)
                return Convert.ToSingle(RbSmall.Tag);
            else if (RbMeduim.Checked)
                return Convert.ToSingle(RbMeduim.Tag);
            else
                return Convert.ToSingle(Rblarge.Tag);

        }

        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;

            if(chbChesse.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbChesse.Tag);
            }

            if (chbOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbOnion.Tag);
            }

            if (chbChesse.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbChesse.Tag);
            }

            if (chbMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbMushrooms.Tag);
            }

            if (chbOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbOlives.Tag);
            }

            if (chbTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbTomatoes.Tag);
            }

            if (chbPepper.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chbPepper.Tag);
            }

            return ToppingsTotalPrice;
        }

        float GetSelectedCrustPrice()
        {
            if (RbThinCrust.Checked)
                return Convert.ToSingle(RbThinCrust.Tag);
            else
                return Convert.ToSingle(RbThinkCrust.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
        }
        void UpdateTotalPrice()
        {
            LbTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }
        void UpdateSize ()
        {
            UpdateTotalPrice();

            if (RbSmall.Checked)
            {
                SummarySize.Text = "Small";
                return;
            }

            if (RbMeduim.Checked)
            {
                SummarySize.Text = "Medium";
                return;
            }

            if (Rblarge.Checked)
            {
                SummarySize.Text = "Large";
                return;
            }
        }
        void UpdateCrust()
        {
            UpdateTotalPrice();

            if(RbThinCrust.Checked)
            {
                SummaryCrust.Text = "Thin Crust";
                return;

            }
            if (RbThinkCrust.Checked)
            {
                SummaryCrust.Text = "Think Crust";
                return;
            }
        }
        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if(RbEatIn.Checked)
            {
                SummaryWhereToEat.Text = "Eat In";
                return;
            }

            if(RbEatOut.Checked)
            {
                SummaryWhereToEat.Text = "Eat Out";
                return;

            }

        }
        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sTopping = "";
            
            if(chbChesse.Checked)
            {
                sTopping = "Extra Cheese";
            }

            if (chbMushrooms.Checked)
            {
                sTopping += ", Mushrooms";
            }

            if (chbOlives.Checked)
            {
                sTopping += ", Olives";
            }


            if (chbTomatoes.Checked)
            {
                sTopping += ", Tomatoes";
            }

            if (chbOnion.Checked)
            {
                sTopping = ", Onion";
            }

            if (chbPepper.Checked)
            {
                sTopping += ", Green peppers";
            }

            if(sTopping.StartsWith(","))
            {
                sTopping = sTopping.Substring(1 , sTopping.Length-1).Trim();
            }

            if(sTopping == "")
            {
                sTopping = "No Topping";
            }

            SummaryTopping.Text = sTopping;
        }

        //Pizza Size
        private void Rblarge_CheckedChanged_1(object sender, EventArgs e)
        {
            UpdateSize();
        }
        private void RbMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }
        private void RbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        //Crust
        private void RbThinkCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }
        private void RbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        //Where To Eat
        private void RbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }
        private void RbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        //Toppings
        private void chbPepper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }
        private void chbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }
        private void chbMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }
        private void chbChesse_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }


        //Buttons
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order","Confirm" ,MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {    
            GbSize.Enabled = false;
            GbSrust.Enabled = false;
            GbTopping.Enabled = false;
            GbWhereToEat.Enabled = false;
            }
            else

                MessageBox.Show("Update your order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void btnRestForm_Click(object sender, EventArgs e)
        {
            SummarySize.Text = " ";
            SummaryCrust.Text = " ";
            SummaryTopping.Text = " ";
            SummaryWhereToEat.Text = " ";
            LbTotalPrice.Text = " ";
            
            //Size Reset
            RbSmall.Checked = false;
            Rblarge.Checked = false;
            RbMeduim.Checked = true;

            //Crust Reset
            RbThinCrust.Checked = true;
            RbThinkCrust.Checked = false;

            //Topping Reset
            chbChesse.Checked = false;
            chbMushrooms.Checked = false;
            chbTomatoes.Checked = false;
            chbOnion.Checked = false;
            chbOlives.Checked = false;
            chbPepper.Checked = false;

            //Where To eat Reset
            RbEatIn.Checked = true;
            RbEatOut.Checked = false; 

            GbSize.Enabled = true;
            GbSrust.Enabled = true;
            GbTopping.Enabled = true;
            GbWhereToEat.Enabled = true;

            //Reset Total Price
            LbTotalPrice.Tag = 0;

        }
        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }


    }
}
