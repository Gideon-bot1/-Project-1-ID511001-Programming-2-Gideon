using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
/// The Lecturer class inherits id, firstName and lastName from Person.
/// It adds the lecturers course, position and salary to Lecturer.
/// Controls access to the lecturers information with properties.
/// Returns a string so that other classes can display this information.
/// </summary>

namespace Project1Gideon
{
    public class Lecturer : Person
    {
        private EPosition position;
        private ESalary salary;
        private Course course;

        public Lecturer(int id, string firstName, string lastName, EPosition position, ESalary salary, Course course) : base(id, firstName, lastName)
        {
            this.position = position;
            this.salary = salary;
            this.course = course;
        }

        public EPosition Position
        {
            get { return position; }
        }

        public ESalary Salary
        {
            get { return salary; }
        }
        public Course Course
        {
            get { return course; }
        }

        public string LecturerInfo()
        {
            return $"ID: {id}\nName: {firstName} {lastName}\nPosition: {position}\nSalary: {salary}\nCourse: {course.CourseInfo()}";
        }
    }
}
