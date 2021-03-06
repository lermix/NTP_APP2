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

            cmbLanguage.Items.AddRange(Enum.GetValues(typeof(Languages)).Cast<Enum>().ToArray());
            cmbLanguage.SelectedItem = AppSettings.languages;
            cmbServerType.Items.AddRange(Enum.GetValues(typeof(ServerType)).Cast<Enum>().ToArray());
            cmbServerType.SelectedItem = AppSettings.serverType;
            cmbEncryption.Items.AddRange(Enum.GetValues(typeof(Encryption)).Cast<Enum>().ToArray());
            cmbEncryption.SelectedItem = AppSettings.encryption;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            iniFilesManager.Write(AppSettings.SERVER_TYPE, cmbServerType.SelectedItem.ToString());
            iniFilesManager.Write(AppSettings.ENCRYPTION_TYPE, cmbEncryption.SelectedItem.ToString());


            AppSettings.serverType = (ServerType)Enum.Parse(typeof(ServerType), cmbServerType.SelectedItem.ToString());
            AppSettings.encryption = (Encryption)Enum.Parse(typeof(Encryption), cmbEncryption.SelectedItem.ToString());
            AppSettings.languages = (Languages)Enum.Parse(typeof(Languages), cmbLanguage.SelectedItem.ToString());

            if ((Languages)Enum.Parse(typeof(Languages), cmbLanguage.SelectedItem.ToString()) == Languages.Hrvatski)
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("hr");            
            else
                Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");

            this.Close();
            
        }

    }
}
