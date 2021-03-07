using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.IO;
using System.Windows.Input;
//using AutoItX3Lib;

namespace ByteMacro
{
    public partial class Form1 : Form
    {
        //AutoItX3 au3 = new AutoItX3();
        Functions func = new Functions();
        //FormData DataManager.data = new();

        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(Keys vKey);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point lpPoint);

        private const int LEFTDOWN = 0x0002;
        private const int LEFTUP = 0x0004;

        Color oldCol;
        Color newCol;

        Point xy;

        int initialHeightOffset;
        int initialWidthOffset;

        private bool aimbotThread = false;

        //To abort threads when closing because Thread.Abort no longer works
        public static bool isClosing = false;

        public Form1()
        {
            InitializeComponent();
            int offsetX = Convert.ToInt32(numericX.Value);
            int offsetY = Convert.ToInt32(numericY.Value);
            xy = new Point(Screen.PrimaryScreen.Bounds.Width / 2 + offsetX, Screen.PrimaryScreen.Bounds.Height / 2 + offsetY);
            
            initialHeightOffset = this.Height - output.Height;
            initialWidthOffset = this.Width - output.Width;

            //TODO: DataManager.data Saving/Loading
            if (!File.Exists("DataManager.data.xml")) Data.saveData();

            var formData = Data.loadData();
            if (formData != null)
            {
                trigKey.Text = DataManager.data.trigKey;
                macroKey.Text = DataManager.data.macroKey;
                macroDelay.Value = DataManager.data.macroDelay;
                macroOutput.Text = DataManager.data.macroOutput;

                autoclickKey.Text = DataManager.data.ACKey;
                autoclickDelay.Value = DataManager.data.ACDelay;
            }

            //SET LANGUAGE TO ENGLISH
            System.Globalization.CultureInfo.DefaultThreadCurrentUICulture = System.Globalization.CultureInfo.GetCultureInfo("en-US");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Thread tb = new Thread(trigger) { IsBackground = true };
            Thread sm = new Thread(spaceMacro) { IsBackground = true };
            sm.SetApartmentState(ApartmentState.STA);
            tb.Start();
            sm.Start();

            Thread ac = new Thread(autoClicker) { IsBackground = true };
            ac.SetApartmentState(ApartmentState.STA);
            ac.Start();
        }

        void trigger()
        {
            while (isClosing==false)
            {
                Keys key = returnKeyFromString(trigKey.Text);
                if (GetAsyncKeyState(key) < 0)
                {
                    Thread.Sleep(10);
                    oldCol = getPixel(xy);
                    output.Text += "\n" + DateTime.Now.ToString("HH: mm: ss") + " Triggerbot toggled on " + oldCol.ToString();
                    Thread.Sleep(5);
                    newCol = getPixel(xy);
                    if (oldCol.Equals(newCol) == false)
                    {
                        Thread.Sleep(10);
                        ByteMacro.Autoclicker.MouseClick();
                        output.Text += "\n" + DateTime.Now.ToString("HH: mm: ss") + " Triggered " + newCol.ToString();
                        Thread.Sleep(2000);
                    }
                }
                Thread.Sleep(2);
            }
        }

        private bool latestState = false;
        void spaceMacro()
        {
            while (isClosing==false)
            {
                if (checkBoxToggle.Checked == true)
                {
                    Keys key = returnKeyFromString(macroKey.Text);
                    if (GetAsyncKeyState(key) < 0)
                    {
                        if (checkBoxSpace.Checked)
                        {
                            func.pressSpaceBar();
                            output.Text += "\n" + DateTime.Now.ToString("HH: mm: ss") + " Spacebar macro toggled";
                            Thread.Sleep(Convert.ToInt32(macroDelay.Value));
                        }
                        else
                        {
                            if (checkBoxEnter.Checked)
                            {
                                SendKeys.SendWait(macroOutput.Text + "{ENTER}");
                                Thread.Sleep(Convert.ToInt32(macroDelay.Value));
                            }
                            else
                            {
                                SendKeys.SendWait(macroOutput.Text);
                                Thread.Sleep(Convert.ToInt32(macroDelay.Value));
                            }
                        }
                    }
                }
                else
                {
                    Key key = convertKey(macroKey.Text);
                    if (Keyboard.IsKeyToggled(key))
                    {
                        if (Keyboard.IsKeyToggled(key) != latestState)
                        {
                            output.Text += $"Macro {Keyboard.IsKeyToggled(key)}";
                        }

                        if (checkBoxSpace.Checked)
                        {
                            func.pressSpaceBar();
                            output.Text += "\n" + DateTime.Now.ToString("HH: mm: ss") + " Spacebar macro toggled";
                            Thread.Sleep(Convert.ToInt32(macroDelay.Value));
                        }
                        else
                        {
                            if (checkBoxEnter.Checked)
                            {
                                SendKeys.SendWait(macroOutput.Text + "{ENTER}");
                                Thread.Sleep(Convert.ToInt32(macroDelay.Value));
                            }
                            else
                            {
                                SendKeys.SendWait(macroOutput.Text);
                                Thread.Sleep(Convert.ToInt32(macroDelay.Value));
                            }
                        }
                    }
                    latestState = Keyboard.IsKeyToggled(key);
                }
                Thread.Sleep(2);
            }
        }

