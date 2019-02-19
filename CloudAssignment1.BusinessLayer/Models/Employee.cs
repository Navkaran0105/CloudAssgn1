using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CloudAssign1.Models
{
    public class Employee
    {
        public int EmpNO { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Pos { get; set; }
        public DateTime StartDate { get; set; }
        public double Salary { get; set; }
        public string DeptName { get; set; }
        public string DeptContact { get; set; }

        public Employee(int EmpNO, string FirstName, string LastName, string Pos, DateTime StartDate, double Salary, string DeptName, string DeptContact)
        {
            this.EmpNO = EmpNO;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Pos = Pos;
            this.StartDate = StartDate;
            this.Salary = Salary;
            this.DeptName = DeptName;
            this.DeptContact = DeptContact;
        }
    }
}