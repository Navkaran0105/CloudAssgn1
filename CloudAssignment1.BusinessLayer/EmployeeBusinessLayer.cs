using CloudAssign1.Models;
using CloudAssignment1.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace CloudAssignment1.BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployeeDetails()
        {
            try
            {
                DataTable DsEmployeeDetailsFromDB = new EmployeeDataLayer().GetAllEmployeeDataFromDB();
                return GetListFromDatatable(DsEmployeeDetailsFromDB);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private List<Employee> GetListFromDatatable(DataTable Dt)
        {
            List<Employee> EmployeeList = new List<Employee>();

            foreach (DataRow dr in Dt.Rows)
            {
                EmployeeList.Add(
                    new Employee(
                        int.Parse(dr["empno-12"].ToString()),
                        dr["empFName-12"].ToString(),
                        dr["empLName-12"].ToString(),
                        dr["empPos-12"].ToString(),
                        DateTime.Parse(dr["empStartDate-12"].ToString()),
                        double.Parse(dr["empSal-12"].ToString()),
                        dr["depName-12"].ToString(),
                        dr["depContact-12"].ToString()
                       )
               );
            }

            return EmployeeList;

        }
    }
}