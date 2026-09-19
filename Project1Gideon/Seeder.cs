using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
/// The Seeder class creates lists for Institution, Department and Course informtion.
/// Populates each list with the relevant info.
/// Returns each populated list so the info can be used by the class that called the method.
/// </summary>

namespace Project1Gideon
{
    //Creates lists to store class information
    public static class Seeder
    {
        private static List<Institution> institutions = new List<Institution>();
        private static List<Department> departments = new List<Department>();
        private static List<Course> courses = new List<Course>();

        //Adds information to the institution list
        public static List<Institution> SeedInstitutions()
        {
            institutions.Add(new Institution("Otago Polytechnic", "Otago", "New Zealand"));
            institutions.Add(new Institution("Otago University", "Otago", "New Zealand"));
            institutions.Add(new Institution("Victoria University", "Wellington", "New Zealand"));
            return institutions;
        }
        public static List<Department> SeedDepartments()
        {
            departments.Add(new Department(institutions[0], "Information Technology"));
            departments.Add(new Department(institutions[1], "Medicine"));
            departments.Add(new Department(institutions[2], "Public Health"));
            return departments;
        }
        public static List<Course> SeedCourses()
        {
            courses.Add(new Course(departments[0], "ID511001", "Programming 2", "Advanced programming concepts", 15, 9275));
            courses.Add(new Course(departments[1], "MICN501", "Medicine 5th Year", "Advanced Learning in Medicine", 18, 19538));
            courses.Add(new Course(departments[2], "HLWB303", "Health and Wellbeing", "Global Health and wellbeing", 20, 8528));
            return courses;
        }
    }
}
