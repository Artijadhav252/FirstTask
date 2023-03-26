using FirstTask.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstTask.Controllers
{
    public class UserController : Controller
    {
        public void Index()
        {
            FirstDemoContext db = new FirstDemoContext();
            var Doctor = db.Doctors.ToList();
            var Student = db.Students.ToList();
            var Customer = db.Customers.ToList();
            var Employee = db.Employees.ToList();
            var Department = db.Departments.ToList();


        }
    }
}
