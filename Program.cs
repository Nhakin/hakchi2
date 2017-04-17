﻿#pragma warning disable 0618
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace com.clusterrr.hakchi_gui
{
    static class Program
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if DEBUG
            try
            {
                AllocConsole();
                Debug.Listeners.Add(new TextWriterTraceListener(System.Console.Out));
            }
            catch { }
            try
            {
                Stream logFile = File.Create("debuglog.txt");
                Debug.Listeners.Add(new TextWriterTraceListener(logFile));
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message + ex.StackTrace);
            }
            Debug.AutoFlush = true;
#endif
            bool createdNew = true;
            using (Mutex mutex = new Mutex(true, "hakchi2", out createdNew))
            {
                if (createdNew)
                {
                    // For updates
                    AppDomain.CurrentDomain.AppendPrivatePath("languages");
                    var oldFiles = Directory.GetFiles(Path.GetDirectoryName(Application.ExecutablePath), "hakchi.resources.dll", SearchOption.AllDirectories);
                    foreach (var d in oldFiles)
                        if (!d.Contains(@"\languages\"))
                        {
                            var dir = Path.GetDirectoryName(d);
                            Debug.WriteLine("Removing old directory: " + dir);
                            Directory.Delete(dir, true);
                        }

                    Debug.WriteLine("Starting, version: " + Assembly.GetExecutingAssembly().GetName().Version);
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                    Debug.WriteLine("Done.");
                }
                else
                {
                    Process current = Process.GetCurrentProcess();
                    foreach (Process process in Process.GetProcessesByName("hakchi"))
                    {
                        if (process.Id != current.Id)
                        {
                            ShowWindow(process.MainWindowHandle, 9); // Restore
                            SetForegroundWindow(process.MainWindowHandle); // Foreground
                            break;
                        }
                    }
                }
            }
        }
    }
}
