using Models;
using NTP_Ivo_Ojvan.Clients;
using NTP_Ivo_Ojvan.Models;
using NTP_Ivo_Ojvan.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_Ivo_Ojvan
{
    public partial class SellForm : Form
    {
        List<Product> selectedProducts;
        Lookup<int, Product> allProducts;
        string username;

        public SellForm(string username, List<Product> allProducts)
        {
            InitializeComponent();

            this.username = username;
            selectedProducts = new List<Product>();

            getProducts(allProducts);
        }


        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            selectedProducts.Add((Product)listBoxProduct.SelectedItem);
            dgv.DataSource = null;
            dgv.DataSource = selectedProducts;            
        }

        private void tboxSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxProduct.Items.Clear();

            listBoxProduct.Items.AddRange(allProducts.SelectMany(g => g)
                 .Where(x => x.name.StartsWith(tboxSearch.Text)).ToArray());
            listBoxProduct.ValueMember = "name";  

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            Bill bill = new Bill(username, double.Parse(lblTotal.Text), DateTime.Now.ToString("yyyy_MM_dd_hh_mm"));
            
            XmlManager.insert(bill);

            PDFManager.createPDFfromList(
                selectedProducts, "Racun_" + DateTime.Now,
                @"C:\Users\Alen\Desktop\Racuni\Racun_" + DateTime.Now.ToString("yyyy_MM_dd_hh_mm") + ".pdf");

            dgv.DataSource = null;
            selectedProducts.Clear();
            dgv.DataSource = selectedProducts;
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            calculateTotalPrice();

        }

        private void calculateTotalPrice()
        {
            List<double> allPrices = ((List<Product>)dgv.DataSource).Select(item => item.price).ToList();
            Calculator.CalculatorSoapClient mySoapClient = new Calculator.CalculatorSoapClient();
            Calculator.ArrayOfDouble ar = new Calculator.ArrayOfDouble();

            foreach (double item in allPrices)
            {
                ar.Add(item);
            }

            try
            {
                lblTotal.Text = mySoapClient.Sum(ar).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Soap servis nedostupan zbraja lokalno");
                lblTotal.Text = ar.Sum().ToString();
                
            }
        }

        private void getProducts (List<Product> products)
        {
            allProducts = (Lookup<int, Product>)products.ToLookup(x => x.id, x => x);
            listBoxProduct.Items.AddRange(allProducts.SelectMany(g => g).Select(x => x)
                .ToArray());
            listBoxProduct.ValueMember = "name";             
        }

        private void btnAsc_Click(object sender, EventArgs e)
        {
            listBoxProduct.Items.Clear();
            listBoxProduct.Items.AddRange(allProducts.SelectMany(g => g)
                .OrderBy(x => x.name).Select(x => x.name).ToArray());
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            listBoxProduct.Items.Clear();
            listBoxProduct.Items.AddRange(allProducts.SelectMany(g => g)
                .OrderByDescending(x => x.name).Select(x => x.name).ToArray());
        }
    }
}
