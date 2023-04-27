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
            nameTextBox = new TextBox();
            label1 = new Label();
            necessityButton = new Button();
            electricButton = new Button();
            clothingButton = new Button();
            printButton = new Button();
            outputTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(612, 31);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 30);
            nameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(525, 34);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 1;
            label1.Text = "名称";
            // 
            // necessityButton
            // 
            necessityButton.Location = new Point(612, 102);
            necessityButton.Name = "necessityButton";
            necessityButton.Size = new Size(112, 34);
            necessityButton.TabIndex = 2;
            necessityButton.Text = "百货";
            necessityButton.UseVisualStyleBackColor = true;
            necessityButton.Click += necessityButton_Click;
            // 
            // electricButton
            // 
            electricButton.Location = new Point(612, 179);
            electricButton.Name = "electricButton";
            electricButton.Size = new Size(112, 34);
            electricButton.TabIndex = 3;
            electricButton.Text = "电器";
            electricButton.UseVisualStyleBackColor = true;
            electricButton.Click += electricButton_Click;
            // 
            // clothingButton
            // 
            clothingButton.Location = new Point(612, 259);
            clothingButton.Name = "clothingButton";
            clothingButton.Size = new Size(112, 34);
            clothingButton.TabIndex = 4;
            clothingButton.Text = "衣服";
            clothingButton.UseVisualStyleBackColor = true;
            clothingButton.Click += clothingButton_Click;
            // 
            // printButton
            // 
            printButton.Location = new Point(612, 348);
            printButton.Name = "printButton";
            printButton.Size = new Size(112, 34);
            printButton.TabIndex = 5;
            printButton.Text = "打印信息";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(29, 34);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(443, 348);
            outputTextBox.TabIndex = 6;
            outputTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputTextBox);
            Controls.Add(printButton);
            Controls.Add(clothingButton);
            Controls.Add(electricButton);
            Controls.Add(necessityButton);
            Controls.Add(label1);
            Controls.Add(nameTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label label1;
        private Button necessityButton;
        private Button electricButton;
        private Button clothingButton;
        private Button printButton;
        private RichTextBox outputTextBox;
    }
}