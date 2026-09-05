using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class frmPizzaOrder : Form

    {
        float totalPrice = 0;
        public frmPizzaOrder()
        {
            InitializeComponent();
        }

        void UpdateSize()
        {
            if (rbSmall.Checked)
            {
                lblSizeChoice.Text = "Small";
                return;
            }
            if (rbMedium.Checked)
            {
                lblSizeChoice.Text = "Medium";
                return;
            }
            if (rbLarge.Checked)
            {
                lblSizeChoice.Text = "Large";
                return;
            }

        }
        void UpdateCrust()
        {
            if (rbThinCrust.Checked)
            {
                lblcrust.Text = "Thin";
                return;
            }
            else if (rbThickCrust.Checked)
            {
                lblcrust.Text = "Thick";
                return;
            }
            else
            {
                lblcrust.Text = "Stuffed";
                return;
            }
           

        }
        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
                return;
            }
            else
            {
                lblWhereToEat.Text = "Take Out";
                return;
            }


        }
        void UpdateToppings()
        {
            string sToppings = "";

            if (chkExtraCheese.Checked)
            {
                sToppings += "Extra Cheese,";

            }
            if (chkMushrooms.Checked)
            {
                sToppings += "Mushrooms,";

            }
             if(chkTomatoes.Checked)
            {
                sToppings += "Tomatoes,";


            }
            if (chkOlives.Checked)
            {
                sToppings += "Olives,";

            }
            if (chkGreenPeppers.Checked)
            {
                sToppings += "Green Peppers,";

            }
            if (chkOnion.Checked)
            {
                sToppings += "Onion,";

            }
            label8.Text = sToppings;
        }

        float GetSelectedSizePrice()
        {
           

            if (rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if (rbMedium.Checked)
            {
                return Convert.ToSingle(rbMedium.Tag);
            }
            else 
            {
                return Convert.ToSingle(rbLarge.Tag);
            }

            
        }
        float GetSelectedCrustPrice()
        {
            if (rbThinCrust.Checked)
            {
                return Convert.ToSingle(rbThinCrust.Tag);
            }
            else if(rbThickCrust.Checked)
            {
                return Convert.ToSingle(rbThickCrust.Tag);
            }
            else 
            {
                return Convert.ToSingle(rbStuffed.Tag);
            }
           
        }
        float GetSelectedToppingPrice()
        {
            float ToppingsPrice = 0;
            if (chkExtraCheese.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkExtraCheese.Tag);
            }
             if (chkOlives.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOlives.Tag);
            }
             if (chkGreenPeppers.Checked)
            {
                ToppingsPrice+= Convert.ToSingle(chkGreenPeppers.Tag);
            }
             if (chkMushrooms.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkMushrooms.Tag);
            }
             if (chkOnion.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if (chkTomatoes.Checked)
            {
                ToppingsPrice+= Convert.ToSingle(chkTomatoes.Tag);
            }
            return ToppingsPrice;


        }
        float GetSelectedWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                return Convert.ToSingle(rbEatIn.Tag);
            }

            else
            {
                return Convert.ToSingle(rbTakeOut.Tag);
            }
        }
        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + GetSelectedCrustPrice() + GetSelectedToppingPrice() + GetSelectedWhereToEat(); ;
        }

        void UpdateTotalPrice()
        {
            totalPrice = CalculateTotalPrice();
            lblTotalPrice.Text = totalPrice.ToString();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
            UpdateTotalPrice();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
            UpdateTotalPrice();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
            UpdateTotalPrice();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
            UpdateTotalPrice();
        }
      
        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
            UpdateTotalPrice();
        }
        private void rbStuffed_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
            UpdateTotalPrice();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();

        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            UpdateTotalPrice();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();
            UpdateTotalPrice();
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Confirmed","Success");

                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbCrustType.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
            }

        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {
            gbSize.Enabled        = true;
            gbToppings.Enabled    = true;
            gbCrustType.Enabled   = true;
            gbWhereToEat.Enabled  = true;
            btnOrderPizza.Enabled = true; 
        }

        private void lblTotalPrice_Click(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void frmPizzaOrder_Load(object sender, EventArgs e)
        {
            Form frmMain = new frmMain();
        }

     
     
       

        private void lblSizeChoice_Click(object sender, EventArgs e)
        {
            UpdateSize();
            UpdateTotalPrice();
        }

        private void gbSize_Enter(object sender, EventArgs e)
        {

        }
    }
}
