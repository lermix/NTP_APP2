using Models;
using NTP_Ivo_Ojvan.Clients;
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

namespace NTP_Ivo_Ojvan.Forms
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void btnGetFromDatabase_Click(object sender, EventArgs e)
        {
            listBoxUsers.Items.Clear();
            listBoxUsers.Visible = true;
            listBoxUsers.DisplayMember = "username";
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            List<User> users = new List<User>();
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
            listBoxUsers.Items.AddRange(users.ToArray());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (formNotFilled()) return;
            Messanger.insert(getFormUser(), Models.Enums.MessageObjectType.User);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (formNotFilled()) return;
            Messanger.update(getFormUser(), Models.Enums.MessageObjectType.User);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (formNotFilled()) return;
            Messanger.delete(getFormUser(), Models.Enums.MessageObjectType.User);
        }

        private void listBoxUsers_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedItem == null) return;
            addToForm((User)listBoxUsers.SelectedItem);
        }

        private User getFormUser()
        {
            User user = new User();
            if (!string.IsNullOrEmpty(tboxId.Text))
            {
                user.id = int.Parse(tboxId.Text);
            }            
            user.username = tboxUsername.Text;
            switch (AppSettings.encryption)
            {
                case Models.Enums.Encryption.CES:
                    user.password = CES.Encryption(tboxPassword.Text);
                    break;
                case Models.Enums.Encryption.AES:
                    user.password = AES.Encrypt(tboxPassword.Text);
                    break;
                default:
                    break;
            }
           

            return user;
        }

        private void addToForm(User user)
        {
            tboxId.Text = user.id.ToString();
            tboxUsername.Text = user.username;
            tboxPassword.Text = user.password;
        }

        private bool formNotFilled()
        {
            foreach (TextBox item in this.Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(item.Text) && item.Name != "tboxId")
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


    }
}
