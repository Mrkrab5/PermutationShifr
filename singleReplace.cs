using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationShifr
{
    internal class singleReplace
    {

        public singleReplace() 
        { 
        
        }

        static public string Decoding(string massenge)
        {
            string result = "", n = massenge.ToUpper(), tmpString = "";

            Random rnd = new Random();
            
            //Заполнение дополнительной строки случайными уникальными значениями
            for(int i = 0; i < massenge.Length; i++)
            {
                int v = rnd.Next(0, massenge.Length);
                //Проверка содержиться ли число в строке, если да то генерируем значение
                while(tmpString.Contains(v.ToString()))
                    v = rnd.Next(0, massenge.Length);

                tmpString += $"{v} ";
            }

            int h = 0;
            string number = "";
            //Пока всё не зашифровали
            while(h < tmpString.Length)
            {
                if (tmpString[h] != ' ')
                    number += tmpString[h];
                else
                {
                    result += n[Int32.Parse(number)];
                    number = "";
                }
                h++;
            }

            return result;
        }
    }
}
