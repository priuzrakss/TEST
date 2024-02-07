using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace TEST
{

    public partial class CreateQuestTestView : Form
    {
        MainView mainView;
        public CreateQuestTestView(MainView mv)
        {
            InitializeComponent();
            mainView = mv;
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
        }

        Testy test;
        public int count;
        public int Ind = 0;
        private int is_anwser = 0;
        internal void getTest(Testy temp_test, string name, int count)
        {
            this.count = count;
            this.test = temp_test;
            test.init();
            test.setTestName(name);
            QuestNumber.Text = $"{Ind + 1}/ {count}";

        }
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult rslt = MessageBox.Show("Если вы закроете окно сейчас ничего не сохранится", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (rslt == DialogResult.OK)
            {
                this.Close();
                mainView.Show();
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { is_anwser = 1; checkBox2.Checked = false; checkBox3.Checked = false; checkBox4.Checked = false; }
        }

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

        private void nextBtn_Click(object sender, EventArgs e)
        {
            Ind++;
            QuestNumber.Text = $"{Ind + 1}/ {count}";
            if (test.Quest_text.Count > Ind)
            {
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
                test.AddQuest(QuestText.Text, AnswerText1.Text, AnswerText2.Text, AnswerText3.Text, AnswerText4.Text, is_anwser);
                QuestText.Text = "";
                AnswerText1.Text = "";
                AnswerText2.Text = "";
                AnswerText3.Text = "";
                AnswerText4.Text = "";
            }
            if (checkBox1.Checked) { is_anwser = 1; }
            if (checkBox2.Checked) { is_anwser = 2; }
            if (checkBox3.Checked) { is_anwser = 3; }
            if (checkBox4.Checked) { is_anwser = 4; }



            else
            {
                var result = MessageBox.Show("Сохранить тест?", "Достигнут последний вопрос", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Save();
                }
                else
                {
                    this.Close();
                    mainView.Show();
                }

            }
        }

        public void Save()
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

        private void prevBtn_Click(object sender, EventArgs e)
        {
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

        private void QuestNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
