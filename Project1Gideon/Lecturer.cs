using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string LecturerInfo()
        {
            return $"ID: {id}\nName: {firstName} {lastName}\nPosition: {position}\nSalary: {salary}\nCourse: {course.CourseInfo()}";
        }

        public EPosition GetPosition()
        {
            return position;
        }

        public ESalary GetSalary()
        {
            return salary;
        }
        public Course GetCourse()
        {
            return course;
        }
    }
}
