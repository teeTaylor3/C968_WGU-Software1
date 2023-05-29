using C968_Terrence_Taylor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Terrence_Taylor
{
    public partial class AddParts : Form 
    {
        bool isInhouse;

        private bool allowSave()
        {
            int number;

            return  (!string.IsNullOrWhiteSpace(aptsName.Text)) && 
                    (!int.TryParse(aptsInventory.Text, out number)) && (!decimal.TryParse(aptsPrice.Text, out decimal result)) && 
                    (!int.TryParse(aptsMax.Text, out number)) && (!int.TryParse(aptsMin.Text, out number)) && 
                    (isInhouse && !int.TryParse(aptsIDorName.Text, out number)) || (!string.IsNullOrWhiteSpace(aptsIDorName.Text));
        }
    
        private void checkOnRBSwitch()
        {
            int number;

            if (string.IsNullOrWhiteSpace(aptsIDorName.Text) || 
                (isInhouse && !int.TryParse(aptsIDorName.Text, out number)))
            {
                aptsIDorName.BackColor = Color.Salmon;
                MessageBox.Show("If part is inhouse a number is required.\n" +
                    "If part is outsourced a company name is required.");
                Save1.Enabled = false;
            }
            else
            {
                aptsIDorName.BackColor = Color.White;
                Save1.Enabled = allowSave();
            }
        }

        public AddParts()
        {
            InitializeComponent();
        }

        private void Part_Load(object sender, EventArgs e)
        {

        }

        #region Button Events
        private void Save1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(aptsInventory.Text) < Convert.ToInt32(aptsMin.Text) ||
                   Convert.ToInt32(aptsInventory.Text) > Convert.ToInt32(aptsMax.Text))
                {
                    Save1.Enabled = false;
                    aptsInventory.BackColor = Color.Salmon;
                    MessageBox.Show("Inventory must be a number between minimum and maximum.");
                    this.Show();
                }
                else if (isInhouse)
                {
                    Part prt = new Inhouse((Inventory.AllParts.Count + 1), aptsName.Text, Convert.ToInt32(aptsInventory.Text),
                        Convert.ToDecimal(aptsPrice.Text), Convert.ToInt32(aptsMin.Text), Convert.ToInt32(aptsMax.Text),
                        Convert.ToInt32(aptsIDorName.Text));

                    Inventory.AddPart(prt);
                    this.Close();
                    MainScreen MnScrn = new MainScreen();
                    MnScrn.Show();
                }
                else if (!isInhouse)
                {
                    Part prt = new Outsourced((Inventory.AllParts.Count + 1), aptsName.Text, Convert.ToInt32(aptsInventory.Text),
                        Convert.ToDecimal(aptsPrice.Text), Convert.ToInt32(aptsMin.Text), Convert.ToInt32(aptsMax.Text),
                        aptsIDorName.Text);

                    Inventory.AddPart(prt);
                    this.Close();
                    MainScreen MnScrn = new MainScreen();
                    MnScrn.Show();
                }
                else
                {
                    Save1.Enabled = false;
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Check fields for correct input");
            }
        }

        private void Cancel1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen MnScrn = new MainScreen();
            MnScrn.Show();
        }

        private void InHouse1_CheckedChanged(object sender, EventArgs e)
        {
            labelIDorName1.Text = "Machine ID";
            isInhouse = true;
        }
    
        private void Ousourced1_CheckedChanged(object sender, EventArgs e)
        {
            labelIDorName1.Text = "Company Name";
            isInhouse = false;
        }
        #endregion

        // The following code is used for form validation
        #region Validation
        private void aptsID_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void aptsName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(aptsName.Text))
                {
                    aptsName.BackColor = Color.Salmon;
                    Save1.Enabled = false;
                    MessageBox.Show("Part name must be entered");
                }
                else
                {
                    aptsName.BackColor = Color.White;
                    Save1.Enabled = allowSave();
                }
            }
            catch (FormatException)
            {
                
            }
        }

        private void aptsInventory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(aptsInventory.Text))
                {
                    aptsInventory.BackColor = Color.Salmon;
                    Save1.Enabled = false;
                }
                else if (Convert.ToInt32(aptsInventory.Text) < Convert.ToInt32(aptsMin.Text) ||
                    Convert.ToInt32(aptsInventory.Text) > Convert.ToInt32(aptsMax.Text))
                {
                    Save1.Enabled = false;
                    aptsInventory.BackColor = Color.Salmon;
                    MessageBox.Show("Inventory must be a number between minimum and maximum.");
                }
                else
                {
                    aptsInventory.BackColor = Color.White;
                    Save1.Enabled = allowSave();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Inventory must be a number between minimum and maximum.");
                aptsInventory.BackColor = Color.Salmon;
            }
        }

        private void aptsPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(aptsPrice.Text))
                {
                    aptsPrice.BackColor = Color.Salmon;
                    Save1.Enabled = false;
                }
                else if (Convert.ToDecimal(aptsPrice.Text) < 1 ||
                    Convert.ToDecimal(aptsPrice.Text) > 1000)
                {
                    aptsPrice.BackColor = Color.Salmon;
                    Save1.Enabled = false;
                }
                else if ((aptsPrice.Text.All(char.IsDigit)))
                {
                    aptsPrice.BackColor = Color.White;
                    Save1.Enabled = allowSave();
                }
                else
                {
                    aptsPrice.BackColor = Color.White;
                    Save1.Enabled = allowSave();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Price must be a number.");
                aptsPrice.BackColor = Color.Salmon;
            }
        }

        private void aptsMax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(aptsMax.Text))
                {
                    aptsMax.BackColor = Color.Salmon;
                    Save1.Enabled = false;
                }
                else if (Convert.ToInt32(aptsMax.Text) <= Convert.ToInt32(aptsMin.Text))
                {
                    aptsMax.BackColor = Color.Salmon;
                    Save1.Enabled = false;
                    MessageBox.Show("Maximum inventory must be a number greater than minimum.");
                }
                else
                {
                    aptsMax.BackColor = Color.White;
                    Save1.Enabled = allowSave();
                }
            }
            catch (FormatException)
            {
               
            }
        }

        private void aptsMin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(aptsMin.Text))
                {
                    aptsMin.BackColor = Color.Salmon;
                    Save1.Enabled = false;
                }
                else if (Convert.ToInt32(aptsMin.Text) < 0 ||
                    Convert.ToInt32(aptsMin.Text) >= Convert.ToInt32(aptsMax.Text))
                {
                    aptsMin.BackColor = Color.Salmon;
                    Save1.Enabled = false;
                    MessageBox.Show("Minimum inventory must be a number less than maximum.");
                }
                else
                {
                    aptsMin.BackColor = Color.White;
                    Save1.Enabled = allowSave();
                }
            }
            catch (FormatException)
            {

            }
        }

        private void aptsIDorName_TextChanged(object sender, EventArgs e)
        {
            checkOnRBSwitch();
        }
        #endregion
    }
}
