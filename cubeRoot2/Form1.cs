using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cubeRoot2
{
    public partial class Form1 : Form
    {
        Random randomizer = new Random();
        int cubed1, cubed2, cubed3, cubed4, cubed5, befCube1, befCube2, befCube3, befCube4, befCube5, level, fullTime, score;
        double timeLeft;
        bool firstTime = true;
        bool afterFail = false;
        
        private void answer3_ValueChanged(object sender, EventArgs e)
        {
            if (befCube3 == answer3.Value)
                answer3.Enabled = false;
        }

        private void answer4_ValueChanged(object sender, EventArgs e)
        {
            if (befCube4 == answer4.Value)
                answer4.Enabled = false;
        }

        private void answer5_ValueChanged(object sender, EventArgs e)
        {
            if (befCube5 == answer5.Value)
                answer5.Enabled = false;
        }

        private void answer2_ValueChanged(object sender, EventArgs e)
        {
            if (befCube2 == answer2.Value)
                answer2.Enabled = false;
        }

        private void answer1_ValueChanged(object sender, EventArgs e)
        {
            if (befCube1 == answer1.Value)
                answer1.Enabled = false;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void StartTheQuiz()
        {
            befCube1 = randomizer.Next(11, 100);
            Debug.WriteLine("\n1 = " + befCube1.ToString());
            befCube2 = randomizer.Next(11, 100);
            Debug.WriteLine("2 = " + befCube2.ToString());
            befCube3 = randomizer.Next(11, 100);
            Debug.WriteLine("3 = " + befCube3.ToString());
            befCube4 = randomizer.Next(11, 100);
            Debug.WriteLine("4 = " + befCube4.ToString());
            befCube5 = randomizer.Next(11, 100);
            Debug.WriteLine("5 = " + befCube5.ToString());
            cubed1 = (int)Math.Pow(befCube1, 3);
            cubed2 = (int)Math.Pow(befCube2, 3);
            cubed3 = (int)Math.Pow(befCube3, 3);
            cubed4 = (int)Math.Pow(befCube4, 3);
            cubed5 = (int)Math.Pow(befCube5, 3);

            cubedLabel1.Text = cubed1.ToString();
            cubedLabel2.Text = cubed2.ToString();
            cubedLabel3.Text = cubed3.ToString();
            cubedLabel4.Text = cubed4.ToString();
            cubedLabel5.Text = cubed5.ToString();

            answer1.Value = 0;
            answer2.Value = 0;
            answer3.Value = 0;
            answer4.Value = 0;
            answer5.Value = 0;

            answer1.Enabled = true;
            answer2.Enabled = true;
            answer3.Enabled = true;
            answer4.Enabled = true;
            answer5.Enabled = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
            timeLeft = 120 - level * 5;
            fullTime = (int)timeLeft;
            timer1.Start();
            timeLeftVar.ForeColor = Color.SteelBlue;
            timeLeftVar.Text = timeLeft.ToString();
            levelVar.Text = (level + 1).ToString();
        }

        private bool CheckAnswers()
        {
            if (
                (befCube1 == answer1.Value)
                && (befCube2 == answer2.Value)
                && (befCube3 == answer3.Value)
                && (befCube4 == answer4.Value)
                && (befCube5 == answer5.Value)
                )
            {
                startButton.Enabled = true;
                return true;
            }
            else
                return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft <= fullTime * 0.6 && timeLeft > fullTime * 0.3)
                timeLeftVar.ForeColor = Color.Orange;
            else if (timeLeft <= fullTime * 0.3 && timeLeft > 0)
                timeLeftVar.ForeColor = Color.Red;
            if (CheckAnswers())
            {
                timer1.Stop();
                if (level != 22)
                {
                    level++;
                    startButton.Text = "Generate level " + (level + 1).ToString();
                }
                else
                    startButton.Text = "Regenerate";
                if (level != 22)
                    MessageBox.Show("You have successfully completed level " + (level).ToString());
                else if (firstTime == false)
                {
                    score++;
                    scoreVal.Text = score.ToString();
                }
                else
                {
                    MessageBox.Show("You have reached level 23. You will score points every time you finish in time. But once you fail, the game is over.");
                    score = 0;
                    scoreText.Visible = true;
                    scoreVal.Visible = true;
                    firstTime = false;
                    scoreVal.Text = score.ToString();
                }
                startButton.Focus();
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft -= 0.1;
                timeLeftVar.Text = ((int)timeLeft).ToString();
            }
            else
            {
                timer1.Stop();
                startButton.Enabled = true;
                timeLeftVar.Text = "0";
                if (level > 0 && level <= 4)
                    level = 0;
                else if (level > 4 && level < 22)
                    level -= 5;
                else if (level == 22)
                {
                    MessageBox.Show("You scored " + score.ToString());
                    level = 0;
                    afterFail = true;
                    scoreText.Visible = false;
                    scoreVal.Visible = false;
                };
                if (level != 22)
                    startButton.Text = "Generate level " + (level + 1).ToString();
                else if (level == 22)
                    startButton.Text = "Regenerate";
                if (afterFail != true)
                {
                    MessageBox.Show("You have failed to finish in time");
                }
                else
                    afterFail = false;
                answer1.Value = befCube1;
                answer2.Value = befCube2;
                answer3.Value = befCube3;
                answer4.Value = befCube4;
                answer5.Value = befCube5;
            }
        }
    }
}
