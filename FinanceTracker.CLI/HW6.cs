using FinanceTracker.Application.Interfaces;
using FinanceTracker.Application.Services;

namespace FinanceTracker.CLI
{
    public class HW6
    {
        public static void Work6()
        {
            IFinanceService service = new FinanceService();
            int choice = 0;

            do
            {

                Console.WriteLine("   ФИНАНСОВЫЙ ТРЕКЕР");
                Console.WriteLine("1.Просмотр баланса");
                Console.WriteLine("2.Добавить транзакцию");
                Console.WriteLine("3.Получить все транзакции");
                Console.WriteLine("4.Сохранить в файл");
                Console.WriteLine("0.Выход");

                Console.Write("Выберите дз(0-4): ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
                }

                switch (choice)
                {
                    case 1:
                        decimal balance = service.GetTotalIncome() - service.GetTotalExpense();
                        Console.WriteLine($"Мой баланс: {balance}");
                        break;
                    case 2:
                        Console.WriteLine("Процесс добавления транзакции");
                        service.AddTransaction();
                        break;
                    case 3:
                        service.GetAllTransaction();
                        break;
                    case 4:
                        service.AddInFile();
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
