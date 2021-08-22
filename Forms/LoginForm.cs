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
    public partial class LoginForm : Form
    {
        List<User> allUsers;
        
        public LoginForm()
        {
            InitializeComponent();

            allUsers = getUsers();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = allUsers.Find(x => x.username == tboxUsername.Text);
            if (user != null && user.password == tBoxPassword.Text)
            {
                this.Hide();
                MainForm mainForm = new MainForm(user);
                mainForm.Location = this.Location;
                mainForm.StartPosition = this.StartPosition;
                mainForm.FormClosing += delegate { this.Close(); };
                mainForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Korisnik s tim imenom i sifrom ne psotoji");
            }
        }

        private List<User> getUsers()
        {
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
            return users;
        }
    }
}
