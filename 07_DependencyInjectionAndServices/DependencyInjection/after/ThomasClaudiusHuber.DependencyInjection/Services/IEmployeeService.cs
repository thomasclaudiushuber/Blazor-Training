using System.Collections.Generic;
using System.Threading.Tasks;
using ThomasClaudiusHuber.DependencyInjection.Model;

namespace ThomasClaudiusHuber.DependencyInjection.Services
{
  public interface IEmployeeService
  {
    Task<IEnumerable<Employee>> LoadEmployeesAsync();
  }
}