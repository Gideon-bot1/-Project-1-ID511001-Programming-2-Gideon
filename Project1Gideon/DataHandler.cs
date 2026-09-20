using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
/// The DataHandler class is responsible for reading in learner and lecturer information from the .txt files.
/// It converts the info into objects and adds them to the correct lists.
/// It is also responsible for saving and updating the .txt files when a person is added or removed.
/// </summary>

namespace Project1Gideon
{
    public class DataHandler
    {
        public enum PersonType
        {
            LEARNER,
            LECTURER,
        }
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

        /// <summary>
        /// Checks if PersonType is LEARNER or LECTURER.
        /// Reads the .txt, creates an object, formats the data and adds it to the correct list.
        /// Displays error message if file was not found or if any other error occured.
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="learners"></param>
        /// <param name="courses"></param>
        /// <param name="lecturers"></param>
        /// <param name="type"></param>

        public static void ReadPersonFromFile(string filepath, List<Learner> learners, List<Course> courses, List<Lecturer> lecturers, PersonType type)
        {
            if (type == PersonType.LEARNER)
            {
                try
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
                catch (FileNotFoundException)
                {
                    MessageBox.Show("The Learners.txt file could not be found.");
                }
                catch
                {
                    MessageBox.Show("There was an error reading the Learners.txt file.");
                }
            }
            else if (type == PersonType.LECTURER)
            {
                try
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
                catch (FileNotFoundException)
                {
                    MessageBox.Show("The Lecturers.txt file could not be found.");
                }
                catch
                {
                    MessageBox.Show("There was an error reading the Lecturers.txt file.");
                }
            }
        }

        /// <summary>
        /// Takes the data from the learners list and comma seperates it into a string.
        /// It does this for each learner and then updates the learners.txt file with any new data.
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="learners"></param>
        /// <param name="courses"></param>

        public static void SaveLearnersToFile(string filepath, List<Learner> learners, List<Course> courses)
        {
            try
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
            catch
            {
                MessageBox.Show("There was an error saving to the Learners.txt file");
            }
        }
        //Takes information from Lecturers, converts enums to int values, formats and saves them to a .txt 
        public static void SaveLecturersToFile(string filepath, List<Lecturer> lecturers, List<Course> courses)
        {
            try
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
            catch
            {
                MessageBox.Show("There was an error saving to the Lecturers.txt file.");
            }
        }
    }
}
