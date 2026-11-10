using System;
using System.Windows.Forms;

namespace Lab_2_Ass
{
    public partial class Form_choose : Form
    {
        internal Form_login LoginForm { get; set; }

        public Form_choose()
        {
            InitializeComponent();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Mushroom_Identification mushroomForm = new Mushroom_Identification();
            mushroomForm.ChooseForm = this;
            mushroomForm.Show();
            Hide();
        }

        private void btnBiycle_Click(object sender, EventArgs e)
        {
            Form_biycle bicycleForm = new Form_biycle();
            bicycleForm.ChooseForm = this;
            bicycleForm.Show();
            Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (LoginForm != null)
            {
                LoginForm.Show();
            }

            Close();
        }
    }
}
