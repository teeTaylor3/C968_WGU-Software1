using C968_Terrence_Taylor.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace C968_Terrence_Taylor
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Inventory.Products.Clear();
            Inventory.Products.Add(new Product(1, "With Clear Backboard", 59, 279.99M, 1, 75));
            Inventory.Products.Add(new Product(2, "With Black Backboard", 43, 234.99M, 1, 75));
            Inventory.Products.Add(new Product(3, "With White Backboard", 51, 224.99M, 1, 75));

            Inventory.AllParts.Clear();
            Inventory.AllParts.Add(new Inhouse(1, "Net", 125, 7.99m, 1, 300, 44));
            Inventory.AllParts.Add(new Inhouse(2, "Post", 78, 109.99m, 1, 200, 52));
            Inventory.AllParts.Add(new Inhouse(3, "Rim", 113, 34.99m, 1, 300, 73));
            Inventory.AllParts.Add(new Outsourced(4, "Backboard", 32, 149.99m, 1, 40, "Got Your Back."));
            Inventory.AllParts.Add(new Outsourced(5, "Goalbase", 21, 74.99m, 1, 40, "Solid Foundation"));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainScreen());
        }
    }
}
