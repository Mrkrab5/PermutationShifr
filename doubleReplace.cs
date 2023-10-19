using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationShifr
{
    internal class doubleReplace
    {

        public doubleReplace()
        {

        }

        static public string Decoding(string massenge)
        {
            string tmpString = massenge.ToUpper(), result = "";

            int[,] sequence = new int[2, 6] { { 4, 2, 1, 3, 5, 0 }, { 5, 0, 3, 1, 4, 2 } };

            char[,] arraySymbol = new char[6, 6];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    //Пока длина строки больше 0 добавляем в массив элементы строки
                    if (tmpString.Length > 0)
                    {
                        if (tmpString[0] == ' ')
                            arraySymbol[i, j] = '_';
                        else
                            arraySymbol[i, j] = tmpString[0];
                        //Удаляем добавленный элемент
                        tmpString = tmpString.Substring(1, tmpString.Length - 1);
                    }
                    else
                        arraySymbol[i, j] = '_';
                }
            }
            
            char[,] swapColumn = new char[6, 6];
            //Перестановка колонок
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 6; j++)
                    swapColumn[j, i] = arraySymbol[j, sequence[0, i]];
            }

            arraySymbol = swapColumn;
            char[,] swapRow = new char[6, 6];
            //Перестановка строк
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    swapRow[i, j] = arraySymbol[sequence[1, i], j];
            }
            //Вывод результата сверху вниз слево направо
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                    result += swapRow[j, i];
            }

            return result;
        }
    }
}
