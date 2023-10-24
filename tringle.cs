using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationShifr
{
    internal class tringle
    {


        public tringle() 
        {
        
        }

        static public string Decoding(string massenge, string key)
        {
            string tmpString = massenge.ToUpper(), result = "";

            int countSymbol = 0, row, addSymbol = 0, itogSymbol = 0;

            tmpString = tmpString.Replace(" ", "_");
            //Подсчёт кол-ва эл-в в строке
            for (int i = 0; i < massenge.Length; i++)
            {
                if (countSymbol == addSymbol || (countSymbol != addSymbol && i + 1 == massenge.Length))
                {
                    countSymbol++;
                    addSymbol = 0;
                }
                else
                    addSymbol++;
            }
            //Подсчёт сколько всего символов должно быть в треугольнике
            for (int i = 1; i <= countSymbol; i++)
                itogSymbol += i;
            //Добавление недостающих символов
            for (int i = 0; i < itogSymbol; i++)
            {
                if (tmpString.Length <= i)
                    tmpString += '_';
            }
            
            //Создание массива символов под размер треугольника
            char[,] arraySymbol = new char[countSymbol, countSymbol * 2 - 1];

            row = countSymbol;

            //Переменная для подсчёта того сколько символов осталось ввести
            int remainingSymbol = tmpString.Length - 1;
            
            //Заполнение массива символами
            for (int i = countSymbol - 1; i >= 0; i--)
            {
                for(int j = countSymbol * 2 - 2; j >= 0; j--)
                {
                    //Если количество символов нечётное, если индекс строки сейчас чётный то символы
                    //пишутся только на чётных местах
                    //если нечётный то наоборот, последнее условие делает запись в виде треугольника
                    if (countSymbol % 2 == 1 && (((i % 2 == 0 && j % 2 == 0) || (i % 2 == 1 && j % 2 == 1)) && 
                        (j <= countSymbol * 2 - countSymbol + i - 1 && j >= countSymbol - i - 1)))
                    {
                        arraySymbol[i, j] = tmpString[remainingSymbol];
                        remainingSymbol--;
                    }
                    //Если количество символов чётное, если индекс строки сейчас чётный то символы
                    //пишутся только на нечётных местах
                    //если нечётный то наоборот, последнее условие делает запись в виде треугольника
                    else if (countSymbol % 2 == 0 && (((i % 2 == 0 && j % 2 == 1) || (i % 2 == 1 && j % 2 == 0)) &&
                        (j <= countSymbol * 2 - countSymbol + i - 1 && j >= countSymbol - i - 1)))
                    {
                        arraySymbol[i, j] = tmpString[remainingSymbol];
                        remainingSymbol--;
                    }
                }
            }

            Dictionary<char, int[]> dictSortKey = new Dictionary<char, int[]>();

            //Добавляем символы если их не хватает
            if (key.Length < itogSymbol)
            {
                int n = key.Length;
                for (int i = 0; i < countSymbol * 2 - 1; i++)
                {
                    if (key.Length <= i)
                        key += key[i % n];
                }
            }
            else
                key = key.Substring(0, countSymbol * 2 - 1);
            
            //Добавление элементов в словарь dictSortKey
            for (int i = 0; i < key.Length; i++)
            {
                //Если элемента ещё нет в словаре
                if (!dictSortKey.ContainsKey(key[i]))
                {
                    //Количество символов в строке
                    countSymbol = key.Split(key[i]).Count() - 1;
                    
                    //Создаём массив для индексов, чтобы потом по ним сортировать
                    int[] arrayCount = new int[countSymbol];
                    
                    //Заполнение массива индексов значениями для исключения ситуации,
                    //когда индекс равен 0
                    for (int j = 0; j < countSymbol; j++)
                        arrayCount[j] = -1;

                    //Поиск повторяющихся символов и добавление их индексов
                    //в массив если их нет в словаре
                    for(int j = 0; j < countSymbol; j++)
                    {
                        //можно добавлять в массив индексов
                        bool may = true;
                        for (int k = 0; k < key.Length; k++)
                        {
                            //Если элементы равны и его индекс не находиться в массива и можно добавлять
                            if (key[k] == key[i] && !arrayCount.Contains(k) && may)
                            {
                                arrayCount[j] = k;
                                may = false;
                            }
                        }
                    }
                    //Добавление символа и индексов на которых он встречается в словарь
                    dictSortKey.Add(key[i], arrayCount);
                }
            }
            //Строка для проверки добавленных символов
            string addedSymbol = "";

            //Составление строки из уникальных символов ключа
            for(int i = 0; i < key.Length; i++)
            {
                if (!addedSymbol.Contains(key[i]))
                    addedSymbol += key[i];
            }
            
            //Строка для сортировки в алфавитном порядке
            addedSymbol = String.Concat(addedSymbol.OrderBy(ch => ch));

            //Заполнение результата
            for (int i = 0; i < addedSymbol.Length; i++)
            {
                //Получаем количество, сколько раз встречается символ
                countSymbol = dictSortKey[addedSymbol[i]].Count();
                
                //Добавление в результат столбца из словаря по индексу
                for(int j = 0; j < countSymbol; j++)
                {
                    for (int k = 0; k < row; k++)
                    {
                        //Если символ в строке не равен пустому значению
                        if (arraySymbol[k, dictSortKey[addedSymbol[i]][j]] != '\0')
                            result += arraySymbol[k, dictSortKey[addedSymbol[i]][j]];
                    }
                }
            }

            return result;
        }
    }
}
