using System;
using System.Linq;

namespace Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = "простой простой,. текст для.. примера., примера для1.. задания по по Строкам".ToLower().Split(' '); // меняем заглавные буквы и делим на подстроки
            int n = 1;
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = str[i].Trim('.', ',');  // убираем с текста . и ,
            }
            var val = str.Where(x => str.Count(z => z == x) == n).Distinct(); // создаем переменную, которая выбирает не повторяющиеся слова
            Console.WriteLine(string.Join(" ", val));
            Console.ReadKey();
        }
    }
}
