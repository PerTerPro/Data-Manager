using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using LearMVC1.BL;
using LearMVC1.Filters;
using LearMVC1.Models;
using LearMVC1.ViewModel;

namespace LearMVC1.Controllers
{
    public class BulkUploadController:AsyncController
    {
        public async Task<ActionResult> Upload(FileUploadViewModel model)
        {
            int t1 = Thread.CurrentThread.ManagedThreadId;
            List<Employee> employees = await Task.Factory.StartNew<List<Employee>>(() => GetEmployees(model));
            int t2 = Thread.CurrentThread.ManagedThreadId;
            EmployeeBusinessLayer bal = new EmployeeBusinessLayer();
            bal.UploadEmployee(employees);
            return RedirectToAction("Index", "Employee");

            //List<Employee> employees = GetEmployees(model);
            //EmployeeBusinessLayer bal = new EmployeeBusinessLayer();
            //bal.UploadEmployee(employees);
            //return RedirectToAction("Index", "Employee");
        }

        private List<Employee> GetEmployees(FileUploadViewModel model)
        {
            List<Employee> employees = new List<Employee>();
            StreamReader csvreaderReader = new StreamReader(model.fileUpload.InputStream);
            csvreaderReader.ReadLine();
            while (!csvreaderReader.EndOfStream)
            {
                var line = csvreaderReader.ReadLine();
                var values = line.Split(',');
                Employee e = new Employee();
                e.FirstName = values[0];
                e.LastName = values[1];
                e.Salary = int.Parse(values[2]);
                employees.Add(e);
            }
            return employees;
        } 

        [HeaderFooterFilter]
        [AdminFilter]
        public ActionResult Index()
        {
            return View(new FileUploadViewModel());
        }
    }
}