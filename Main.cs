using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Clicker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_MOVE = 0x0001;

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
        }

        public int mouse_down_min = 10;
        public int mouse_down_max = 40;

        public int mouse_up_min = 10;
        public int mouse_up_max = 40;

        public bool running;

        public static Random random = new Random();

        private GlobalKeyboardHook _globalKeyboardHook;

        private void Form1_Load(object sender, EventArgs e)
        {
            _globalKeyboardHook = new GlobalKeyboardHook();
            _globalKeyboardHook.KeyboardPressed += OnKeyPressed;
        }

        public void Toggle(bool value)
        {
            if (value != running)
            {
                running = value;

                button1.Text = running ? "DEACTIVATE" : "ACTIVATE";

                if (running)
                    ClickLoop();
            }
        }

        public async void ClickLoop()
        {
            while (running)
            {
                await Task.Delay(random.Next(mouse_down_min, mouse_down_max));

                mouse_event(MOUSEEVENTF_MOVE, random.Next(0, 10), random.Next(0, 15),0,0);

                mouse_event(MOUSEEVENTF_LEFTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0);

                await Task.Delay(random.Next(mouse_up_min, mouse_up_max));

                mouse_event(MOUSEEVENTF_MOVE, random.Next(-10, 10), random.Next(-10, 10), 0, 0);

                mouse_event(MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Toggle(!running);
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (e.KeyboardData.VirtualCode == 164)
                Toggle(e.KeyboardState == GlobalKeyboardHook.KeyboardState.SysKeyDown);

        }
    }
}
