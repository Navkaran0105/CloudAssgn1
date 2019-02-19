using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CloudAssignment1.BusinessLayer.Models
{
    public class Department
    {
        public int depNo { get; set; }
        public string depName { get; set; }
        public string depContact { get; set; }


        public Department(int depNo, string depName, string depContact)
        {
            this.depNo = depNo;
            this.depName = depName;
            this.depContact = depContact;
        }

    }
}