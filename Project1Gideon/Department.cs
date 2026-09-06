using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Gideon
{
    public class Department
    {
        private Institution institution;
        private string departmentname;

        public Department(Institution institution, string departmentname)
        {
            this.institution = institution;
            this.departmentname = departmentname;
        }
        public string DepartmentInfo()
        {
            return $"{institution.InstitutionInfo()}\nDepartment: {departmentname}";
        }
    }
}
