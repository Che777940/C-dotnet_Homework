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

        static void MainMenu()
        {
            Console.WriteLine("ДОБРО ПОЖАЛОВАТЬ В КАЛЬКУЛЯТОР");

        Start:

            Console.Write("Введите число: ");

            if (!double.TryParse(Console.ReadLine(), out double result))
            {
                Console.WriteLine("Ошибка, некорректное число");
                goto Start;
            }

        Start1:
                    Console.WriteLine("   КАЛЬКУЛЯТОР");
                    Console.WriteLine("1.Сложение");
                    Console.WriteLine("2.Вычитание");
                    Console.WriteLine("3.Умножение");
                    Console.WriteLine("4.Деление");
                    Console.WriteLine("5.Процент от числа");
                    Console.WriteLine("6.Корень квадратный");
                    Console.WriteLine("7.Начать сначала");
                    Console.WriteLine("8.Выход");
                    Console.Write("Выберите действие(0-6): ");
            
            switch (ParserChoice(0))
                {
                //Сложение
                    case 1:
                    Console.WriteLine("СЛОЖЕНИЕ");
                    StartSum: 
                    Console.Write("Введите число, с которым хотите сложить: ");

                    if (!double.TryParse(Console.ReadLine(), out double num2))
                    {
                        Console.WriteLine("Ошибка, некорректное число");
                        goto StartSum;
                    }

                    result = result + num2;

                    StartSum1: Console.WriteLine($"Текущий результат: {result}");
                    Console.WriteLine("Хотите продолжить?");
                    Console.WriteLine("1.Да");
                    Console.WriteLine("2.Нет");
                    Console.Write("Введите номер (1-2): ");

                    switch (ParserChoice(0))
                    {
                        case 1:
                        StartSum2:
                            Console.Write("Введите число, с которым хотите сложить: ");

                            if (!double.TryParse(Console.ReadLine(), out double num3))
                            {
                                Console.WriteLine("Ошибка, некорректное число");
                                goto StartSum2;
                            }
                            result = result + num3;
                            goto StartSum1;
                        case 2:
                            Console.WriteLine($"Итоговый результат: {result}");
                            goto Start1;
                        case 0:
                            Console.WriteLine($"Итоговый результат: {result}");
                            goto Start1;
                        default:
                            Console.WriteLine("Введен неправильный номер");
                            goto StartSum1;
                    }
                    case 2:
                    // Вычитание
                    Console.WriteLine("ВыЧИТАНИЕ");
                StartDif:
                    Console.Write("Введите число, с которым хотите отнять: ");

                    if (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Ошибка, некорректное число");
                        goto StartDif;
                    }

                     result = result - num2;

                StartDif2:
                    Console.WriteLine($"Текущий результат: {result}");
                    Console.WriteLine("Хотите продолжить отнимать?");
                    Console.WriteLine("1.Да");
                    Console.WriteLine("2.Нет");
                    Console.Write("Введите номер (1-2): ");

                    switch (ParserChoice(0))
                    {
                        case 1:
                            Console.Write("Введите число, с которым хотите отнять: ");
                            if (!double.TryParse(Console.ReadLine(), out double num3))
                            {
                                Console.WriteLine("Ошибка, некорректное число");
                                goto case 1;
                            }
                            result = result - num3;
                            goto StartDif2;
                        case 2:
                            Console.WriteLine($"Итоговый результат: {result}");
                            goto Start1;
                        case 0:
                            Console.WriteLine($"Итоговый результат: {result}");
                            goto Start1;
                        default:
                            Console.WriteLine("Введен неправильный номер");
                            break;
                    }
                    break;
                    case 3:
                    // Сложение
                    Console.WriteLine("УМНОЖЕНИЕ");
                   
                StartMult:
                    Console.Write("Введите число, с которым хотите умножить: ");

                    if (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Ошибка, некорректное число");
                        goto StartMult;
                    }

                     result = result * num2;

                StartMult2:
                    Console.WriteLine($"Текущий результат: {result}");
                    Console.WriteLine("Хотите продолжить умножать?");
                    Console.WriteLine("1.Да");
                    Console.WriteLine("2.Нет");
                    Console.Write("Введите номер (1-2): ");

                    switch (ParserChoice(0))
                    {
                        case 1:
                            Console.Write("Введите число, с которым хотите умножить: ");
                            if (!double.TryParse(Console.ReadLine(), out double num3))
                            {
                                Console.WriteLine("Ошибка, некорректное число");
                                goto case 1;
                            }
                            result = result * num3;
                            goto StartMult2;
                        case 2:
                            Console.WriteLine($"Итоговый результат: {result}");
                            goto Start1;
                        case 0:
                            Console.WriteLine($"Итоговый результат: {result}");
                            goto Start1;
                        default:
                            Console.WriteLine("Введен неправильный номер");
                            goto Start1;       
                    }
                    case 4:
                        // Деление
                        Console.WriteLine("ДЕЛЕНИЕ");

                StartDiv:
                    Console.Write("Введите делитель: ");

                    if (!double.TryParse(Console.ReadLine(), out num2) || num2 == 0)
                    {
                        Console.WriteLine("Ошибка, некорректное число");
                        goto StartDiv;
                    }

                     result = result / num2;

                StartDiv2:
                    Console.WriteLine($"Текущий результат: {result}");
                    Console.WriteLine("Хотите продолжить делить?");
                    Console.WriteLine("1.Да");
                    Console.WriteLine("2.Нет");
                    Console.Write("Введите номер (1-2): ");

                    switch (ParserChoice(0))
                    {
                        case 1:
                            Console.Write("Введите делитель: ");
                            if (!double.TryParse(Console.ReadLine(), out double num3) || num3 == 0)
                            {
                                Console.WriteLine("Ошибка, некорректное число");
                                goto case 1;
                            }
                            result = result / num3;
                            goto StartDiv2;
                        case 2:
                            Console.WriteLine($"Итоговый результат: {result}");
                            goto Start1;
                        case 0:
                            Console.WriteLine($"Итоговый результат: {result}");
                            goto Start1;
                        default:
                            Console.WriteLine("Введен неправильный номер");
                            goto Start1;
                    }
                    case 5:
                       // Процент от числа
                        Console.WriteLine("ПРОЦЕНТ ОТ ЧИСЛА");
                StartPerNum:
                    Console.Write("Введите число, для составления процента от резултативного числа: ");

                    if (!double.TryParse(Console.ReadLine(), out num2) || num2 >= result || num2 == 0)
                    {
                        Console.WriteLine("Ошибка, некорректное число");
                        goto StartPerNum;
                    }

                    double resultPerNum = (num2 / result) * 100;

                StartPerNum2:
                    Console.WriteLine($"Число от процента: {result}");
                    Console.WriteLine($"Итоговый процент: {resultPerNum}%");
                    Console.WriteLine("Хотите продолжить делить?");
                    Console.WriteLine("1.Да");
                    Console.WriteLine("2.Нет");
                    Console.Write("Введите номер (1-2): ");

                    switch (ParserChoice(0))
                    {
                        case 1:
                            Console.Write("Введите число, для составления процента от резултативного числа: ");
                            if (!double.TryParse(Console.ReadLine(), out double num3) || num3 == 0 || num3 >= result)
                            {
                                Console.WriteLine("Ошибка, некорректное число");
                                goto case 1;
                            }
                            resultPerNum = (num3 / result) * 100;
                            goto StartPerNum2;
                        case 2:
                            Console.WriteLine($"Итоговый процент: {result}");
                            Console.WriteLine($"Число от процента: {result}");
                            goto Start1;
                        case 0:
                            Console.WriteLine($"Итоговый процент: {result}");
                            Console.WriteLine($"Число от процента: {result}");
                            goto Start1;
                        default:
                            Console.WriteLine("Введен неправильный номер");
                            goto Start1;
                    }
                    case 6:
                        // Вычисление квадратного корня
                        Console.WriteLine("ВЫЧИСЛЕНИЕ КВАДРАТНОГО КОРНЯ");
                        if (result < 0)
                        {
                        Console.WriteLine("Число должно быть положительным");
                        goto Start1;
                        }

                    result = Math.Sqrt(result);

                StartSqrt2:
                    Console.WriteLine($"Текущий результат: {result}");
                    Console.WriteLine("Хотите продолжить вычислять корень?");
                    Console.WriteLine("1.Да");
                    Console.WriteLine("2.Нет");
                    Console.Write("Введите номер (1-2): ");

                    switch (ParserChoice(0))
                    {
                        case 1:
                            result = Math.Sqrt(result);
                            goto StartSqrt2;
                        case 2:
                            Console.WriteLine($"Итоговый процент: {result}");
                            Console.WriteLine($"Число от процента: {result}");
                            goto Start1;
                        case 0:
                            Console.WriteLine($"Итоговый процент: {result}");
                            Console.WriteLine($"Число от процента: {result}");
                            goto Start1;
                        default:
                            Console.WriteLine("Введен неправильный номер");
                            goto Start1;
                    }
                    case 7:
                        Console.WriteLine("Результат полностью обнулён");
                        result = 0;
                        goto Start;
                    case 8:
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
