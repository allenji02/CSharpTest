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
            idTextBox = new TextBox();
            nameTextBox = new TextBox();
            label2 = new Label();
            ageTextBox = new TextBox();
            label3 = new Label();
            addButton = new Button();
            getByNameButton = new Button();
            sortByIDButton = new Button();
            sortByAgeButton = new Button();
            getByIndexButton = new Button();
            indexTextBox = new TextBox();
            label4 = new Label();
            outputTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 49);
            label1.Name = "label1";
            label1.Size = new Size(64, 24);
            label1.TabIndex = 0;
            label1.Text = "学号：";
            // 
            // idTextBox
            // 
            idTextBox.Location = new Point(99, 46);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(98, 30);
            idTextBox.TabIndex = 1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(296, 46);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(95, 30);
            nameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 49);
            label2.Name = "label2";
            label2.Size = new Size(64, 24);
            label2.TabIndex = 2;
            label2.Text = "姓名：";
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(494, 46);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(89, 30);
            ageTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(424, 49);
            label3.Name = "label3";
            label3.Size = new Size(64, 24);
            label3.TabIndex = 4;
            label3.Text = "年龄：";
            // 
            // addButton
            // 
            addButton.Location = new Point(623, 44);
            addButton.Name = "addButton";
            addButton.Size = new Size(142, 34);
            addButton.TabIndex = 6;
            addButton.Text = "添加学生记录";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // getByNameButton
            // 
            getByNameButton.Location = new Point(29, 119);
            getByNameButton.Name = "getByNameButton";
            getByNameButton.Size = new Size(112, 34);
            getByNameButton.TabIndex = 7;
            getByNameButton.Text = "按姓名查找";
            getByNameButton.UseVisualStyleBackColor = true;
            getByNameButton.Click += getByNameButton_Click;
            // 
            // sortByIDButton
            // 
            sortByIDButton.Location = new Point(190, 119);
            sortByIDButton.Name = "sortByIDButton";
            sortByIDButton.Size = new Size(112, 34);
            sortByIDButton.TabIndex = 8;
            sortByIDButton.Text = "按学号升序";
            sortByIDButton.UseVisualStyleBackColor = true;
            sortByIDButton.Click += sortByIDButton_Click;
            // 
            // sortByAgeButton
            // 
            sortByAgeButton.Location = new Point(353, 119);
            sortByAgeButton.Name = "sortByAgeButton";
            sortByAgeButton.Size = new Size(112, 34);
            sortByAgeButton.TabIndex = 9;
            sortByAgeButton.Text = "按年龄降序";
            sortByAgeButton.UseVisualStyleBackColor = true;
            sortByAgeButton.Click += sortByAgeButton_Click;
            // 
            // getByIndexButton
            // 
            getByIndexButton.Location = new Point(520, 119);
            getByIndexButton.Name = "getByIndexButton";
            getByIndexButton.Size = new Size(112, 34);
            getByIndexButton.TabIndex = 10;
            getByIndexButton.Text = "显示第";
            getByIndexButton.UseVisualStyleBackColor = true;
            getByIndexButton.Click += getByIndexButton_Click;
            // 
            // indexTextBox
            // 
            indexTextBox.Location = new Point(654, 121);
            indexTextBox.Name = "indexTextBox";
            indexTextBox.Size = new Size(45, 30);
            indexTextBox.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(714, 124);
            label4.Name = "label4";
            label4.Size = new Size(28, 24);
            label4.TabIndex = 12;
            label4.Text = "条";
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(29, 190);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.Size = new Size(736, 207);
            outputTextBox.TabIndex = 13;
            outputTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outputTextBox);
            Controls.Add(label4);
            Controls.Add(indexTextBox);
            Controls.Add(getByIndexButton);
            Controls.Add(sortByAgeButton);
            Controls.Add(sortByIDButton);
            Controls.Add(getByNameButton);
            Controls.Add(addButton);
            Controls.Add(ageTextBox);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(idTextBox);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox idTextBox;
        private TextBox nameTextBox;
        private Label label2;
        private TextBox ageTextBox;
        private Label label3;
        private Button addButton;
        private Button getByNameButton;
        private Button sortByIDButton;
        private Button sortByAgeButton;
        private Button getByIndexButton;
        private TextBox indexTextBox;
        private Label label4;
        private RichTextBox outputTextBox;
    }
}