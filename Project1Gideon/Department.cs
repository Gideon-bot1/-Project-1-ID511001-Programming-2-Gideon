using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
/// The Department class stores instiution and department name in a department object.
/// It contains a method that returns a public string that Form1.cs uses to display Department information.
/// Its uses public properties to control the other classes access to private information.
/// </summary>

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
        public string DepartmentName
        {
            get { return departmentname; }
        }
        public Institution Institution
        {
            get { return institution; }
        }
    }
}
