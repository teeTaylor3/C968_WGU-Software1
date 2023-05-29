using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C968_Terrence_Taylor.Model
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public static int num = 1;

        public Part(string name, int inStock, decimal price, int min, int max)
            {
                PartID = num++;
                Name = name;
                InStock = inStock;
                Price = price;
                Min = min;
                Max = max;
            }

        public Part(int partID, string name, int inStock, decimal price, int min, int max)
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
        }
    }
}
