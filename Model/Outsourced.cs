using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_Terrence_Taylor.Model
{
    public class Outsourced : Part
    {
        public Outsourced(string name, int inStock, decimal price, int min, int max, string compName) : 
            base(name, inStock, price, min, max)
        {
            CompanyName = compName;
        }
        
        public Outsourced(int partID, string name, int inStock, decimal price, int min, int max, string compName) : 
            base(partID, name, inStock, price, min, max)
        {
            CompanyName = compName;
        }

        public string CompanyName { get; set; }
    }
}
