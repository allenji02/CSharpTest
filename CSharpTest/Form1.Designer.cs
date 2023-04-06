namespace CSharpTest
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
            outputTextBox = new TextBox();
            mp3Button = new Button();
            aviButton = new Button();
            preButton = new Button();
            stopButton = new Button();
            playButton = new Button();
            pauseButton = new Button();
            nextButton = new Button();
            SuspendLayout();
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(289, 114);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(205, 30);
            outputTextBox.TabIndex = 0;
            // 
            // mp3Button
            // 
            mp3Button.Location = new Point(114, 112);
            mp3Button.Name = "mp3Button";
            mp3Button.Size = new Size(112, 34);
            mp3Button.TabIndex = 1;
            mp3Button.Text = "MP3";
            mp3Button.UseVisualStyleBackColor = true;
            mp3Button.Click += mp3Button_Click;
            // 
            // aviButton
            // 
            aviButton.Location = new Point(568, 112);
            aviButton.Name = "aviButton";
            aviButton.Size = new Size(112, 34);
            aviButton.TabIndex = 2;
            aviButton.Text = "AVI";
            aviButton.UseVisualStyleBackColor = true;
            aviButton.Click += aviButton_Click;
            // 
            // preButton
            // 
            preButton.Location = new Point(49, 234);
            preButton.Name = "preButton";
            preButton.Size = new Size(112, 34);
            preButton.TabIndex = 3;
            preButton.Text = "上一首";
            preButton.UseVisualStyleBackColor = true;
            preButton.Click += preButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(203, 234);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(112, 34);
            stopButton.TabIndex = 4;
            stopButton.Text = "停止";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // playButton
            // 
            playButton.Location = new Point(345, 234);
            playButton.Name = "playButton";
            playButton.Size = new Size(112, 34);
            playButton.TabIndex = 5;
            playButton.Text = "播放";
            playButton.UseVisualStyleBackColor = true;
            playButton.Click += playButton_Click;
            // 
            // pauseButton
            // 
            pauseButton.Location = new Point(503, 234);
            pauseButton.Name = "pauseButton";
            pauseButton.Size = new Size(112, 34);
            pauseButton.TabIndex = 6;
            pauseButton.Text = "暂停";
            pauseButton.UseVisualStyleBackColor = true;
            pauseButton.Click += pauseButton_Click;
            // 
            // nextButton
            // 
            nextButton.Location = new Point(638, 234);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(112, 34);
            nextButton.TabIndex = 7;
            nextButton.Text = "下一首";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(nextButton);
            Controls.Add(pauseButton);
            Controls.Add(playButton);
            Controls.Add(stopButton);
            Controls.Add(preButton);
            Controls.Add(aviButton);
            Controls.Add(mp3Button);
            Controls.Add(outputTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox outputTextBox;
        private Button mp3Button;
        private Button aviButton;
        private Button preButton;
        private Button stopButton;
        private Button playButton;
        private Button pauseButton;
        private Button nextButton;
    }
}