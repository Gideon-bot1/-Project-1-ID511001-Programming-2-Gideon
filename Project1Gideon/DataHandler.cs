using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1Gideon
{
    public class DataHandler
    {

        //Stores lists for datahandler
        private List<Learner> learners;
        private List<Lecturer> lecturers;
        private List<Course> courses;

        //DataHandler contructor
        public DataHandler(List<Course> courses)
        {
            this.courses = courses;

            learners = new List<Learner>();
            lecturers = new List<Lecturer>();
        }
        //Reads Learner information and adds them to the learner list
        public static void ReadLearnersFromFile(string filepath, List<Learner> learners, List<Course> courses)
        {
            List<string> lines = File.ReadAllLines(filepath).ToList();
            foreach (string line in lines)
            {
                string[] learnerDetails = line.Split(',');
                int id = int.Parse(learnerDetails[0]);
                string firstName = learnerDetails[1];
                string lastName = learnerDetails[2];
                int courseNum = int.Parse(learnerDetails[3]);

                List<int> marks = new List<int>()
                {
                    Convert.ToInt32(learnerDetails[4]),
                    Convert.ToInt32(learnerDetails[5]),
                    Convert.ToInt32(learnerDetails[6]),
                    Convert.ToInt32(learnerDetails[7]),
                    Convert.ToInt32(learnerDetails[8])
                };

                CourseAssessmentMark assessmentMarks = new CourseAssessmentMark(courses[courseNum], marks);
                Learner learner = new Learner(id, firstName, lastName, assessmentMarks);
                learners.Add(learner);
            }
        }
        //Reads lecturer information and adds them to lecturer list
        public static void ReadLecturersFromFile(string filepath, List<Lecturer> lecturers, List<Course> courses)
        {
            List<string> lines = File.ReadAllLines(filepath).ToList();
            foreach (string line in lines)
            {
                string[] lecturerDetails = line.Split(',');
                int id = int.Parse(lecturerDetails[0]);
                string firstName = lecturerDetails[1];
                string lastName = lecturerDetails[2];
                EPosition position = (EPosition)int.Parse(lecturerDetails[3]);
                ESalary salary = (ESalary)int.Parse(lecturerDetails[4]);
                int courseNum = int.Parse(lecturerDetails[5]);

                Course course = courses[courseNum];

                Lecturer lecturer = new Lecturer(id, firstName, lastName, position, salary, course);
                lecturers.Add(lecturer);
            }
        }
        //Takes informaton from learners and course assessment marks then formats and saves them back into a .txt
        public static void SaveLearnersToFile(string filepath, List<Learner> learners, List<Course> courses)
        {
            List<string> lines = new List<string>();

            foreach (Learner learner in learners)
            {
                CourseAssessmentMark assessmentMark = learner.CourseAssessmentMark;
                List<int> marks = assessmentMark.AllMarks;
                int id = learner.Id;
                string firstName = learner.FirstName;
                string lastName = learner.LastName;
                int courseNum = courses.IndexOf(assessmentMark.Course);

                string line = $"{id},{firstName},{lastName},{courseNum},{marks[0]},{marks[1]},{marks[2]},{marks[3]},{marks[4]}";
                lines.Add(line);
            }
            File.WriteAllLines(filepath, lines);
        }
        //Takes information from Lecturers, converts enums to int values, formats and saves them to a .txt 
        public static void SaveLecturersToFile(string filepath, List<Lecturer> lecturers, List<Course> courses)
        {
            List<string> lines = new List<string>();
            foreach (Lecturer lecturer in lecturers)
            {
                int id = lecturer.Id;
                string firstName = lecturer.FirstName;
                string lastName = lecturer.LastName;
                EPosition position = lecturer.Position;
                ESalary salary = lecturer.Salary;
                Course course = lecturer.Course;
                int courseNum = courses.IndexOf(course);

                int positionNum = (int)position;
                int salaryNum = (int)salary;

                string line = $"{id},{firstName},{lastName},{positionNum},{salaryNum},{courseNum}";
                lines.Add(line);
            }
            File.WriteAllLines(filepath, lines);
        }
    }
}
