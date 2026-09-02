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

        private readonly IFinanceService _service;

        public TransactionsController(IFinanceService service)
        {
            _service = service;
        }
        public IActionResult Transaction()
        {
            var transactions = _service.GetAllTransactionWeb();
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

            _service.AddTransactionWeb(transaction);

            return RedirectToAction("Transaction");
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _service.DeleteTransaction(id);

            return RedirectToAction("Transaction");
        }


    }
}
