using System.Linq.Expressions;
using ASPMVCRepositoryDemo.Models;

namespace ASPMVCRepositoryDemo.Respository.IRepository
{
    public interface IEmployeesRepo : IRepository<Employee>
    {
        void updateEmployee(Employee employee);
        void saveEmployee();
    }
}
