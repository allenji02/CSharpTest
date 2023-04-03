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
            hourTextBox = new TextBox();
            minuteTextBox = new TextBox();
            secondTextBOX = new TextBox();
            incrButton = new Button();
            SuspendLayout();
            // 
            // hourTextBox
            // 
            hourTextBox.Location = new Point(75, 142);
            hourTextBox.Name = "hourTextBox";
            hourTextBox.Size = new Size(150, 30);
            hourTextBox.TabIndex = 0;
            // 
            // minuteTextBox
            // 
            minuteTextBox.Location = new Point(282, 142);
            minuteTextBox.Name = "minuteTextBox";
            minuteTextBox.Size = new Size(150, 30);
            minuteTextBox.TabIndex = 1;
            // 
            // secondTextBOX
            // 
            secondTextBOX.Location = new Point(481, 142);
            secondTextBOX.Name = "secondTextBOX";
            secondTextBOX.Size = new Size(150, 30);
            secondTextBOX.TabIndex = 2;
            // 
            // incrButton
            // 
            incrButton.Location = new Point(658, 140);
            incrButton.Name = "incrButton";
            incrButton.Size = new Size(112, 34);
            incrButton.TabIndex = 3;
            incrButton.Text = "incr";
            incrButton.UseVisualStyleBackColor = true;
            incrButton.Click += incrButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(incrButton);
            Controls.Add(secondTextBOX);
            Controls.Add(minuteTextBox);
            Controls.Add(hourTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox hourTextBox;
        private TextBox minuteTextBox;
        private TextBox secondTextBOX;
        private Button incrButton;
    }
}