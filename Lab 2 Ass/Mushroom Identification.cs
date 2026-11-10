using System;
using System.Windows.Forms;

namespace Lab_2_Ass
{
    public partial class Mushroom_Identification : Form
    {
        internal Form_choose ChooseForm { get; set; }

        public Mushroom_Identification()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            lblResult.Text = "Results:";
            bool forest;
            bool convex;
            string result;

            if (!TryGetAnswer(
                rbForestYes,
                rbForestNo,
                "Choose yes or no for whether the mushroom grows in a forest.",
                out forest) ||
                !TryGetAnswer(
                    rbConvexYes,
                    rbConvexNo,
                    "Choose yes or no for whether the mushroom has a convex cap.",
                    out convex))
            {
                return;
            }

            if (!forest)
            {
                result = convex ? "Agaric jaunissant" : "Coprin chevelu";
            }
            else if (convex)
            {
                bool ring;
                if (!TryGetAnswer(
                    rbRingYes,
                    rbRingNo,
                    "Choose yes or no for whether the mushroom has a ring.",
                    out ring))
                {
                    return;
                }

                result = ring ? "Amanite tue-mouche" : "Pied bleu";
            }
            else
            {
                bool gills;
                if (!TryGetAnswer(
                    rbGillsYes,
                    rbGillsNo,
                    "Choose yes or no for whether the mushroom has gills.",
                    out gills))
                {
                    return;
                }

                result = gills ? "Girolle" : "Cepe de bordeaux";
            }

            lblResult.Text = "Identified Mushroom: " + result;
            MessageBox.Show(
                "Your mushroom is: " + result,
                "Identification Result",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private bool TryGetAnswer(
            RadioButton yesButton,
            RadioButton noButton,
            string validationMessage,
            out bool answer)
        {
            if (yesButton.Checked)
            {
                answer = true;
                return true;
            }

            if (noButton.Checked)
            {
                answer = false;
                return true;
            }

            answer = false;
            MessageBox.Show(
                validationMessage,
                "Mushroom Identification",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
            return false;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ChooseForm != null)
            {
                ChooseForm.Show();
            }

            Close();
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
    }
    
