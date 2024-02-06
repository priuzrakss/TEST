using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TEST.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TEST
{
    public partial class CreateMainTestView : Form
    {
        public int numInd = 0;
        MainView mainView;
        public CreateMainTestView(MainView mv)
        {
            InitializeComponent();
            mainView = mv;
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
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
            if (testName.Text != "" && numberOfQuests.Text != "" && result == true && numberOfQuests.Text != "0")
            {
                Testy test = new Testy();
                CreateQuestTestView CTQVM = new CreateQuestTestView(mainView);
                string text = numberOfQuests.Text;
                int count = Int32.Parse(text);
                CTQVM.getTest(test, testName.Text, count);
                CTQVM.Show();
                this.Close();

            }

        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            if (numInd > 0)
            {
                numInd--;
                numberOfQuests.Text = numInd.ToString();
            }
        }

        private void plsBtn_Click(object sender, EventArgs e)
        {
            numInd++;
            numberOfQuests.Text = numInd.ToString();
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
    }
}
