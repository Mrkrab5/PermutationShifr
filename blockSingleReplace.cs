using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationShifr
{
    internal class blockSingleReplace
    {

        public blockSingleReplace() 
        {
        
        }

        static public string Decoding(string massenge)
        {
            string n = massenge.ToUpper(), bigReg = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            
            Random rnd = new Random();

            if (massenge.Length % 3 == 1)
                n += $"{bigReg[rnd.Next(0, bigReg.Length)]}{bigReg[rnd.Next(0, bigReg.Length)]}";
            else if (massenge.Length % 3 == 2)
                n += $"{bigReg[rnd.Next(0, bigReg.Length)]}";
        }
    }
}
