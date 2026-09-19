using System.Linq.Expressions;

namespace Project1Gideon
{
    public partial class Form1 : Form
    {
        private List<Institution> institutions;
        private List<Department> departments;
        private List<Course> courses;
        private List<Learner> learners;
        private List<Lecturer> lecturers;
        //The ? after Lecturer means the variable is allowed to be null
        private Lecturer? selectedLecturer;
        public Form1()
        {
            InitializeComponent();

            institutions = Seeder.SeedInstitutions();
            departments = Seeder.SeedDepartments();
            courses = Seeder.SeedCourses();

            foreach (Course course in courses)
            {
                cmbCourse.Items.Add(course.Code + " " + course.Name);
            }

            cmbPosition.Items.Add(EPosition.Lecturer);
            cmbPosition.Items.Add(EPosition.Senior_Lecturer);
            cmbPosition.Items.Add(EPosition.Principal_Lecturer);
            cmbPosition.Items.Add(EPosition.Assosciate_Professor);
            cmbPosition.Items.Add(EPosition.Professor);

            learners = new List<Learner>();
            lecturers = new List<Lecturer>();

            //Calls readfile methods
            DataHandler.ReadLearnersFromFile("learners.txt", learners, courses);
            DataHandler.ReadLecturersFromFile("lecturers.txt", lecturers, courses);
        }
        //Hides DataGridView and displays add learner inputs
        private void ShowLearnerInputs()
        {
            lblDetails.Text = "Add Learner:";
            dgvDisplayInfo.Visible = false;
            lblFirstName.Visible = true;
            lblLastName.Visible = true;
            lblCourse.Visible = true;
            lblMark1.Visible = true;
            lblMark2.Visible = true;
            lblMark3.Visible = true;
            lblMark4.Visible = true;
            lblMark5.Visible = true;
            tbxFirstName.Visible = true;
            tbxLastName.Visible = true;
            tbxMark1.Visible = true;
            tbxMark2.Visible = true;
            tbxMark3.Visible = true;
            tbxMark4.Visible = true;
            tbxMark5.Visible = true;
            btnSaveLearner.Visible = true;
            cmbCourse.Visible = true;
        }
        //Hides Learner inputs
        private void HideLearnerInputs()
        {
            lblFirstName.Visible = false;
            lblLastName.Visible = false;
            lblCourse.Visible = false;
            lblMark1.Visible = false;
            lblMark2.Visible = false;
            lblMark3.Visible = false;
            lblMark4.Visible = false;
            lblMark5.Visible = false;
            tbxFirstName.Visible = false;
            tbxLastName.Visible = false;
            tbxMark1.Visible = false;
            tbxMark2.Visible = false;
            tbxMark3.Visible = false;
            tbxMark4.Visible = false;
            tbxMark5.Visible = false;
            btnSaveLearner.Visible = false;
            cmbCourse.Visible = false;
        }
        //Clears add learner inputs so another learner can be added
        private void ClearAddLearner()
        {
            tbxFirstName.Clear();
            tbxLastName.Clear();
            cmbCourse.SelectedIndex = -1;
            tbxMark1.Clear();
            tbxMark2.Clear();
            tbxMark3.Clear();
            tbxMark4.Clear();
            tbxMark5.Clear();
        }
        //Displays Lecturer inputs and hides DGV
        private void ShowLecturerInputs()
        {
            //I deleted cleardgv and now have an error
            dgvDisplayInfo.Visible = false;
            lblDetails.Text = "Add Lecturer:";
            lblFirstName.Visible = true;
            tbxFirstName.Visible = true;
            lblLastName.Visible = true;
            tbxLastName.Visible = true;
            lblCourse.Visible = true;
            cmbCourse.Visible = true;
            lblPosition.Visible = true;
            cmbPosition.Visible = true;
            btnSaveLecturer.Visible = true;
        }
        //Hides Lecturer inputs
        private void HideLecturerInputs()
        {
            lblFirstName.Visible = false;
            tbxFirstName.Visible = false;
            lblLastName.Visible = false;
            tbxLastName.Visible = false;
            lblCourse.Visible = false;
            cmbCourse.Visible = false;
            lblPosition.Visible = false;
            cmbPosition.Visible = false;
            btnSaveLecturer.Visible = false;
        }
        private void ClearAddLecturer()
        {
            tbxFirstName.Clear();
            tbxLastName.Clear();
            cmbCourse.SelectedIndex = -1;
            cmbPosition.SelectedIndex = -1;
        }
        private void ShowRemoveLecturer()
        {
            dgvDisplayInfo.Visible = false;
            lblDetails.Text = "Remove Lecturer:";
            lblLecturerID.Visible = true;
            tbxLecturerID.Visible = true;
            btnRemove.Visible = true;
            lblLecturerName.Visible = true;
            btnSearch.Visible = true;
        }
        private void HideRemoveLecturer()
        {
            lblLecturerID.Visible = false;
            tbxLecturerID.Visible = false;
            btnRemove.Visible = false;
            lblLecturerName.Visible = false;
            btnSearch.Visible = false;
            btnYes.Visible = false;
            btnCancel.Visible = false;
            lblAreYouSure.Visible = false;
        }
        //Clears DataGridView
        private void ClearDgv()
        {
            dgvDisplayInfo.Rows.Clear();
            dgvDisplayInfo.Columns.Clear();
        }

