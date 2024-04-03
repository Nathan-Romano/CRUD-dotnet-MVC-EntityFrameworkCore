using CRUD_MVC_SQL.Data;
using CRUD_MVC_SQL.Models;
using CRUD_MVC_SQL.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_MVC_SQL.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddEmployeeViewModel viewModel) 
        {
            var employee = new Employee
            {
                Name = viewModel.Name,
                Position = viewModel.Position,
                Salary = viewModel.Salary,
            };
            await dbContext.Employees.AddAsync(employee);
            await dbContext.SaveChangesAsync();  
            return View(viewModel);
        }
    }
}
