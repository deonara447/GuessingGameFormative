using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameFormative
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        int playerGuess;
        int correctNumber;
        //int difference;
        //int numAbsolute


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            correctNumber = randGen.Next(1, 101);
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            
            playerGuess = Convert.ToInt32(numberInput.Text);
            //difference = correctNumber - playerGuess;
            //numAbsolute = Math.Abs(difference);


            if (playerGuess < correctNumber)
            {
                hintLabel.Text = "Too Low";
            }

            if (playerGuess > correctNumber)
            {
                hintLabel.Text = "Too High";
            }

            if (playerGuess == correctNumber)
            {
                hintLabel.Text = "You got it!";
            }
            //
        }
    }
}
