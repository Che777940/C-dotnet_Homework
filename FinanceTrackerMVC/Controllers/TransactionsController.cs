using FinanceTracker.Application.Interfaces;
using FinanceTracker.Application.Services;
using FinanceTracker.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

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
    }
}
