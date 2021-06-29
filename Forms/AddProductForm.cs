using NTP_Ivo_ojvan.Clients;
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
using static NTP_Ivo_Ojvan.Models.Enums;

namespace NTP_Ivo_Ojvan
{
    public partial class AddProductForm : Form
    {
        numberToWord.NumberConversionSoapTypeClient SOAPClient;
        List<Product> allProducts;

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (formNotFilled()) return;
            Thread t = new Thread(new ParameterizedThreadStart(insertProduct));
            t.Start(getFormProduct());
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {
            cmbBrand.Items.AddRange(Enum.GetValues(typeof(Brand)).Cast<Enum>().ToArray());
            SOAPClient = new numberToWord.NumberConversionSoapTypeClient("NumberConversionSoap");

        }

        private void btnSelectExisting_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(showExsiting));
            t.Start();
        }

        private void listBoxProducts_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedItem != null)
            {
                tboxId.Text = ((Product)listBoxProducts.SelectedItem).id.ToString();
                tBoxName.Text = ((Product)listBoxProducts.SelectedItem).name.ToString();
                cmbBrand.SelectedItem = ((Product)listBoxProducts.SelectedItem).brand;
                tboxPrice.Text = ((Product)listBoxProducts.SelectedItem).price.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (formNotFilled()) return;
            Messanger.update<Product>(getFormProduct(), MessageObjectType.Product);
        }   

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (formNotFilled()) return;
            Messanger.delete<Product>(getFormProduct(), MessageObjectType.Product);
        }

        private Product getFormProduct()
        {
            Product product = new Product();

            product.id = int.Parse(tboxId.Text);
            product.name = tBoxName.Text;
            product.brand = (Brand)cmbBrand.SelectedItem;
            product.price = double.Parse(tboxPrice.Text);

            return product;
        }

        private bool formNotFilled()
        {
            foreach (TextBox item in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    MessageBox.Show("Moraju biti upisani svi podaci");
                    return true;
                }

            }
            foreach (ComboBox item in this.Controls.OfType<ComboBox>())
            {
                if (string.IsNullOrEmpty(item.Text))
                {
                    MessageBox.Show("Moraju biti upisani svi podaci");
                    return true;
                }

            }

            return false;
        }

        private void tboxPrice_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxPrice.Text))
            {
                lblPriceTxt.Text = "";
                return;
            }
            lblPriceTxt.Text = SOAPClient.NumberToDollars(decimal.Parse(tboxPrice.Text));
        }

        private void insertProduct(object product)
        {
            Messanger.insert(product, MessageObjectType.Product);
            MessageBox.Show("Product added");

        }

        private void showExsiting()
        {

            allProducts = Messanger.select<Product>(MessageObjectType.Product);
            listBoxProducts.Invoke((MethodInvoker)delegate
           {
               listBoxProducts.Items.Clear();
               listBoxProducts.Visible = true;
               listBoxProducts.ValueMember = "name";
               listBoxProducts.Items.AddRange(allProducts.ToArray());

           });

            btnUpdate.Invoke((MethodInvoker) delegate {
                btnUpdate.Visible = true;
            });

            btnDelete.Invoke((MethodInvoker) delegate {
                btnDelete.Visible = true;
            });
        }
    }
}
