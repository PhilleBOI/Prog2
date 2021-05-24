using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Luffarschack
{
    public partial class Form1 : Form
    {
        Boolean checker;
        int plusone;

        void Enable_False()
        {
            btn_1.Enabled = false;
            btn_2.Enabled = false;
            btn_3.Enabled = false;
            btn_4.Enabled = false;
            btn_5.Enabled = false;
            btn_6.Enabled = false;
            btn_7.Enabled = false;
            btn_8.Enabled = false;
            btn_9.Enabled = false;
        }
        void score()
        {
            if (btn_1.Text == "X" && btn_2.Text == "X" && btn_3.Text == "X")
            {
                btn_1.BackColor = Color.PowderBlue;
                btn_2.BackColor = Color.PowderBlue;
                btn_3.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_1.Text == "X" && btn_4.Text == "X" && btn_7.Text == "X")
            {
                btn_1.BackColor = Color.PowderBlue;
                btn_4.BackColor = Color.PowderBlue;
                btn_7.BackColor = Color.PowderBlue;

                MessageBox.Show("The winner is Player X!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_1.Text == "X" && btn_5.Text == "X" && btn_9.Text == "X")
            {
                btn_1.BackColor = Color.Pink;
                btn_5.BackColor = Color.Pink;
                btn_9.BackColor = Color.Pink;

                MessageBox.Show("The winner is Player X!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_2.Text == "X" && btn_5.Text == "X" && btn_8.Text == "X")
            {
                btn_2.BackColor = Color.SlateBlue;
                btn_5.BackColor = Color.SlateBlue;
                btn_8.BackColor = Color.SlateBlue;

                MessageBox.Show("The winner is Player X!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_3.Text == "X" && btn_5.Text == "X" && btn_7.Text == "X")
            {
                btn_3.BackColor = Color.Crimson;
                btn_5.BackColor = Color.Crimson;
                btn_7.BackColor = Color.Crimson;

                MessageBox.Show("The winner is Player X!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_3.Text == "X" && btn_6.Text == "X" && btn_9.Text == "X")
            {
                btn_3.BackColor = Color.Violet;
                btn_6.BackColor = Color.Violet;
                btn_9.BackColor = Color.Violet;

                MessageBox.Show("The winner is Player X!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_4.Text == "X" && btn_5.Text == "X" && btn_6.Text == "X")
            {
                btn_4.BackColor = Color.DarkSlateBlue;
                btn_5.BackColor = Color.DarkSlateBlue;
                btn_6.BackColor = Color.DarkSlateBlue;

                MessageBox.Show("The winner is Player X!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_7.Text == "X" && btn_8.Text == "X" && btn_9.Text == "X")
            {
                btn_7.BackColor = Color.Azure;
                btn_8.BackColor = Color.Azure;
                btn_9.BackColor = Color.Azure;

                MessageBox.Show("The winner is Player X!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerX.Text);
                lblPlayerX.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            //=================================================================================================================================
            //=================================================================================================================================

            if (btn_1.Text == "O" && btn_2.Text == "O" && btn_3.Text == "O")
            {
                btn_1.BackColor = Color.AliceBlue;
                btn_2.BackColor = Color.AliceBlue;
                btn_3.BackColor = Color.AliceBlue;

                MessageBox.Show("The winner is Player O!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_1.Text == "O" && btn_4.Text == "O" && btn_7.Text == "O")
            {
                btn_1.BackColor = Color.LemonChiffon;
                btn_4.BackColor = Color.LemonChiffon;
                btn_7.BackColor = Color.LemonChiffon;

                MessageBox.Show("The winner is Player O!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_1.Text == "O" && btn_5.Text == "O" && btn_9.Text == "O")
            {
                btn_1.BackColor = Color.BlueViolet;
                btn_5.BackColor = Color.BlueViolet;
                btn_9.BackColor = Color.BlueViolet;

                MessageBox.Show("The winner is Player O!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_2.Text == "O" && btn_5.Text == "O" && btn_8.Text == "O")
            {
                btn_2.BackColor = Color.NavajoWhite;
                btn_5.BackColor = Color.NavajoWhite;
                btn_8.BackColor = Color.NavajoWhite;

                MessageBox.Show("The winner is Player O!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_3.Text == "O" && btn_5.Text == "O" && btn_7.Text == "O")
            {
                btn_3.BackColor = Color.SandyBrown;
                btn_5.BackColor = Color.SandyBrown;
                btn_7.BackColor = Color.SandyBrown;

                MessageBox.Show("The winner is Player O!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_3.Text == "O" && btn_6.Text == "O" && btn_9.Text == "O")
            {
                btn_3.BackColor = Color.SeaGreen;
                btn_6.BackColor = Color.SeaGreen;
                btn_9.BackColor = Color.SeaGreen;

                MessageBox.Show("The winner is Player O!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_4.Text == "O" && btn_5.Text == "O" && btn_6.Text == "O")
            {
                btn_4.BackColor = Color.Aqua;
                btn_5.BackColor = Color.Aqua;
                btn_6.BackColor = Color.Aqua;

                MessageBox.Show("The winner is Player O!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }

            if (btn_7.Text == "O" && btn_8.Text == "O" && btn_9.Text == "O")
            {
                btn_7.BackColor = Color.DarkBlue;
                btn_8.BackColor = Color.DarkBlue;
                btn_9.BackColor = Color.DarkBlue;

                MessageBox.Show("The winner is Player O!", "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
                plusone = int.Parse(lblPlayerO.Text);
                lblPlayerO.Text = Convert.ToString(plusone + 1);
                Enable_False();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_1.Text = "X";
                checker = true;
            }
            else
            {
                btn_1.Text = "O";
                checker = false;
            }
            score();
            btn_1.Enabled = false;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_2.Text = "X";
                checker = true;
            }
            else
            {
                btn_2.Text = "O";
                checker = false;
            }
            score();
            btn_2.Enabled = false;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_3.Text = "X";
                checker = true;
            }
            else
            {
                btn_3.Text = "O";
                checker = false;
            }
            score();
            btn_3.Enabled = false;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_4.Text = "X";
                checker = true;
            }
            else
            {
                btn_4.Text = "O";
                checker = false;
            }
            score();
            btn_4.Enabled = false;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_5.Text = "X";
                checker = true;
            }
            else
            {
                btn_5.Text = "O";
                checker = false;
            }
            score();
            btn_5.Enabled = false;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_6.Text = "X";
                checker = true;
            }
            else
            {
                btn_6.Text = "O";
                checker = false;
            }
            score();
            btn_6.Enabled = false;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_7.Text = "X";
                checker = true;
            }
            else
            {
                btn_7.Text = "O";
                checker = false;
            }
            score();
            btn_7.Enabled = false;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_8.Text = "X";
                checker = true;
            }
            else
            {
                btn_8.Text = "O";
                checker = false;
            }
            score();
            btn_8.Enabled = false;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (checker == false)
            {
                btn_9.Text = "X";
                checker = true;
            }
            else
            {
                btn_9.Text = "O";
                checker = false;
            }
            score();
            btn_9.Enabled = false;
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            try
            {
                btn_1.Enabled = true;
                btn_2.Enabled = true;
                btn_3.Enabled = true;
                btn_4.Enabled = true;
                btn_5.Enabled = true;
                btn_6.Enabled = true;
                btn_7.Enabled = true;
                btn_8.Enabled = true;
                btn_9.Enabled = true;

                btn_1.Text = "";
                btn_2.Text = "";
                btn_3.Text = "";
                btn_4.Text = "";
                btn_5.Text = "";
                btn_6.Text = "";
                btn_7.Text = "";
                btn_8.Text = "";
                btn_9.Text = "";

                lblPlayerX.Text = "0";
                lblPlayerO.Text = "0";

                btn_1.BackColor = Color.WhiteSmoke;
                btn_2.BackColor = Color.WhiteSmoke;
                btn_3.BackColor = Color.WhiteSmoke;
                btn_4.BackColor = Color.WhiteSmoke;
                btn_5.BackColor = Color.WhiteSmoke;
                btn_6.BackColor = Color.WhiteSmoke;
                btn_7.BackColor = Color.WhiteSmoke;
                btn_8.BackColor = Color.WhiteSmoke;
                btn_9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            try
            {
                btn_1.Enabled = true;
                btn_2.Enabled = true;
                btn_3.Enabled = true;
                btn_4.Enabled = true;
                btn_5.Enabled = true;
                btn_6.Enabled = true;
                btn_7.Enabled = true;
                btn_8.Enabled = true;
                btn_9.Enabled = true;

                btn_1.Text = "";
                btn_2.Text = "";
                btn_3.Text = "";
                btn_4.Text = "";
                btn_5.Text = "";
                btn_6.Text = "";
                btn_7.Text = "";
                btn_8.Text = "";
                btn_9.Text = "";

                btn_NewGame.Enabled = true;

                btn_1.BackColor = Color.WhiteSmoke;
                btn_2.BackColor = Color.WhiteSmoke;
                btn_3.BackColor = Color.WhiteSmoke;
                btn_4.BackColor = Color.WhiteSmoke;
                btn_5.BackColor = Color.WhiteSmoke;
                btn_6.BackColor = Color.WhiteSmoke;
                btn_7.BackColor = Color.WhiteSmoke;
                btn_8.BackColor = Color.WhiteSmoke;
                btn_9.BackColor = Color.WhiteSmoke;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iExit;
                iExit = MessageBox.Show("Är du säker på att du vill avsluta?", "Luffarschack", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Luffarschack", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
