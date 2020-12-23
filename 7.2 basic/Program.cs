using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2_basic
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Задача организации, в особенности же новая модель, организационной деятельности. Способствует подготовке и реализации модели развития.";
            int countSymbols = 0;
            char[] symbols = { ',', '.' };

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < symbols.Length; j++)
                {
                    if (text[i].ToString() == symbols[j].ToString())
                    {
                        countSymbols++;
                    }
                }
            }
            Console.WriteLine(countSymbols);
            Console.ReadKey();
        }
    }
}
