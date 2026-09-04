using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Task
{
    public class HW10
    {
        public delegate void MathOp(ref double result);
        public static void Work10()
        {
            double result = 0;
            MainMenu(ref result);
        }

        static void MainMenu(ref double result)
        {
            Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В КАЛЬКУЛЯТОР");
            int choice = 0;

            Console.Write("Введите число: ");

            if (result == 0) {
                while (!double.TryParse(Console.ReadLine(), out result))
                {
                    Console.WriteLine("Ошибка, некорректное число");
                }
            }


            do
            {
                Console.WriteLine("   КАЛЬКУЛЯТОР");
                Console.WriteLine("1.Сложение");
                Console.WriteLine("2.Вычитание");
                Console.WriteLine("3.Умножение");
                Console.WriteLine("4.Деление");
                Console.WriteLine("5.Процент от числа");
                Console.WriteLine("6.Корень квадратный");
                Console.WriteLine("7.Начать сначала");
                Console.WriteLine("0.Выход");
                Console.Write("Выберите действие(0-6): ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ошибка, некорректный номер");
                }
                switch (choice)
                {
                    //Сложение
                    case 1:
                        MathOp operationSum = Sum;
                        operationSum(ref result);
                        break;
                    case 2:
                        MathOp operationDif = Dif;
                        operationDif(ref result);
                        break;
                    case 3:
                        MathOp operationMult = Mult;
                        operationMult(ref result);
                        break;
                    case 4:
                        MathOp operationDiv = Div;
                        operationDiv(ref result);
                        break;
                    case 5:
                        MathOp operationPer = Per;
                        operationPer(ref result);
                        break;
                    case 6:
                        MathOp operationSqrt = Sqrt;
                        operationSqrt(ref result);
                        break;
                    case 7:
                        Console.WriteLine("Результат полностью обнулён");
                        result = 0;
                        MainMenu(ref result);
                        break;
                    case 0:
                        Console.WriteLine("До свидания");
                        return;
                    default:
                        Console.WriteLine("Выбран неверный номер");
                        MainMenu(ref result);
                        break;
                }
            } while (choice != 0);
        }

        public static void Sum(ref double result)
        {
            Console.WriteLine("СЛОЖЕНИЕ");
            double num2;
            double num3;
            int choice = 0;
            Console.Write("Введите число, с которым хотите сложить: ");

            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Ошибка, некорректное число");
            }

            result = result + num2;

            do
            {
                Console.WriteLine($"Текущий результат: {result}");
                Console.WriteLine("Хотите продолжить?");
                Console.WriteLine("1.Да");
                Console.WriteLine("2.Нет");
                Console.Write("Введите номер (1-2): ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ошибка, некорректный номер");
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите число, с которым хотите сложить: ");

                        while (!double.TryParse(Console.ReadLine(), out num3))
                        {
                            Console.Write("Ошибка, некорректное число: ");
                        }
                        result = result + num3;
                        break;
                    case 2:
                        Console.WriteLine($"Итоговый результат: {result}");
                        return;
                    default:
                        Console.WriteLine("Введен неправильный номер");
                        break;
                }
            } while (choice != 2);
        }

        public static void Dif(ref double result)
        {
            double num2;
            double num3;
            int choice = 0;
            Console.WriteLine("ВыЧИТАНИЕ");
            Console.Write("Введите число, с которым хотите отнять: ");

            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Ошибка, некорректное число");
            }

            result = result - num2;

            do
            {
                Console.WriteLine($"Текущий результат: {result}");
                Console.WriteLine("Хотите продолжить отнимать?");
                Console.WriteLine("1.Да");
                Console.WriteLine("2.Нет");
                Console.Write("Введите номер (1-2): ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ошибка, некорректный номер");
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите число, с которым хотите отнять: ");
                        if (!double.TryParse(Console.ReadLine(), out num3))
                        {
                            Console.WriteLine("Ошибка, некорректное число");
                            goto case 1;
                        }
                        result = result - num3;
                        break;
                    case 2:
                        Console.WriteLine($"Итоговый результат: {result}");
                        return;
                    default:
                        Console.WriteLine("Введен неправильный номер");
                        break;
                }
            }while(choice != 2);
        }

        public static void Mult(ref double result)
        {
            double num2;
            double num3;
            int choice = 0;
            Console.WriteLine("УМНОЖЕНИЕ");

            Console.Write("Введите число, с которым хотите умножить: ");

            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Ошибка, некорректное число");
            }

            result = result * num2;

            do
            {
                Console.WriteLine($"Текущий результат: {result}");
                Console.WriteLine("Хотите продолжить умножать?");
                Console.WriteLine("1.Да");
                Console.WriteLine("2.Нет");
                Console.Write("Введите номер (1-2): ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Ошибка, некорректный номер");
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Введите число, с которым хотите умножить: ");
                        if (!double.TryParse(Console.ReadLine(), out num3))
                        {
                            Console.WriteLine("Ошибка, некорректное число");
                            goto case 1;
                        }
                        result = result * num3;
                        break;
                    case 2:
                        Console.WriteLine($"Итоговый результат: {result}");
                        return;
                    default:
                        Console.WriteLine("Введен неправильный номер");
                        break;
                }
            } while (choice != 2);
        }

        public static void Div(ref double result)
        {
            Console.WriteLine("ДЕЛЕНИЕ");
            double num2;
            double num3;
            int choice = 0;
            Console.Write("Введите делитель: ");

            while (!double.TryParse(Console.ReadLine(), out num2) || num2 == 0)
            {
                Console.WriteLine("Ошибка, некорректное число");
            }

            result = result / num2;
            do
            {
                Console.WriteLine($"Текущий результат: {result}");
                Console.WriteLine("Хотите продолжить делить?");
                Console.WriteLine("1.Да");
                Console.WriteLine("2.Нет");
                Console.Write("Введите номер (1-2): ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Ошибка, некорректный номер:");
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Введите делитель: ");
                        while (!double.TryParse(Console.ReadLine(), out num3) || num3 == 0)
                        {
                            Console.Write("Ошибка, некорректное число: ");
                        }
                        result = result / num3;
                        break;
                    case 2:
                        Console.WriteLine($"Итоговый результат: {result}");
                        return;
                    default:
                        Console.WriteLine("Введен неправильный номер");
                        break;
                }
            }while(choice != 2);
        }

        public static void Per(ref double result)
        {
            double num2;
            double num3;
            int choice = 0;
            Console.WriteLine("ПРОЦЕНТ ОТ ЧИСЛА");
            Console.Write("Введите число, для составления процента от резултативного числа: ");

            while(!double.TryParse(Console.ReadLine(), out num2) || num2 >= result || num2 == 0)
            {
                Console.WriteLine("Ошибка, некорректное число");
            }

            double resultPerNum = (num2 / result) * 100;

            do
            {
                Console.WriteLine($"Число от процента: {result}");
                Console.WriteLine($"Итоговый процент: {resultPerNum}%");
                Console.WriteLine("Хотите продолжить делить?");
                Console.WriteLine("1.Да");
                Console.WriteLine("2.Нет");
                Console.Write("Введите номер (1-2): ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Ошибка, некорректный номер:");
                }
                switch (choice)
                {
                    case 1:
                        Console.Write("Введите число, для составления процента от резултативного числа: ");
                        while (!double.TryParse(Console.ReadLine(), out num3) || num3 == 0 || num3 >= result)
                        {
                            Console.WriteLine("Ошибка, некорректное число");
                            goto case 1;
                        }
                        resultPerNum = (num3 / result) * 100;
                        break;
                    case 2:
                        Console.WriteLine($"Итоговый процент: {result}");
                        Console.WriteLine($"Число от процента: {result}");
                        return;
                    default:
                        Console.WriteLine("Введен неправильный номер");
                        break;
                }
            } while (choice != 2);
        }

        public static void Sqrt(ref double result)
        {
            int choice = 0;
            Console.WriteLine("ВЫЧИСЛЕНИЕ КВАДРАТНОГО КОРНЯ");
            while (result < 0)
            {
                Console.WriteLine("Число должно быть положительным");
            }

            result = Math.Sqrt(result);

            do
            {
                Console.WriteLine($"Текущий результат: {result}");
                Console.WriteLine("Хотите продолжить вычислять корень?");
                Console.WriteLine("1.Да");
                Console.WriteLine("2.Нет");
                Console.Write("Введите номер (1-2): ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Ошибка, некорректный номер:");
                }

                switch (choice)
                {
                    case 1:
                        result = Math.Sqrt(result);
                        break;
                    case 2:
                        Console.WriteLine($"Итоговый процент: {result}");
                        Console.WriteLine($"Число от процента: {result}");
                        return;
                    default:
                        Console.WriteLine("Введен неправильный номер");
                        break;
                }
            } while (choice != 2); 
        }
    }
}
