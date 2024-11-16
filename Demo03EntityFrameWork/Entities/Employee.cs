using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo03EntityFrameWork.Entities
{
    internal class Employee
    {
        #region Properties
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public int? Age { get; set; } 
        #endregion


    }
}
