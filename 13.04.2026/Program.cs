using System.Globalization;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- Contains(содержит) ---

            string world = "Hello";
            Console.WriteLine(world.Contains("ll"));
            Console.WriteLine(world.Contains("oll"));
            // если строка содержит подстроку "lo" вывести на консоль Succes
            if (world.Contains("lo")) // необязательно писать ==true
            {
                Console.WriteLine("Success");
            }
            else
            {
                Console.WriteLine("Error");
            }
            char[] example = { 'a', '.', '0' };// нельзя писать " только '
            Console.WriteLine(example.Contains(','));
            Console.WriteLine(example.Contains('a'));
            char[] punc = { '.', '!', '?', ',', ':', '\"', ';', '–', '(', ')', '[', ']', '{', '}', '/' };
            char x = 'a';
            if (punc.Contains(x)) // можно написать "aaa".Contains(x)
            {
                Console.WriteLine("The symbol is punc");
            }
            else
            {
                Console.WriteLine("It is not");
            }

            Console.WriteLine();

            // --- Replace ---

            string text = "Cat and dog dogsii love";
            // можно проверять по слову, рассмотреть dogsii и сравнить с dog
            text.Replace("dog", "kittens"); // не меняет текст
            Console.WriteLine(text);
            text = text.Replace("dog", "kittens");
            Console.WriteLine(text.Replace("dog","kittens")); // если будет несколько dog, то изменяться все dog

            string textik = "I love coffee";
            Console.WriteLine(textik.Replace("coffee", "tea"));

            Console.WriteLine();

            // --- Trim ---

            string world2 = "  cat  ,";
            string world3 = "cat";
            Console.WriteLine(world2 + " изначальное");
            world2 = world2.Trim(' '); // удаляет с краев
            Console.WriteLine(world2+ " 1");

            world2 = "  cat  ,";
            world2 = world2.Trim('t');
            Console.WriteLine(world2 + " 2");

            world2 = "  cat  ,";
            world2 = world2.Trim(' ', ',','t');
            Console.WriteLine(world2 + " 3");

            world2 = "cat,";
            world2 = world2.Trim(punc); // останется ток cat
            Console.WriteLine(world2 + " 4");

            Console.WriteLine();

            // --- Split ---

            string text2 = "Hello, my clear 2 friends!";
            string[] dirtyWorlds = text2.Split(punc, StringSplitOptions.RemoveEmptyEntries); // удаляет пустые строки 
            //string[] dirtyWorlds = text2.Split(' ');
            for (int i = 0; i<dirtyWorlds.Length; i++)
            {
                Console.WriteLine(dirtyWorlds[i]);
            }

            Console.WriteLine();

            // --- Join ---

            string text3 = String.Join(" ", dirtyWorlds);
            Console.WriteLine(text3);
            Console.WriteLine();

            // --- IdDigit/IsLetter ---

            char s = 'a';
            Console.WriteLine(Char.IsLetter(s)); // буква
            Console.WriteLine(Char.IsDigit(s)); // цифра
            Console.WriteLine(Char.IsPunctuation(s)); // пунктуация
            Console.WriteLine(Char.IsLower(s)); // регистр
            Console.WriteLine(Char.IsUpper(s)); // регистр
            Console.WriteLine();

            // --- ToUpper/ToLower ---

            string world4 = "Hell0";
            Console.WriteLine(world4.ToLower()); // делается маленькими
            Console.WriteLine(world4.ToUpper()); //делается большими

            string glasnie = "у е ы а о э я и ю";
            glasnie = glasnie.ToUpper();
            Console.WriteLine(glasnie);
            Console.WriteLine();

            // вынести в массив все слова тексте ( посчитать количество )
            string input = "Hello, my clear 2 friends!!!";
            string[] dirtywords = input.Split(' ');
            for (int i = 0;i<dirtywords.Length;i++)
            {
                string trimworld = dirtywords[i].Trim(punc);
                Console.WriteLine(trimworld);

                bool f = false;
                int k = 0;
                string[] result = new string[0];
                foreach (char symbol in trimworld)
                {
                    if(char.IsDigit(symbol)  && char.IsPunctuation(symbol))
                    {
                        f = false;
                    }
                    if (f)
                    {
                        k++;
                        Array.Resize(ref result, result.Length+1);
                        result[^1] = trimworld.ToLower(); // можно без ToLower
                    }
                }
            }
        }
    }
}
