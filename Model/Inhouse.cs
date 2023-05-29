using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C968_Terrence_Taylor.Model
{
    public class Inhouse : Part
    {
        public Inhouse(string name, int inStock, decimal price, int min, int max, int machID) : 
            base(name, inStock, price, min, max)
        {
            MachineID = machID;
        }

        public Inhouse(int partID, string name, int inStock, decimal price, int min, int max, int machID) : 
            base(partID, name, inStock, price, min, max)
        {
            MachineID = machID;
        }

        public int MachineID { get; set; }
    }
}
