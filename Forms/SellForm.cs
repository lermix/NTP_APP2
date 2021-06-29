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
        List<Product> allProducts;

        public SellForm()
        {
            InitializeComponent();

            selectedProducts = new List<Product>();
            allProducts = new List<Product>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(getProducts));
            t.Start();           

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
            listBoxProduct.Items.AddRange(allProducts.Where(item => item.name.StartsWith(tboxSearch.Text)).ToArray());
            listBoxProduct.ValueMember = "name";  

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            PDFManager.createPDFfromList(
                selectedProducts, "Racun_" + DateTime.Now,
                @"C:\Users\Alen\Desktop\Racuni\Racun_" + DateTime.Now.ToString("yyyy_mm_dd_hh_mm") + ".pdf");
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            List<double> allPrices = ((List<Product>)dgv.DataSource).Select(item => item.price).ToList();
            Calculator.CalculatorSoapClient mySoapClient = new Calculator.CalculatorSoapClient();
            Calculator.ArrayOfDouble ar = new Calculator.ArrayOfDouble();

            foreach (double item in allPrices)
            {
                ar.Add(item);
            }

            lblTotal.Text = mySoapClient.Sum( ar ).ToString();
        }

        private void getProducts ()
        {
            allProducts = Messanger.select<Product>(Enums.MessageObjectType.Product);
            listBoxProduct.Invoke((MethodInvoker)delegate
            {
                listBoxProduct.Items.AddRange(allProducts.ToArray());
                listBoxProduct.ValueMember = "name";
            }); 
             
        }
    }
}
