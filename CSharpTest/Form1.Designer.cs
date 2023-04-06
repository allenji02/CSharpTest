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
            createButton = new Button();
            withdrawButton = new Button();
            depositButton = new Button();
            checkButton = new Button();
            withdrawTextBox = new TextBox();
            depositTextBox = new TextBox();
            outputTextBox = new RichTextBox();
            createVIPButton = new Button();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Location = new Point(50, 74);
            createButton.Name = "createButton";
            createButton.Size = new Size(112, 34);
            createButton.TabIndex = 0;
            createButton.Text = "创建账户";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // withdrawButton
            // 
            withdrawButton.Location = new Point(50, 152);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(112, 34);
            withdrawButton.TabIndex = 1;
            withdrawButton.Text = "取款";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositButton
            // 
            depositButton.Location = new Point(50, 228);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(112, 34);
            depositButton.TabIndex = 2;
            depositButton.Text = "存款";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // checkButton
            // 
            checkButton.Location = new Point(50, 300);
            checkButton.Name = "checkButton";
            checkButton.Size = new Size(112, 34);
            checkButton.TabIndex = 3;
            checkButton.Text = "查询余额";
            checkButton.UseVisualStyleBackColor = true;
            checkButton.Click += checkButton_Click;
            // 
            // withdrawTextBox
            // 
            withdrawTextBox.Location = new Point(197, 154);
            withdrawTextBox.Name = "withdrawTextBox";
            withdrawTextBox.Size = new Size(150, 30);
            withdrawTextBox.TabIndex = 4;
            // 
            // depositTextBox
            // 
            depositTextBox.Location = new Point(197, 230);
            depositTextBox.Name = "depositTextBox";
            depositTextBox.Size = new Size(150, 30);
            depositTextBox.TabIndex = 5;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(432, 74);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(273, 260);
            outputTextBox.TabIndex = 6;
            outputTextBox.Text = "";
            // 
            // createVIPButton
            // 
            createVIPButton.Location = new Point(197, 74);
            createVIPButton.Name = "createVIPButton";
            createVIPButton.Size = new Size(133, 34);
            createVIPButton.TabIndex = 7;
            createVIPButton.Text = "创建 VIP 账户";
            createVIPButton.UseVisualStyleBackColor = true;
            createVIPButton.Click += createVIPButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(createVIPButton);
            Controls.Add(outputTextBox);
            Controls.Add(depositTextBox);
            Controls.Add(withdrawTextBox);
            Controls.Add(checkButton);
            Controls.Add(depositButton);
            Controls.Add(withdrawButton);
            Controls.Add(createButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createButton;
        private Button withdrawButton;
        private Button depositButton;
        private Button checkButton;
        private TextBox withdrawTextBox;
        private TextBox depositTextBox;
        private RichTextBox outputTextBox;
        private Button createVIPButton;
    }
}