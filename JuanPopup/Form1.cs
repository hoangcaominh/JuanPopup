using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using JsonData;

namespace JuanPopup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            int X = Screen.PrimaryScreen.WorkingArea.Width - Width - 10;
            int Y = Screen.PrimaryScreen.WorkingArea.Height - Height - 4;
            Location = new Point(X, Y);
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(File.ReadAllText("index.dat"));
            DataClass data = new DataClass();

            if (index >= data.Size())
            {
                data.Shuffle();
                data.SaveData();
                index = 0;
            }

            if (data.Size() > 0)
            {
                (Author.Text, Header.Text, Content.Text) = data.Load(index);
            }

            index += 1;
            File.WriteAllText("index.dat", index.ToString());
        }
    }
}
