using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//11).	Дана строка, содержащая текст на русском языке. 
//В предложениях некоторые из слов записаны подряд несколько раз 
//(предложение заканчивается точкой или знаком восклицания). 
//Получить в новой строке отредактированный текст, в котором удалены подряд идущие вхождения 
//слов в предложениях.
namespace ConsoleApp1
{
    class Program
    {

        public static string letterUp(string read)
        {

            StringBuilder text = new StringBuilder(read);
            int num = 2;
            for (int i = 0; i < text.Length; i++)
            {
                if (i < text.Length - num)
                {
                    if (text[i] == '!')
                    {
                        text[i + num] = Char.ToUpper(text[i + num]);
                    }
                    if (text[i] == '.')
                    {
                        text[i + num] = Char.ToUpper(text[i + num]);
                    }
                }

            }
            return Convert.ToString(text);
        }
        static string Del(string text)
        {
            string word = "";
            int num = 1;
            string rightText = "";
            for (int i = 0; i < text.Length - num; i++)
            {
                word += text[i];
                if (text[i + num] == ' ' || text[i + num] == '.' || text[i + num] == '!')
                {
                    int number, cmprsn = 3;
                    number = text.ToLower().IndexOf(word.ToLower(), i);
                    if (number < cmprsn)
                    {
                        rightText += word;
                    }
                    word = "";
                    if (text[i + num] == '.')
                    {
                        rightText += ".";
                    }
                    if (text[i + num] == '!')
                    {
                        rightText += "!";
                    }
                }
            }
            return letterUp(rightText);

            
        }
        static void Main(string[] args)
        {
              string text = "Это короткий текст текст текст    текст, текст! Из из него необходимо удалить удалить удалить все все все все повторяющиеся слова слова слова.";
              //Console.WriteLine($"Текст:\n{text}");
            Console.WriteLine(Del(text));
        //    string word = "";
        //    int num = 1;
        //    string rightText = "";
        //    for (int i = 0; i < text.Length - num; i++)
        //    {
        //        word += text[i];
        //        if (text[i + num] == ' ' || text[i + num] == '.' || text[i + num] == '!')
        //        {
        //            int number, cmprsn = 3;
        //            number = text.ToLower().IndexOf(word.ToLower(), i);
        //            if (number < cmprsn)
        //            {
        //                rightText += word;
        //            }
        //            word = "";
        //            if (text[i + num] == '.')
        //            {
        //                rightText += ".";
        //            }
        //            if (text[i + num] == '!')
        //            {
        //                rightText += "!";
        //            }
        //        }
        //    }
        //    letterUp(rightText);
        //}
        }
    }
}
