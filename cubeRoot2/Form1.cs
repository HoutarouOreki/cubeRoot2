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
        int comboStreak, cubed1, cubed2, cubed3, cubed4, cubed5, befCube1, befCube2, befCube3, befCube4, befCube5, level, fullTime, score, topScore;
        double timeLeft, maxTime, addedScore, maxScore, scoreDiffTimer;

        private void Timer2_Tick(object sender, EventArgs e)
        {
            if (scoreDiffTimer > 0)
            {
                scoreDiffTimer--;
                if (scoreDiffTimer == 19)
                    scoreDiffLabel.BackColor = DefaultBackColor;
            }
            else if (scoreDiffTimer == 0)
                scoreDiffLabel.Visible = false;
        }

        private void GameQuit_Click(object sender, EventArgs e)
        {
            Close();
            CubeMenu cubeMenu = new CubeMenu();
            cubeMenu.Show();
        }

        bool firstTime = true;
        int lives = 3;
        
        private void Answer3_ValueChanged(object sender, EventArgs e)
        {
            if (befCube3 == answer3.Value)
            {
                answer3.Enabled = false;
                AddScore();
            }
        }

        private void Answer4_ValueChanged(object sender, EventArgs e)
        {
            if (befCube4 == answer4.Value)
            {
                answer4.Enabled = false;
                AddScore();
            }
        }

        private void Answer5_ValueChanged(object sender, EventArgs e)
        {
            if (befCube5 == answer5.Value)
            {
                answer5.Enabled = false;
                AddScore();
            }
        }

        private void Answer2_ValueChanged(object sender, EventArgs e)
        {
            if (befCube2 == answer2.Value)
            {
                answer2.Enabled = false;
                AddScore();
            }
        }

        private void Answer1_ValueChanged(object sender, EventArgs e)
        {
            if (befCube1 == answer1.Value)
            {
                answer1.Enabled = false;
                AddScore();
            }
        }

        private void Answer_Enter(object sender, EventArgs e)
        {

            if (sender is NumericUpDown answerBox)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        public Form1()
        {
            InitializeComponent();
            livesVal.Text = lives.ToString();
        }

        public void AddScore()
        {
            if (level != 22)
            {
                addedScore = ((Math.Pow((level + 1), 2)) * (timeLeft / maxTime) + 1);
                maxScore = Math.Pow(level + 1, 2);
            }
            else
            {
                addedScore = ((Math.Pow(23, 2) * (timeLeft / 10)) + (Math.Pow(comboStreak, 3) * (timeLeft / 10)));
                maxScore = Math.Pow(23, 2) + Math.Pow(comboStreak, 3);
            }
            score += (int)addedScore;
            if (score > topScore)
            {
                topScore = score;
                hiScoreVal.Text = topScore.ToString();
            }
            scoreVal.Text = score.ToString();
            Debug.WriteLine("Added " + ((int)addedScore).ToString() + "/" + ((int)maxScore).ToString());
            ScoreDiff();
            //dodgerBlue, lightGreen
        }

        public void ScoreDiff()
        {
            scoreDiffTimer = 21;
            scoreDiffLabel.Text = "+" + ((int)addedScore).ToString();
            scoreDiffLabel.BackColor = Color.LightCyan;
            if (addedScore >= maxScore * 0.8)
                scoreDiffLabel.ForeColor = Color.DodgerBlue;
            else if (addedScore >= maxScore * 0.5)
                scoreDiffLabel.ForeColor = Color.LimeGreen;
            else if (addedScore >= maxScore * 0.2)
                scoreDiffLabel.ForeColor = Color.Goldenrod;
            else
                scoreDiffLabel.ForeColor = Color.DarkGray;
            scoreDiffLabel.Visible = true;
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

        private void StartButton_Click(object sender, EventArgs e)
        {
            startButton.Enabled = false;
            gameQuit.TabStop = false;
            StartTheQuiz();
            answer1.Focus();
            timeLeft = 120 - level * 5;
            maxTime = timeLeft;
            fullTime = (int)timeLeft;
            timer1.Start();
            timeLeftVar.ForeColor = Color.SteelBlue;
            timeLeftVar.Text = timeLeft.ToString();
            levelVar.Text = (level + 1).ToString();
            livesVal.Text = lives.ToString();
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
                gameQuit.TabIndex = 1;
                startButton.Enabled = true;
                gameQuit.TabStop = true;
                return true;
            }
            else
                return false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
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
                    comboStreak++;
                    comboVal.Text = comboStreak.ToString();
                }
                else
                {
                    startButton.Text = "Regenerate";
                    comboStreak++;
                    comboVal.Text = comboStreak.ToString();
                }
                if (level != 22)
                {

                }
                else if (firstTime == false)
                {
                }
                else
                {
                    MessageBox.Show("You have reached level 23. You will score points every time you finish in time. But once you fail, the game is over.");
                    firstTime = false;
                    comboVal.Text = comboStreak.ToString();
                }
                startButton.Focus();
                gameQuit.TabIndex = 1;
                startButton.Enabled = true;
                gameQuit.TabStop = true;
            }
            else if (timeLeft > 0)
            {
                timeLeft -= 0.1;
                timeLeftVar.Text = ((int)timeLeft).ToString();
            }
            else
            {
                timer1.Stop();
                lives--;
                comboStreak = 0;
                comboVal.Text = comboStreak.ToString();
                livesVal.Text = lives.ToString();
                gameQuit.TabIndex = 1;
                startButton.Enabled = true;
                gameQuit.TabStop = true;
                timeLeftVar.Text = "0";
                if (lives == 0)
                {
                    MessageBox.Show("Game over. You've scored " + score.ToString() + " points.");
                    score = 0;
                    scoreVal.Text = score.ToString();
                    level = 0;
                    levelVar.Text = level.ToString();
                    lives = 3;
                    startButton.Text = "Restart (level 1)";
                }
                else if (level != 22)
                    startButton.Text = "Generate level " + (level + 1).ToString();
                else if (level == 22)
                    startButton.Text = "Regenerate";
                answer1.Value = befCube1;
                answer2.Value = befCube2;
                answer3.Value = befCube3;
                answer4.Value = befCube4;
                answer5.Value = befCube5;
            }
        }
    }
}
