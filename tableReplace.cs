using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationShifr
{
    internal class tableReplace
    {

        public tableReplace() 
        {
        
        }

        static public string Decoding(string massenge)
        {
            string tmpString = massenge.ToUpper(), result = "";
            
            int row = massenge.Length % 6 == 0 ? massenge.Length / 6 : massenge.Length / 6 + 1;
            
            char[,] arraySymbol = new char[row, 6];

            for (int i = 0; i < row; i++)
            {
                for(int j = 0; j < 6; j++)
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
            //Шифруем сообщение, идём от столбца к столбцу
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < row; j++)
                    result += arraySymbol[j, i];
            }

            return result;
        }
    }
}
