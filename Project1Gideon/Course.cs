using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
/// The Course class stores department, code, name, description, credit and fees in a Course object.
/// Its uses public properties to control the other classes access to private information.
/// It contains a methed to return a string containing all the course info so that Form1.cs can display it.
/// </summary>

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

        /// <summary>
        /// Takes the course data and formats it into a string.
        /// </summary>
        /// <returns>a formatted string for Form1 to display course info.</returns>

        public string CourseInfo()
        {
            return $"{department.DepartmentInfo()}\nCode: {code}\nCourse: {name}\nDescription: {description}\nCredits: {credits}\nFees: {fees:c}";
        }
        public string Code
        { 
            get { return code; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Description
        {
            get { return description; }
        }
        public int Credits
        {
            get { return credits; }
        }
        public int Fees
        {
            get { return fees; }
        }
        public Department Department
        {
            get { return department; }
        }
    }
}
