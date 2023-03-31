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
            label3 = new Label();
            nameTextBox = new TextBox();
            phoneTextBox = new TextBox();
            emailTextBox = new TextBox();
            addButton = new Button();
            outputTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 56);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "姓名：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 118);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 1;
            label2.Text = "电话：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 184);
            label3.Name = "label3";
            label3.Size = new Size(75, 24);
            label3.TabIndex = 2;
            label3.Text = "Email：";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(127, 53);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 30);
            nameTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(127, 115);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(150, 30);
            phoneTextBox.TabIndex = 4;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(127, 181);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(150, 30);
            emailTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            addButton.Location = new Point(415, 113);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 34);
            addButton.TabIndex = 7;
            addButton.Text = "添加";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(32, 252);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(407, 144);
            outputTextBox.TabIndex = 8;
            outputTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputTextBox);
            Controls.Add(addButton);
            Controls.Add(emailTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(label3);
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
        private Label label3;
        private TextBox nameTextBox;
        private TextBox phoneTextBox;
        private TextBox emailTextBox;
        private Button addButton;
        private RichTextBox outputTextBox;
    }
}