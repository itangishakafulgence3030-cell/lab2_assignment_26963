using System;
using System.Windows.Forms;

namespace Lab_2_Ass
{
    public partial class Form_biycle : Form
    {
        internal Form_choose ChooseForm { get; set; }

        public Form_biycle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int startTime;
            int endTime;
            txtTotalCost.Clear();

            if (!int.TryParse(txtStartTime.Text, out startTime) ||
                !int.TryParse(txtEndTime.Text, out endTime))
            {
                MessageBox.Show(
                    "Enter whole numbers for the starting and ending hours.",
                    "Invalid rental hours",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (startTime < 0 || startTime > 23 ||
                endTime < 1 || endTime > 24 ||
                startTime >= endTime)
            {
                MessageBox.Show(
                    "Start time must be 0-23, end time 1-24, " +
                    "and start time must be less than end time.",
                    "Invalid rental hours",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            int total = 0;
            for (int hour = startTime; hour < endTime; hour++)
            {
                int rate;

                if (hour < 7 || hour >= 21)
                {
                    rate = 500;
                }
                else if (hour < 14)
                {
                    rate = 1000;
                }
                else if (hour < 19)
                {
                    rate = 1500;
                }
                else
                {
                    rate = 1000;
                }

                total += rate;
            }

            string result = total + " RWF";
            txtTotalCost.Text = result;
            MessageBox.Show(
                "Total rental cost: " + result,
                "Bicycle Rental",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form_login loginForm = ChooseForm == null ? null : ChooseForm.LoginForm;
            if (loginForm != null)
            {
                loginForm.Show();
            }

            Close();
            if (ChooseForm != null)
            {
                ChooseForm.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (ChooseForm != null)
            {
                ChooseForm.Show();
            }

            Close();
        }
    }
}
