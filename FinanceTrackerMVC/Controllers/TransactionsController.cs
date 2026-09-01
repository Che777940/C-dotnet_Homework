using FinanceTracker.Application.Interfaces;
using FinanceTracker.Application.Services;
using FinanceTracker.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using FinanceTracker.Domain.Entities;

namespace FinanceTrackerMVC.Controllers
{
    public class TransactionsController : Controller
    {
        public IActionResult Transaction()
        {
            IFinanceService service = new FinanceService();
            service.ReadOnFile();

            var transactions = service.GetAllTransactionWeb();
            return View(transactions);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Transaction transaction)
        {

            IFinanceService service = new FinanceService();
            Console.WriteLine(transaction._amount);
            Console.WriteLine(transaction._type);
            Console.WriteLine(transaction._category);
            Console.WriteLine(transaction._description);
            Console.WriteLine(transaction._date);

            service.AddTransactionWeb(transaction);
            return RedirectToAction("Transaction");
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}
