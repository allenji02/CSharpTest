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
            label2 = new Label();
            cTextBox = new TextBox();
            fTextBox = new TextBox();
            convertButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(241, 176);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "摄氏度";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(525, 176);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 1;
            label2.Text = "华氏度";
            // 
            // cTextBox
            // 
            cTextBox.Location = new Point(72, 173);
            cTextBox.Name = "cTextBox";
            cTextBox.Size = new Size(150, 30);
            cTextBox.TabIndex = 2;
            // 
            // fTextBox
            // 
            fTextBox.Location = new Point(359, 173);
            fTextBox.Name = "fTextBox";
            fTextBox.Size = new Size(150, 30);
            fTextBox.TabIndex = 3;
            // 
            // convertButton
            // 
            convertButton.Location = new Point(611, 171);
            convertButton.Name = "convertButton";
            convertButton.Size = new Size(112, 34);
            convertButton.TabIndex = 4;
            convertButton.Text = "转换";
            convertButton.UseVisualStyleBackColor = true;
            convertButton.Click += convertButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(convertButton);
            Controls.Add(fTextBox);
            Controls.Add(cTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox cTextBox;
        private TextBox fTextBox;
        private Button convertButton;
    }
}