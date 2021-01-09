using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThomasClaudiusHuber.DependencyInjection.Model;
using ThomasClaudiusHuber.DependencyInjection.Services;

namespace ThomasClaudiusHuber.DependencyInjection.Pages
{
  public partial class Employees2Base : ComponentBase
  {
    [Microsoft.AspNetCore.Components.Inject]
    protected IEmployeeService EmployeeService { get; set; }

    protected IEnumerable<Employee> employees;

    protected override async Task OnInitializedAsync()
    {
      employees = await EmployeeService.LoadEmployeesAsync();
    }
  }
}
