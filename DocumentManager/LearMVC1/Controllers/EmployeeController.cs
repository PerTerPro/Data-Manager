using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;
using LearMVC1.BL;
using LearMVC1.DataAccessLayer;
using LearMVC1.Filters;
using LearMVC1.Models;
using LearMVC1.ViewModel;

namespace LearMVC1.Controllers
{
    public class EmployeeController : Controller
    {
        public string GetString()
        {
            return "Hello World is old now. It’s time for wassup bro ;)";
        }

        [AdminFilter]
        [HeaderFooterFilter]
        public ActionResult AddNew()
        {
            CreateEmployeeViewModel employeeListViewModel = new CreateEmployeeViewModel();
            return View("CreateEmployee", employeeListViewModel);
        }

        [AdminFilter]
        [HeaderFooterFilter]
        public ActionResult SaveEmployee(Employee e, string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "Save Employee":
                {
                    if (ModelState.IsValid)
                    {
                        EmployeeBusinessLayer empBLA = new EmployeeBusinessLayer();
                        empBLA.SaveEmployee(e);
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        CreateEmployeeViewModel vm = new CreateEmployeeViewModel();
                        vm.FirstName = e.FirstName;
                        vm.LastName = e.LastName;

                   

                        if (e.Salary.HasValue)
                        {
                            vm.Salary = e.Salary.ToString();
                        }
                        else
                        {
                            vm.Salary = ModelState["Salary"].Value.AttemptedValue;
                        }
                        return View("CreateEmployee", vm); //Day 4 Change - Passing a here
                    }
                }
                    break;
                case "Cancel":
                    return RedirectToAction("Index");
            }
            return  new EmptyResult();
        }


        [ChildActionOnly]
        public ActionResult GetAddNewLink()
        {
            if (Convert.ToBoolean(Session["IsAdmin"]))
            {
                return PartialView("AddNewLink");
            }
            else
            {
                return new EmptyResult();
            }
        }
     
        [HeaderFooterFilter]
        public ActionResult Index()
        {
            EmployeeListViewModel emp = new EmployeeListViewModel();
            emp.UserName = User.Identity.Name;

            BL.EmployeeBusinessLayer ebl = new EmployeeBusinessLayer();
            var employees = ebl.GetEmployees();

            List<EmployeeViewModel> lst = new List<EmployeeViewModel>();
            foreach (var VARIABLE in employees)
            {
                EmployeeViewModel e = new EmployeeViewModel();
                e.EmployeeName = VARIABLE.FirstName + " " + VARIABLE.LastName;
                e.Salary = VARIABLE.Salary.Value.ToString("C");
                if (VARIABLE.Salary > 1500)
                {
                    e.SalaryColor = "yellow";
                }
                else
                {
                    e.SalaryColor = "green";
                }
                lst.Add(e);


            }
            emp.Employees = lst;


            emp.FooterData=new FooterViewModel();
            emp.FooterData.CompanyName = "CtCPWSS";
            emp.FooterData.Year = "2020";

            return View("Index", emp);
        }
    }
}