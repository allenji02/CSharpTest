﻿namespace CSharpTest
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
            moneyText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            rateText = new TextBox();
            label5 = new Label();
            label6 = new Label();
            yearText = new TextBox();
            calculate = new Button();
            label7 = new Label();
            label8 = new Label();
            interestText = new TextBox();
            label9 = new Label();
            label10 = new Label();
            totalText = new TextBox();
            SuspendLayout();
            // 
            // moneyText
            // 
            moneyText.Location = new Point(156, 43);
            moneyText.Name = "moneyText";
            moneyText.Size = new Size(150, 30);
            moneyText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 46);
            label1.Name = "label1";
            label1.Size = new Size(100, 24);
            label1.TabIndex = 1;
            label1.Text = "存款金额：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 46);
            label2.Name = "label2";
            label2.Size = new Size(28, 24);
            label2.TabIndex = 2;
            label2.Text = "元";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 108);
            label3.Name = "label3";
            label3.Size = new Size(26, 24);
            label3.TabIndex = 5;
            label3.Text = "%";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 108);
            label4.Name = "label4";
            label4.Size = new Size(98, 24);
            label4.TabIndex = 4;
            label4.Text = "年利率%：";
            // 
            // rateText
            // 
            rateText.Location = new Point(156, 105);
            rateText.Name = "rateText";
            rateText.Size = new Size(150, 30);
            rateText.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(324, 161);
            label5.Name = "label5";
            label5.Size = new Size(28, 24);
            label5.TabIndex = 8;
            label5.Text = "年";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 161);
            label6.Name = "label6";
            label6.Size = new Size(100, 24);
            label6.TabIndex = 7;
            label6.Text = "存款年限：";
            // 
            // yearText
            // 
            yearText.Location = new Point(156, 158);
            yearText.Name = "yearText";
            yearText.Size = new Size(150, 30);
            yearText.TabIndex = 6;
            // 
            // calculate
            // 
            calculate.Location = new Point(238, 215);
            calculate.Name = "calculate";
            calculate.Size = new Size(112, 34);
            calculate.TabIndex = 9;
            calculate.Text = "计算";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(324, 282);
            label7.Name = "label7";
            label7.Size = new Size(28, 24);
            label7.TabIndex = 12;
            label7.Text = "元";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(51, 282);
            label8.Name = "label8";
            label8.Size = new Size(100, 24);
            label8.TabIndex = 11;
            label8.Text = "利息总额：";
            // 
            // interestText
            // 
            interestText.Location = new Point(156, 279);
            interestText.Name = "interestText";
            interestText.ReadOnly = true;
            interestText.Size = new Size(150, 30);
            interestText.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(324, 342);
            label9.Name = "label9";
            label9.Size = new Size(28, 24);
            label9.TabIndex = 15;
            label9.Text = "元";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(51, 342);
            label10.Name = "label10";
            label10.Size = new Size(100, 24);
            label10.TabIndex = 14;
            label10.Text = "本息合计：";
            // 
            // totalText
            // 
            totalText.Location = new Point(156, 339);
            totalText.Name = "totalText";
            totalText.ReadOnly = true;
            totalText.Size = new Size(150, 30);
            totalText.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(totalText);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(interestText);
            Controls.Add(calculate);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(yearText);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(rateText);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(moneyText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox moneyText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox rateText;
        private Label label5;
        private Label label6;
        private TextBox yearText;
        private Button calculate;
        private Label label7;
        private Label label8;
        private TextBox interestText;
        private Label label9;
        private Label label10;
        private TextBox totalText;
    }
}