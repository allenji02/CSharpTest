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
            idxLabel = new Label();
            inputTextBox = new TextBox();
            addButton = new Button();
            label3 = new Label();
            preSortTextBox = new TextBox();
            afterSortTextBox = new TextBox();
            label4 = new Label();
            sortButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 37);
            label1.Name = "label1";
            label1.Size = new Size(299, 24);
            label1.TabIndex = 0;
            label1.Text = "数组空间为 5，请依次输入 5 个数字";
            // 
            // idxLabel
            // 
            idxLabel.AutoSize = true;
            idxLabel.Location = new Point(88, 87);
            idxLabel.Name = "idxLabel";
            idxLabel.Size = new Size(151, 24);
            idxLabel.TabIndex = 1;
            idxLabel.Text = "请输入第 i 个数字";
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(288, 84);
            inputTextBox.Name = "inputTextBox";
            inputTextBox.Size = new Size(150, 30);
            inputTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            addButton.Location = new Point(504, 82);
            addButton.Name = "addButton";
            addButton.Size = new Size(112, 34);
            addButton.TabIndex = 3;
            addButton.Text = "添加";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 163);
            label3.Name = "label3";
            label3.Size = new Size(136, 24);
            label3.TabIndex = 4;
            label3.Text = "排序前数组序列";
            // 
            // preSortTextBox
            // 
            preSortTextBox.Location = new Point(146, 214);
            preSortTextBox.Name = "preSortTextBox";
            preSortTextBox.ReadOnly = true;
            preSortTextBox.Size = new Size(299, 30);
            preSortTextBox.TabIndex = 5;
            // 
            // afterSortTextBox
            // 
            afterSortTextBox.Location = new Point(146, 328);
            afterSortTextBox.Name = "afterSortTextBox";
            afterSortTextBox.ReadOnly = true;
            afterSortTextBox.Size = new Size(299, 30);
            afterSortTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 277);
            label4.Name = "label4";
            label4.Size = new Size(136, 24);
            label4.TabIndex = 6;
            label4.Text = "排序前数组序列";
            // 
            // sortButton
            // 
            sortButton.Location = new Point(333, 272);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(112, 34);
            sortButton.TabIndex = 8;
            sortButton.Text = "排序";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(sortButton);
            Controls.Add(afterSortTextBox);
            Controls.Add(label4);
            Controls.Add(preSortTextBox);
            Controls.Add(label3);
            Controls.Add(addButton);
            Controls.Add(inputTextBox);
            Controls.Add(idxLabel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label idxLabel;
        private TextBox inputTextBox;
        private Button addButton;
        private Label label3;
        private TextBox preSortTextBox;
        private TextBox afterSortTextBox;
        private Label label4;
        private Button sortButton;
    }
}