        //TODO: Make aimbot work
        void aimbot()
        {
            Point nullPoint = new Point(-1, -1);
            while (aimbotThread==true)
            {
                Keys key = returnKeyFromString(aimKey.Text);

                int x1 = Convert.ToInt32(coords1.Text.Split(',')[0]);
                int y1 = Convert.ToInt32(coords1.Text.Split(',')[1]);

                int x2 = Convert.ToInt32(coords2.Text.Split(',')[0]);
                int y2 = Convert.ToInt32(coords2.Text.Split(',')[1]);

                int r = Convert.ToInt32(targetCol.Text.Split(',')[0]);
                int g = Convert.ToInt32(targetCol.Text.Split(',')[1]);
                int b = Convert.ToInt32(targetCol.Text.Split(',')[2]);
                Color col = Color.FromArgb(r, g, b);
                //int hexCol = rgbToHex(col);

                if (GetAsyncKeyState(key) < 0)
                {
                    /*if (count == 1)*/ output.Text += "\nStarted color aimbot";
                    try
                    {
                        Point pos = func.pixelSearch(x1, y1, x2, y2, col);
                        if (pos != nullPoint)
                        {
                            output.Text += "\n found target color at " + pos.ToString();
                            func.setCursorPos(pos);
                            //mouseClick();
                        }

                        /*object pix = au3.PixelSearch(x1, y1, x2, y2, hexCol);
                        if (pix.ToString() != "1")
                        {
                            object[] pixCoord = (object[])pix;
                            au3.MouseClick("LEFT", (int)pixCoord[0], (int)pixCoord[1], 1, 1);
                        }*/
                    }
                    catch { }
                }
                Thread.Sleep(2);
            }
        }

        private bool latestACState = false;
        void autoClicker()
        {
            while (isClosing==false)
            {   
                if (autoclickToggle.Checked)
                {
                    Key key = convertKey(autoclickKey.Text);
                    if (Keyboard.IsKeyToggled(key) != latestACState)
                    {
                        output.Text += $"Autoclicker {Keyboard.IsKeyToggled(key)}\n";
                    }
                    int delay = Convert.ToInt32(autoclickDelay.Value);
                    
                    if (Keyboard.IsKeyToggled(key))
                    {
                        ByteMacro.Autoclicker.MouseClick();
                        Thread.Sleep(delay);
                    }
                    latestACState = Keyboard.IsKeyToggled(key);
                }
                
                Thread.Sleep(4);
            }
        }

        public Color getPixel(Point position)
        {
            using(var bitmap = new Bitmap(1, 1))
            {
                using(var graphics = Graphics.FromImage(bitmap))
                {
                    graphics.CopyFromScreen(position, new Point(0, 0), new Size(1, 1));
                }
                return bitmap.GetPixel(0, 0);
            }
        }

        public Keys returnKeyFromString(string key)
        {
            return (Keys)Enum.Parse(typeof(Keys), key, true);
        }
        public Key convertKey(string _key)
        {
            return (Key)Enum.Parse(typeof(Key), _key, true);
        }

        //----------FORM CLOSING----------//
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isClosing = true;

            //TODO: DataManager.data Saving

            DataManager.data.trigKey = trigKey.Text;

            DataManager.data.macroKey = macroKey.Text;
            DataManager.data.macroDelay = macroDelay.Value;
            DataManager.data.macroOutput = macroOutput.Text;

            DataManager.data.ACKey = autoclickKey.Text;
            DataManager.data.ACDelay = autoclickDelay.Value;

            Data.saveData();

            Environment.Exit(0);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            output.Height = this.Height - initialHeightOffset;
            output.Width = this.Width - initialWidthOffset;
        }

        public Point getCursorPosition()
        {
            Point lpPoint;
            GetCursorPos(out lpPoint);
            return lpPoint;
        }

        int clickCount = 0;
        private void btnCursorDetails_Click(object sender, EventArgs e)
        {
            clickCount++;
            if (clickCount < 2)
            {
                MessageBox.Show("Click on the desired pixel of the screen to get position and color of the pixel", "Hey", MessageBoxButtons.OK);
            }
            while (true)
            {
                if (GetAsyncKeyState(Keys.LButton) < 0)
                {
                    Point cursorPos = getCursorPosition();
                    Color pixelColor = getPixel(cursorPos);

                    for (int i = 0; i < 15; i++) output.Text += "//";
                    string text = "\nPos: " + cursorPos.ToString() + "\nColor: " + pixelColor.ToString() + "\n";
                    output.Text += text;
                    for (int i = 0; i < 15; i++) output.Text += "//";
                    output.Text += "\n";
                    break;
                }
                Thread.Sleep(2);
            }
        }

        int rgbToHex(Color color)
        {
            string hex = "0x" + color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
            return Convert.ToInt32(hex, 16);
        }

        private void aimToggle_CheckedChanged(object sender, EventArgs e)
        {
            Thread ab = new Thread(aimbot) { IsBackground = true };
            if (aimToggle.Checked == true)
            {
                aimbotThread = true;
            }
            else
            {
                aimbotThread = false;
            }
        }

        private void checkBoxSpace_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSpace.Checked) macroOutput.ReadOnly = true;
            else macroOutput.ReadOnly = false;
        }

    }
}
