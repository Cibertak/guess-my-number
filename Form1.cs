using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace geuss_my_number
{
    public partial class Form1 : Form
    {
        int number;
        int guess;
        int count;
        Random R_ran = new Random();
        public Form1()
        {
            InitializeComponent();
            number = R_ran.Next(1, 100);
            count = 10;
        }

        private void geuss_Click(object sender, EventArgs e)
        {
            guess = Convert.ToInt32(tbox_guess.Text);
            
            if(guess == number)
            {
                Lb_output.Text = "That is correct.";
            }
            else if (guess > number)
            {
                Lb_output.Text = "That is too high.";
                count--;
                lb_left.Text = "Guess left: " + Convert.ToString(count);
                losecheck();
            }
            else if (guess < number)
            {
                Lb_output.Text = "That is too low.";
                count--;
                lb_left.Text = "Guess left: " + Convert.ToString(count);
                losecheck();
            }


        }
        private void losecheck()
        {
            if (count == 0)
            {
                DialogResult dialogResult = MessageBox.Show("game over, would you like to play again?", "game over", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    number = R_ran.Next(1, 100);
                    count = 10;
                    Lb_output.Text = "guess my new number";
                    lb_left.Text = "Guess left: " + Convert.ToString(count);
                }
                else if (dialogResult == DialogResult.No)
                {
                    Application.Exit();
                }
            }
        }
    }
}
