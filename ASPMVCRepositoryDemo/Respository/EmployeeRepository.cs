using System.Linq.Expressions;
using ASPMVCRepositoryDemo.Models;
using ASPMVCRepositoryDemo.Respository.IRepository;
using ASPMVCRepositoryDemo.Data;
using Microsoft.EntityFrameworkCore;

namespace ASPMVCRepositoryDemo.Respository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeesRepo
    {
        private readonly ApplicationDbContext dbcontext;

        public EmployeeRepository(ApplicationDbContext _db) : base(_db)
        {
            dbcontext = _db;
        }

        public void saveEmployee()
        {
            dbcontext.SaveChanges();
        }

        public void updateEmployee(Employee employee)
        {
            dbcontext.Employees.Update(employee);
        }
    }
}
