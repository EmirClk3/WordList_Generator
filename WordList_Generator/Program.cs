using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading;

namespace WordList_Generator
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                goto START;
            }
            else if(process == "2"){}
            Console.ReadLine();
        }
    }
}
