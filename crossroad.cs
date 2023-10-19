using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationShifr
{
    internal class crossroad
    {

        public crossroad()
        {

        }

        static public string Decoding(string massenge)
        {
            string tmpString = massenge.ToUpper(), result = "";

            int n = 2, circle = massenge.Length % 4 == 0 ? massenge.Length / 4 : massenge.Length / 4 + 1;

            Dictionary<int, string> dictCircle = new Dictionary<int, string>();
            //Заполнение словаря по "кругам"
            for (int i = 0; i < circle; i++)
            {
                string strEncrypt = "";

                for (int j = 0; j < 4; j++)
                {
                    if (tmpString.Length > i * 4 + j)
                    {
                        if (tmpString[i * 4 + j] != ' ')
                            strEncrypt += tmpString[i * 4 + j];
                        else
                            strEncrypt += '_';
                    }
                    else
                        strEncrypt += '_';
                }

                dictCircle.Add(i, strEncrypt);
            }
            //Если количество "кругов" не чётное, добовляем 1 "круг" заполненный пробелами
            //для правильной работы алгоритма
            if (circle % 2 == 1)
            {
                dictCircle.Add(circle, "____");
                circle++;
            }
            //Запись зашифрованного сообщения
            for (int i = 0; i < circle; i += 2)
                result += $"{dictCircle[i][1]}{dictCircle[i + 1][1]}" +
                          $"{dictCircle[i][0]}{dictCircle[i][2]}{dictCircle[i + 1][0]}{dictCircle[i + 1][2]}" +
                          $"{dictCircle[i][3]}{dictCircle[i + 1][3]}";
            
            return result;
        }
    }
}
