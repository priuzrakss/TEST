using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;
using System.Text.Json;

namespace TEST
{
    public partial class MainView : Form
    {
        Testy test;
        Testy testForPass;
        public MainView()
        {
            InitializeComponent();
            this.MouseDown += new MouseEventHandler(Form1_MouseDown);
            testname.Text = "Не выбран";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (testname.Text == "Не выбран")
            {
                MessageBox.Show("Вы не выбрали тест!", "Выберите тест!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                PassTestView PTV = new PassTestView(this);
                PTV.Show();
                this.Hide();
                PTV.getTest(testForPass);

            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CreateMainTestView CMTV = new CreateMainTestView(this);
            CMTV.Show(); 
            this.Hide(); 
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string JoinString;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Json|*.json";
            ofd.Title = "Открыть Тест";
            ofd.ShowDialog();
            testForPass = JsonSerializer.Deserialize<Testy>(ofd.OpenFile());
            testForPass.setTestName(ofd.SafeFileName);
            testname.Text = ofd.SafeFileName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void MainView_Load(object sender, EventArgs e)
        {

        }
    }
}
