using C968_Terrence_Taylor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Terrence_Taylor
{
    public partial class ModifyParts : Form
    {
        bool isInhouse;

        private bool allowSave()
        {
            int number;
            return (!string.IsNullOrWhiteSpace(mptsName.Text)) && (!int.TryParse(mptsInventory.Text, out number))
                && (!decimal.TryParse(mptsPrice.Text, out decimal result)) && (!int.TryParse(mptsMax.Text, out number))
                && (!int.TryParse(mptsMin.Text, out number)) && (isInhouse && int.TryParse(mptsIDorName.Text, out number)) 
                || (!string.IsNullOrWhiteSpace(mptsIDorName.Text));
        }

        private void checkOnRBSwitch()
        {
            int number;
            if (string.IsNullOrWhiteSpace(mptsIDorName.Text) || 
                (isInhouse && !int.TryParse(mptsIDorName.Text, out number)))
            {
                mptsIDorName.BackColor = Color.Salmon;
                MessageBox.Show("If inhouse, a number is required.\nIf outsourced, a company name is required.");
                Save2.Enabled = false;
            }
            else
            {
                mptsIDorName.BackColor = Color.White;
                Save2.Enabled = allowSave();
            }
        }
        public ModifyParts()
        {
            InitializeComponent();
            mptsID.Text = Inventory.CurrentPt.PartID.ToString();
            mptsName.Text = Inventory.CurrentPt.Name;
            mptsInventory.Text = Inventory.CurrentPt.InStock.ToString();
            mptsPrice.Text = Inventory.CurrentPt.Price.ToString();
            mptsMax.Text = Inventory.CurrentPt.Max.ToString();
            mptsMin.Text = Inventory.CurrentPt.Min.ToString();
            if (Inventory.CurrentPt is Inhouse)
            {
                Inhouse e = (Inhouse)Inventory.CurrentPt;
                mptsIDorName.Text = e.MachineID.ToString();
                isInhouse = true;
                rbInHouse2.Checked = true; 
            }
            else
            {
                Outsourced e = (Outsourced)Inventory.CurrentPt;
                mptsIDorName.Text = e.CompanyName.ToString();
                isInhouse = false;
                rbOutsourced2.Checked = true;
            }
        }

        private void ModifyParts_Load(object sender, EventArgs e)
        {

        }

        #region Button Events
        private void Save2_Click(object sender, EventArgs e)
        {
            try
            {
                if (isInhouse)
                {
                    Part pt = new Inhouse(Convert.ToInt32(mptsID.Text), mptsName.Text, Convert.ToInt32(mptsInventory.Text),
                        Convert.ToDecimal(mptsPrice.Text), Convert.ToInt32(mptsMin.Text), Convert.ToInt32(mptsMax.Text),
                        Convert.ToInt32(mptsIDorName.Text));

                    Inventory.Swap(pt);
                }
                else
                {
                    Part pt = new Outsourced(Convert.ToInt32(mptsID.Text), mptsName.Text, Convert.ToInt32(mptsInventory.Text),
                        Convert.ToDecimal(mptsPrice.Text), Convert.ToInt32(mptsMin.Text), Convert.ToInt32(mptsMax.Text),
                        mptsIDorName.Text);

                    Inventory.Swap(pt);
                }

                this.Close();
                MainScreen MnScrn = new MainScreen();
                MnScrn.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Check fields for correct input");
            }
        }

        private void Cancel2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen MnScrn = new MainScreen();
            MnScrn.Show();
        }

        private void InHouse2_CheckedChanged(object sender, EventArgs e)
        {
            labelIDorName2.Text = "Machine ID";
            isInhouse = true;
            checkOnRBSwitch();
            
        }

        private void Outsourced2_CheckedChanged(object sender, EventArgs e)
        {
            labelIDorName2.Text = "Company Name";
            isInhouse = false;
            checkOnRBSwitch();
        }
        #endregion

        // The following code is used for form validation
        #region Validation
        private void mptsID_TextChanged(object sender, EventArgs e)
        {

        }

        private void mptsName_TextChanged(object sender, EventArgs e)
        {
            try 
            { 

                if (string.IsNullOrWhiteSpace(mptsName.Text))
                {
                    mptsName.BackColor = Color.Salmon;
                    Save2.Enabled = false;
                    MessageBox.Show("Part name must be entered");
                }
                else
                {
                    mptsName.BackColor = Color.White;
                    Save2.Enabled = allowSave();
                }
            }
            catch (FormatException)
            {
                
            }
        }

        private void mptsInventory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mptsInventory.Text))
                {
                    mptsInventory.BackColor = Color.Salmon;
                    Save2.Enabled = false;
                }
                else if (Convert.ToInt32(mptsInventory.Text) < Convert.ToInt32(mptsMin.Text) ||
                    Convert.ToInt32(mptsInventory.Text) > Convert.ToInt32(mptsMax.Text))
                {
                    mptsInventory.BackColor = Color.Salmon;
                    Save2.Enabled = false;
                    MessageBox.Show("Inventory must be a number between minimum and maximum");
                }
                else
                {
                    mptsInventory.BackColor = Color.White;
                    Save2.Enabled = allowSave();
                }
            }
            catch (FormatException)
            {

            }
        }

        private void mptsPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mptsPrice.Text))
                {
                    mptsPrice.BackColor = Color.Salmon;
                    Save2.Enabled = false;
                }
                else if (Convert.ToDecimal(mptsPrice.Text) < 1 ||
                    Convert.ToDecimal(mptsPrice.Text) > 1000)
                {
                    mptsPrice.BackColor = Color.Salmon;
                    Save2.Enabled = false;
                }
                else if (mptsPrice.Text.All(char.IsDigit))
                {
                    mptsPrice.BackColor = Color.White;
                    Save2.Enabled = allowSave();
                }
                else
                {
                    mptsPrice.BackColor = Color.White;
                    Save2.Enabled = allowSave();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Price must be a number.");
                mptsPrice.BackColor = Color.Salmon;
            }
        }

        private void mptsMax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mptsMax.Text))
                {
                    mptsMax.BackColor = Color.Salmon;
                    Save2.Enabled = false;
                }
                else if (Convert.ToInt32(mptsMax.Text) < Convert.ToInt32(mptsMin.Text))
                {
                    mptsMax.BackColor = Color.Salmon;
                    Save2.Enabled = false;
                    MessageBox.Show("Maximum inventory must be a number greater than minimum.");
                }
                else
                {
                    mptsMax.BackColor = Color.White;
                    Save2.Enabled = allowSave();
                }
            }
            catch (FormatException)
            {

            }
        }

        private void mptsMin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mptsMin.Text))
                {
                    mptsMin.BackColor = Color.Salmon;
                    Save2.Enabled = false;
                }
                else if (Convert.ToInt32(mptsMin.Text) < 0 ||
                    Convert.ToInt32(mptsMin.Text) > Convert.ToInt32(mptsMax.Text))
                {
                    mptsMin.BackColor = Color.Salmon;
                    Save2.Enabled = false;
                    MessageBox.Show("Minimum inventory must be a number less than maximum.");
                }
                else
                {
                    mptsMin.BackColor = Color.White;
                    Save2.Enabled = allowSave();
                }
            }
            catch (FormatException)
            {

            }
        }

        private void mptsIDorName_TextChanged(object sender, EventArgs e)
        {
            checkOnRBSwitch();
        }
        #endregion
    }
}
