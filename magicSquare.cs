using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationShifr
{
    internal class magicSquare
    {

        public magicSquare() 
        {
        
        }

        static public string Decoding(string massenge)
        {
            string tmpString = massenge.ToUpper(), strEncrypt = "", result = "";

            Dictionary<int, int[]> dictPlaceSymbol = new Dictionary<int, int[]>
            { {15, new int[] {0, 0}}, { 1, new int[] {0, 1}}, { 2, new int[] {0, 2}}, {12, new int[] {0, 3}},
              { 4, new int[] {1, 0}}, {10, new int[] {1, 1}}, { 9, new int[] {1, 2}}, { 7, new int[] {1, 3}},
              { 8, new int[] {2, 0}}, { 6, new int[] {2, 1}}, { 5, new int[] {2, 2}}, {11, new int[] {2, 3}},
              { 3, new int[] {3, 0}}, {13, new int[] {3, 1}}, {14, new int[] {3, 2}}, { 0, new int[] {3, 3}}};

            char[,] arraySymbol = new char[4, 4];

            tmpString = tmpString.Replace(" ", "");
            //Заполнение строки и массива символов для шифрования
            for (int i = 0; i < 16; i++)
            {
                //Если ещё есть что шифровать из строки
                if (tmpString.Length > i)
                        strEncrypt += tmpString[i];
                else
                    strEncrypt += '_';

                arraySymbol[dictPlaceSymbol[i][0], dictPlaceSymbol[i][1]] = strEncrypt[i];
            }

            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                    result += arraySymbol[i, j];
            }

            return result;
        }
    }
}
