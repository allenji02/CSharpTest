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
            ageTextBox = new TextBox();
            chineseOrRequiredTextBox = new TextBox();
            mathOrOptionalTextBox = new TextBox();
            englishTextBox = new TextBox();
            pupilButton = new Button();
            seniorButton = new Button();
            undergraduateButton = new Button();
            outputTextBox = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(102, 50);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 30);
            nameTextBox.TabIndex = 0;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(102, 136);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(150, 30);
            ageTextBox.TabIndex = 1;
            // 
            // chineseOrRequiredTextBox
            // 
            chineseOrRequiredTextBox.Location = new Point(418, 50);
            chineseOrRequiredTextBox.Name = "chineseOrRequiredTextBox";
            chineseOrRequiredTextBox.Size = new Size(150, 30);
            chineseOrRequiredTextBox.TabIndex = 2;
            // 
            // mathOrOptionalTextBox
            // 
            mathOrOptionalTextBox.Location = new Point(418, 136);
            mathOrOptionalTextBox.Name = "mathOrOptionalTextBox";
            mathOrOptionalTextBox.Size = new Size(150, 30);
            mathOrOptionalTextBox.TabIndex = 3;
            // 
            // englishTextBox
            // 
            englishTextBox.Location = new Point(418, 215);
            englishTextBox.Name = "englishTextBox";
            englishTextBox.Size = new Size(150, 30);
            englishTextBox.TabIndex = 4;
            // 
            // pupilButton
            // 
            pupilButton.Location = new Point(634, 48);
            pupilButton.Name = "pupilButton";
            pupilButton.Size = new Size(112, 34);
            pupilButton.TabIndex = 5;
            pupilButton.Text = "小学生";
            pupilButton.UseVisualStyleBackColor = true;
            pupilButton.Click += pupilButton_Click;
            // 
            // seniorButton
            // 
            seniorButton.Location = new Point(634, 134);
            seniorButton.Name = "seniorButton";
            seniorButton.Size = new Size(112, 34);
            seniorButton.TabIndex = 6;
            seniorButton.Text = "中学生";
            seniorButton.UseVisualStyleBackColor = true;
            seniorButton.Click += seniorButton_Click;
            // 
            // undergraduateButton
            // 
            undergraduateButton.Location = new Point(634, 213);
            undergraduateButton.Name = "undergraduateButton";
            undergraduateButton.Size = new Size(112, 34);
            undergraduateButton.TabIndex = 7;
            undergraduateButton.Text = "大学生";
            undergraduateButton.UseVisualStyleBackColor = true;
            undergraduateButton.Click += undergraduateButton_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(102, 268);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(466, 144);
            outputTextBox.TabIndex = 8;
            outputTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 53);
            label1.Name = "label1";
            label1.Size = new Size(46, 24);
            label1.TabIndex = 9;
            label1.Text = "姓名";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 139);
            label2.Name = "label2";
            label2.Size = new Size(46, 24);
            label2.TabIndex = 10;
            label2.Text = "年龄";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(276, 53);
            label3.Name = "label3";
            label3.Size = new Size(108, 24);
            label3.TabIndex = 11;
            label3.Text = "语文/必修课";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 139);
            label4.Name = "label4";
            label4.Size = new Size(108, 24);
            label4.TabIndex = 12;
            label4.Text = "数学/选修课";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 218);
            label5.Name = "label5";
            label5.Size = new Size(46, 24);
            label5.TabIndex = 13;
            label5.Text = "英语";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(outputTextBox);
            Controls.Add(undergraduateButton);
            Controls.Add(seniorButton);
            Controls.Add(pupilButton);
            Controls.Add(englishTextBox);
            Controls.Add(mathOrOptionalTextBox);
            Controls.Add(chineseOrRequiredTextBox);
            Controls.Add(ageTextBox);
            Controls.Add(nameTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox ageTextBox;
        private TextBox chineseOrRequiredTextBox;
        private TextBox mathOrOptionalTextBox;
        private TextBox englishTextBox;
        private Button pupilButton;
        private Button seniorButton;
        private Button undergraduateButton;
        private RichTextBox outputTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}