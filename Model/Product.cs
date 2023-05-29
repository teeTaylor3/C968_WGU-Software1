using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C968_Terrence_Taylor.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public static int num = 1;
        public Product(string name, int inStock, decimal price, int min, int max)
        {
            ProductID = num++;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }
        public Product(int prodID, string name, int inStock, decimal price, int min, int max)
        {
            ProductID = prodID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part part)
        { 
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int partID) 
        {
            bool removed = false;
            for (int i = AssociatedParts.Count - 1; i >= 0; i--)
            {
                if (AssociatedParts[i].PartID == partID)
                {
                    AssociatedParts.RemoveAt(i);
                    removed = true;
                }
                else
                {
                    MessageBox.Show("Part not removed.");
                    removed = false;
                }
            }
            return removed;
        }

        public Part LookupAssociatedPart(int partID)
        {
            for (int i = AssociatedParts.Count - 1; i >= 0; i--)
            {
                if (AssociatedParts[i].PartID == partID)
                {
                    return AssociatedParts[i];
                }
                else
                {
                    MessageBox.Show("Part not found.");
                }
            }
            return null;
        }
    }

};
