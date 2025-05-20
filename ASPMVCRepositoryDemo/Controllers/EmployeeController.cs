using ASPMVCRepositoryDemo.Models;
using ASPMVCRepositoryDemo.Respository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVCRepositoryDemo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeesRepo employeesRepo;

        public EmployeeController(IEmployeesRepo _employeesRepo)
        {
            employeesRepo = _employeesRepo;
        }
        public IActionResult Index()
        {
            List<Employee> listEmps = employeesRepo.GetAll().ToList();
            return View(listEmps);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeesRepo.Add(employee);
                employeesRepo.saveEmployee();
                TempData["success"] = "New employee saved successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Employee? employee = employeesRepo.Get(u => u.Id == id);

            if (employee == null) return NotFound();
            
            return View(employee);
        }
        [HttpPost]
        public IActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                employeesRepo.updateEmployee(employee);
                employeesRepo.saveEmployee();
                TempData["success"] = "Employee updated successfully!";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Employee? employee = employeesRepo.Get(u => u.Id == id);

            if (employee == null) return NotFound();
            return View(employee);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Employee? obj = employeesRepo.Get(u => u.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            employeesRepo.Remove(obj);
            employeesRepo.saveEmployee();
            TempData["success"] = "Employee deleted successfully!";
            return RedirectToAction("Index");
        }
    }
}
