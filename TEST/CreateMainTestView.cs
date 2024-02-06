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
using static System.Net.Mime.MediaTypeNames;

namespace TEST
{
    public partial class CreateMainTestView : Form
    {
        MainView mainView;
        public CreateMainTestView(MainView mv)
        {
            InitializeComponent();
            mainView = mv;
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

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int i = 0;
            bool result = int.TryParse(numberOfQuests.Text, out i);

            if (testName.Text == "")
            {
                MessageBox.Show("Вы не ввели имя теста", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (numberOfQuests.Text == "")
            {
                MessageBox.Show("Вы не ввели количество вопросов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (result == false)
            {
                MessageBox.Show("Вы ввели текстовые символы в количество вопросов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (testName.Text != "" && numberOfQuests.Text != "" && result == true)
            {
                Testy test = new Testy();
                CreateQuestTestView CTQVM = new CreateQuestTestView();
                string text = numberOfQuests.Text;
                int count = Int32.Parse(text);
                CTQVM.getTest(testName.Text, count);
                CTQVM.Show();
                this.Close();

            }

        }

        private void minBtn_Click(object sender, EventArgs e)
        {

        }

        private void plsBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
