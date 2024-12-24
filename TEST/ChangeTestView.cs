using System.Runtime.InteropServices;
using System.Text.Json;

namespace TEST
{
    public partial class ChangeTestView : Form
    {
        MainView mainView;
        Testy test;
        public int count;
        public int Ind = 0;
        private int is_anwser = 0;

        public ChangeTestView(MainView mv)
        {
            InitializeComponent();
            QuestNumber.Text = $"{Ind + 1}/{count}";
            mainView = mv;
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);

        }
        public void Save()
        {
            var result = MessageBox.Show("Сохранить тест?", "Сохранить тест?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.FileName = test.getName();
                saveFileDialog1.Filter = "Json|*.json";
                saveFileDialog1.Title = "Сохранить Тест";
                saveFileDialog1.ShowDialog();


                var options = new JsonSerializerOptions
                {
                    WriteIndented = true
                };
                string jsonString = JsonSerializer.Serialize(test, options);
                File.WriteAllText(saveFileDialog1.FileName, jsonString);
                this.Close();
                mainView.Show();
            }
            else
            {
                var result_exit = MessageBox.Show("Хотите выйти?", "Изменения не будут сохранены", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result_exit == DialogResult.Yes)
                {
                    this.Close();
                    mainView.Show();
                }
            }
        }

        internal void getTest(Testy test)
        {
            this.test = test;
            QuestText.Text = test.Quest_text[Ind].ToString();
            AnswerText1.Text = test.Answer_text_1[Ind].ToString();
            AnswerText2.Text = test.Answer_text_2[Ind].ToString();
            AnswerText3.Text = test.Answer_text_3[Ind].ToString();
            AnswerText4.Text = test.Answer_text_4[Ind].ToString();
            switch (test.is_answ[Ind])
            {
                case 1:
                    checkBox1.Checked = true;
                    break;

                case 2:
                    checkBox2.Checked = true;
                    break;
                case 3:
                    checkBox3.Checked = true;
                    break;
                case 4:
                    checkBox4.Checked = true;
                    break;
            }
            count = test.Quest_text.Count;
            QuestNumber.Text = $"{Ind + 1}/ {count}";
        }



        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (Ind +1 < count)
            {
                test.Quest_text[Ind] = QuestText.Text;
                test.Answer_text_1[Ind] = AnswerText1.Text;
                test.Answer_text_2[Ind] = AnswerText2.Text;
                test.Answer_text_3[Ind] = AnswerText3.Text;
                test.Answer_text_4[Ind] = AnswerText4.Text;
                if (checkBox1.Checked) { is_anwser = 1; }
                if (checkBox2.Checked) { is_anwser = 2; }
                if (checkBox3.Checked) { is_anwser = 3; }
                if (checkBox4.Checked) { is_anwser = 4; }
                test.is_answ[Ind] = is_anwser;


                Ind++;
                QuestNumber.Text = $"{Ind + 1}/ {count}";
                QuestText.Text = test.Quest_text[Ind].ToString();
                AnswerText1.Text = test.Answer_text_1[Ind].ToString();
                AnswerText2.Text = test.Answer_text_2[Ind].ToString();
                AnswerText3.Text = test.Answer_text_3[Ind].ToString();
                AnswerText4.Text = test.Answer_text_4[Ind].ToString();
                switch (test.is_answ[Ind])
                {
                    case 1:
                        checkBox1.Checked = true;
                        break;

                    case 2:
                        checkBox2.Checked = true;
                        break;
                    case 3:
                        checkBox3.Checked = true;
                        break;
                    case 4:
                        checkBox4.Checked = true;
                        break;
                }
            }
            else
            {
                Save();
            }

        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            test.Quest_text[Ind] = QuestText.Text;
            test.Answer_text_1[Ind] = AnswerText1.Text;
            test.Answer_text_2[Ind] = AnswerText2.Text;
            test.Answer_text_3[Ind] = AnswerText3.Text;
            test.Answer_text_4[Ind] = AnswerText4.Text;
            if (checkBox1.Checked) { is_anwser = 1; }
            if (checkBox2.Checked) { is_anwser = 2; }
            if (checkBox3.Checked) { is_anwser = 3; }
            if (checkBox4.Checked) { is_anwser = 4; }
            test.is_answ[Ind] = is_anwser;

            if (Ind != 0)
            {
                Ind--;
                QuestNumber.Text = $"{Ind + 1}/ {count}";
                QuestText.Text = test.Quest_text[Ind].ToString();
                AnswerText1.Text = test.Answer_text_1[Ind].ToString();
                AnswerText2.Text = test.Answer_text_1[Ind].ToString();
                AnswerText3.Text = test.Answer_text_1[Ind].ToString();
                AnswerText4.Text = test.Answer_text_1[Ind].ToString();

                switch (test.is_answ[Ind])
                {
                    case 1:
                        checkBox1.Checked = true;
                        break;

                    case 2:
                        checkBox2.Checked = true;
                        break;
                    case 3:
                        checkBox3.Checked = true;
                        break;
                    case 4:
                        checkBox4.Checked = true;
                        break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            mainView.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;



        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { is_anwser = 2; checkBox1.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { is_anwser = 3; checkBox2.Checked = false; checkBox1.Checked = false; checkBox4.Checked = false; }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) { is_anwser = 4; checkBox2.Checked = false; checkBox3.Checked = false; checkBox1.Checked = false; }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { is_anwser = 1; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