        //Checks if Id is avaliable 
        private int CheckLecturerID()
        {
            int id = 1;
            bool idExists = true;

            while (idExists)
            {
                idExists = false;

                foreach (Lecturer existingLecturer in lecturers)
                {                         //== is equal to
                    if (existingLecturer.Id == id)
                    {
                        id++;
                        idExists = true;
                        break;
                    }
                }
            }
            return id;
        }
        private void btn1DisplayCourseDetails_Click(object sender, EventArgs e)
        {
            ClearDgv();
            dgvDisplayInfo.Visible = true;
            lblDetails.Text = "Display: Course Details";
            HideLearnerInputs();
            HideLecturerInputs();
            HideRemoveLecturer();

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
            ClearDgv();
            dgvDisplayInfo.Visible = true;
            lblDetails.Text = "Display: All Marks";
            HideLearnerInputs();
            HideLecturerInputs();
            HideRemoveLecturer();

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
            ClearDgv();
            dgvDisplayInfo.Visible = true;
            lblDetails.Text = "Display: All Grades";
            HideLearnerInputs();
            HideLecturerInputs();
            HideRemoveLecturer();

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
            ClearDgv();
            dgvDisplayInfo.Visible = true;
            lblDetails.Text = "Display: Highest Marks";
            HideLearnerInputs();
            HideLecturerInputs();
            HideRemoveLecturer();

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
            ClearDgv();
            dgvDisplayInfo.Visible = true;
            lblDetails.Text = "Display: Lowest Marks";
            HideLearnerInputs();
            HideLecturerInputs();
            HideRemoveLecturer();

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
            ClearDgv();
            dgvDisplayInfo.Visible = true;
            lblDetails.Text = "Display: Fail Marks";
            HideLearnerInputs();
            HideLecturerInputs();
            HideRemoveLecturer();

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
            ClearDgv();
            dgvDisplayInfo.Visible = true;
            lblDetails.Text = "Display: Average Marks";
            HideLearnerInputs();
            HideLecturerInputs();
            HideRemoveLecturer();

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
            ClearDgv();
            dgvDisplayInfo.Visible = true;
            lblDetails.Text = "Display: Average Grades";
            HideLearnerInputs();
            HideLecturerInputs();
            HideRemoveLecturer();

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
            ClearDgv();
            dgvDisplayInfo.Visible = true;
            lblDetails.Text = "Display: Lecturer Details";
            HideLearnerInputs();
            HideLecturerInputs();
            HideRemoveLecturer();

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

        private void btn10AddALearner_Click(object sender, EventArgs e)
        {
            HideLecturerInputs();
            ShowLearnerInputs();
            HideRemoveLecturer();
        }

        private void btn11AddALecturer_Click(object sender, EventArgs e)
        {
            HideLearnerInputs();
            ShowLecturerInputs();
            HideRemoveLecturer();
        }

        private void AddLearner(Learner learner)
        {
            try
            {
                learners.Add(learner);
                DataHandler.SaveLearnersToFile("learners.txt", learners, courses);
            }
            catch
            {
                MessageBox.Show("There was an error adding the learner.");
            }
        }

        private void btnSaveLearner_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = tbxFirstName.Text;
                string lastName = tbxLastName.Text;
                int courseNum = cmbCourse.SelectedIndex;
                Course course = courses[courseNum];

                int mark1 = Convert.ToInt32(tbxMark1.Text);
                int mark2 = Convert.ToInt32(tbxMark2.Text);
                int mark3 = Convert.ToInt32(tbxMark3.Text);
                int mark4 = Convert.ToInt32(tbxMark4.Text);
                int mark5 = Convert.ToInt32(tbxMark5.Text);

                List<int> marks = new List<int>()
                { mark1, mark2, mark3, mark4, mark5 };

                CourseAssessmentMark assessmentMark = new CourseAssessmentMark(course, marks);

                int id = learners.Count + 1;

                Learner learner = new Learner(id, firstName, lastName, assessmentMark);

                AddLearner(learner);
                MessageBox.Show("Learner Saved");
                ClearAddLearner();
            }
            catch
            {
                MessageBox.Show("There was an error saving the learner. Please check the information you entered is correct.");
            }
        }

