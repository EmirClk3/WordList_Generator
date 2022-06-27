using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace WordList_Generator
{
    internal class Program
    {
        [DllImport("kernel32.dll", ExactSpelling = true)]
        private static extern IntPtr GetConsoleWindow();
        private static IntPtr ThisConsole = GetConsoleWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int HIDE = 0;
        private const int MAXIMIZE = 3;
        private const int MINIMIZE = 6;
        private const int RESTORE = 9;
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);
            ShowWindow(ThisConsole, MAXIMIZE);
            FileProcessClass fileProcess = new FileProcessClass();SetWordListKeys listKeys = new SetWordListKeys();PasswordGenerateClass password = new PasswordGenerateClass();ViewClass viewer = new ViewClass();
            START:
            viewer.Signature();
            viewer.StartScreen();

            string process = Console.ReadLine();
            Console.Clear();
            viewer.Signature();

            if(process == "1")
            {
                string filePath = fileProcess.NewFileCreate();
                Console.Clear();
                viewer.Signature();
                ArrayList questionsAnswer = listKeys.questions();
                ArrayList passw = password.passwordGenerate2(questionsAnswer);
                fileProcess.FileWrite(filePath, passw);
                Console.Clear();
                viewer.Signature();
                viewer.writeComplate(filePath);
                Thread.Sleep(5000);
                Console.Clear();
                goto START;
            }
            else if(process == "2"){}
            Console.ReadLine();
        }
    }
}
