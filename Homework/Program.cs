using System.Xml.Serialization;
using FinanceTracker.CLI;

namespace Homework.Task
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int choice = 0;
            do
            {

                Console.WriteLine("ДОМАШНЕЕ ЗАДАНИЕ");
                Console.WriteLine("1.Урок 1");
                Console.WriteLine("2.Урок 2");
                Console.WriteLine("3.Урок 3");
                Console.WriteLine("4.Урок 4");
                Console.WriteLine("5.Урок 5");
                Console.WriteLine("6.Урок 6");
                Console.WriteLine("7.Практика");
                Console.WriteLine("0.Выход");

                Console.Write("Выберите дз(1-4): ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
                }

                switch (choice)
                {
                    case 1:
                        HW1.Work1();
                        break;
                    case 2:
                        Console.WriteLine("ГИТ");
                        break;
                    case 3:
                        HW3.Work3();
                        break;
                    case 4:
                        HW4.Work4();
                        break;
                    case 5:
                        HW5.Work5();
                        break;
                    case 6:
                        HW6.Work6();
                        break;
                    case 7:
                        Debt debt = new Debt(120000.0, 1.01);
                        debt.PrintBalance();
                        debt.WaitOneYear();
                        debt.PrintBalance();

                        int years = 0;
                        while (years < 20)
                        {
                            debt.WaitOneYear();
                            years = years + 1;
                        }
                        debt.PrintBalance();

                        break;
                    case 0:
                        Console.WriteLine("До свидания");
                        break;
                    default:
                        Console.WriteLine("Неверный выбор");
                        break;
                }
            } while (choice != 0);
        }
    }
}