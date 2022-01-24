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

        public int mouse_down_min => (int)mouseDownMin.Value;
        public int mouse_down_max => (int)mouseDownMax.Value;

        public int mouse_up_min => (int)mouseUpMin.Value;
        public int mouse_up_max => (int)mouseUpMax.Value;

        public bool running;

        public static Random random = new Random();

        private GlobalKeyboardHook _globalKeyboardHook;

        private void Form1_Load(object sender, EventArgs e)
        {
            _globalKeyboardHook = new GlobalKeyboardHook();

            _globalKeyboardHook.KeyboardPressed += OnKeyPressed;

            LoadSettings();

            FormClosing += (s, args) => SaveSettings();
        }

        void LoadSettings()
        {
            mouseDownMin.Value = (int)Properties.Settings.Default["MouseDownMin"];
            mouseDownMax.Value = (int)Properties.Settings.Default["MouseDownMax"];

            mouseUpMin.Value = (int)Properties.Settings.Default["MouseUpMin"];
            mouseUpMax.Value = (int)Properties.Settings.Default["MouseUpMax"];

            cursorMoveCheckBox.Checked = (bool)Properties.Settings.Default["ShiftCursor"];
        }

        void SaveSettings()
        {
            Properties.Settings.Default["MouseDownMin"] = (int)mouseDownMin.Value;
            Properties.Settings.Default["MouseDownMax"] = (int)mouseDownMax.Value;

            Properties.Settings.Default["MouseUpMin"] = (int)mouseUpMin.Value;
            Properties.Settings.Default["MouseUpMax"] = (int)mouseUpMax.Value;

            Properties.Settings.Default["ShiftCursor"] = cursorMoveCheckBox.Checked;

            Properties.Settings.Default.Save();
        }

        public void Toggle(bool value)
        {
            if (value != running)
            {
                running = value;
                activateButton.Text = running ? "DEACTIVATE" : "ACTIVATE";

                if (running)
                    ClickLoop();
            }
        }

        public async void ClickLoop()
        {
            while (running)
            {
                var down = random.Next(mouse_down_min, mouse_down_max);

                toolStripStatusLabel1.Text = $"MOUSE DOWN - {down}ms";

                await Task.Delay(down);

                if(cursorMoveCheckBox.Checked)
                    mouse_event(MOUSEEVENTF_MOVE, random.Next(0, 10), random.Next(0, 15),0,0);

                mouse_event(MOUSEEVENTF_LEFTDOWN, Cursor.Position.X, Cursor.Position.Y, 0, 0);

                var up = random.Next(mouse_up_min, mouse_up_max);

                toolStripStatusLabel1.Text = $"MOUSE UP - {up}ms";

                await Task.Delay(up);

                if (cursorMoveCheckBox.Checked)
                    mouse_event(MOUSEEVENTF_MOVE, random.Next(-10, 10), random.Next(-10, 10), 0, 0);

                mouse_event(MOUSEEVENTF_LEFTUP, Cursor.Position.X, Cursor.Position.Y, 0, 0);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (!running)
            {
                activateButton.Text = "3...";
                await Task.Delay(500);
                activateButton.Text = "2...";
                await Task.Delay(500);
                activateButton.Text = "1...";
                await Task.Delay(500);

                Toggle(true);
            } else
            {
                Toggle(false);
            }
        }

        private void OnKeyPressed(object sender, GlobalKeyboardHookEventArgs e)
        {
            if (e.KeyboardData.VirtualCode == 164)
                Toggle(e.KeyboardState == GlobalKeyboardHook.KeyboardState.SysKeyDown);

        }
    }
}
