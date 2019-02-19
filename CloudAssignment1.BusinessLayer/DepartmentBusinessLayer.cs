using CloudAssignment1.BusinessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using CloudAssignment1.DataLayer;

namespace CloudAssignment1.BusinessLayer
{
    public class DepartmentBusinessLayer
    {
        public List<Department> GetAllDepartments()
        {
            try
            {
                List<Department> DepartmentList = new List<Department>();
                DataTable DepartentTablefromDB = new DepartmentDataLayer().GetAllDepartmentsFromDB();

                foreach (DataRow dr in DepartentTablefromDB.Rows)
                {
                    DepartmentList.Add(
                        new Department(
                            int.Parse(dr["depNo-12"].ToString()),
                            dr["depName-12"].ToString(),
                            dr["depContact-12"].ToString()
                           )
                   );
                }

                return DepartmentList;
            }

            catch (Exception e)
            {
                throw e;
            }

        }


    }
}