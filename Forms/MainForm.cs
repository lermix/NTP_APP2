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
using static NTP_Ivo_Ojvan.Models.Enums;

namespace NTP_Ivo_Ojvan.Forms
{
    public partial class MainForm : Form
    {
        string username;
        List<Product> products;
        List<User> users;

        public MainForm(User user)
        {
            InitializeComponent();
            username = user.username;
            this.Text = "Korisnik: " + user.username;

            getData();
            
        }

        private void getData()
        {
            Thread tProducts = new Thread(new ThreadStart(getProducts));
            Thread tUsers = new Thread(new ThreadStart(getUsers));
            Thread tSettings = new Thread(new ThreadStart(getSettings));
            tProducts.Start();
            tUsers.Start();
            tSettings.Start();
        }

        

        private void btnSell_Click(object sender, EventArgs e)
        {
            if (products != null && products.Count > 0)
            {
                this.Hide();
                SellForm sellForm = new SellForm(username, products);
                sellForm.Location = this.Location;
                sellForm.StartPosition = this.StartPosition;
                sellForm.FormClosing += delegate { this.Show(); };
                sellForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Još nema proizvoda pokušajte kasnije");
            }
            
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.Location = this.Location;
            addProductForm.StartPosition = this.StartPosition;
            addProductForm.FormClosing += delegate { this.Show(); };
            addProductForm.ShowDialog();
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            PropertiesForm propertiesForm = new PropertiesForm();
            propertiesForm.Location = this.Location;
            propertiesForm.StartPosition = this.StartPosition;
            propertiesForm.FormClosing += delegate { this.Show(); };
            propertiesForm.ShowDialog();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (AppSettings.databaseType == DatabaseType.Xml)
            {
                MessageBox.Show("Korisnici se ne spremaju lokalno molim odaberite mysql kao bazu");

                return;
            }
            UsersForm userForm = new UsersForm(users);
            userForm.Location = this.Location;
            userForm.StartPosition = this.StartPosition;
            userForm.FormClosing += delegate { this.Show(); };
            userForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            chBoxProducts.Checked = false;
            chBoxUsers.Checked = false;
            chBoxSettings.Checked = false;
            getData();
        }

        private void getSettings()
        {
            IniFilesManager iniFilesManager = new IniFilesManager(AppSettings.DEFAULT_SETTINGS_PATH);
            AppSettings.databaseType = (DatabaseType)Enum.Parse(typeof(DatabaseType), iniFilesManager.Read(AppSettings.DATABASE_TYPE));
            AppSettings.serverType = (ServerType)Enum.Parse(typeof(ServerType), iniFilesManager.Read(AppSettings.SERVER_TYPE));

            bool jobDone = false;
            while (!jobDone)
            {
                if (IsHandleCreated)
                {
                    chBoxSettings.Invoke((MethodInvoker)delegate
                    {
                        chBoxSettings.Checked = true;
                    });
                    jobDone = true;
                }

                else
                    Thread.Sleep(2000);
            }
            
        }

        private void getProducts()
        {
            bool jobDone = false;
            while (!jobDone)
            {
                if (IsHandleCreated)
                {
                    products = Messanger.select<Product>(Enums.MessageObjectType.Product);
                    chBoxProducts.Invoke((MethodInvoker)delegate
                    {
                        chBoxProducts.Checked = true;
                    });
                    jobDone = true;
                }
                else
                {
                    Thread.Sleep(2000);
                }
            }


        }

        private void getUsers()
        {
            bool jobDone = false;
            while (!jobDone)
            {
                if (IsHandleCreated)
                {
                    users = new List<User>();
                    foreach (User item in Messanger.select<User>(Models.Enums.MessageObjectType.User).ToArray())
                    {
                        User temp = item;
                        switch (AppSettings.encryption)
                        {
                            case Models.Enums.Encryption.CES:
                                temp.password = CES.Decryption(temp.password);
                                break;
                            case Models.Enums.Encryption.AES:
                                temp.password = AES.Decrypt(temp.password);
                                break;
                            default:
                                break;
                        }
                        users.Add(temp);
                    }
                    chBoxUsers.Invoke((MethodInvoker)delegate
                    {
                        chBoxUsers.Checked = true;
                    });
                    jobDone = true;
                }
                else
                {
                    Thread.Sleep(2000);
                }
            }
        }

    }
}
