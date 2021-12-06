using System.Linq;
using System;

namespace Exersizes
{
    /*
     * 1.Напишите функцию, которая принимает массив с разными числами, 
     * а возвращает наиболее встрещающееся число из этого массива.
     * 
     * 2.Напишите функцию, которая принимает массив с разными числами, 
     * а возвращает максимальное произведение двух чисел из этого массива.
     * 
     * 3.Напишите функцию, которая принимает строку, 
     * а возвращает ее перевернутый вариант (слова в обратном порядке).
     * 
     * 4.Напишите функцию, которая принимает две строки: string1 и string2, 
     * а возвращает "yes", если вторая строка является анаграммой первой, и "no", если нет. 
     * Одна строка является анаграммой другой строки, если из первой можно получить вторую путём перестановки символов.
     */

    class Program
    {
        public static int Ex_1(int[] arr)
        {
            int result = arr[0];
            int LastCounter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 0;

                for (int j = 0; j < arr.Length; j++)
                    if (arr[i] == arr[j])
                        counter++;

                if (counter >= LastCounter)
                {
                    result = arr[i];
                    LastCounter = counter;
                }
            }
            return result;
        }
        public static int Ex_2(int[] arr)
        {
            int multiple = arr[0];

            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length; j++)
                    if (arr[i] * arr[j] > multiple)
                        multiple = arr[i] * arr[j];

            return multiple;
        }
        public static string Ex_3(string str)
        {
            string revStr = "";
            string[] words = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = words.Length - 1; i >= 0; i--)
            {
                revStr += (" " + words[i]);
            }

            return revStr.Trim(' ');
        }
        public static string Ex_4(string str1, string str2)
        {
            

            return "";
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 2, 2, 3, 0 };
            Console.WriteLine(Ex_1(array));
            Console.WriteLine(Ex_2(array));

            string str = "Ma Pa   Da  Ba";
            Console.WriteLine(Ex_3(str));
        }
    }
}