        private void AddLecturer(Lecturer lecturer)
        {
            try
            {
                lecturers.Add(lecturer);
                DataHandler.SaveLecturersToFile("lecturers.txt", lecturers, courses);
            }
            catch
            {
                MessageBox.Show("There was an error adding the lecturer.");
            }
        }

        private void btnSaveLecturer_Click(object sender, EventArgs e)
        {
            try
            {
                String firstName = tbxFirstName.Text;
                String lastName = tbxLastName.Text;
                int courseNum = cmbCourse.SelectedIndex;
                Course course = courses[courseNum];
                int positionNum = cmbPosition.SelectedIndex;
                EPosition position = (EPosition)positionNum;

                ESalary salary;

                switch (position)
                {
                    case EPosition.Lecturer:
                        salary = ESalary.Lecturer_Salary;
                        break;

                    case EPosition.Senior_Lecturer:
                        salary = ESalary.Senior_Lecturer_Salary;
                        break;

                    case EPosition.Principal_Lecturer:
                        salary = ESalary.Principal_Lecturer_Salary;
                        break;

                    case EPosition.Assosciate_Professor:
                        salary = ESalary.Associate_Professor_Salary;
                        break;

                    case EPosition.Professor:
                        salary = ESalary.Professor_Salary;
                        break;
                    default:
                        salary = ESalary.Lecturer_Salary;
                        MessageBox.Show("Your Lecturer has been givin a Lecturers Salary.\nPossible issue with Position assignment");
                        break;
                }

                int id = CheckLecturerID();

                Lecturer lecturer = new Lecturer(id, firstName, lastName, position, salary, course);

                AddLecturer(lecturer);
                MessageBox.Show("Lecturer Saved");
                ClearAddLecturer();
            }
            catch
            {
                MessageBox.Show("There was an error saving the lecturer. Please check the information you entered is correct.");
            }
        }

        private void btn12RemoveALecturer_Click(object sender, EventArgs e)
        {
            HideLearnerInputs();
            HideLecturerInputs();
            ShowRemoveLecturer();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lblAreYouSure.Visible = true;
            btnYes.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbxLecturerID.Text);
                bool found = false;
                foreach (Lecturer lecturer in lecturers)
                {
                    if (lecturer.Id == id)
                    {
                        selectedLecturer = lecturer;
                        lblLecturerName.Text = "Lecturer: " + lecturer.FirstName + " " + lecturer.LastName;
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    selectedLecturer = null;
                    lblLecturerName.Text = "The ID you have entered is not registered in our system";
                }
            }
            catch
            {
                MessageBox.Show("Please enter a valid ID.");
            }
        }
        private void btnYes_Click(object sender, EventArgs e)
        {
            try
            {
                lecturers.Remove(selectedLecturer);
                if (selectedLecturer != null)
                {
                    MessageBox.Show("The lecturer you selected was removed");
                }
                else
                {
                    MessageBox.Show("A lecturer was not selected");
                }
                DataHandler.SaveLecturersToFile("lecturers.txt", lecturers, courses);
                lblAreYouSure.Visible = false;
                btnYes.Visible = false;
                btnCancel.Visible = false;
                lblLecturerName.Text = "Lecturer:";
                tbxLecturerID.Clear();
            }
            catch
            {
                MessageBox.Show("The was an error removing the lecturer.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblAreYouSure.Visible = false;
            btnYes.Visible = false;
            btnCancel.Visible = false;
        }

        private void lblLecturerName_Click(object sender, EventArgs e)
        {
            if (selectedLecturer != null)
            {
                MessageBox.Show(selectedLecturer.LecturerInfo());
            }
        }
    }
}
