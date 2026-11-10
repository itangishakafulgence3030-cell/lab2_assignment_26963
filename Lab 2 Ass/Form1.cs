using System;
using System.Windows.Forms;

namespace Lab_2_Ass
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your username and password.",
                    "Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show(
                "Login successful!",
                "Login",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            Form_choose nextForm = new Form_choose();
            nextForm.LoginForm = this;
            nextForm.Show();
            Hide();
        }
    }
}
