using System.IO.Pipelines;
using System.Xml.Serialization;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        static double Sum(double result)
        {
        StartSum: double num;
            Console.Write("Введите число: ");

            if (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Ошибка, некорректный номер");
                goto StartSum;
            }

            result = result + num;

        StartSum1: Console.WriteLine($"Текущий результат: {result}");
            Console.WriteLine("Хотите продолжить?");
            Console.WriteLine("1.Да");
            Console.WriteLine("2.Обнулить полученный результат");
            Console.WriteLine("0.Нет");
            Console.Write("Введите номер (0-2): ");

            switch (ParserChoice(0))
            {
                case 1:
                    goto StartSum;
                case 0:
                    Console.WriteLine($"Итоговый результат: {result}");
                    MainMenu();
                    break;
                case 2:
                    result = 0;
                    Console.WriteLine("Результат обнулён");
                    goto StartSum;
                default:
                    Console.WriteLine("Введен неправильный номер");
                    goto StartSum1;
            }

            return result;
        }


        static void Dif()
        {
            {
            StartDif:
                Console.Write("Введите первое число: ");

                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Ошибка, некорректное число");
                    goto StartDif;
                }

            StartDif1:
                Console.Write("Введите второе число: ");

                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Ошибка, некорректное число");
                    goto StartDif1;
                }

                double result = num1 - num2;

            StartDif2:
                Console.WriteLine($"Текущий результат: {result}");
                Console.WriteLine("Хотите продолжить отнимать?");
                Console.WriteLine("1.Да");
                Console.WriteLine("2.Обнулить результат");
                Console.WriteLine("0.Нет");
                Console.Write("Введите номер (0-2): ");

                switch (ParserChoice(0))
                {
                    case 1:
                        Console.Write("Введите число: ");
                        if (!double.TryParse(Console.ReadLine(), out double num3))
                        {
                            Console.WriteLine("Ошибка, некорректное число");
                            goto case 1;
                        }
                        result = result - num3;
                        goto StartDif2;
                    case 2:
                        result = 0;
                        Console.WriteLine("Результат обнулён");
                        goto StartDif;
                    case 0:
                        Console.WriteLine($"Итоговый результат: {result}");
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Введен неправильный номер");
                        Dif();
                        break;
                }

            }
        }

        static void Multiplication()
        {
            {
            StartMult:
                Console.Write("Введите первое число: ");

                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Ошибка, некорректное число");
                    goto StartMult;
                }

            StartMult1:
                Console.Write("Введите второе число: ");

                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Ошибка, некорректное число");
                    goto StartMult1;
                }

                double result = num1 * num2;

            StartMult2:
                Console.WriteLine($"Текущий результат: {result}");
                Console.WriteLine("Хотите продолжить умножать?");
                Console.WriteLine("1.Да");
                Console.WriteLine("2.Обнулить результат");
                Console.WriteLine("0.Нет");
                Console.Write("Введите номер (0-2): ");

                switch (ParserChoice(0))
                {
                    case 1:
                        Console.Write("Введите число: ");
                        if (!double.TryParse(Console.ReadLine(), out double num3))
                        {
                            Console.WriteLine("Ошибка, некорректное число");
                            goto case 1;
                        }
                        result = result * num3;
                        goto StartMult2;
                    case 2:
                        result = 0;
                        Console.WriteLine("Результат обнулён");
                        goto StartMult;
                    case 0:
                        Console.WriteLine($"Итоговый результат: {result}");
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Введен неправильный номер");
                        Multiplication();
                        break;
                }

            }
        }

        static void Division()
        {
            {
            StartDiv:
                Console.Write("Введите первое число: ");

                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Ошибка, некорректное число");
                    goto StartDiv;
                }

            StartDiv1:
                Console.Write("Введите второе число: ");

                if (!double.TryParse(Console.ReadLine(), out double num2) || num1 == 0)
                {
                    Console.WriteLine("Ошибка, некорректное число");
                    goto StartDiv1;
                }

                double result = num1 / num2;

            StartDiv2:
                Console.WriteLine($"Текущий результат: {result}");
                Console.WriteLine("Хотите продолжить делить?");
                Console.WriteLine("1.Да");
                Console.WriteLine("2.Обнулить результат");
                Console.WriteLine("0.Нет");
                Console.Write("Введите номер (0-2): ");

                switch (ParserChoice(0))
                {
                    case 1:
                        Console.Write("Введите число: ");
                        if (!double.TryParse(Console.ReadLine(), out double num3) || num3 == 0)
                        {
                            Console.WriteLine("Ошибка, некорректное число");
                            goto case 1;
                        }
                        result = result / num3;
                        goto StartDiv2;
                    case 2:
                        result = 0;
                        Console.WriteLine("Результат обнулён");
                        goto StartDiv;
                    case 0:
                        Console.WriteLine($"Итоговый результат: {result}");
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Введен неправильный номер");
                        Division();
                        break;
                }

            }
        }

        static void PercentageNum()
        {
            {
            StartDiv:
                Console.Write("Введите первое число: ");

                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Ошибка, некорректное число");
                    goto StartDiv;
                }

            StartDiv1:
                Console.Write("Введите второе число: ");

                if (!double.TryParse(Console.ReadLine(), out double num2) || num1 == 0)
                {
                    Console.WriteLine("Ошибка, некорректное число");
                    goto StartDiv1;
                }

                double result = num1 / num2;

            StartDiv2:
                Console.WriteLine($"Текущий результат: {result}");
                Console.WriteLine("Хотите продолжить делить?");
                Console.WriteLine("1.Да");
                Console.WriteLine("2.Обнулить результат");
                Console.WriteLine("0.Нет");
                Console.Write("Введите номер (0-2): ");

                switch (ParserChoice(0))
                {
                    case 1:
                        Console.Write("Введите число: ");
                        if (!double.TryParse(Console.ReadLine(), out double num3) || num3 == 0)
                        {
                            Console.WriteLine("Ошибка, некорректное число");
                            goto case 1;
                        }
                        result = result / num3;
                        goto StartDiv2;
                    case 2:
                        result = 0;
                        Console.WriteLine("Результат обнулён");
                        goto StartDiv;
                    case 0:
                        Console.WriteLine($"Итоговый результат: {result}");
                        MainMenu();
                        break;
                    default:
                        Console.WriteLine("Введен неправильный номер");
                        Division();
                        break;
                }

            }
        }

        static void SquareRoot()
        {

        }

        static void MainMenu()
        {

            Console.WriteLine("   КАЛЬКУЛЯТОР");
                    Console.WriteLine("1.Сложение");
                    Console.WriteLine("2.Вычитание");
                    Console.WriteLine("3.Умножение");
                    Console.WriteLine("4.Деление");
                    Console.WriteLine("5.Процент от числа");
                    Console.WriteLine("6.Корень квадратный");
                    Console.WriteLine("0.Выход");
                    Console.Write("Выберите действие(0-6): ");
            
            switch (ParserChoice(0))
                {
                    case 1:
                        Console.WriteLine("СЛОЖЕНИЕ");
                        Sum(0);
                    break;
                    case 2:
                        Console.WriteLine("ВыЧИТАНИЕ");
                        Dif();
                        break;
                    case 3:
                        Console.WriteLine("УМНОЖЕНИЕ");
                        Multiplication();
                        break;
                    case 4:
                        Division();
                        Console.WriteLine("ДЕЛЕНИЕ");
                        break;
                    case 5:
                        PercentageNum();
                        Console.WriteLine("ВыЧИТАНИЕ");
                        break;
                    case 6:
                        SquareRoot();
                        Console.WriteLine("ВыЧИТАНИЕ");
                        break;
                    case 7:
                        Console.WriteLine("До свидания");
                        break;
                    case 0:
                        MainMenu();
                    break;
                    default:
                        Console.WriteLine("Выбран неверный номер");
                        MainMenu();
                        break;
            }
        }


        static int ParserChoice(int choice)
        {

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Ошибка, некорректный номер");
            }

            return choice;
        }
    }
}
