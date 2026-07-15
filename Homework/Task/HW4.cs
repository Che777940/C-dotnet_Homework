using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Homework.Task
{
    internal class HW4
    {
        public static void Work4()
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            int choice = 0;

            do
            {
                Console.WriteLine("1.Циклы");
                Console.WriteLine("2.Матрицы");
                Console.WriteLine("3.Листы");
                Console.WriteLine("0.Вернуться назад");
                Console.Write("Выберите часть задания (1-3): ");

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
                }

                switch (choice)
                {
                    case 1:
                        Cycle();
                        break;
                    case 2:
                        Matrix();
                        break;
                    case 3:
                        List();
                        break;
                    case 0:
                        return;
                }
            } while (choice != 0);
        }


        public static void Cycle()
        {
            decimal N = 0;

            Console.Write("Введите N: ");
            while (!decimal.TryParse(Console.ReadLine(), out N) || N > 1)
            {
                Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
            }

            for (; N <= 1; N = N + 0.1m)
            {
                Console.WriteLine($"Число: {N} ");
            }

            Console.Write("Введите до куда вы хотите, чтобы выводились числа кроме 35 (7,14,21,28, 42...): ");
            while (!decimal.TryParse(Console.ReadLine(), out N) || N == 0 || N == 35 || N % 7 != 0 || N < 0)
            {
                Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
            }

            for (int i = 7; i <= N; i = i + 7)
            {
                if (i == 35)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"Числа: {i}");
                }
            }


            Console.Write("Введи до какого числа будут выводиться числа Фибоначчи: ");
            while (!decimal.TryParse(Console.ReadLine(), out N) || N < 0)
            {
                Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
            }

            int fib1 = 0, fib2 = 1;
            while (fib2 < N)
            {
                if (fib1 == 0 || fib1 == 1)
                {
                    Console.WriteLine($"Число: {fib1}");
                }

                fib2 = fib2 + fib1;
                fib1 = fib2 - fib1;
                if(fib2 > N)
                {
                    break;
                }
                Console.WriteLine($"Число: {fib2}");
            }
        }


        public static void Matrix()
        {
            int n = 0, m = 0;
            Console.Write("Введите длину матрицы: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0 || n > 5)
            {
                Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
            }

            Console.Write("Введите ширину матрицы: ");
            while (!int.TryParse(Console.ReadLine(), out m) || m < 0 || m > 5)
            {
                Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
            }

            int[,] matrix = new int[n, m];
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    {
                        matrix[i, j] = random.Next(-9, 9);
                    }
                }
            }

                int choice = 0;

                do
                {
                    Console.WriteLine("ЧАСТИ ЗАДАНИЯ");
                    Console.WriteLine("1.Вывод массива на экран в матричном виде");
                    Console.WriteLine("2.Поиск количества положительных и отрицательных элементов");
                    Console.WriteLine("3.Чётные строки - чётные элементы, нечётные строки - нечётные элементы, если элементов нет - пустая строка");
                    Console.WriteLine("4.Используя словарь, подсчитать и вывести сколько раз, какое число было в матрице");
                    Console.WriteLine("0.Вернуться назад");
                    Console.Write("Выберите один из номеров(1-4): ");
                    while (!int.TryParse(Console.ReadLine(), out choice))
                    {
                        Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
                    }

                    switch (choice)
                    {
                        case 1:
                            PrintMatrix(n, m, matrix);
                            break;
                        case 2:
                            NumberSearchPlMn(n, m, matrix);
                            break;
                        case 3:
                            PrintMatrixParity(n, m, matrix);
                            break;
                        case 4:
                            WorkDictionary(n, m, matrix);
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("Неправильно введён номер");
                            break;
                    }
                } while (choice != 0);
        }
   


        public static void PrintMatrix(int n, int m, int[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j]}  ");
                }

                Console.WriteLine();
            }

        }
       
        public static void NumberSearchPlMn(int n, int m, int[,] matrix)
        {
            int countMinus = 0;
            int countPlus = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                 if (matrix[i,j] < 0)
                    {
                        countMinus++;
                    }
                 if(matrix[i,j] >= 0)
                    {
                        countPlus++;
                    }
                }
            }
            Console.WriteLine($"Положительных элементов {countPlus} и отрицательных {countMinus}");

        }

        public static void PrintMatrixParity(int n, int m, int[,] matrix)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if(i % 2 == 0) // проверка на нечётность строки
                    {
                        if (matrix[i, j] % 2 != 0)
                        {
                            Console.Write($"{matrix[i, j]} ");
                        }
                    }
                    if (i % 2 != 0) // проверка на чётность строки
                    {
                        if (matrix[i,j] % 2 == 0)
                        {
                            Console.Write($"{matrix[i, j]} ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        public static void WorkDictionary(int n, int m, int[,] matrix)
        {
            Dictionary<int, int> dictMatrix = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int val = matrix[i, j];
                    if (dictMatrix.ContainsKey(val))
                    {
                        dictMatrix[val]++;
                    }
                    else
                        dictMatrix[val] = 1;
                }
            }

            Console.WriteLine("Сколько раз встречается каждое число:");
            foreach (var pair in dictMatrix)
            {
                Console.WriteLine($"Число {pair.Key} – {pair.Value} раз(а)");
            }
        }

        public static void List()
        {
            List<int> ls = new List<int>();
            Random random = new Random();
            int number = 0;
            int kol;

            Console.Write("Введите размерность списка: ");
            while (!int.TryParse(Console.ReadLine(), out kol))
            {
                Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
            }

            for (int i = 0; i < kol; i++)
            {
                Console.Write("Добавьте число в список: ");
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
                }

                ls.Add(number);
            }

            int choice = 0;

            do
            {
                Console.WriteLine("ЧАСТИ ЗАДАНИЯ");
                Console.WriteLine("1.Добавление элемента в список");
                Console.WriteLine("2.Вывод списка");
                Console.WriteLine("3.Удаление элемента");
                Console.WriteLine("4.Заменить каждый четный элемент на удвоенное значение (*2), я нечетный на 0.Вывести лист.");
                Console.WriteLine("5.По этому листу создать HashSet. Вывести.");
                Console.WriteLine("0.Вернуться назад");
                Console.Write("Выберите один из номеров(0-5): ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
                }

                switch (choice)
                {
                    case 1:
                        AddList(ls);
                        break;
                    case 2:
                        PrintList(ls);
                        break;
                    case 3:
                        PopList(ls);
                        break;
                    case 4:
                        ParityList(ls);
                        break;
                    case 5:
                        HashSetList(ls);
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Неправильно введён номер");
                        break;
                }
            } while (choice != 0);

        }


        public static void PrintList(List<int> ls)
        {
            foreach (var list in ls)
            {
                Console.Write($"{list} ");
            }
            Console.WriteLine();
        }

        public static void AddList(List<int> ls)
        {
                int choice = 0;
                int number;
                Console.Write("Добавьте число в список: ");
                while (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
                }

                ls.Add(number);

            do { 
            Console.WriteLine("1.Да");
            Console.WriteLine("2.Нет");
            Console.Write("Хотите продолжить добовлять: ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Добавьте число в список: ");
                        while (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
                        }

                        ls.Add(number);
                        break;
                    case 2:
                        return;
                    default:
                        Console.WriteLine("Неправильный ввод: ");
                        break;
                }

            }while(choice != 2);

        }

        public static void PopList(List<int> ls)
        {
            int choice = 0;
            int number;
            Console.Write("Выберите число, которое хотите удалить: ");
            while (!int.TryParse(Console.ReadLine(), out number) || ls.Remove(number) != true)
            {
                Console.Write("Ошибка, некорректный ввод или такого элемента не существует, попробуйте ещё раз: ");
            }

            Console.WriteLine($"Элемент удалён");
            do
            {
                Console.WriteLine("1.Да");
                Console.WriteLine("2.Нет");
                Console.Write("Хотите продолжить удалять: ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Выберите число, которое хотите удалить: ");
                        while (!int.TryParse(Console.ReadLine(), out number) || ls.Remove(number) != true)
                        {
                            Console.Write("Ошибка, некорректный ввод или такого элемента не существует, попробуйте ещё раз: ");
                        }

                        Console.WriteLine($"Элемент удалён");
                        break;
                    case 2:
                        return;
                    default:
                        Console.WriteLine("Неправильный ввод: ");
                        break;
                }

            } while (choice != 2);
        }

        public static void ParityList(List<int> ls)
        {

            Console.Write("Первоначальный массив: ");
            PrintList(ls);

            Console.Write("Итоговый массив: ");
            for(int i = 0; i < ls.Count; i++)
            {
                if (ls[i] % 2 == 0)
                {
                    Console.Write($"{ls[i] * 2} ");
                }
                if (ls[i] % 2 != 0)
                {
                    Console.Write($"{ls[i] * 0} ");
                }
            }
            Console.WriteLine();
        }

        public static void HashSetList(List<int> ls)
        {
            HashSet<int> hs = new HashSet<int>();
            
            for(int i = 0; i < ls.Count; i++)
            {
                int variable = ls[i];
                hs.Add(variable);
            }

            Console.Write("Итоговый HashSet: ");
            foreach(int hashset in hs)
            {
                Console.Write($"{hashset} ");
            }

            Console.WriteLine();
        }

    }
}
