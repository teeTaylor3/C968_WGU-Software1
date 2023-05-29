using C968_Terrence_Taylor.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Terrence_Taylor
{
    public partial class MainScreen : Form
    {
       private int idxSelectedPart;
       private int idxSelectedProd;

        public MainScreen()
        {
            InitializeComponent();

            Inventory.idxSelectedPart = -1;
            DGVPart.ClearSelection();
            DGVPart.DataSource = Inventory.AllParts;
            DGVPart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVPart.ReadOnly = true;
            DGVPart.RowHeadersVisible = false;

            Inventory.idxSelectedProd = -1;
            DGVProduct.ClearSelection();
            DGVProduct.DataSource = Inventory.Products;
            DGVProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVProduct.ReadOnly = true;
            DGVProduct.RowHeadersVisible = false;
        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = DGVPart.SelectedCells;
            DGVPart.ClearSelection();
            DGVProduct.ClearSelection();
        }

        #region Part Interface
        private void SetIdxSelectedPart()
        {
            if (DGVPart.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.DGVPart.SelectedRows[0];
                Inventory.idxSelectedPart = row.Index;
            }
            else
            {
                Inventory.idxSelectedPart = -1;
            }
        }

        private void DGVPart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetIdxSelectedPart();
            DGVPart.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            DGVPart.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void Add1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddParts APts = new AddParts();
            APts.Show();
        }

        private void Modify1_Click(object sender, EventArgs e)
        {
            try
            {
                SetIdxSelectedPart();
                if (idxSelectedPart >= 0)
                {
                    Inventory.CurrentPt = Inventory.AllParts[Inventory.idxSelectedPart];
                    this.Hide();
                    ModifyParts MPts = new ModifyParts();
                    MPts.Show();
                }
                else
                {
                    MessageBox.Show("Please select a part to modify.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }

        private void Delete1_Click(object sender, EventArgs e)
        {
            try
            {
                SetIdxSelectedPart();
                if (idxSelectedPart >= 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (dialogResult == DialogResult.Yes)
                    {
                        Inventory.AllParts.RemoveAt(Inventory.idxSelectedPart);
                    }
                    else
                    {
                        MessageBox.Show("Please select part to delete.");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a part to modify.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }
        private void Search1_Click(object sender, EventArgs e)
        {
            BindingList<Part> TempList = new BindingList<Part>();
            bool found = false;
            if (SearchParts.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(SearchParts.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.AllParts[i]);
                        found = true;
                    }
                }
                if (found)
                    DGVPart.DataSource = TempList;

            }
            if (!found)
            {
                MessageBox.Show("Part not found. Please search by name.");
                DGVPart.DataSource = Inventory.AllParts;
            }
        }
        #endregion

        #region Product Interface
        private void SetIdxSelectedProd()
        {
            if (DGVProduct.SelectedRows.Count != 0)
            {
                DataGridViewRow row = this.DGVProduct.SelectedRows[0];
                Inventory.idxSelectedProd = row.Index;
            }
            else
            {
                Inventory.idxSelectedProd = -1;
            }
        }

        private void DGVProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetIdxSelectedProd();
            DGVProduct.DefaultCellStyle.SelectionBackColor = Color.Yellow;
            DGVProduct.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void Add2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProduct APd = new AddProduct();
            APd.Show();
        }

        private void Modify2_Click(object sender, EventArgs e)
        {
            try
            {
                SetIdxSelectedProd();
                if (idxSelectedProd >= 0)
                {
                    Inventory.CurrentPd = Inventory.Products[Inventory.idxSelectedProd];
                    this.Hide();
                    ModifyProduct MPd = new ModifyProduct();
                    MPd.Show();
                }
                else
                {
                    MessageBox.Show("Please select a product to modify.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select a product to modify.");
            }
        }

        private void Delete2_Click(object sender, EventArgs e)
        {
            try
            {
                SetIdxSelectedProd();
                if (idxSelectedProd >= 0)
                {
                    Inventory.CurrentPd = Inventory.Products[Inventory.idxSelectedProd];
                    if (Inventory.CurrentPd.AssociatedParts.Count == 0)
                        {
                            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this product?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                        if (dialogResult == DialogResult.Yes)
                        {
                            Inventory.Products.RemoveAt(Inventory.idxSelectedProd);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Products with associated parts cannot be deleted.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Select product to delete.");
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Select product to delete.");
            }
        }

        private void Search2_Click(object sender, EventArgs e)
        {
            BindingList<Product> TempList = new BindingList<Product>();
            bool found = false;
            if (SearchProducts.Text != "")
            {
                for (int i = 0; i < Inventory.Products.Count; i++)
                {
                    if (Inventory.Products[i].Name.ToUpper().Contains(SearchProducts.Text.ToUpper()))
                    {
                        TempList.Add(Inventory.Products[i]);
                        found = true;
                    }
                }
                if (found)
                    DGVProduct.DataSource = TempList;
            }
            if (!found)
            {
                MessageBox.Show("Product not found. Please search by name");
                DGVProduct.DataSource = Inventory.Products;
            }
        }
        #endregion

        private void Exit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
