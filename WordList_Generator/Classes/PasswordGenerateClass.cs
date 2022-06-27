using System;
using System.Collections;
namespace WordList_Generator
{
    internal class PasswordGenerateClass
    {
        //ŞİFRE OLUŞTURMA METODLARI
        public ArrayList passwordGenerate2(ArrayList PassKeyWord)
        {
            SetWordListKeys WordList = new SetWordListKeys();
            ArrayList Passwords = new ArrayList();
            string sembol = "_-*/";

            //İKİLİ KOMBİNASYON
            for (int i = 0; i < PassKeyWord.Count; i++)
            {
                for (int j = 0; j < PassKeyWord.Count; j++)
                {
                    Passwords.Add(Convert.ToString(PassKeyWord[i]) + Convert.ToString(PassKeyWord[j]));
                }
            }
            //SEMBOLLÜ + ÜÇLÜ KOMBİNASYON
            for (int a = 0; a < sembol.Length ; a++)
            {
                for (int i = 0; i < PassKeyWord.Count; i++)
                {
                    for (int j = 0; j < PassKeyWord.Count; j++)
                    {
                        Passwords.Add(Convert.ToString(PassKeyWord[a]) + Convert.ToString(PassKeyWord[i]) + Convert.ToString(PassKeyWord[j]));
                        Passwords.Add(Convert.ToString(PassKeyWord[i]) + sembol[a] + Convert.ToString(PassKeyWord[j]));
                        for (int k = 0; k < PassKeyWord.Count; k++)
                        {
                            Passwords.Add(Convert.ToString(PassKeyWord[i]) + sembol[a] + Convert.ToString(PassKeyWord[j]) + Convert.ToString(PassKeyWord[k]));
                            Passwords.Add(Convert.ToString(PassKeyWord[i]) + Convert.ToString(PassKeyWord[j]) + sembol[a] + Convert.ToString(PassKeyWord[k]));
                            Passwords.Add(Convert.ToString(PassKeyWord[i]) + sembol[a] + Convert.ToString(PassKeyWord[j]) + sembol[a] + Convert.ToString(PassKeyWord[k]));
                        }
                    }
                }
            }
            return Passwords;
        }
    }
}
