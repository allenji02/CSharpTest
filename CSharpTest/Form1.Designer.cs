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
            label1 = new Label();
            inputTextBox = new TextBox();
            label2 = new Label();
            outputTextBox = new TextBox();
            reverseButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 191);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "原数：";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(106, 188);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(150, 30);
            inputTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 191);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 2;
            label2.Text = "逆序：";
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(372, 188);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(150, 30);
            outputTextBox.TabIndex = 3;
            // 
            // reverseButton
            // 
            reverseButton.Location = new Point(591, 186);
            reverseButton.Name = "reverseButton";
            reverseButton.Size = new Size(112, 34);
            reverseButton.TabIndex = 4;
            reverseButton.Text = "逆序";
            reverseButton.UseVisualStyleBackColor = true;
            reverseButton.Click += reverseButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(reverseButton);
            Controls.Add(outputTextBox);
            Controls.Add(label2);
            Controls.Add(inputTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox inputTextBox;
        private Label label2;
        private TextBox outputTextBox;
        private Button reverseButton;
    }
}