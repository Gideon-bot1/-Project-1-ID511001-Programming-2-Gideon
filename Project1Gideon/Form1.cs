namespace Project1Gideon
{
    public partial class Form1 : Form
    {
        private List<Institution> institutions;
        private List<Department> departments;
        private List<Course> courses;
        private List<Learner> learners;
        private List<Lecturer> lecturers;
        public Form1()
        {
            InitializeComponent();
            institutions = Seeder.SeedInstitutions();
            departments = Seeder.SeedDepartments();
            courses = Seeder.SeedCourses();
            learners = new List<Learner>();
            lecturers = new List<Lecturer>();

            //Calls readfile methods
            DataHandler.ReadLearnersFromFile("learners.txt", learners, courses);
            DataHandler.ReadLecturersFromFile("lecturers.txt", lecturers, courses);
        }
        private void btn1DisplayCourseDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (courses[0].CourseInfo() + "\n\n" +
             courses[1].CourseInfo() + "\n\n" +
             courses[2].CourseInfo());

            MessageBox.Show(learners[0].LearnerInfo());

            MessageBox.Show(lecturers[0].LecturerInfo());
        }
    }
}
