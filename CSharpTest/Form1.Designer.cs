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
            findButton = new Button();
            outputLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 87);
            label1.Name = "label1";
            label1.Size = new Size(149, 24);
            label1.TabIndex = 0;
            label1.Text = "1000 以内的完数";
            // 
            // findButton
            // 
            findButton.Location = new Point(277, 82);
            findButton.Name = "findButton";
            findButton.Size = new Size(112, 34);
            findButton.TabIndex = 1;
            findButton.Text = "查找";
            findButton.UseVisualStyleBackColor = true;
            findButton.Click += findButton_Click;
            // 
            // outputLabel
            // 
            outputLabel.AutoSize = true;
            outputLabel.Location = new Point(44, 166);
            outputLabel.Name = "outputLabel";
            outputLabel.Size = new Size(73, 24);
            outputLabel.TabIndex = 2;
            outputLabel.Text = "Output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputLabel);
            Controls.Add(findButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button findButton;
        private Label outputLabel;
    }
}