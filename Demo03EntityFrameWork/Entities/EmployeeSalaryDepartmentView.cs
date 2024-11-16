using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03EntityFrameWork.Entities
{
    public class EmployeeSalaryDepartmentView
    {
        //[Keyless]
        public int EmployeeId { get; set; }

        public string EmployeeName { get; set; }

        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

    }
}
