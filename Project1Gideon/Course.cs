using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Gideon
{
    public class Course
    {
        private Department department;
        private string code;
        private string name;
        private string description;
        private int credits;
        private int fees;

        //constructor 
        public Course(Department department, string code, string name, string description, int credits, int fees)
        {
            this.department = department;
            this.code = code;
            this.name = name;
            this.description = description;
            this.credits = credits;
            this.fees = fees;
        }
        //formatted string 
        public string CourseInfo()
        {
            return $"{department.DepartmentInfo()}\nCode: {code}\nCourse: {name}\nDescription: {description}\nCredits: {credits}\nFees: {fees:c}";
        }
    }
}
