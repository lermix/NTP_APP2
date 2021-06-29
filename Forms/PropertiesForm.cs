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
    public partial class PropertiesForm : Form
    {   
        IniFilesManager iniFilesManager;

        public PropertiesForm()
        {
            InitializeComponent();
        }

        private void PropertiesForm_Load(object sender, EventArgs e)
        {
            iniFilesManager = new IniFilesManager(AppSettings.DEFAULT_SETTINGS_PATH);

            cmbDatabaseType.Items.AddRange(Enum.GetValues(typeof(DatabaseType)).Cast<Enum>().ToArray());
            cmbDatabaseType.SelectedItem = AppSettings.databaseType;
            cmbServerType.Items.AddRange(Enum.GetValues(typeof(ServerType)).Cast<Enum>().ToArray());
            cmbServerType.SelectedItem = AppSettings.serverType;
            cmbEncryption.Items.AddRange(Enum.GetValues(typeof(Encryption)).Cast<Enum>().ToArray());
            cmbEncryption.SelectedItem = AppSettings.encryption;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            iniFilesManager.Write(AppSettings.DATABASE_TYPE, cmbDatabaseType.SelectedItem.ToString());
            iniFilesManager.Write(AppSettings.SERVER_TYPE, cmbServerType.SelectedItem.ToString());
            iniFilesManager.Write(AppSettings.ENCRYPTION_TYPE, cmbEncryption.SelectedItem.ToString());


            AppSettings.databaseType =  (DatabaseType) Enum.Parse(typeof(DatabaseType) ,cmbDatabaseType.SelectedItem.ToString());
            AppSettings.serverType = (ServerType) Enum.Parse(typeof(ServerType),cmbServerType.SelectedItem.ToString());
            AppSettings.encryption = (Encryption)Enum.Parse(typeof(Encryption), cmbEncryption.SelectedItem.ToString());


            this.Close();
        }
    }
}
