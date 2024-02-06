namespace TEST
{
    partial class CreateMainTestView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button6 = new Button();
            button5 = new Button();
            testName = new TextBox();
            label2 = new Label();
            plsBtn = new Button();
            minBtn = new Button();
            numberOfQuests = new TextBox();
            label3 = new Label();
            nextBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 0;
            label1.Text = "Создание теста";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(45, 45, 45);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(346, 2);
            button6.Name = "button6";
            button6.Size = new Size(42, 28);
            button6.TabIndex = 10;
            button6.Text = "-";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(45, 45, 45);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(385, 2);
            button5.Name = "button5";
            button5.Size = new Size(44, 28);
            button5.TabIndex = 9;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // testName
            // 
            testName.Location = new Point(186, 71);
            testName.Name = "testName";
            testName.Size = new Size(169, 23);
            testName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(144, 21);
            label2.TabIndex = 12;
            label2.Text = "Введите имя теста:";
            // 
            // plsBtn
            // 
            plsBtn.BackColor = Color.FromArgb(55, 55, 55);
            plsBtn.FlatAppearance.BorderSize = 0;
            plsBtn.FlatStyle = FlatStyle.Flat;
            plsBtn.ForeColor = Color.White;
            plsBtn.Location = new Point(326, 122);
            plsBtn.Name = "plsBtn";
            plsBtn.Size = new Size(29, 23);
            plsBtn.TabIndex = 13;
            plsBtn.Text = "+";
            plsBtn.UseVisualStyleBackColor = false;
            plsBtn.Click += plsBtn_Click;
            // 
            // minBtn
            // 
            minBtn.BackColor = Color.FromArgb(55, 55, 55);
            minBtn.FlatAppearance.BorderSize = 0;
            minBtn.FlatStyle = FlatStyle.Flat;
            minBtn.ForeColor = Color.White;
            minBtn.Location = new Point(186, 122);
            minBtn.Name = "minBtn";
            minBtn.Size = new Size(29, 23);
            minBtn.TabIndex = 14;
            minBtn.Text = "-";
            minBtn.UseVisualStyleBackColor = false;
            minBtn.Click += minBtn_Click;
            // 
            // numberOfQuests
            // 
            numberOfQuests.Location = new Point(221, 122);
            numberOfQuests.Name = "numberOfQuests";
            numberOfQuests.Size = new Size(99, 23);
            numberOfQuests.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.White;
            label3.ImageAlign = ContentAlignment.MiddleRight;
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(168, 21);
            label3.TabIndex = 16;
            label3.Text = "Количество вопросов:";
            // 
            // nextBtn
            // 
            nextBtn.BackColor = Color.FromArgb(55, 55, 55);
            nextBtn.FlatAppearance.BorderSize = 0;
            nextBtn.FlatStyle = FlatStyle.Flat;
            nextBtn.ForeColor = Color.White;
            nextBtn.Location = new Point(172, 195);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(75, 23);
            nextBtn.TabIndex = 17;
            nextBtn.Text = "Продолжить";
            nextBtn.UseVisualStyleBackColor = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // CreateMainTestView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(429, 260);
            Controls.Add(nextBtn);
            Controls.Add(label3);
            Controls.Add(numberOfQuests);
            Controls.Add(minBtn);
            Controls.Add(plsBtn);
            Controls.Add(label2);
            Controls.Add(testName);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateMainTestView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button6;
        private Button button5;
        private TextBox testName;
        private Label label2;
        private Button plsBtn;
        private Button minBtn;
        private TextBox numberOfQuests;
        private Label label3;
        private Button nextBtn;
    }
}