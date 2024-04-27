using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TS2302004.Models;

namespace TS2302004.Controllers
{
    public class CompanyController : Controller
    {
        private readonly CompanyDbContext db;
        public CompanyController(CompanyDbContext db)
        {
            this.db = db;
        }
        public async Task<IActionResult> Index()
        {
            var list = await db.Employees.ToListAsync();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View("Create");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteSelected(int[] selectedIds)
        {
            if (selectedIds != null && selectedIds.Length > 0)
            {
                var deleteEmployee = await db.Employees.Where(e => selectedIds.Contains(e.Id)).ToListAsync();
                db.Employees.RemoveRange(deleteEmployee);
                await db.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}
