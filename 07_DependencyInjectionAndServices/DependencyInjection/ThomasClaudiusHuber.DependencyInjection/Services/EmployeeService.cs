using System.Collections.Generic;
using System.Threading.Tasks;
using ThomasClaudiusHuber.DependencyInjection.Model;

namespace ThomasClaudiusHuber.DependencyInjection.Services
{
  public class EmployeeService : IEmployeeService
  {
    public Task<IEnumerable<Employee>> LoadEmployeesAsync()
    {
      IEnumerable<Employee> employees = new List<Employee>
      {
        new Employee{FirstName="Sylvester",LastName="Stallone"},
        new Employee{FirstName="Arnold",LastName="Schwarzenegger"},
        new Employee{FirstName="Linda",LastName="Hamilton"},
        new Employee{FirstName="Dolph",LastName="Lundgren"}
      };

      return Task.FromResult(employees);
    }
  }
}
