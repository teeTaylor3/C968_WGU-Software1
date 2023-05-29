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
    public partial class ModifyProduct : Form
    {
        public BindingList<Part> partsToAdd = new BindingList<Part>();
        MainScreen mainScreen;

        private int idxSelectedPart;
        private bool AllowSave()
        {
            int number;
            return (!string.IsNullOrWhiteSpace(mpdName.Text)) && (int.TryParse(mpdInventory.Text, out number))
                && (decimal.TryParse(mpdPrice.Text, out decimal result)) && (int.TryParse(mpdMax.Text, out number))
                && (int.TryParse(mpdMin.Text, out number));

        }

        public ModifyProduct()
        {
            InitializeComponent();
            DGVAllParts2.DataSource = Inventory.AllParts;
            DGVAllParts2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVAllParts2.ReadOnly = true;
            DGVAllParts2.RowHeadersVisible = false;

            // The following populates the Associated Parts data grid
            foreach (Part part in Inventory.CurrentPd.AssociatedParts)
            {
                partsToAdd.Add(part);
            }
            var assocpart = new BindingSource();
            assocpart.DataSource = partsToAdd;
            DGVAssociatedParts2.DataSource = assocpart;
            DGVAssociatedParts2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVAssociatedParts2.ReadOnly = true;
            DGVAssociatedParts2.RowHeadersVisible = false;

            mpdID.Text = Inventory.CurrentPd.ProductID.ToString();
            mpdName.Text = Inventory.CurrentPd.Name;
            mpdInventory.Text = Inventory.CurrentPd.InStock.ToString();
            mpdPrice.Text = Inventory.CurrentPd.Price.ToString();
            mpdMax.Text = Inventory.CurrentPd.Max.ToString();
            mpdMin.Text = Inventory.CurrentPd.Min.ToString();
          
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {
            DGVAllParts2.ClearSelection();
            DGVAssociatedParts2.ClearSelection();

        }

        private void SetIdxSelectedPart()
        {
            if (DGVAllParts2.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.DGVAllParts2.SelectedRows[0];
                Inventory.idxSelectedPart = row.Index;
            }
            else
            {
                Inventory.idxSelectedPart = -1;
            }
        }

        private void SetIdxAssociatedPart()
        {
            if (DGVAssociatedParts2.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.DGVAssociatedParts2.SelectedRows[0];
                Inventory.idxSelectedPart = row.Index;
            }
            else
            {
                Inventory.idxSelectedPart = -1;
            }
        }
        private void DGVAllParts2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetIdxSelectedPart();
            DGVAllParts2.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            DGVAllParts2.DefaultCellStyle.SelectionForeColor = Color.Black;
            Save4.Enabled = AllowSave();
        }

        private void DGVAssociatedParts2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetIdxAssociatedPart();
            DGVAssociatedParts2.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            DGVAssociatedParts2.DefaultCellStyle.SelectionForeColor = Color.Black;
            Save4.Enabled = AllowSave();
        }

        #region Button Events
        private void Add4_Click(object sender, EventArgs e)
        {
            try
            {
                SetIdxSelectedPart();
                if (Inventory.idxSelectedPart >= 0)
                {
                    Inventory.CurrentPt = Inventory.AllParts[Inventory.idxSelectedPart];
                    if (partsToAdd.Contains(Inventory.CurrentPt))
                    {
                        MessageBox.Show("Part is already assoicated with this product.");
                    }
                    else 
                    {
                        partsToAdd.Add(Inventory.CurrentPt);
                    }
                }
                else
                {
                    MessageBox.Show("Please select part to add.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select part to add.");
            }
        }

        private void Delete4_Click(object sender, EventArgs e)
        {
            SetIdxAssociatedPart();
            if (idxSelectedPart >= 0)
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

        private void Save4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(mpdName.Text) || !string.IsNullOrEmpty(mpdInventory.Text) ||
                    !string.IsNullOrEmpty(mpdPrice.Text) || !string.IsNullOrEmpty(mpdMin.Text) || !string.IsNullOrEmpty(mpdMax.Text))
                    
                {
                    Product prd = new Product(Convert.ToInt32(mpdID.Text), mpdName.Text, Convert.ToInt32(mpdInventory.Text),
                        Convert.ToDecimal(mpdPrice.Text), Convert.ToInt32(mpdMin.Text), Convert.ToInt32(mpdMax.Text));

                    foreach (Part part in partsToAdd)
                    {
                        prd.AddAssociatedPart(part);
                    }
                    Inventory.UpdateProduct(Convert.ToInt32(mpdID.Text), prd);
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
        private void Cancel4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen MnScrn = new MainScreen();
            MnScrn.Show();
        }

        private void Search4_Click(object sender, EventArgs e)
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
                    DGVAllParts2.DataSource = TempList;

            }
            if (!found)
            {
                MessageBox.Show("Part not found. Please search by name.");
                DGVAllParts2.DataSource = Inventory.AllParts;
            }
        }
        #endregion

        // The following code is used for form validation
        #region Validation
        private void mpdID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void mpdName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mpdName.Text))
                {
                    mpdName.BackColor = Color.Salmon;
                    Save4.Enabled = false;
                    MessageBox.Show("Product name must be entered");
                }
                else
                {
                    mpdName.BackColor = Color.White;
                    Save4.Enabled = AllowSave();
                }
            }
            catch (FormatException)
            {
                
            }
        }

        private void mpdInventory_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mpdInventory.Text))
                {
                    mpdInventory.BackColor = Color.Salmon;
                    Save4.Enabled = false;
                }
                else if (Convert.ToInt32(mpdInventory.Text) < Convert.ToInt32(mpdMin.Text) ||
                    Convert.ToInt32(mpdInventory.Text) > Convert.ToInt32(mpdMax.Text))
                {
                    mpdInventory.BackColor = Color.Salmon;
                    Save4.Enabled = false;
                    MessageBox.Show("Inventory must be a number between minimum and maximum");
                }
                else
                {
                    mpdInventory.BackColor = Color.White;
                    Save4.Enabled = AllowSave();
                }
            }
            catch (FormatException)
            {
                
            }
        }

        private void mpdPrice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mpdPrice.Text))
                {
                    mpdPrice.BackColor = Color.Salmon;
                    Save4.Enabled = false;
                }
                else if (Convert.ToDecimal(mpdPrice.Text) < 1 ||
                    Convert.ToDecimal(mpdPrice.Text) > 1000)
                {
                    mpdPrice.BackColor = Color.Salmon;
                    Save4.Enabled = false;
                }
                else if (mpdPrice.Text.All(char.IsDigit))
                {
                    mpdPrice.BackColor = Color.White;
                    Save4.Enabled = AllowSave();
                }
                else
                {
                    mpdPrice.BackColor = Color.White;
                    Save4.Enabled = AllowSave();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Price must be a number.");
                mpdPrice.BackColor = Color.Salmon;
            }
        }

        private void mpdMax_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mpdMax.Text))
                {
                    mpdMax.BackColor = Color.Salmon;
                    Save4.Enabled = false;
                }
                else if (Convert.ToInt32(mpdMax.Text) < Convert.ToInt32(mpdMin.Text))
                {
                    mpdMax.BackColor = Color.Salmon;
                    Save4.Enabled = false;
                    MessageBox.Show("Maximum inventory must be a number greater than minimum.");
                }
                else
                {
                    mpdMax.BackColor = Color.White;
                    Save4.Enabled = AllowSave();
                }
            }
            catch (FormatException)
            {
               
            }
        }

        private void mpdMin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mpdMin.Text))
                {
                    mpdMin.BackColor = Color.Salmon;
                    Save4.Enabled = false;
                }
                else if (Convert.ToInt32(mpdMin.Text) < 0 ||
                    Convert.ToInt32(mpdMin.Text) > Convert.ToInt32(mpdMax.Text))
                {
                    mpdMin.BackColor = Color.Salmon;
                    Save4.Enabled = false;
                    MessageBox.Show("Minimum inventory must be a number less than maximum.");
                }
                else
                {
                    mpdMin.BackColor = Color.White;
                    Save4.Enabled = AllowSave();
                }
            }
            catch (FormatException)
            {
                
            }
        }
        #endregion
    }
}
