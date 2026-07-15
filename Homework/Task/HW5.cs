using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace Homework.Task
{
    internal class HW5
    {
        public static void Work5()
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            int choice = 0;

            string text = "Wow! This is my 1st tsest. Do you see number42? Yes!" +
                          " \nOtto ran to room101. Anna loves level99." +
                          " \nAre you ready? No, I am not!" +
                          " \nThis has no comma. But this one, definitely has a comma, right?" +
                          " \nHey! Look at Bob — he found 777 coins!" +
                          " \nIs 12345 the longest digit-word? Maybe!" +
                          " \nOtto said: \"Wow!\" Anna replied: \"Yes!\"" +
                          " \nNever odd or even. sentence123 Done!";

            Console.WriteLine(text);

            string[] words = text.Split(new char[] { ' ' });
            Console.WriteLine(words.Length);

            do
            {
                Console.WriteLine("1.Найти слова, содержащие максимальное количество цифр.");
                Console.WriteLine("2.Найти самое длинное слово и определить, сколько раз оно встретилось в тексте.");
                Console.WriteLine("3.Заменить цифры от 0 до 9 на слова «ноль», «один», ..., «девять».");
                Console.WriteLine("4.Вывести на экран сначала вопросительные, а затем восклицательные предложения.");
                Console.WriteLine("5.Вывести на экран только предложения, не содержащие запятых.");
                Console.WriteLine("6.Найти слова, начинающиеся и заканчивающиеся на одну и ту же букву.");
                Console.WriteLine("7.Добавить возможность поиска по части ввода. ( не учитывать регистр)");
                Console.WriteLine("8.Вывести палиндромы, если они есть.");
                Console.WriteLine("0.Вернуться назад");
                Console.Write("Выберите часть задания (0-8): ");

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
                }

                switch (choice)
                {
                    case 1:
                        SearchMaxDigit(words);
                        break;
                    case 2:
                        SearchLongWord(words);
                        break;
                    case 3:
                        ReplaceDigit(words);
                        break;
                    case 4:
                        PrintQuestionAndExclam(text);
                        break;
                    case 5:
                        SearchNoComma(text);
                        break;
                    case 6:
                        StartEndSameCharWord(words);
                        break;
                    case 7:
                        SearchWord(words);
                        break;
                    case 8:
                        Palindrom(text);
                        break;
                    case 0:
                        return;
                }
            } while (choice != 0);
        }

        public static void SearchMaxDigit(string[] words)
        {
            int maxCount = 0;

            for (int i = 0; i < words.Length; i++) {
                int count = 0;
                for (int j = 0; j < words[i].Length; j++)
                {
                    char sm = words[i][j];
                    if (char.IsDigit(sm))
                    {
                        count++;
                    }
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
            }

            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < words[i].Length; j++)
                {
                    char sm = words[i][j];
                    if (char.IsDigit(sm))
                    {
                        count++;
                    }
                }
                if (count == maxCount)
                {
                    Console.WriteLine($"{words[i]} ");
                }
            }

        }

        public static void SearchLongWord(string[] words)
        {
            int maxCount = 0;
            int count = 0;
            HashSet<string> hsLongWords = new HashSet<string>();

            for (int i = 0; i < words.Length; i++)
            {
                    count = 0;
                for (int j = 0; j < words[i].Length; j++)
                {
                    char sm = words[i][j];
                    count++;
                    if (count > maxCount)
                    {
                        maxCount = count;
                    }
                }
            }

            string sameWords = null;

            for (int i = 0; i < words.Length; i++)
            {
                count = 0;
                for (int j = 0; j < words[i].Length; j++)
                {
                    char sm = words[i][j];
                    count++;
                }
                if (count == maxCount)
                {
                    hsLongWords.Add(words[i]);
                }
            }

            List<string>lsLongWords = hsLongWords.ToList();

            for (int i = 0; i < hsLongWords.Count; i++)
            {
                count = 0;
                for (int j = 0; j < words.Length; j++)
                {
                    
                    if (lsLongWords[i] == words[j])
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Самое длинное слово {lsLongWords[i]}, которое встречается {count} раз");
            }

        }

        public static void ReplaceDigit(string[] words)
        {
            string[] strDigits = new string[] {"ноль", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять"};
            

            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                for (int j = 0; j < strDigits.Length; j++)
                {
                    word = word.Replace(j.ToString(), strDigits[j]);
                }
                words[i] = word;
            }
            string result = string.Join(" ", words);
            Console.WriteLine(result);
        }

        public static void PrintQuestionAndExclam(string text)
        {
            int startIndex = 0;
            int length = 0;
            for (int i = 0; i < text.Length; i++)
            {
                string substring;
                if (text[i] == '!')
                {
                    length = i + 1 - startIndex;
                    substring = text.Substring(startIndex, length);
                    Console.WriteLine($"Предложение: {substring}");
                    startIndex = i + 2;
                }
                else if (text[i] == '.')
                {
                    startIndex = i + 2;
                }
                else if (text[i] == '?')
                {
                    length = i - startIndex;
                    startIndex = i + 2;
                }
            }

            for (int i = 0; i < text.Length; i++)
            {
                string substring;
                if (text[i] == '!')
                {
                    length = i + 1 - startIndex;
                    startIndex = i + 2;
                }
                else if (text[i] == '.')
                {
                    startIndex = i + 2;
                }
                else if (text[i] == '?')
                {
                    length = i + 1 - startIndex;
                    substring = text.Substring(startIndex, length);
                    Console.WriteLine($"Предложение: {substring}");
                    startIndex = i + 2;
                }
            }
        }


            public static void SearchNoComma(string text)
            {
            int startIndex = 0;
            int length = 0;
            int count = 0;
            text = text.ReplaceLineEndings("");
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ',')
                {
                    count++;
                }
                string substring;
                if (text[i] == '!' || text[i] == '?' || text[i] == '.')
                {
                    length = i + 1 - startIndex;
                    if (count == 0)
                    {
                        substring = text.Substring(startIndex, length);
                        Console.WriteLine($"Предложение: {substring}");
                    }
                    count = 0;
                    startIndex = i + 2;
                }
            }


        }

        public static void StartEndSameCharWord(string[] words)
        {

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToLower().Trim('!','.','?','"');
                for (int j = 0; j < words[i].Length; j++)
                {
                    char sm = words[i][j];
                    int count = words[i].Length;
                    if ((words[i][0] == words[i][count-1]) && !char.IsDigit(words[i][0]))
                    {
                        Console.WriteLine($"Слово заканчивается и начинается на одну и ту же букву: {words[i]}");
                    }
                    break;
                }
            }
        }

        public static void SearchWord(string[] words)
        {
            Console.Write("Введите часть слова, которое вы хотите найти: ");
            string wordSearch = Console.ReadLine();
            string sub;
            int length = wordSearch.Count();

            for (int i = 0; i < words.Length; i++)
            {
               string word = words[i].Trim('!', '.', '?', '"');
                for (int j = 0; j <= word.Length - length; j++)
                {
                    wordSearch = wordSearch.ToLower();
                    sub = word.Substring(j, length);
                    sub = sub.ToLower();
                    if (wordSearch == sub)
                    {
                        Console.WriteLine($"Найденное слово: {words[i]}");
                        break;
                    }
                } 
            }

        }

        public static void Palindrom(string text)
        {
            int startIndex = 0;
            int length = 0;
            text = text.ReplaceLineEndings("");

            for (int i = 0; i < text.Length; i++)
            {
                string substring;
                if (text[i] == '!' || text[i] == '?' || text[i] == '.')
                {
                    length = i + 1 - startIndex;
                    substring = text.Substring(startIndex, length).ToLower().Trim(' ');
                    string newSubstring = Regex.Replace(substring, @"[^\p{L}]", "");
                    length = newSubstring.Length;

                    bool isPal = true;
                    for (int j = 0; j < length / 2; j++)
                    {
                        if (newSubstring[j] != newSubstring[length - 1 - j])
                        {
                            isPal = false;
                            break;
                        }
                    }

                    if (length > 0 && isPal)
                    {
                        Console.WriteLine($"Предложение: {substring}, палиндром");
                    }
                    startIndex = i + 1;
                }
            }
        }

    }
}
