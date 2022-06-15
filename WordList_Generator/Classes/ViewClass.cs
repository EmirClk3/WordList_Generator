using System;
using System.IO;
using System.Threading;

namespace WordList_Generator
{
    internal class ViewClass
    {
        //USERINTERFACE METODLARI
        public void Signature()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write(
                "░░░░░░░░█████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                "░░░░█████████████░░░░░░░░░░░░░░███░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                "░░░██░░░░░░░░░░░██░░░░░░░░░░░██████████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                "░░░░░░░░░░░░░░░░░░░░░░░░░░░░██░░░░░░░░█░░╔═══╗░░░░░░░░░░░░░░░░░░░░╔╗░░░░░░░░░░░░░░░\n" +
                "░░░░░░░░░░░█████░░░░░░░░░░░░░░░░░░░░░░░░░║╔═╗║░░░░░░░░░░░░░░░░░░░░║║░░░░░░░░░░░░░░░\n" +
                "░░░░░░░░░░█░░░░███░░░░░░░░░░░░███████░░░░║╚═╝╠══╦══╦══╦╗╔╗╔╦══╦═╦═╝║░░░░░░░░░░░░░░░\n" +
                "░░░░░░░░░█░░░░░░░░█░░░░░░░░░░█░░░░░░█░░░░║╔══╣╔╗║══╣══╣╚╝╚╝║╔╗║╔╣╔╗║░░░░░░░░░░░░░░░\n" +
                "░░░░░░░░█░░░░░░░░░██░░░░░░░░█░░░░░░░█░░░░║║░░║╔╗╠══╠══╠╗╔╗╔╣╚╝║║║╚╝║░░░░░░░░░░░░░░░\n" +
                "░░░░░░░█░░░░░░░░░███░░░░░░██░░░░░░░███░░░╚╝░░╚╝╚╩══╩══╝╚╝╚╝╚══╩╝╚══╝░░░░░░░░░░░░░░░\n" +
                "░░░░░░█░░░░░░░░░████░░░░░█░░░░░░░█████░░░╔═══╦═══╦═╗░╔╦═══╦═══╦═══╦════╦═══╦═══╗░░░\n" +
                "░░░░░█░░░░░░░░░█████░░░░█░░░░░░░░█████░░░║╔═╗║╔══╣ ╚╗║║╔══╣╔═╗║╔═╗║╔╗╔╗║╔═╗║╔═╗║░░░\n" +
                "░░░░█░░░░░░░░░██████░░░░█░░░░░░░██████░░░║║░╚╣╚══╣╔╗╚╝║╚══╣╚═╝║║░║╠╝║║╚╣║░║║╚═╝║░░░\n" +
                "░░░░█░░░░░░░░░██████░░░█░░░░░░░███████░░░║║╔═╣╔══╣║╚╗ ║╔══╣╔╗╔╣╚═╝║░║║░║║░║║╔╗╔╝░░░\n" +
                "░░░░█░░░░░░░░██████░░░░█░░░░░░████████░░░║╚╩═║╚══╣║░║ ║╚══╣║║╚╣╔═╗║░║║░║╚═╝║║║╚╗░░░\n" +
                "░░░░██░░░░░░░█████░░░░█░░░░░░░████████░░░╚═══╩═══╩╝░╚═╩═══╩╝╚═╩╝░╚╝░╚╝░╚═══╩╝╚═╝░░░\n" +
                "░░░░░██░░░░░█████░░░░░█░░░░░░████████░░░░╔════╦═══╦═══╦╗░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                "░░░░░░██░░░░████░░█░░█░░░░░█████████░░░░░║╔╗╔╗║╔═╗║╔═╗║║░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                "░░░░░░░████████░░█░░░█░░░░░████████░░░░░░╚╝║║╚╣║░║║║░║║║░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                "░░░░░░░░░░░░░░░░█░░░░██░░███████░░░░░░░░░░░║║░║║░║║║░║║║░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                "░░░░░░░░░░░░░░░█░░░░░░████░░░░░░░░░░░░░░░░░║║░║╚═╝║╚═╝║╚══╗░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                "░░░░░░░░░░░░░░█░░░░░░░░░░░░░░░░░░░░░░░░░░░░╚╝░╚═══╩═══╩═══╝░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                "░░░░░░░░░░░░░░█░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                "░░░░░░░░░░░░░░░██░░█░░░░░░░░░░░░░░░░░░░░░░░╔╗░░╔╗░░░░░╔╗░░░╔═══╗░░╔═══╗░░╔═══╗░░░░░\n" +
                "░░░██░░░░░░░░░░░░░█░░░░░░░░░░░░██░░░░░░░░░░║╚╗╔╝║░░░░╔╝║░░░║╔═╗║░░║╔═╗║░░║╔═╗║░░░░░\n" +
                "░░░░████░░░░░░░░░░░░░░░░░░░░░████░░░░░░░░░░╚╗║║╔╝░░░░╚╗║░░░║║║║║░░║║║║║░░║║║║║░░░░░\n" +
                "░░░░░██████░░░░░░░░░░░░░░███████░░░░░░░░░░░░║╚╝║░╔══╗░║║░░░║║║║║░░║║║║║░░║║║║║░░░░░\n" +
                "░░░░░░█████████████████████████░░░░░░░░░░░░░╚╗╔╝░╚══╝╔╝╚╗╔╗║╚═╝║╔╗║╚═╝║╔╗║╚═╝║░░░░░\n" +
                "░░░░░░░███████████████████████░░░░░░░░░░░░░░░╚╝░░░░░░╚══╝╚╝╚═══╝╚╝╚═══╝╚╝╚═══╝░░░░░\n" +
                "░░░░░░░░░███████████████████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                "░░░░░░░░░░░░░░███████████░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                "░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░\n" +
                "░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Developed by Emirhan Çelik");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("░░░░░\n░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
        }
        public void StartScreen()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("WORDLİST OLUŞTURMA UYGULAMASINA HOŞ GELDİN");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n1- Yeni WordList Dosyası Oluştur\n2- Mevcut Dosyaları Listele");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("İşlem Seç: ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public void writer(string text, int speed)
        {
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(speed);
            }
        }
        public void writeComplate(string path)
        {
            FileInfo info = new FileInfo(path);
            Console.ForegroundColor = ConsoleColor.White;
            writer("WordList Yazdırılıyor Lütfen Bekleyin...", 60);
            Thread.Sleep(1000);
            Console.Write("\nWorld List Yazdırma Başarılı !");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\n|-<-Dosya Bilgileri->-|");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
                "Dosya adı: " + info.Name +
                "\nDosya yolu: " + info.FullName +
                "\nDosya boyutu: " + info.Length + "Byte" +
                "\nDosya oluşturma tarihi: " + info.CreationTime);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("5 Saniye Sonra Ana Ekrana Dönülücek!");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
        }
        public string NewFileCreateDesign()
        {
            string defaultLocation = "C:\\WORDLISTS";
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("DOSYA OLUŞTURMA BİLGİLERİ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("\nWordList dosya ismini girin: ");
            Console.ForegroundColor = ConsoleColor.White;
            string Name = "\\" + Console.ReadLine() + ".txt";
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("WordList dosya konumunu girin (C:\\WORDLISTS): ");
            Console.ForegroundColor = ConsoleColor.White;
            string PathS = Console.ReadLine();
            if (PathS == "")
            {
                return defaultLocation + Name;
            }
            else
            {
                string PathA = PathS + Name;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                return PathA;
            }
        }
    }
}
