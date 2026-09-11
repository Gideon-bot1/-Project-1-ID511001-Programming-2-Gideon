using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Gideon
{
    public class Learner : Person
    {
        private CourseAssessmentMark courseAssessmentMark;

        public Learner(int id, string firstName, string lastName, CourseAssessmentMark courseAssessmentMark) : base(id, firstName, lastName)
        {
            this.courseAssessmentMark = courseAssessmentMark;
        }

        public CourseAssessmentMark GetCourseAssessmentMark()
        {
            return courseAssessmentMark;
        }

        public string LearnerInfo()
        {
            return $"ID: {id}\nName: {firstName} {lastName}\nCourse: {courseAssessmentMark.GetCourse().CourseInfo()}";
        }

    }
}
