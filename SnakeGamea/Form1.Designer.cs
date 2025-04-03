namespace SnakeGamea
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            picCanvas = new PictureBox();
            txtScore = new Label();
            label2 = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            txtHighscore = new Label();
            btnStart = new Button();
            ((System.ComponentModel.ISupportInitialize)picCanvas).BeginInit();
            SuspendLayout();
            // 
            // picCanvas
            // 
            picCanvas.BackColor = SystemColors.ControlDark;
            picCanvas.Location = new Point(154, 50);
            picCanvas.Name = "picCanvas";
            picCanvas.Size = new Size(488, 503);
            picCanvas.TabIndex = 0;
            picCanvas.TabStop = false;
            picCanvas.Click += picCanvas_Click;
            picCanvas.Paint += updateGraphics;
            // 
            // txtScore
            // 
            txtScore.AutoSize = true;
            txtScore.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.Location = new Point(665, 13);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(67, 25);
            txtScore.TabIndex = 1;
            txtScore.Text = "Score:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(726, 13);
            label2.Name = "label2";
            label2.Size = new Size(34, 25);
            label2.TabIndex = 2;
            label2.Text = "00";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Tick += gameTimer_Tick;
            // 
            // txtHighscore
            // 
            txtHighscore.AutoSize = true;
            txtHighscore.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHighscore.Location = new Point(510, 9);
            txtHighscore.Name = "txtHighscore";
            txtHighscore.Size = new Size(107, 25);
            txtHighscore.TabIndex = 3;
            txtHighscore.Text = "Highscore:";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(726, 519);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 615);
            Controls.Add(btnStart);
            Controls.Add(txtHighscore);
            Controls.Add(label2);
            Controls.Add(txtScore);
            Controls.Add(picCanvas);
            Name = "Form1";
            Text = "Snake Game";
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)picCanvas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picCanvas;
        private Label txtScore;
        private Label label2;
        private System.Windows.Forms.Timer gameTimer;
        private Label txtHighscore;
        private Button btnStart;
    }
}
