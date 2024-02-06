using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST.Models;

namespace TEST
{
    public partial class PassTestView : Form
    {
        MainView mainView;
        Testy test;
        List<int> wrong_answers = new List<int>();
        int Ind = 0;
        int right_answers = 0;
        Answer answer = new Answer();
        public int count = 0;
        public int is_anwser = 0;
        public PassTestView(MainView mv)
        {
            InitializeComponent();
            mainView = mv;
        }

        internal void getTest(Testy test)
        {
            this.test = test;
            label1.Text = test.getName();
            count = test.Quest_text.Count;
            QuestText.Text = test.Quest_text[0];
            AnswerText1.Text = test.Answer_text_1[0];
            AnswerText2.Text = test.Answer_text_2[0];
            AnswerText3.Text = test.Answer_text_3[0];
            AnswerText4.Text = test.Answer_text_4[0];
            QuestNumber.Text = $"{Ind + 1}/ {count}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (answer.answer.Count <= Ind)
            {
                if (checkBox1.Checked) { answer.AddAnswer(1); }
                if (checkBox2.Checked) { answer.AddAnswer(2); }
                if (checkBox3.Checked) { answer.AddAnswer(3); }
                if (checkBox4.Checked) { answer.AddAnswer(4); }
            }
            else
            {
                if (checkBox1.Checked) { answer.answer[Ind] = 1; }
                if (checkBox2.Checked) { answer.answer[Ind] = 2; }
                if (checkBox3.Checked) { answer.answer[Ind] = 3; }
                if (checkBox4.Checked) { answer.answer[Ind] = 4; }
            }

            if (answer.answer.Count != count)
            {
                Ind++;
                QuestNumber.Text = $"{Ind + 1}/ {count}";
                QuestText.Text = test.Quest_text[Ind];
                AnswerText1.Text = test.Answer_text_1[Ind];
                AnswerText2.Text = test.Answer_text_2[Ind];
                AnswerText3.Text = test.Answer_text_3[Ind];
                AnswerText4.Text = test.Answer_text_4[Ind];

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
            else if (answer.answer.Count <= Ind)
            {
                Ind++;
                QuestNumber.Text = $"{Ind + 1}/ {count}";
                QuestText.Text = test.Quest_text[Ind];
                AnswerText1.Text = test.Answer_text_1[Ind];
                AnswerText2.Text = test.Answer_text_2[Ind];
                AnswerText3.Text = test.Answer_text_3[Ind];
                AnswerText4.Text = test.Answer_text_4[Ind];

                switch (answer.answer[Ind])
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
                    case 5:
                        MessageBox.Show("КАК?", "Это технический не возможно!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else if (answer.answer.Count == count)
            {
                for (int i = 0; i < count; i++)
                {
                    if (test.is_answ[i] == answer.answer[i]) { right_answers++; }
                    else { wrong_answers.Add(i); }
                }

                MessageBox.Show($"Количество правильных ответов:{right_answers}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int i = 0; i < wrong_answers.Count; i++)
                {
                    string right_answers = "";
                    switch (test.is_answ[wrong_answers[i]])
                    {
                        case 1:
                            right_answers = test.Answer_text_1[wrong_answers[i]];
                            break;
                        case 2:
                            right_answers = test.Answer_text_2[wrong_answers[i]];
                            break;
                        case 3:
                            right_answers = test.Answer_text_3[wrong_answers[i]];
                            break;
                        case 4:
                            right_answers = test.Answer_text_4[wrong_answers[i]];
                            break;

                    }
                    MessageBox.Show($"Ошибка в вопросе: {test.Quest_text[wrong_answers[i]]}\n " +
                        $"Правельный ответ: {right_answers.ToString()}  ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    mainView.Show();
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Ind--;
            QuestNumber.Text = $"{Ind + 1}/ {count}";
            QuestText.Text = test.Quest_text[Ind];
            AnswerText1.Text = test.Answer_text_1[Ind];
            AnswerText2.Text = test.Answer_text_2[Ind];
            AnswerText3.Text = test.Answer_text_3[Ind];
            AnswerText4.Text = test.Answer_text_4[Ind];

            switch (answer.answer[Ind])
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            mainView.Show();
        }
    }
}
