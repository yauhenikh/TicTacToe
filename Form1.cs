using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public enum Player
        {
            X, O
        }

        Player currentPlayer;
        List<Button> buttons;
        Random rand = new Random();

        bool playVsPlayer = true;
        bool playVsComputer = false;

        public int turns = 0;
        public int s1 = 0;
        public int s2 = 0;
        public int sd = 0;

        public Form1()
        {
            InitializeComponent();
            ResetGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (playVsPlayer == true)
            {
                if (currentPlayer == Player.X)
                {
                    button.Enabled = false;
                    button.Text = "X";
                    button.BackColor = Color.PaleTurquoise;
                    buttons.Remove(button);
                    currentPlayer = Player.O;
                    turns++;
                }
                else
                {
                    button.Enabled = false;
                    button.Text = "O";
                    button.BackColor = Color.Bisque;
                    buttons.Remove(button);
                    currentPlayer = Player.X;
                    turns++;
                }

                if (CheckDraw() == true)
                {
                    MessageBox.Show("Tie Game!");
                    sd++;
                    NewGame();
                }

                if (CheckWinner() == true)
                {
                    if (button.Text == "X")
                    {
                        MessageBox.Show("X Won!");
                        s1++;
                        NewGame();
                    }
                    else
                    {
                        MessageBox.Show("O Won!");
                        s2++;
                        NewGame();
                    }
                }
            }

            if (playVsComputer == true)
            {
                currentPlayer = Player.X;
                button.Text = "X";
                button.Enabled = false;
                button.BackColor = Color.PaleTurquoise;
                buttons.Remove(button);
                turns++;

                if (CheckDraw() == true)
                {
                    AImoves.Stop();

                    MessageBox.Show("Tie Game!");
                    sd++;
                    NewGame();

                    return;
                }

                if (CheckWinner() == true)
                {
                    AImoves.Stop();

                    MessageBox.Show("X Won!");
                    s1++;
                    NewGame();
                    
                    return;
                }

                AImoves.Start();
            }
        }

        private void AImove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = "O";
                buttons[index].BackColor = Color.Bisque;
                turns++;

                if (CheckDraw() == true)
                {
                    AImoves.Stop();

                    MessageBox.Show("Tie Game!");
                    sd++;
                    NewGame();
                }

                if (CheckWinner() == true)
                {
                    AImoves.Stop();

                    MessageBox.Show("O Won!");
                    s2++;
                    NewGame();
                }

                buttons.RemoveAt(index);
                AImoves.Stop();
            }
        }

        private void NGButton_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void RButton_Click(object sender, EventArgs e)
        {
            s1 = s2 = sd = 0;
            NewGame();
        }

        private void PvP_Click(object sender, EventArgs e)
        {
            playVsComputer = false;
            playVsPlayer = true;
            s1 = s2 = sd = 0;
            NewGame();
        }

        private void PvE_Click(object sender, EventArgs e)
        {
            playVsPlayer = false;
            playVsComputer = true;
            s1 = s2 = sd = 0;
            NewGame();
        }

        private void EButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetGame()
        {
            foreach (Control control in Controls)
            {
                if (control is Button && control.Tag != null && control.Tag.ToString() == "play")
                {
                    ((Button)control).Enabled = true;
                    ((Button)control).Text = "";
                    ((Button)control).BackColor = default(Color);
                }
            }

            Loadbuttons();
        }

        private void Loadbuttons()
        {
            buttons = new List<Button> { A00, A01, A02, A10, A11, A12, A20, A21, A22 };
        }

        void NewGame()
        {
            ResetGame();
            currentPlayer = Player.X;
            turns = 0;
            XWin.Text = "X: " + s1;
            OWin.Text = "O: " + s2;
            Draws.Text = "Draws: " + sd;
        }

        bool CheckDraw()
        {
            if ((turns == 9) && (CheckWinner() == false))
                return true;
            else
                return false;
        }

        bool CheckWinner()
        {
            // horizontal checks
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && (A00.Text != ""))
                return true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && (A10.Text != ""))
                return true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && (A20.Text != ""))
                return true;

            // vertical checks
            if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && (A00.Text != ""))
                return true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && (A01.Text != ""))
                return true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && (A02.Text != ""))
                return true;

            // diagonal checks
            if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && (A00.Text != ""))
                return true;
            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && (A02.Text != ""))
                return true;
            else
                return false;
        }
    }
}
