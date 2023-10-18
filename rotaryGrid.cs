using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationShifr
{
    internal class rotaryGrid
    {

        public rotaryGrid() 
        {
        
        }

        static public string Decoding(string massenge)
        {
            string tmpString = massenge.ToUpper(), result = "", strEncrypt = "";
            
            char[,] arraySymbol = new char[6, 6];

            int[,] arrayPlace = new int[4, 9] 
            { {1,   3,  5,  6,  8, 10, 13, 15, 17}, {0,   2,  4,  7,  9, 11, 12, 14, 16},
              {19, 21, 23, 24, 26, 28, 31, 33, 35}, {18, 20, 22, 25, 27, 29, 30, 32, 34}};
                        
            //Заполнение строки для шифрования
            for (int i = 0; i < 36; i++)
            {
                //Если ещё есть что шифровать из строки
                if (massenge.Length > i)
                {
                    if (tmpString[i] != ' ')
                        strEncrypt += tmpString[i];
                    else
                        strEncrypt += '_';
                }
                else
                    strEncrypt += '_';
            }

            int countEncrypt = 0;
            //Заполнение массива символов из strEncrypt по позициям arrayPlace
            for (int i = 0; i < 4; i++)
            {
                int shift = i < 2 ? 0 : 3;

                for (int j = 0; j < 9; j++)
                {
                    //строка высчитывается с учётом переворота "трофарета" и т.к. по 3 символа в строке
                    //считается в какой строке мы находимся, а столбец зависит от остатка деления места
                    //на 6 т.е. на количество столбцов
                    arraySymbol[j / 3 + shift, arrayPlace[i, j] % 6] = strEncrypt[countEncrypt];
                    countEncrypt++;
                }
            }
            //Формирования строки результата
            for(int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    result += arraySymbol[j, i];
            }

            return result;
        }
    }
}
