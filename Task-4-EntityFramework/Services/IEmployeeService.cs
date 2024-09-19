using Task_4_EntityFramework.Models;

namespace Task_4_EntityFramework.Services
{
    public interface IEmployeeService
    {
        IEnumerable<Employee> GetAll();
        Employee GetById(int id);
        void Post(Employee employee);
        Employee Update(int id, Employee employee);
        Employee Delete(int id);
        IEnumerable<Employee> Employ_sal(int sal);
    }
}
