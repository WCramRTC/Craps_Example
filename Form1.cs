using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Craps_Example
{
    public partial class Form1 : Form
    {
        Random dice = new Random();
        int currentBalance;
        int currentPoint;
        int bet;
        int placedBet;

        // true is round 1, false is round 2
        bool turn = true;
        bool roundOver = true;

        const int startingBalance = 500;

        public Form1()
        {
            InitializeComponent();
            Restart();
        } // Form1

        private void btnRoll_Click(object sender, EventArgs e)
        {
            if(ValidateRoll())
            {
                if (roundOver)
                {
                    placedBet = bet;
                    currentBalance -= placedBet;
                    lblBet.Text = $"Bet - {placedBet}";
                    rtbDisplay.Text += $"Round 1! Good Luck\n";
                    roundOver = false;
                }

                Round(diceRoll());

                // Special Code - Auto Scrolls to bottom of rich text box
                rtbDisplay.SelectionStart = rtbDisplay.Text.Length;
                rtbDisplay.ScrollToCaret();
            }
        } // btnRoll_Click

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if(bet > 0)
            {
                bet -= 5;
                UpdateDisplay();
            }

        } // btnDecrease_Click

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if(bet < currentBalance)
            {
                bet += 5;
                UpdateDisplay();
            }


        } // btnIncrease_Click

        public bool ValidateRoll()
        {
            bool validRoll = true;

            if(bet <= 0)
            {
                validRoll = false;
                MessageBox.Show("Enter A Valid Bet");
            }

            return validRoll;
        }

        public int diceRoll()
        {
            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            rtbDisplay.Text += $"Dice 1: {roll1}\nDice 2: {roll2}\nTotal: {roll1 + roll2}\n";
            return roll1 + roll2;

        }

        // Game Rules
        //An even money bet, made on the first roll of the dice(known as the “come out roll”).
        //You win if a 7 or 11 roll, or lose if 2, 3, or 12 roll(known as “craps”). Any other number
        //that rolls becomes the “point” and the point must roll again before a 7 to win.

        public void Round(int roll)
        {
            if (turn) round1(roll);
            else round2(roll);
            UpdateDisplay();
        } // Round()

        public void round1(int roll)
        {
            
            switch (roll)
            {
                // Win
                case 7:
                case 11:              
                    YouWin();
                break;
                    // Lose
                case 2:
                case 3:
                case 12:
                    YouLose();
                    break;
                    // Turn Two
                default:
                    turn = false;
                    currentPoint = roll;
                    rtbDisplay.Text += $"Round 2! Current poins - {currentPoint}\n";
                    break;

            }
        } // round1()

        public void round2(int roll)
        {
            if(roll == currentPoint)
            {
                YouWin();
            }
            else if(roll == 7)
            {
                YouLose();
            }
        } // round1()

        public void NewRound()
        {
            rtbDisplay.Text += "New Round! Place you bets!\n";
            turn = true;
            roundOver = true;
        } // StartOver()


        public void Restart()
        {
            bet = 0;
            turn = true;
            currentBalance = startingBalance;
            UpdateDisplay();
        } // Restart()

        public void UpdateDisplay()
        {
            disBet.Text = bet.ToString();

            if (turn) disTurn.Text = "1";
            else disTurn.Text = "2";

            disPoint.Text = currentPoint.ToString();
            
            disAmount.Text = currentBalance.ToString();

        } // UpdateDisplay

        public void YouWin()
        {
            currentBalance += placedBet * 2;
            rtbDisplay.Text += "Win!!\n";
            NewRound();
        } // YouWinText

        public void YouLose()
        {
            rtbDisplay.Text += "Lose :(\n";
            NewRound();

        } // YouLoseText

        private void btnReset_Click(object sender, EventArgs e)
        {
            Restart();
        } // btnReset_Click()
    } // Form1
} // namespace
