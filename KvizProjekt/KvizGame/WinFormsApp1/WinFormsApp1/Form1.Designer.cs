namespace QuizGame
{
    partial class startLabel
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
            retryButton = new Button();
            scoreLabel = new Label();
            questionLabel = new Label();
            nextButton = new Button();
            questionNumberLabel = new Label();
            timerLabel = new Label();
            timeLabel = new Label();
            startButton = new Button();
            labels = new Label();
            RadioButton1 = new RadioButton();
            RadioButton2 = new RadioButton();
            RadioButton3 = new RadioButton();
            RadioButton4 = new RadioButton();
            vGroupBox = new GroupBox();
            vGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // retryButton
            // 
            retryButton.BackColor = SystemColors.Window;
            retryButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            retryButton.Location = new Point(595, 378);
            retryButton.Margin = new Padding(0);
            retryButton.Name = "retryButton";
            retryButton.Size = new Size(113, 37);
            retryButton.TabIndex = 1;
            retryButton.Text = "Újra";
            retryButton.UseVisualStyleBackColor = false;
            retryButton.Click += retryButton_Click;
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = SystemColors.InactiveBorder;
            scoreLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            scoreLabel.Location = new Point(77, 350);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(73, 25);
            scoreLabel.TabIndex = 2;
            scoreLabel.Text = "pontok";
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.BackColor = SystemColors.InactiveBorder;
            questionLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            questionLabel.Location = new Point(77, 84);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(40, 30);
            questionLabel.TabIndex = 3;
            questionLabel.Text = "???";
            // 
            // nextButton
            // 
            nextButton.BackColor = SystemColors.Window;
            nextButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            nextButton.ForeColor = SystemColors.ControlText;
            nextButton.Location = new Point(77, 349);
            nextButton.Margin = new Padding(0);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(113, 37);
            nextButton.TabIndex = 4;
            nextButton.Text = "Következő";
            nextButton.UseVisualStyleBackColor = false;
            nextButton.Click += nextButton_Click;
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.BackColor = SystemColors.InactiveBorder;
            questionNumberLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            questionNumberLabel.Location = new Point(577, 22);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(131, 25);
            questionNumberLabel.TabIndex = 5;
            questionNumberLabel.Text = "Kérdések: 0/0";
            // 
            // timerLabel
            // 
            timerLabel.AutoSize = true;
            timerLabel.BackColor = SystemColors.InactiveBorder;
            timerLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            timerLabel.Location = new Point(77, 22);
            timerLabel.Name = "timerLabel";
            timerLabel.Size = new Size(138, 25);
            timerLabel.TabIndex = 6;
            timerLabel.Text = "Hátlralévő idő:";
            // 
            // timeLabel
            // 
            timeLabel.AutoSize = true;
            timeLabel.BackColor = SystemColors.InactiveBorder;
            timeLabel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            timeLabel.Location = new Point(77, 400);
            timeLabel.Name = "timeLabel";
            timeLabel.Size = new Size(50, 25);
            timeLabel.TabIndex = 7;
            timeLabel.Text = "Idő: ";
            // 
            // startButton
            // 
            startButton.BackColor = SystemColors.Window;
            startButton.BackgroundImageLayout = ImageLayout.None;
            startButton.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 238);
            startButton.Location = new Point(279, 344);
            startButton.Name = "startButton";
            startButton.Size = new Size(189, 44);
            startButton.TabIndex = 8;
            startButton.Text = "Játék indítása";
            startButton.UseVisualStyleBackColor = false;
            // 
            // labels
            // 
            labels.AutoSize = true;
            labels.BackColor = SystemColors.InactiveBorder;
            labels.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            labels.Location = new Point(250, 82);
            labels.Name = "labels";
            labels.Size = new Size(282, 32);
            labels.TabIndex = 9;
            labels.Text = "TÖRTÉNELMI KVÍZ JÁTÉK";
            // 
            // RadioButton1
            // 
            RadioButton1.AutoSize = true;
            RadioButton1.Font = new Font("Segoe UI Semibold", 15.25F, FontStyle.Bold);
            RadioButton1.Location = new Point(25, 19);
            RadioButton1.Name = "RadioButton1";
            RadioButton1.Size = new Size(96, 34);
            RadioButton1.TabIndex = 0;
            RadioButton1.TabStop = true;
            RadioButton1.Text = "Válasz1";
            RadioButton1.UseVisualStyleBackColor = true;
            // 
            // RadioButton2
            // 
            RadioButton2.AutoSize = true;
            RadioButton2.Font = new Font("Segoe UI Semibold", 15.25F, FontStyle.Bold);
            RadioButton2.Location = new Point(25, 89);
            RadioButton2.Name = "RadioButton2";
            RadioButton2.Size = new Size(100, 34);
            RadioButton2.TabIndex = 1;
            RadioButton2.TabStop = true;
            RadioButton2.Text = "Válasz2";
            RadioButton2.UseVisualStyleBackColor = true;
            // 
            // RadioButton3
            // 
            RadioButton3.AutoSize = true;
            RadioButton3.Font = new Font("Segoe UI Semibold", 15.25F, FontStyle.Bold);
            RadioButton3.Location = new Point(367, 19);
            RadioButton3.Name = "RadioButton3";
            RadioButton3.Size = new Size(100, 34);
            RadioButton3.TabIndex = 2;
            RadioButton3.TabStop = true;
            RadioButton3.Text = "Válasz3";
            RadioButton3.UseVisualStyleBackColor = true;
            // 
            // RadioButton4
            // 
            RadioButton4.AutoSize = true;
            RadioButton4.Font = new Font("Segoe UI Semibold", 15.25F, FontStyle.Bold);
            RadioButton4.Location = new Point(366, 89);
            RadioButton4.Name = "RadioButton4";
            RadioButton4.Size = new Size(100, 34);
            RadioButton4.TabIndex = 3;
            RadioButton4.TabStop = true;
            RadioButton4.Text = "Válasz4";
            RadioButton4.UseVisualStyleBackColor = true;
            // 
            // vGroupBox
            // 
            vGroupBox.BackColor = SystemColors.InactiveBorder;
            vGroupBox.Controls.Add(RadioButton4);
            vGroupBox.Controls.Add(RadioButton3);
            vGroupBox.Controls.Add(RadioButton2);
            vGroupBox.Controls.Add(RadioButton1);
            vGroupBox.FlatStyle = FlatStyle.System;
            vGroupBox.Location = new Point(77, 160);
            vGroupBox.Margin = new Padding(0);
            vGroupBox.Name = "vGroupBox";
            vGroupBox.Padding = new Padding(0);
            vGroupBox.Size = new Size(631, 132);
            vGroupBox.TabIndex = 0;
            vGroupBox.TabStop = false;
            // 
            // startLabel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(784, 461);
            Controls.Add(labels);
            Controls.Add(startButton);
            Controls.Add(timeLabel);
            Controls.Add(timerLabel);
            Controls.Add(questionNumberLabel);
            Controls.Add(nextButton);
            Controls.Add(questionLabel);
            Controls.Add(scoreLabel);
            Controls.Add(retryButton);
            Controls.Add(vGroupBox);
            Name = "startLabel";
            Text = "Form1";
            vGroupBox.ResumeLayout(false);
            vGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button retryButton;
        private Label scoreLabel;
        private Label questionLabel;
        private Button nextButton;
        private Label questionNumberLabel;
        private Label timerLabel;
        private Label timeLabel;
        private Button startButton;
        private Label labels;
        private RadioButton RadioButton1;
        private RadioButton RadioButton2;
        private RadioButton RadioButton3;
        private RadioButton RadioButton4;
        private GroupBox vGroupBox;
    }
}
