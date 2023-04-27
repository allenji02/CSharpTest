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
            nameTextBox = new TextBox();
            titleTextBox = new TextBox();
            label3 = new Label();
            indexTextBox = new TextBox();
            pushButton = new Button();
            insertButton = new Button();
            traverseButton = new Button();
            deleteButton = new Button();
            outputTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 65);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "姓名：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 134);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 1;
            label2.Text = "职称：";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(117, 62);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(150, 30);
            nameTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(117, 131);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(150, 30);
            titleTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(577, 102);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 4;
            label3.Text = "索引：";
            // 
            // indexTextBox
            // 
            indexTextBox.Location = new Point(647, 99);
            indexTextBox.Name = "indexTextBox";
            indexTextBox.Size = new Size(92, 30);
            indexTextBox.TabIndex = 5;
            // 
            // pushButton
            // 
            pushButton.Location = new Point(318, 60);
            pushButton.Name = "pushButton";
            pushButton.Size = new Size(112, 34);
            pushButton.TabIndex = 6;
            pushButton.Text = "添加到末尾";
            pushButton.UseVisualStyleBackColor = true;
            pushButton.Click += pushButton_Click;
            // 
            // insertButton
            // 
            insertButton.Location = new Point(452, 60);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(112, 34);
            insertButton.TabIndex = 7;
            insertButton.Text = "插入到";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.Click += insertButton_Click;
            // 
            // traverseButton
            // 
            traverseButton.Location = new Point(318, 129);
            traverseButton.Name = "traverseButton";
            traverseButton.Size = new Size(112, 34);
            traverseButton.TabIndex = 8;
            traverseButton.Text = "遍历";
            traverseButton.UseVisualStyleBackColor = true;
            traverseButton.Click += traverseButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(452, 129);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(112, 34);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "删除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(35, 203);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(704, 189);
            outputTextBox.TabIndex = 10;
            outputTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputTextBox);
            Controls.Add(deleteButton);
            Controls.Add(traverseButton);
            Controls.Add(insertButton);
            Controls.Add(pushButton);
            Controls.Add(indexTextBox);
            Controls.Add(label3);
            Controls.Add(titleTextBox);
            Controls.Add(nameTextBox);
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
        private TextBox nameTextBox;
        private TextBox titleTextBox;
        private Label label3;
        private TextBox indexTextBox;
        private Button pushButton;
        private Button insertButton;
        private Button traverseButton;
        private Button deleteButton;
        private RichTextBox outputTextBox;
    }
}