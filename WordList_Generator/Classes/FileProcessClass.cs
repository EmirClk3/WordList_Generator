using System;
using System.Collections;
using System.IO;

namespace WordList_Generator
{
    //DOSYA İŞLEMLERİ
    internal class FileProcessClass
    {
        ViewClass view = new ViewClass();
        public string NewFileCreate()
        {
            String FilePath = view.NewFileCreateDesign();
            if (!File.Exists(FilePath))
            {
                File.Create(FilePath).Close();
                Console.Write("WordList Dosyası ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(FilePath);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(" Konumuna Oluşturuldu");
            }
            else
            {
                Console.WriteLine("Dosya zaten mevcut");
            }
            return FilePath;
        }
        public void FileWrite(string path, ArrayList list)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            for (int i = 0; i < list.Count; i++)
            {
                string control = Convert.ToString(list[i]);
                if(control.Length > 5)
                {
                    streamWriter.WriteLine(control);
                }
            }
            streamWriter.Close();

        }

    }

    //WORDLİST KEYWORD SORULARI
    public class SetWordListKeys
    {
        public ArrayList questions()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("DOSYA İÇİN KEYWORD BİLGİLERİNİ GİRİN");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            string[] questionArray = { "İsim: ", "Soyisim: ", "Yaşı: ", "Doğum Yılı: ", "Baba Adı: ", "Anne Adı: ", "Kardeş adı: ", "Yaşadığı Şehir: ", "Plakası: ", "Nereli: ", "Plakası: ", "Evcil Hayvan Adı: ","Kullanmak İstediğiniz Sembol(Yoksa Boş Geçebilirsin): ","Eklemek İstediğiniz Keyword Var Mı (Y/N)" };
            ArrayList question = new ArrayList();
            for (int i = 0; i < questionArray.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(questionArray[i]);
                Console.ForegroundColor = ConsoleColor.White;
                string answer = Console.ReadLine();
                if (answer != "") { question.Add(answer); }
                else { }
            }

            if (Convert.ToString(question[question.Count - 1]) == "Y")
            {
                question.RemoveAt(question.Count - 1);
                while (true)
                {
                    Console.Write("Eklemek İstediğiniz Keyword (Çıkmak için '.'): ");
                    string ExternalQuestion = Console.ReadLine();
                    if (ExternalQuestion != ".")
                    {
                        if (ExternalQuestion != "")
                        {
                            question.Add(ExternalQuestion);
                        }
                        else { }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else
            {
                question.RemoveAt(question.Count - 1);
            }
            return question;
        }
    }
}