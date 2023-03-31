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
            inputTextBox = new TextBox();
            preSortTextBox = new TextBox();
            afterSortTextBox = new TextBox();
            sortButton = new Button();
            inputButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 93);
            label1.Name = "label1";
            label1.Size = new Size(136, 24);
            label1.TabIndex = 0;
            label1.Text = "输入数组元素：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 156);
            label2.Name = "label2";
            label2.Size = new Size(154, 24);
            label2.TabIndex = 1;
            label2.Text = "排序前数组序列：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 222);
            label3.Name = "label3";
            label3.Size = new Size(154, 24);
            label3.TabIndex = 2;
            label3.Text = "排序后数组序列：";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(258, 90);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(229, 30);
            inputTextBox.TabIndex = 3;
            // 
            // preSortTextBox
            // 
            preSortTextBox.Location = new Point(258, 153);
            preSortTextBox.Name = "preSortTextBox";
            preSortTextBox.Size = new Size(229, 30);
            preSortTextBox.TabIndex = 4;
            // 
            // afterSortTextBox
            // 
            afterSortTextBox.Location = new Point(258, 219);
            afterSortTextBox.Name = "afterSortTextBox";
            afterSortTextBox.Size = new Size(229, 30);
            afterSortTextBox.TabIndex = 5;
            // 
            // sortButton
            // 
            sortButton.Location = new Point(541, 151);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(112, 34);
            sortButton.TabIndex = 6;
            sortButton.Text = "排序";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // inputButton
            // 
            inputButton.Location = new Point(541, 88);
            inputButton.Name = "inputButton";
            inputButton.Size = new Size(112, 34);
            inputButton.TabIndex = 7;
            inputButton.Text = "输入";
            inputButton.UseVisualStyleBackColor = true;
            inputButton.Click += inputButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inputButton);
            Controls.Add(sortButton);
            Controls.Add(afterSortTextBox);
            Controls.Add(preSortTextBox);
            Controls.Add(inputTextBox);
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
        private TextBox inputTextBox;
        private TextBox preSortTextBox;
        private TextBox afterSortTextBox;
        private Button sortButton;
        private Button inputButton;
    }
}