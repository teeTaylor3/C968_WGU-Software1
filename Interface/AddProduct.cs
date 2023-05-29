using C968_Terrence_Taylor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Terrence_Taylor
{
    public partial class AddProduct : Form
    {
        public BindingList<Part> partsToAdd = new BindingList<Part>();
        private int idxSelectedPart;

        private bool AllowSave()
        {
            int number;
            return (!string.IsNullOrWhiteSpace(apdName.Text)) && (int.TryParse(apdInventory.Text, out number))
            && (decimal.TryParse(apdPrice.Text, out decimal result)) && (int.TryParse(apdMax.Text, out number)) && (int.TryParse(apdMin.Text, out number));
        }
        
        public AddProduct()
        {
            InitializeComponent();
            DGVAllParts1.DataSource = Inventory.AllParts;
            DGVAllParts1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVAllParts1.ReadOnly = true;
            DGVAllParts1.RowHeadersVisible = false;

            DGVAssociatedParts1.DataSource = partsToAdd;
            DGVAssociatedParts1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVAssociatedParts1.ReadOnly = true;
            DGVAssociatedParts1.RowHeadersVisible = false;

        }
        private void AddProduct_Load(object sender, EventArgs e)
        {
            DGVAllParts1.ClearSelection();
            DGVAssociatedParts1.ClearSelection();
        }

        private void SetIdxSelectedPart()
        {
            if (DGVAllParts1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.DGVAllParts1.SelectedRows[0];
                Inventory.idxSelectedPart = row.Index;
            }
            else
            {
                Inventory.idxSelectedPart = -1;
            }
        }

        private void SetIdxAssociatedPart()
        {
            if (DGVAssociatedParts1.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.DGVAssociatedParts1.SelectedRows[0];
                Inventory.idxSelectedPart = row.Index;
            }
            else
            {
                Inventory.idxSelectedPart = -1;
            }
        }

        private void DGVAllParts1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetIdxSelectedPart();
            DGVAllParts1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            DGVAllParts1.DefaultCellStyle.SelectionForeColor = Color.Black;
            Save3.Enabled = AllowSave();
        }

            private void DGVAssociatedParts1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetIdxAssociatedPart();
            DGVAssociatedParts1.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            DGVAssociatedParts1.DefaultCellStyle.SelectionForeColor = Color.Black;
            Save3.Enabled = AllowSave();
        }

        #region Button Events
        private void Add3_Click(object sender, EventArgs e)
        {
            SetIdxSelectedPart();
            if (Inventory.idxSelectedPart >= 0)
            {
                Inventory.CurrentPt = Inventory.AllParts[Inventory.idxSelectedPart];
                partsToAdd.Add(Inventory.CurrentPt);
            }
            else
            {
                MessageBox.Show("Please select part to add.");
            }
        }
        
        private void Delete3_Click(object sender, EventArgs e)
        {
            SetIdxAssociatedPart();
            if (Inventory.idxSelectedPart >= 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    Inventory.CurrentPd.AssociatedParts.RemoveAt(Inventory.idxSelectedPart);
                }
                else
                {
                    MessageBox.Show("Please select part to delete.");
                }
            }
            else
            {
                MessageBox.Show("Please select part to delete.");
            }
        }

        private void Save3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(apdInventory.Text) < Convert.ToInt32(apdMin.Text) ||
                   Convert.ToInt32(apdInventory.Text) > Convert.ToInt32(apdMax.Text))
                {
                    Save3.Enabled = false;
                    apdInventory.BackColor = Color.Salmon;
                    MessageBox.Show("Inventory must be a number between minimum and maximum.");
                    this.Show();
                }
                else if (!string.IsNullOrEmpty(apdID.Text) || !string.IsNullOrEmpty(apdName.Text) || !string.IsNullOrEmpty(apdInventory.Text) ||
                    !string.IsNullOrEmpty(apdPrice.Text) || !string.IsNullOrEmpty(apdMin.Text) || !string.IsNullOrEmpty(apdMax.Text))
                {
                    Product prd = new Product((Inventory.Products.Count+1), apdName.Text, Convert.ToInt32(apdInventory.Text),
                        Convert.ToDecimal(apdPrice.Text), Convert.ToInt32(apdMin.Text), Convert.ToInt32(apdMax.Text));

                    Inventory.AddProduct(prd);

                    foreach (Part part in partsToAdd)
                    {
                        prd.AddAssociatedPart(part);
                    }
                    Save3.Enabled = true;

                    this.Close();
                    MainScreen MnScrn = new MainScreen();
                    MnScrn.Show();
                }
                else
                {
                    Save3.Enabled = false;
                }
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Check fields for correct input");
            }
        }

        private void Cancel3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen MnScrn = new MainScreen();
            MnScrn.Show();
        }

        private void Search3_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (SearchAllParts.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(SearchAllParts.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                    DGVAllParts1.DataSource = TempList;

            }
            if (!found)
            {
                MessageBox.Show("Part not found. Please search by name.");
                DGVAllParts1.DataSource = Inventory.AllParts;
            }
        }
        #endregion

        // The following code is used for form validation
        #region Validation
        private void apdID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void apdName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(apdName.Text))
                {
                    apdName.BackColor = Color.Salmon;
                    Save3.Enabled = false;
                    MessageBox.Show("Product name must be entered");
                }
                else
                {
                    apdName.BackColor = Color.White;
                    Save3.Enabled = AllowSave();
                }
            }
            catch (FormatException)
            {
                
            }
        }

        private void apdInventory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(apdInventory.Text))
                {
                    apdInventory.BackColor = Color.Salmon;
                    Save3.Enabled = false;
                }
                else if (Convert.ToInt32(apdInventory.Text) < Convert.ToInt32(apdMin.Text) ||
                    Convert.ToInt32(apdInventory.Text) > Convert.ToInt32(apdMax.Text))
                {
                    apdInventory.BackColor = Color.Salmon;
                    Save3.Enabled = false;
                    MessageBox.Show("Inventory must be a number between minimum and maximum");
                }
                else
                {
                    apdInventory.BackColor = Color.White;
                    Save3.Enabled = AllowSave();
                }
            }
            catch (FormatException)
            {
                
            }
        }

        private void apdPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(apdPrice.Text))
                {
                    apdPrice.BackColor = Color.Salmon;
                    Save3.Enabled = false;
                }
                else if (Convert.ToDecimal(apdPrice.Text) < 1 ||
                    Convert.ToDecimal(apdPrice.Text) > 1000)
                {
                    apdPrice.BackColor = Color.Salmon;
                    Save3.Enabled = false;
                }
                else if (apdPrice.Text.All(char.IsDigit))
                {
                    apdPrice.BackColor = Color.White;
                    Save3.Enabled = AllowSave();
                }
                else
                {
                    apdPrice.BackColor = Color.White;
                    Save3.Enabled = AllowSave();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Price must be a number.");
                apdPrice.BackColor = Color.Salmon;
            }
        }

        private void apdMax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(apdMax.Text))
                {
                    apdMax.BackColor = Color.Salmon;
                    Save3.Enabled = false;
                }
                else if (Convert.ToInt32(apdMax.Text) < Convert.ToInt32(apdMin.Text) ||
                   Convert.ToInt32(apdMax.Text) > 300)
                {
                    apdMax.BackColor = Color.Salmon;
                    Save3.Enabled = false;
                    MessageBox.Show("Maximum inventory must be a number greater than minimum.");
                }
                else
                {
                    apdMax.BackColor = Color.White;
                    Save3.Enabled = AllowSave();
                }
            }
            catch (FormatException)
            {
                
            }
        }

        private void apdMin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(apdMin.Text))
                {
                    apdMin.BackColor = Color.Salmon;
                    Save3.Enabled = false;
                }
                else if (Convert.ToInt32(apdMin.Text) < 0 ||
                    Convert.ToInt32(apdMin.Text) > Convert.ToInt32(apdMax.Text))
                {
                    apdMin.BackColor = Color.Salmon;
                    Save3.Enabled = false;
                    MessageBox.Show("Minimum inventory must be a number less than maximum.");
                }
                else
                {
                    apdMin.BackColor = Color.White;
                    Save3.Enabled = AllowSave();
                }
            }
            catch (FormatException)
            {
                
            }
        }
        #endregion
    }
}
