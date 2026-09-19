using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
/// The Learner class inherits id, firstName and lastName from its parent class Person.
/// Stores the learners course and assessment mark as CourseAssessmentMark.
/// Creates new object Learner and controls access to information via properties.
/// Returns a string with the learners information so that it can be displayed by other classes.
/// </summary>

namespace Project1Gideon
{
    public class Learner : Person
    {
        private CourseAssessmentMark courseAssessmentMark;

        public Learner(int id, string firstName, string lastName, CourseAssessmentMark courseAssessmentMark) : base(id, firstName, lastName)
        {
            this.courseAssessmentMark = courseAssessmentMark;
        }

        public CourseAssessmentMark CourseAssessmentMark
        {
            get { return courseAssessmentMark; }
        }

        public string LearnerInfo()
        {
            return $"ID: {id}\nName: {firstName} {lastName}\nCourse: {courseAssessmentMark.Course.CourseInfo()}";
        }
    }
}
