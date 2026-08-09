using FinanceTracker.Application.Services;
using FinanceTracker.CLI;
using Homework.Homework8_9;
using Homework.Homework8_9interface;
using Homework.Practice2;
using Homework.Practice3;
using Homework.SmartHouse;
using Homework.Work11;
using System.Data;
using System.Reflection.Metadata.Ecma335;
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
                Console.WriteLine("5.Урок 5");
                Console.WriteLine("6.Урок 6 и Урок 12");
                Console.WriteLine("7.Практика");
                Console.WriteLine("8.Дз 8-9");
                Console.WriteLine("9.Дз 10");
                Console.WriteLine("10.Дз 11");
                Console.WriteLine("0.Выход");

                Console.Write("Выберите дз(0-8): ");
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

                        Person person = new Person();
                        person.Greet();

                        Student gStudent = new Student();
                        gStudent.Greet();
                        gStudent.SetAge(16);
                        gStudent.ShowAge();

                        Teacher teacher = new Teacher();
                        teacher.Greet();
                        teacher.SetAge(42);
                        teacher.Explain();


                        SportsCar sportCar = new SportsCar(0, 10);
                        sportCar.Drive(120);
                        sportCar.Refuel(20);
                        sportCar.Drive(23);

                        break;
                    case 8:
                        Animal dog = new Dog();
                        Console.Write("Введите имя собаки: ");
                        string name = Console.ReadLine();
                        dog.SetName(name);
                        dog.getName();
                        dog.Eat();
                        IAnimal dog1 = new Dog1();
                        Console.Write("Введите имя собаки: ");
                        name = Console.ReadLine();
                        dog1.SetName(name);
                        dog1.getName();
                        dog1.Eat();
                        break;
                    case 9:
                        var hub = new SmartHomeHub();
                        var lamp = new SmartLamp("Лампа", hub);
                        var security = new SecuritySiren("Сирена", hub);
                        var phone = new SmartphoneApp("Телефон", hub);
                        hub.TriggerMotion();
                        hub.TriggerFireAlarm();
                        hub.TriggerDoor();
                        hub.TriggerTemperature();
                        hub.TriggerLowBattery();
                        HW10.Work10();
                        break;
                    case 10:
                        var pair = new Pair<int, int>(12, 22);
                        var pair1 = new Pair<string, int>("тринадцать", 20);
                        Console.WriteLine($"Результат pair:{pair.Third}");
                        Console.WriteLine($"Результат pair1:{pair1.Second}");

                        var party = new List<ComparablePair<int, string>>
                        {
                            new ComparablePair<int, string>(3, "a"),
                            new ComparablePair<int, string>(3, "b"),
                            new ComparablePair<int, string>(2, "c"),
                            new ComparablePair<int, string>(3, "d"),

                        };

                        party.Sort();

                        foreach (var p in party)
                        {
                            Console.WriteLine(p);
                        }

                        var list = new MyList<int>();
                        list.Add(2);
                        list.Add(3);
                        list.Add(1);
                        list.Add(9);
                        list.Add(10);

                        foreach (var ls in list)
                        {
                            Console.WriteLine(ls);
                        }

                        break;
                    case 11:
                        
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