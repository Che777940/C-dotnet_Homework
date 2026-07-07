using System.Xml.Serialization;

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