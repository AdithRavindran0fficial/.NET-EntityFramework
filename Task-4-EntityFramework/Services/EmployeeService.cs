using Task_4_EntityFramework.Data;
using Task_4_EntityFramework.Models;

namespace Task_4_EntityFramework.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly EmployeeContext _employeeContext;
        public EmployeeService(EmployeeContext context)
        {
            _employeeContext = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            using (var context = _employeeContext)
            {
                return context.Employee.ToList();
            }
        }
       public Employee GetById(int id)
        {
            using (var context = _employeeContext)
            {
                var emp = context.Employee.FirstOrDefault(emp => emp.Emp_Id == id);
                return emp;
            }
        }
        public void Post(Employee employee)
        {
            using(var context = _employeeContext)
            {
                context.Employee.Add(employee);
                context.SaveChanges();
            }
        }
        public Employee Update(int id, Employee employee)
        {
            using (var context = _employeeContext)
            {
                var exist = context.Employee.FirstOrDefault(emp => emp.Emp_Id == id);
                if(exist != null)
                {
                    exist.Employee_Name = employee.Employee_Name;
                    exist.Employee_Sal=employee.Employee_Sal;
                    exist.Joining = employee.Joining;
                    context.SaveChanges();
                    return exist;
                }
                else
                {
                    return null;
                }
            }
        }
        public Employee Delete(int id)
        {
            using (var context = _employeeContext)
            {
                var delete  = context.Employee.FirstOrDefault(emp=>emp.Emp_Id==id);
                if (delete == null)
                {
                    return null;
                }
                else
                {
                    context.Employee.Remove(delete);
                    return delete;
                }
            }
        }
        public IEnumerable<Employee> Employ_sal(int sal)
        {
            using(var context = _employeeContext) 
            {
                var employee = _employeeContext.Employee.Where(emp => emp.Employee_Sal == sal).ToList();
                return employee;
            }

        }
    }
}
