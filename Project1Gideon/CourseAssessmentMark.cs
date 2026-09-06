using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Gideon
{
    public class CourseAssessmentMark
    {
        //stores course and assessment marks
        private Course course;
        private List<int> marks;

        //constructor
        public CourseAssessmentMark(Course course, List<int> marks)
        {
            this.course = course;
            this.marks = marks;
        }
        public Course GetCourse()
        {
            return course;
        }
        //Converts marks to grades
        private string MarkToGrade(int mark)
        {
            if (mark >= 90)
            {
                return "A+";
            }
            if (mark >= 85)
            {
                return "A";
            }
            if (mark >= 80)
            {
                return "A-";
            }
            if (mark >= 75)
            {
                return "B+";
            }
            if (mark >= 70)
            {
                return "B";
            }
            if (mark >= 65)
            {
                return "B-";
            }
            if (mark >= 60)
            {
                return "C+";
            }
            if (mark >= 55)
            {
                return "C";
            }
            if (mark >= 50)
            {
                return "C-";
            }
            if (mark >= 40)
            {
                return "D";
            }
            else
            {
                return "E";
            }
        }
        public List<int> GetAllMarks()
        {
            return marks;
        }
        //creates a list of all grades
        public List<string> GetAllGrades()
        {
            List<string> grades = new List<string>();
            foreach (int mark in marks)
            {
                grades.Add(MarkToGrade(mark));
            }
            return grades;
        }
        //creates a list of highest mark
        public List<int> GetHighestMark()
        {
            int max = marks.Max();
            List<int> highMarks = new List<int>();
            foreach (int mark in marks)
            {
                if (mark == max)
                {
                    highMarks.Add(mark);
                }
            }
            return highMarks;
        }
        //creates a list of lowest mark
        public List<int> GetLowestMark()
        {
            int min = marks.Min();
            List<int> lowMarks = new List<int>();
            foreach(int mark in marks)
            {
                if (mark == min)
                {
                    lowMarks.Add(mark);
                }
            }
            return lowMarks;
        }
        //creates a list of all failed marks
        public List<int> GetFailMark()
        {
            List<int> failMarks = new List<int>();
            foreach (int mark in marks)
            {
                if (mark <50)
                {
                    failMarks.Add(mark);
                }
            }
            return failMarks;
        }
        public double GetAvgMark()
        {
            return marks.Average();
        }
        public string GetAvgGrade()
        {
            double avg = GetAvgMark();
            int roundedAvg = (int)Math.Round(avg);
            return MarkToGrade(roundedAvg);
        }
    }
}
