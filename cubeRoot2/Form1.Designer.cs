namespace cubeRoot2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeLeftVar = new System.Windows.Forms.Label();
            this.cubedLabel1 = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.NumericUpDown();
            this.answer2 = new System.Windows.Forms.NumericUpDown();
            this.answer3 = new System.Windows.Forms.NumericUpDown();
            this.answer4 = new System.Windows.Forms.NumericUpDown();
            this.answer5 = new System.Windows.Forms.NumericUpDown();
            this.startButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cubedLabel2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cubedLabel3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cubedLabel4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cubedLabel5 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.levelVar = new System.Windows.Forms.Label();
            this.scoreVal = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.livesVal = new System.Windows.Forms.Label();
            this.livesText = new System.Windows.Forms.Label();
            this.comboVal = new System.Windows.Forms.Label();
            this.comboText = new System.Windows.Forms.Label();
            this.levelText = new System.Windows.Forms.Label();
            this.hiScoreVal = new System.Windows.Forms.Label();
            this.hiScoreText = new System.Windows.Forms.Label();
            this.scoreText = new System.Windows.Forms.Label();
            this.scoreDiffLabel = new System.Windows.Forms.Label();
            this.gameQuit = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.answer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer5)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeLeftVar
            // 
            this.timeLeftVar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.timeLeftVar, "timeLeftVar");
            this.timeLeftVar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.timeLeftVar.Name = "timeLeftVar";
            // 
            // cubedLabel1
            // 
            resources.ApplyResources(this.cubedLabel1, "cubedLabel1");
            this.cubedLabel1.Name = "cubedLabel1";
            // 
            // answer1
            // 
            resources.ApplyResources(this.answer1, "answer1");
            this.answer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.answer1.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.answer1.Name = "answer1";
            this.answer1.ValueChanged += new System.EventHandler(this.Answer1_ValueChanged);
            this.answer1.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // answer2
            // 
            resources.ApplyResources(this.answer2, "answer2");
            this.answer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.answer2.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.answer2.Name = "answer2";
            this.answer2.ValueChanged += new System.EventHandler(this.Answer2_ValueChanged);
            this.answer2.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // answer3
            // 
            resources.ApplyResources(this.answer3, "answer3");
            this.answer3.Cursor = System.Windows.Forms.Cursors.Default;
            this.answer3.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.answer3.Name = "answer3";
            this.answer3.ValueChanged += new System.EventHandler(this.Answer3_ValueChanged);
            this.answer3.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // answer4
            // 
            resources.ApplyResources(this.answer4, "answer4");
            this.answer4.Cursor = System.Windows.Forms.Cursors.Default;
            this.answer4.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.answer4.Name = "answer4";
            this.answer4.ValueChanged += new System.EventHandler(this.Answer4_ValueChanged);
            this.answer4.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // answer5
            // 
            resources.ApplyResources(this.answer5, "answer5");
            this.answer5.Cursor = System.Windows.Forms.Cursors.Default;
            this.answer5.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.answer5.Name = "answer5";
            this.answer5.ValueChanged += new System.EventHandler(this.Answer5_ValueChanged);
            this.answer5.Enter += new System.EventHandler(this.Answer_Enter);
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // cubedLabel2
            // 
            resources.ApplyResources(this.cubedLabel2, "cubedLabel2");
            this.cubedLabel2.Name = "cubedLabel2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cubedLabel3
            // 
            resources.ApplyResources(this.cubedLabel3, "cubedLabel3");
            this.cubedLabel3.Name = "cubedLabel3";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // cubedLabel4
            // 
            resources.ApplyResources(this.cubedLabel4, "cubedLabel4");
            this.cubedLabel4.Name = "cubedLabel4";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // cubedLabel5
            // 
            resources.ApplyResources(this.cubedLabel5, "cubedLabel5");
            this.cubedLabel5.Name = "cubedLabel5";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // levelVar
            // 
            this.levelVar.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.levelVar, "levelVar");
            this.levelVar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.levelVar.Name = "levelVar";
            // 
            // scoreVal
            // 
            this.scoreVal.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.scoreVal, "scoreVal");
            this.scoreVal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.scoreVal.Name = "scoreVal";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.livesVal, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.livesText, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.comboVal, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboText, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.levelText, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.hiScoreVal, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.levelVar, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.scoreVal, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.hiScoreText, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.scoreText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.scoreDiffLabel, 0, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // livesVal
            // 
            this.livesVal.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.livesVal, "livesVal");
            this.livesVal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.livesVal.Name = "livesVal";
            // 
            // livesText
            // 
            resources.ApplyResources(this.livesText, "livesText");
            this.livesText.Name = "livesText";
            // 
            // comboVal
            // 
            this.comboVal.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.comboVal, "comboVal");
            this.comboVal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboVal.Name = "comboVal";
            // 
            // comboText
            // 
            resources.ApplyResources(this.comboText, "comboText");
            this.comboText.Name = "comboText";
            // 
            // levelText
            // 
            resources.ApplyResources(this.levelText, "levelText");
            this.levelText.Name = "levelText";
            // 
            // hiScoreVal
            // 
            this.hiScoreVal.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.hiScoreVal, "hiScoreVal");
            this.hiScoreVal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hiScoreVal.Name = "hiScoreVal";
            // 
            // hiScoreText
            // 
            resources.ApplyResources(this.hiScoreText, "hiScoreText");
            this.hiScoreText.Name = "hiScoreText";
            // 
            // scoreText
            // 
            resources.ApplyResources(this.scoreText, "scoreText");
            this.scoreText.Name = "scoreText";
            // 
            // scoreDiffLabel
            // 
            resources.ApplyResources(this.scoreDiffLabel, "scoreDiffLabel");
            this.scoreDiffLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.scoreDiffLabel.Name = "scoreDiffLabel";
            // 
            // gameQuit
            // 
            resources.ApplyResources(this.gameQuit, "gameQuit");
            this.gameQuit.Name = "gameQuit";
            this.gameQuit.UseVisualStyleBackColor = true;
            this.gameQuit.Click += new System.EventHandler(this.GameQuit_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.timeLeftVar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cubedLabel1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label9, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.cubedLabel2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label6, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.cubedLabel5, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.cubedLabel3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.cubedLabel4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.answer5, 2, 5);
            this.tableLayoutPanel2.Controls.Add(this.answer4, 2, 4);
            this.tableLayoutPanel2.Controls.Add(this.answer2, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.answer3, 2, 3);
            this.tableLayoutPanel2.Controls.Add(this.answer1, 2, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.gameQuit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.answer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.answer5)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLeftVar;
        private System.Windows.Forms.Label cubedLabel1;
        private System.Windows.Forms.NumericUpDown answer1;
        private System.Windows.Forms.NumericUpDown answer2;
        private System.Windows.Forms.NumericUpDown answer3;
        private System.Windows.Forms.NumericUpDown answer4;
        private System.Windows.Forms.NumericUpDown answer5;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cubedLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cubedLabel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cubedLabel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cubedLabel5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label levelVar;
        private System.Windows.Forms.Label scoreVal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label levelText;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label hiScoreVal;
        private System.Windows.Forms.Label hiScoreText;
        private System.Windows.Forms.Button gameQuit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label livesVal;
        private System.Windows.Forms.Label livesText;
        private System.Windows.Forms.Label comboVal;
        private System.Windows.Forms.Label comboText;
        private System.Windows.Forms.Label scoreDiffLabel;
        private System.Windows.Forms.Timer timer2;
    }
}

