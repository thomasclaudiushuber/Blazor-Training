using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;
using ThomasClaudiusHuber.DependencyInjection.Model;

namespace ThomasClaudiusHuber.DependencyInjection.Pages
{
  public partial class Employees2Base : ComponentBase
  {
    // TODO: 5. Look at the Employees2.razor file and notice the @inherits directive at the top.
    //          You can see that the Employees2.razor component inherits from this Employees2Base class 
    //          and it is using the protected employees field defined in this class               
    // TODO: 6. Create here an EmployeeService property of type IEmployeeService
    // TODO: 7. Add the [Inject] attribute to the EmployeeService property to inject the IEmployeeService into it

    protected IEnumerable<Employee> employees;

    protected override async Task OnInitializedAsync()
    {
      // TODO: 8. Use the created EmployeeService property here in this method to load the employees into the employees field
    }
  }
}
