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
            dgvDisplayInfo.Rows.Clear();
            dgvDisplayInfo.Columns.Clear();

            dgvDisplayInfo.Columns.Add("Course", "Course");
            dgvDisplayInfo.Columns.Add("Description", "Description");
            dgvDisplayInfo.Columns.Add("Credits", "Credits");
            dgvDisplayInfo.Columns.Add("Fees", "Fees");
            dgvDisplayInfo.Columns.Add("Institution", "Institution");
            dgvDisplayInfo.Columns.Add("Department", "Department");

            foreach (Course course in courses)
            {
                int rowIdx = dgvDisplayInfo.Rows.Add();
                //rowIdx selects the row, .cells[""] selects the column and .Value inserts the info
                dgvDisplayInfo.Rows[rowIdx].Cells["Course"].Value = course.Code + " " + course.Name;
                dgvDisplayInfo.Rows[rowIdx].Cells["Description"].Value = course.Description;
                dgvDisplayInfo.Rows[rowIdx].Cells["Credits"].Value = course.Credits;
                dgvDisplayInfo.Rows[rowIdx].Cells["Fees"].Value = course.Fees;
                dgvDisplayInfo.Rows[rowIdx].Cells["Institution"].Value = course.Department.Institution.Name;
                dgvDisplayInfo.Rows[rowIdx].Cells["Department"].Value = course.Department.DepartmentName;
            }

            //Sizes columns automatically to fit all info
            dgvDisplayInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn2DisplayAllMarks_Click(object sender, EventArgs e)
        {
            dgvDisplayInfo.Rows.Clear();
            dgvDisplayInfo.Columns.Clear();

            dgvDisplayInfo.Columns.Add("ID", "ID");
            dgvDisplayInfo.Columns.Add("Name", "Name");
            dgvDisplayInfo.Columns.Add("Course", "Course");
            dgvDisplayInfo.Columns.Add("Marks", "Marks");

            foreach (Learner learner in learners)
            {
                int rowIdx = dgvDisplayInfo.Rows.Add();
                dgvDisplayInfo.Rows[rowIdx].Cells["ID"].Value = learner.Id;
                dgvDisplayInfo.Rows[rowIdx].Cells["Name"].Value = learner.FirstName + " " + learner.LastName;
                dgvDisplayInfo.Rows[rowIdx].Cells["Course"].Value = learner.CourseAssessmentMark.Course.Code + " " + learner.CourseAssessmentMark.Course.Name;
                dgvDisplayInfo.Rows[rowIdx].Cells["Marks"].Value = string.Join(", ", learner.CourseAssessmentMark.AllMarks);
            }
            dgvDisplayInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn3DisplayAllGrades_Click(object sender, EventArgs e)
        {
            dgvDisplayInfo.Rows.Clear();
            dgvDisplayInfo.Columns.Clear();

            dgvDisplayInfo.Columns.Add("ID", "ID");
            dgvDisplayInfo.Columns.Add("Name", "Name");
            dgvDisplayInfo.Columns.Add("Course", "Course");
            dgvDisplayInfo.Columns.Add("Grades", "Grades");

            foreach (Learner learner in learners)
            {
                int rowIdx = dgvDisplayInfo.Rows.Add();
                dgvDisplayInfo.Rows[rowIdx].Cells["ID"].Value = learner.Id;
                dgvDisplayInfo.Rows[rowIdx].Cells["Name"].Value = learner.FirstName + " " + learner.LastName;
                dgvDisplayInfo.Rows[rowIdx].Cells["Course"].Value = learner.CourseAssessmentMark.Course.Code + " " + learner.CourseAssessmentMark.Course.Name;
                dgvDisplayInfo.Rows[rowIdx].Cells["Grades"].Value = string.Join(", ", learner.CourseAssessmentMark.GetAllGrades());
            }
            dgvDisplayInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void btn4DisplayHighestMarks_Click(object sender, EventArgs e)
        {
            dgvDisplayInfo.Rows.Clear();
            dgvDisplayInfo.Columns.Clear();

            dgvDisplayInfo.Columns.Add("ID", "ID");
            dgvDisplayInfo.Columns.Add("Name", "Name");
            dgvDisplayInfo.Columns.Add("Course", "Course");
            dgvDisplayInfo.Columns.Add("Marks", "Marks");

            foreach (Learner learner in learners)
            {
                int rowIdx = dgvDisplayInfo.Rows.Add();
                dgvDisplayInfo.Rows[rowIdx].Cells["ID"].Value = learner.Id;
                dgvDisplayInfo.Rows[rowIdx].Cells["Name"].Value = learner.FirstName + " " + learner.LastName;
                dgvDisplayInfo.Rows[rowIdx].Cells["Course"].Value = learner.CourseAssessmentMark.Course.Code + " " + learner.CourseAssessmentMark.Course.Name;
                dgvDisplayInfo.Rows[rowIdx].Cells["Marks"].Value = string.Join(", ", learner.CourseAssessmentMark.GetHighestMark());
            }
            dgvDisplayInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn5DisplayLowestMarks_Click(object sender, EventArgs e)
        {
            dgvDisplayInfo.Rows.Clear();
            dgvDisplayInfo.Columns.Clear();

            dgvDisplayInfo.Columns.Add("ID", "ID");
            dgvDisplayInfo.Columns.Add("Name", "Name");
            dgvDisplayInfo.Columns.Add("Course", "Course");
            dgvDisplayInfo.Columns.Add("Marks", "Marks");

            foreach (Learner learner in learners)
            {
                int rowIdx = dgvDisplayInfo.Rows.Add();
                dgvDisplayInfo.Rows[rowIdx].Cells["ID"].Value = learner.Id;
                dgvDisplayInfo.Rows[rowIdx].Cells["Name"].Value = learner.FirstName + " " + learner.LastName;
                dgvDisplayInfo.Rows[rowIdx].Cells["Course"].Value = learner.CourseAssessmentMark.Course.Code + " " + learner.CourseAssessmentMark.Course.Name;
                dgvDisplayInfo.Rows[rowIdx].Cells["Marks"].Value = string.Join(", ", learner.CourseAssessmentMark.GetLowestMark());
            }
            dgvDisplayInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn6DisplayFailMarks_Click(object sender, EventArgs e)
        {
            dgvDisplayInfo.Rows.Clear();
            dgvDisplayInfo.Columns.Clear();

            dgvDisplayInfo.Columns.Add("ID", "ID");
            dgvDisplayInfo.Columns.Add("Name", "Name");
            dgvDisplayInfo.Columns.Add("Course", "Course");
            dgvDisplayInfo.Columns.Add("Marks", "Marks");

            foreach (Learner learner in learners)
            {
                int rowIdx = dgvDisplayInfo.Rows.Add();
                dgvDisplayInfo.Rows[rowIdx].Cells["ID"].Value = learner.Id;
                dgvDisplayInfo.Rows[rowIdx].Cells["Name"].Value = learner.FirstName + " " + learner.LastName;
                dgvDisplayInfo.Rows[rowIdx].Cells["Course"].Value = learner.CourseAssessmentMark.Course.Code + " " + learner.CourseAssessmentMark.Course.Name;
                dgvDisplayInfo.Rows[rowIdx].Cells["Marks"].Value = string.Join(", ", learner.CourseAssessmentMark.GetFailMark());
            }
            dgvDisplayInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn7DisplayAvgMarks_Click(object sender, EventArgs e)
        {
            dgvDisplayInfo.Rows.Clear();
            dgvDisplayInfo.Columns.Clear();

            dgvDisplayInfo.Columns.Add("ID", "ID");
            dgvDisplayInfo.Columns.Add("Name", "Name");
            dgvDisplayInfo.Columns.Add("Course", "Course");
            dgvDisplayInfo.Columns.Add("Average Mark", "Average Marks");

            foreach (Learner learner in learners)
            {
                int rowIdx = dgvDisplayInfo.Rows.Add();
                dgvDisplayInfo.Rows[rowIdx].Cells["ID"].Value = learner.Id;
                dgvDisplayInfo.Rows[rowIdx].Cells["Name"].Value = learner.FirstName + " " + learner.LastName;
                dgvDisplayInfo.Rows[rowIdx].Cells["Course"].Value = learner.CourseAssessmentMark.Course.Code + " " + learner.CourseAssessmentMark.Course.Name;
                dgvDisplayInfo.Rows[rowIdx].Cells["Average Mark"].Value = learner.CourseAssessmentMark.GetAvgMark();
            }
            dgvDisplayInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn8DisplayAvgGrades_Click(object sender, EventArgs e)
        {
            dgvDisplayInfo.Rows.Clear();
            dgvDisplayInfo.Columns.Clear();

            dgvDisplayInfo.Columns.Add("ID", "ID");
            dgvDisplayInfo.Columns.Add("Name", "Name");
            dgvDisplayInfo.Columns.Add("Course", "Course");
            dgvDisplayInfo.Columns.Add("Average Grade", "Average Grade");

            foreach (Learner learner in learners)
            {
                int rowIdx = dgvDisplayInfo.Rows.Add();
                dgvDisplayInfo.Rows[rowIdx].Cells["ID"].Value = learner.Id;
                dgvDisplayInfo.Rows[rowIdx].Cells["Name"].Value = learner.FirstName + " " + learner.LastName;
                dgvDisplayInfo.Rows[rowIdx].Cells["Course"].Value = learner.CourseAssessmentMark.Course.Code + " " + learner.CourseAssessmentMark.Course.Name;
                dgvDisplayInfo.Rows[rowIdx].Cells["Average Grade"].Value = learner.CourseAssessmentMark.GetAvgGrade();
            }
            dgvDisplayInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn9DisplayLecturerDetails_Click(object sender, EventArgs e)
        {
            dgvDisplayInfo.Rows.Clear();
            dgvDisplayInfo.Columns.Clear();

            dgvDisplayInfo.Columns.Add("ID", "ID");
            dgvDisplayInfo.Columns.Add("Name", "Name");
            dgvDisplayInfo.Columns.Add("Position", "Position");
            dgvDisplayInfo.Columns.Add("Institution", "Institution");
            dgvDisplayInfo.Columns.Add("Department", "Department");
            dgvDisplayInfo.Columns.Add("Course", "Course");
            dgvDisplayInfo.Columns.Add("Salary", "Salary");

            foreach (Lecturer lecturer in lecturers)
            {
                int rowIdx = dgvDisplayInfo.Rows.Add();
                dgvDisplayInfo.Rows[rowIdx].Cells["ID"].Value = lecturer.Id;
                dgvDisplayInfo.Rows[rowIdx].Cells["Name"].Value = lecturer.FirstName + " " + lecturer.LastName;
                dgvDisplayInfo.Rows[rowIdx].Cells["Position"].Value = lecturer.Position;
                dgvDisplayInfo.Rows[rowIdx].Cells["Institution"].Value = lecturer.Course.Department.Institution.Name;
                dgvDisplayInfo.Rows[rowIdx].Cells["Department"].Value = lecturer.Course.Department.DepartmentName;
                dgvDisplayInfo.Rows[rowIdx].Cells["Course"].Value = lecturer.Course.Code + " " + lecturer.Course.Name;
                dgvDisplayInfo.Rows[rowIdx].Cells["Salary"].Value = (int)lecturer.Salary;
            }
            dgvDisplayInfo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }
        private void AddLearner(Learner learner)
        {
            learners.Add(learner);
            DataHandler.SaveLearnersToFile("learners.txt", learners, courses);
        }
    }
}
