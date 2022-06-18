using Microsoft.AspNetCore.Mvc;
using ChartDiagram.DataLayer;
using ChartDiagram.Models;

namespace ChartDiagram.Controllers
{
    public class SalesRecordController : Controller
    {
        private readonly DbContextSales _context;

        public SalesRecordController(DbContextSales context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowSalesData()
        {
            return View();
        }

        [HttpPost]
        public List<object> GetSalesData()
        {
            List<object> data = new List<object>();

            List<string> labels = _context.Sales.Select(p => p.MonthName).ToList();
            data.Add(labels);

            List<int> SalesNumber = _context.Sales.Select(p => p.TotalSales).ToList();
            data.Add(SalesNumber);

            return data;

        }
    }
}
