using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkingWithMultipleTable_Prod.Data;
using WorkingWithMultipleTable_Prod.Models.ViewModel;

namespace WorkingWithMultipleTable_Prod.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context;
        public EmployeeController (ApplicationDbContext context)
        {
            context = context;
        }

        public IActionResult Index()
        {
            //EmployeeDepartmentListViewModel emp= new EmployeeDepartmentListViewModel();
            //emp.employees=context.Employees.ToList();
            //emp.departments=context.Departments.ToList();
            //emp.employees = empData;
            //emp.departments = depData;

            //EmployeeDepartmentListViewModel emp = new EmployeeDepartmentListViewModel();
            //var empdata = context.Employees.FromSqlRaw("Select * from Employees").ToList();
            //var depdata = context.Departments.FromSqlRaw("Select * from Departments").ToList();
            //emp.employees = empdata;
            //emp.departments = depdata;



            //var data=(from e in context.Employees
            //         join d in context.Departments
            //         on e.DepartmentId equals d.DepartmentId
            //         select new EmployeeDepartmentSummaryViewModel
            //         {
            //             EmployeeId= e.EmployeeId,
            //             FirstName= e.FirstName,
            //             MiddleName= e.MiddleName,
            //             LastName= e.LastName,
            //             Gender= e.Gender,
            //             DepartmentCode= d.DepartmentCode,
            //             DepartmentName= d.DepartmentName
            //         }).ToList();

            //var data = context.EmployeeDepartmentSummariesViewModels.FromSqlRaw("select e.EmployeeId,e.FirstName,e.MiddleName,e.LastName,e.Gender,d.DepartmentId,d.DepartmentCode,d.DepartmentName from Employees e join Departments d on e.DepartmentId =d.DepartmentId");

            //var empData = context.Employees.FromSqlRaw("exec GetEmployee");
            //var depData = context.Departments.FromSqlRaw("exec GetDepartment");

            var result = context.EmployeeDepartmentSummariesViewModels.FromSqlRaw("exec GetEmployeeDepartmentsList").ToList();

            return View(result);
        } 
    }
}
