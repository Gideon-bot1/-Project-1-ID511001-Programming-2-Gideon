namespace Project1Gideon
{
    public partial class Form1 : Form
    {
        private List<Institution> institutions;
        private List<Department> departments;
        private List<Course> courses;
        public Form1()
        {
            InitializeComponent();
            institutions = Seeder.SeedInstitutions();
            departments = Seeder.SeedDepartments();
            courses = Seeder.SeedCourses();
        }
        private void btn1DisplayCourseDetails_Click(object sender, EventArgs e)
        {
            MessageBox.Show
            (courses[0].CourseInfo() + "\n\n" +
             courses[1].CourseInfo() + "\n\n" +
             courses[2].CourseInfo());
        }
    }
}
