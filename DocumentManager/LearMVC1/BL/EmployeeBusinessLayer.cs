using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LearMVC1.DataAccessLayer;
using LearMVC1.Models;

namespace LearMVC1.BL
{
    public class EmployeeBusinessLayer
    {
        public UserStatus GetUserValied(UserDetails u)
        {
            if (u.UserName=="Admin" && u.Password=="Admin") return UserStatus.AuthenticatedAdmin;
            else if (u.UserName == "Sukesh" && u.Password == "Sukesh") return UserStatus.AuthenticatedUser;
            else return UserStatus.NonAuthenticatedUser;
            
        }

        public void UploadEmployee(List<Employee> employees)
        {
            SalesERPDAL saleDal = new SalesERPDAL();
            saleDal.Employees.AddRange(employees);
            saleDal.SaveChanges();
        }

        public List<Employee> GetEmployees()
        {

            SalesERPDAL salesDal = new SalesERPDAL();
            return salesDal.Employees.ToList();


            var employees = new List<Employee>();
            Employee emp = new Employee();
            emp.FirstName = "johnson";
            emp.LastName = "fernandes";
            emp.Salary = 140000;
            employees.Add(emp);


        
            Employee emp1 = new Employee();
            emp1.FirstName = "johnson1";
            emp1.LastName = "fernandes1";
            emp1.Salary = 1400001;
            employees.Add(emp1);

            Employee emp2 = new Employee();
            emp2.FirstName = "johnson2";
            emp2.LastName = "fernandes2";
            emp2.Salary = 1400001;
            employees.Add(emp2);

            return employees;
        }

        public Employee SaveEmployee(Employee e)
        {

            SalesERPDAL salesDal = new SalesERPDAL();
            salesDal.Employees.Add(e);
            salesDal.SaveChanges();
            return e;
        }
    }
}