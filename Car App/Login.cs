using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_App
{
    public partial class Login : Form
    {
        private static LoginValidator login = new LoginValidator("admin", "1234");

        public Login()
        {
            InitializeComponent();
        }

        public static void user_pass(string user, string pass)
        {
            login.Username = user;
            login.Userpassword = pass;
        }

        public static string GetUserName()
        {
            return login.Username;
        }

        public static string GetPassword()
        {
            return login.Userpassword;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(login.IsLoggedIn(nameInput.Text, passInput.Text))
            {
                var dashboard = new Dashboard();
                dashboard.StartPosition = FormStartPosition.CenterParent;
                this.Hide();
                dashboard.ShowDialog();
                this.Close();
            }
            else
            {
                //show default login error message 
                MessageBox.Show("Login Error!");
            }
                
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            const string message = "Are you sure you want to exit.";
            var result = MessageBox.Show(message, "Login closing",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Close();

        }
    }
}
