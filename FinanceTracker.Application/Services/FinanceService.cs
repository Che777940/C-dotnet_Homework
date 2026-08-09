using FinanceTracker.Application.Interfaces;
using FinanceTracker.Domain.Entities;
using FinanceTracker.Domain.Enums;
using FinanceTracker.Domain.Exceptions;
using FinanceTracker.Infrastructure.Repositories;

namespace FinanceTracker.Application.Services
{
    public class FinanceService : IFinanceService
    {
        private readonly InMemoryTransactionRepository _repository;
        public FinanceService()
        {
           _repository = new InMemoryTransactionRepository();
        }
        public void AddTransaction()
        {
            int choice = 0;
            TransactionType type = TransactionType.Income;

                Console.WriteLine("1.Доход");
                Console.WriteLine("2.Расход");
                Console.WriteLine("0.Назад");
                Console.Write("Выберите тип транзакции: ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Ошибка, некорректный ввод, попробуйте ещё раз: ");
                }
                switch (choice)
                {
                    case 1:
                        type = TransactionType.Income;
                        break;
                    case 2:
                        type = TransactionType.Expense;
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("Неверный номер");
                        break;
                }

            Console.Write("Введите сумму: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            decimal balance = GetTotalIncome() - GetTotalExpense();
            if (balance <= 0)
            {
                try
                {
                    throw new ExpensException(balance, amount);
                }
                catch (ExpensException ex)
                {
                    Console.WriteLine($"Валидация: {ex.Message}");
                    return;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
                }
            }

            Console.Write("Введите категорию: ");
            string oneCategory = Console.ReadLine();
            List<string> category = new List<string>(); 
            category.Add(oneCategory);

            Console.Write("Введите описание: ");
            string description = Console.ReadLine();


            var transaction = new Transaction {
                _amount = amount,
                _type = type,
                _category = category,
                _description = description
            };


            _repository.AddInRepository(transaction);
        }

        public decimal GetTotalExpense()
        {
            var transactions = _repository.GetAll();
            decimal total = 0m;
            for (int i = 0; i < transactions.Count; i++)
            {
                if (transactions[i]._type == TransactionType.Expense)
                    total += transactions[i]._amount;
            }
            return total;
        }

        public decimal GetTotalIncome()
        {
            var transactions = _repository.GetAll();
            decimal total = 0m;
            for (int i = 0; i < transactions.Count; i++)
            {
                if (transactions[i]._type == TransactionType.Income)
                    total += transactions[i]._amount;
            }
            return total;
        }

        public void GetAllTransaction()
        {
            var transactions = _repository.GetAll();
            for (int i = 0; i < transactions.Count; i++)
            {
                Console.WriteLine($"Сумма: {transactions[i]._amount}");
                Console.WriteLine($"Тип: {transactions[i]._type}");
                Console.Write($"Категории: ");

                for (int j = 0; j < transactions[i]._category.Count; j++)
                {
                    Console.Write($"{transactions[i]._category[j]}, ");
                }
                Console.WriteLine($"\nОписание: {transactions[i]._description}");
            }

         
        }
    }
}
