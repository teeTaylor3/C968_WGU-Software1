using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Terrence_Taylor.Model
{
    public static class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();

        public static BindingList<Product> Prods { get { return Prods; } set { Prods = value; } }

        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static BindingList<Part> Parts { get { return Parts; } set { Parts = value; } }

        public static Product product;

        public static Product CurrentPd { get; set; }
        public static int CurrentPdID { get; set; }
        public static int idxSelectedProd { get; set; }
        public static int idxNewProd { get; set; }

        public static Part CurrentPt { get; set; }
        public static int CurrentPtID { get; set; }
        public static int idxSelectedPart { get; set; }


        internal static void Swap(Part prt)
        {
            AllParts.Insert(idxSelectedPart, prt);
            AllParts.RemoveAt(idxSelectedPart + 1);
        }

        #region Product CRUD
        public static void AddProduct(Product prd)
        {
            Products.Add(prd);
        }

        public static Product LookupProduct(int prodID)
        {
            foreach (Product pd in Products)
            {
                if (pd.ProductID == prodID)
                {
                    return pd;
                }
            }
            return null;
        }

        public static void UpdateProduct(int prodID, Product prd)
        {
            foreach (Product prod in Products)
            {
                if (prod.ProductID == prodID)
                {
                    prod.Name = prd.Name;
                    prod.InStock = prd.InStock;
                    prod.Price = prd.Price;
                    prod.Max = prd.Max;
                    prod.Min = prd.Min;
                    prod.AssociatedParts = prd.AssociatedParts;
                    return;
                }
            }
        }
        public static bool DeleteProduct(int prodID)
        {
            bool removed = false;

            foreach (Product pd in Products)
            {
                if (pd.ProductID == prodID)
                {
                    Products.Remove(pd);
                    return removed = true;
                }
                else
                {
                    MessageBox.Show("Product not deleted.");
                    removed = false;
                }
            }
            return removed;
        }
        #endregion

        #region Part CRUD
        public static void AddPart(Part prt)
        {
            AllParts.Add(prt);
        }

        public static Part LookupPart(int partID)
        {
            foreach (Part pt in AllParts)
            {
                if (pt.PartID == partID)
                {
                    return pt;
                }
            }
            return null;
        }

       public static void UpdatePart(int PartID, Part part)
        {
            foreach (Part pt in AllParts)
            {
                if (pt.PartID == PartID)
                {
                    pt.PartID = part.PartID;
                    pt.Name = part.Name;
                    pt.Price = part.Price;
                    pt.InStock = part.InStock;
                    pt.Max = part.Max;
                    pt.Min = part.Min;
                    return;
                }
            }
            return;
        }
        public static bool DeletePart(Part prt)
        {

            bool deleted = false;

            foreach (Part pt in AllParts)
            {
                if (pt.PartID == prt.PartID)
                {
                    Parts.Remove(pt);
                    return deleted = true;
                }
                else
                {
                    MessageBox.Show("Part not found.");
                    deleted = false;
                }
            }
            return deleted;
        }
        #endregion
    }
}


