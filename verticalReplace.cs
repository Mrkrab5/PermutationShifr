using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationShifr
{
    internal class verticalReplace
    {

        public verticalReplace() 
        { 
        
        }

        static public string Decoding(string massenge, string word)
        {
            string tmpString = massenge.ToUpper(), result = "";

            int column = word.Length, row = massenge.Length % column == 0 ? 
                massenge.Length / column : massenge.Length / column + 1;
            
            char[,] arraySymbol = new char[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
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

            Random rnd = new Random();
            
            Dictionary <int, int> dictColumn = new Dictionary<int, int>();
            
            string keyStr = "";

            //Заполнение дополнительной строки случайными уникальными значениями
            for (int i = 0; i < word.Length; i++)
            {
                int v = rnd.Next(0, word.Length);
                //Проверка содержиться ли число в строке, если да то генерируем значение
                while (keyStr.Contains(v.ToString()))
                    v = rnd.Next(0, word.Length);
                //добавляем элемент со значеним - каким номером выводиться столбец : столбец
                dictColumn.Add(v, i);
                keyStr += v;
            }

            //Шифруем сообщение, идём от столбца к столбцу
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                    result += arraySymbol[j, dictColumn[i]];
            }

            return result;
        }
    }
}
