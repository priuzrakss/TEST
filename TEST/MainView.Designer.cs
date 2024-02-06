namespace TEST
{
    partial class MainView
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            testname = new Label();
            button4 = new Button();
            button5 = new Button();
            label2 = new Label();
            button6 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(55, 55, 55);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 50);
            button1.Name = "button1";
            button1.Size = new Size(131, 32);
            button1.TabIndex = 0;
            button1.Text = "Пройти тест";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(55, 55, 55);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(12, 91);
            button2.Name = "button2";
            button2.Size = new Size(131, 32);
            button2.TabIndex = 1;
            button2.Text = "Создать тест";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(55, 55, 55);
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F);
            button3.ForeColor = Color.White;
            button3.Location = new Point(12, 132);
            button3.Name = "button3";
            button3.Size = new Size(131, 32);
            button3.TabIndex = 2;
            button3.Text = "Изменить тест";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(176, 49);
            label1.Name = "label1";
            label1.Size = new Size(120, 21);
            label1.TabIndex = 3;
            label1.Text = "название теста:";
            // 
            // testname
            // 
            testname.AutoSize = true;
            testname.BackColor = Color.FromArgb(0, 0, 0, 0);
            testname.FlatStyle = FlatStyle.Flat;
            testname.Font = new Font("Segoe UI", 12F);
            testname.ForeColor = Color.White;
            testname.Location = new Point(302, 49);
            testname.Name = "testname";
            testname.Size = new Size(104, 21);
            testname.TabIndex = 4;
            testname.Text = "%test name%";
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(55, 55, 55);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 12F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(176, 91);
            button4.Name = "button4";
            button4.Size = new Size(120, 32);
            button4.TabIndex = 5;
            button4.Text = "Выбрать тест";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(45, 45, 45);
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 9F);
            button5.ForeColor = Color.White;
            button5.Location = new Point(420, 0);
            button5.Name = "button5";
            button5.Size = new Size(44, 28);
            button5.TabIndex = 6;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 2);
            label2.Name = "label2";
            label2.Size = new Size(113, 21);
            label2.TabIndex = 7;
            label2.Text = "Главное меню";
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(45, 45, 45);
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 12F);
            button6.ForeColor = Color.White;
            button6.Location = new Point(381, 0);
            button6.Name = "button6";
            button6.Size = new Size(42, 28);
            button6.TabIndex = 8;
            button6.Text = "-";
            button6.TextAlign = ContentAlignment.TopCenter;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // MainView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(45, 45, 45);
            ClientSize = new Size(466, 214);
            Controls.Add(button6);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(testname);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            ImeMode = ImeMode.On;
            Name = "MainView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Главное меню";
            TopMost = true;
            TransparencyKey = Color.White;
            Load += MainView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label testname;
        private Button button4;
        private Button button5;
        private Label label2;
        private Button button6;
    }
}
