using NTP_Ivo_Ojvan.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NTP_Ivo_Ojvan.Models.Enums;

namespace NTP_Ivo_Ojvan.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            IniFilesManager iniFilesManager = new IniFilesManager(AppSettings.DEFAULT_SETTINGS_PATH);
            AppSettings.databaseType = (DatabaseType) Enum.Parse(typeof(DatabaseType), iniFilesManager.Read(AppSettings.DATABASE_TYPE));
            AppSettings.serverType = (ServerType) Enum.Parse(typeof(ServerType), iniFilesManager.Read(AppSettings.SERVER_TYPE));
        }


        private void btnSell_Click(object sender, EventArgs e)
        {
            this.Hide();
            SellForm sellForm = new SellForm();
            sellForm.Location = this.Location;
            sellForm.StartPosition = this.StartPosition;
            sellForm.FormClosing += delegate { this.Show(); };
            sellForm.ShowDialog();
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
            UsersForm userForm = new UsersForm();
            userForm.Location = this.Location;
            userForm.StartPosition = this.StartPosition;
            userForm.FormClosing += delegate { this.Show(); };
            userForm.ShowDialog();
        }
    }
}
