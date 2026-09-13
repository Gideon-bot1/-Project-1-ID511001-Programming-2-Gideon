namespace Project1Gideon
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1DisplayCourseDetails = new Button();
            btn2DisplayAllMarks = new Button();
            btn3DisplayAllGrades = new Button();
            btn4DisplayHighestMarks = new Button();
            btn5DisplayLowestMarks = new Button();
            btn6DisplayFailMarks = new Button();
            btn7DisplayAvgMarks = new Button();
            btn8DisplayAvgGrades = new Button();
            btn9DisplayLecturerDetails = new Button();
            btn10AddALearner = new Button();
            btn11AddALecturer = new Button();
            btn12ReomoveALecturer = new Button();
            btnCalculations = new Button();
            btnExit = new Button();
            dgvDisplayInfo = new DataGridView();
            lblDetails = new Label();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblCourse = new Label();
            lblMark1 = new Label();
            lblMark2 = new Label();
            lblMark3 = new Label();
            lblMark4 = new Label();
            lblMark5 = new Label();
            btnSaveLearner = new Button();
            tbxFirstName = new TextBox();
            tbxLastName = new TextBox();
            tbxMark1 = new TextBox();
            tbxMark2 = new TextBox();
            tbxMark3 = new TextBox();
            tbxMark4 = new TextBox();
            tbxMark5 = new TextBox();
            cmbCourse = new ComboBox();
            lblPosition = new Label();
            cmbPosition = new ComboBox();
            btnSaveLecturer = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDisplayInfo).BeginInit();
            SuspendLayout();
            // 
            // btn1DisplayCourseDetails
            // 
            btn1DisplayCourseDetails.BackColor = Color.DarkGray;
            btn1DisplayCourseDetails.Font = new Font("Segoe UI", 11F);
            btn1DisplayCourseDetails.Location = new Point(12, 12);
            btn1DisplayCourseDetails.Name = "btn1DisplayCourseDetails";
            btn1DisplayCourseDetails.Size = new Size(203, 50);
            btn1DisplayCourseDetails.TabIndex = 0;
            btn1DisplayCourseDetails.Text = "1. Display Course Details";
            btn1DisplayCourseDetails.TextAlign = ContentAlignment.MiddleLeft;
            btn1DisplayCourseDetails.UseVisualStyleBackColor = false;
            btn1DisplayCourseDetails.Click += btn1DisplayCourseDetails_Click;
            // 
            // btn2DisplayAllMarks
            // 
            btn2DisplayAllMarks.BackColor = Color.DarkGray;
            btn2DisplayAllMarks.Font = new Font("Segoe UI", 11F);
            btn2DisplayAllMarks.Location = new Point(12, 68);
            btn2DisplayAllMarks.Name = "btn2DisplayAllMarks";
            btn2DisplayAllMarks.Size = new Size(203, 50);
            btn2DisplayAllMarks.TabIndex = 1;
            btn2DisplayAllMarks.Text = "2. Display All Marks";
            btn2DisplayAllMarks.TextAlign = ContentAlignment.MiddleLeft;
            btn2DisplayAllMarks.UseVisualStyleBackColor = false;
            btn2DisplayAllMarks.Click += btn2DisplayAllMarks_Click;
            // 
            // btn3DisplayAllGrades
            // 
            btn3DisplayAllGrades.BackColor = Color.DarkGray;
            btn3DisplayAllGrades.FlatAppearance.BorderColor = Color.Black;
            btn3DisplayAllGrades.Font = new Font("Segoe UI", 11F);
            btn3DisplayAllGrades.Location = new Point(12, 124);
            btn3DisplayAllGrades.Name = "btn3DisplayAllGrades";
            btn3DisplayAllGrades.Size = new Size(203, 50);
            btn3DisplayAllGrades.TabIndex = 2;
            btn3DisplayAllGrades.Text = "3. Display All Grades";
            btn3DisplayAllGrades.TextAlign = ContentAlignment.MiddleLeft;
            btn3DisplayAllGrades.UseVisualStyleBackColor = false;
            btn3DisplayAllGrades.Click += btn3DisplayAllGrades_Click;
            // 
            // btn4DisplayHighestMarks
            // 
            btn4DisplayHighestMarks.BackColor = Color.DarkGray;
            btn4DisplayHighestMarks.Font = new Font("Segoe UI", 11F);
            btn4DisplayHighestMarks.Location = new Point(12, 180);
            btn4DisplayHighestMarks.Name = "btn4DisplayHighestMarks";
            btn4DisplayHighestMarks.Size = new Size(203, 50);
            btn4DisplayHighestMarks.TabIndex = 3;
            btn4DisplayHighestMarks.Text = "4. Display Highest Marks";
            btn4DisplayHighestMarks.TextAlign = ContentAlignment.MiddleLeft;
            btn4DisplayHighestMarks.UseVisualStyleBackColor = false;
            btn4DisplayHighestMarks.Click += btn4DisplayHighestMarks_Click;
            // 
            // btn5DisplayLowestMarks
            // 
            btn5DisplayLowestMarks.BackColor = Color.DarkGray;
            btn5DisplayLowestMarks.Font = new Font("Segoe UI", 11F);
            btn5DisplayLowestMarks.Location = new Point(12, 236);
            btn5DisplayLowestMarks.Name = "btn5DisplayLowestMarks";
            btn5DisplayLowestMarks.Size = new Size(203, 50);
            btn5DisplayLowestMarks.TabIndex = 4;
            btn5DisplayLowestMarks.Text = "5. Display Lowest Marks";
            btn5DisplayLowestMarks.TextAlign = ContentAlignment.MiddleLeft;
            btn5DisplayLowestMarks.UseVisualStyleBackColor = false;
            btn5DisplayLowestMarks.Click += btn5DisplayLowestMarks_Click;
            // 
            // btn6DisplayFailMarks
            // 
            btn6DisplayFailMarks.BackColor = Color.DarkGray;
            btn6DisplayFailMarks.Font = new Font("Segoe UI", 11F);
            btn6DisplayFailMarks.Location = new Point(12, 292);
            btn6DisplayFailMarks.Name = "btn6DisplayFailMarks";
            btn6DisplayFailMarks.Size = new Size(203, 50);
            btn6DisplayFailMarks.TabIndex = 5;
            btn6DisplayFailMarks.Text = "6. Display Fail Marks";
            btn6DisplayFailMarks.TextAlign = ContentAlignment.MiddleLeft;
            btn6DisplayFailMarks.UseVisualStyleBackColor = false;
            btn6DisplayFailMarks.Click += btn6DisplayFailMarks_Click;
            // 
            // btn7DisplayAvgMarks
            // 
            btn7DisplayAvgMarks.BackColor = Color.DarkGray;
            btn7DisplayAvgMarks.Font = new Font("Segoe UI", 11F);
            btn7DisplayAvgMarks.Location = new Point(12, 348);
            btn7DisplayAvgMarks.Name = "btn7DisplayAvgMarks";
            btn7DisplayAvgMarks.Size = new Size(203, 50);
            btn7DisplayAvgMarks.TabIndex = 6;
            btn7DisplayAvgMarks.Text = "7. Display Average Marks";
            btn7DisplayAvgMarks.TextAlign = ContentAlignment.MiddleLeft;
            btn7DisplayAvgMarks.UseVisualStyleBackColor = false;
            btn7DisplayAvgMarks.Click += btn7DisplayAvgMarks_Click;
            // 
            // btn8DisplayAvgGrades
            // 
            btn8DisplayAvgGrades.BackColor = Color.DarkGray;
            btn8DisplayAvgGrades.Font = new Font("Segoe UI", 11F);
            btn8DisplayAvgGrades.Location = new Point(12, 404);
            btn8DisplayAvgGrades.Name = "btn8DisplayAvgGrades";
            btn8DisplayAvgGrades.Size = new Size(203, 50);
            btn8DisplayAvgGrades.TabIndex = 7;
            btn8DisplayAvgGrades.Text = "8. Display Average Grades";
            btn8DisplayAvgGrades.TextAlign = ContentAlignment.MiddleLeft;
            btn8DisplayAvgGrades.UseVisualStyleBackColor = false;
            btn8DisplayAvgGrades.Click += btn8DisplayAvgGrades_Click;
            // 
            // btn9DisplayLecturerDetails
            // 
            btn9DisplayLecturerDetails.BackColor = Color.DarkGray;
            btn9DisplayLecturerDetails.Font = new Font("Segoe UI", 11F);
            btn9DisplayLecturerDetails.Location = new Point(12, 460);
            btn9DisplayLecturerDetails.Name = "btn9DisplayLecturerDetails";
            btn9DisplayLecturerDetails.Size = new Size(203, 50);
            btn9DisplayLecturerDetails.TabIndex = 8;
            btn9DisplayLecturerDetails.Text = "9. Display Lecturer Details";
            btn9DisplayLecturerDetails.TextAlign = ContentAlignment.MiddleLeft;
            btn9DisplayLecturerDetails.UseVisualStyleBackColor = false;
            btn9DisplayLecturerDetails.Click += btn9DisplayLecturerDetails_Click;
            // 
            // btn10AddALearner
            // 
            btn10AddALearner.BackColor = Color.DarkGray;
            btn10AddALearner.Font = new Font("Segoe UI", 11F);
            btn10AddALearner.Location = new Point(12, 516);
            btn10AddALearner.Name = "btn10AddALearner";
            btn10AddALearner.Size = new Size(203, 50);
            btn10AddALearner.TabIndex = 9;
            btn10AddALearner.Text = "10. Add a Learner";
            btn10AddALearner.TextAlign = ContentAlignment.MiddleLeft;
            btn10AddALearner.UseVisualStyleBackColor = false;
            btn10AddALearner.Click += btn10AddALearner_Click;
            // 
            // btn11AddALecturer
            // 
            btn11AddALecturer.BackColor = Color.DarkGray;
            btn11AddALecturer.Font = new Font("Segoe UI", 11F);
            btn11AddALecturer.Location = new Point(12, 574);
            btn11AddALecturer.Name = "btn11AddALecturer";
            btn11AddALecturer.Size = new Size(203, 50);
            btn11AddALecturer.TabIndex = 10;
            btn11AddALecturer.Text = "11. Add a Lecturer";
            btn11AddALecturer.TextAlign = ContentAlignment.MiddleLeft;
            btn11AddALecturer.UseVisualStyleBackColor = false;
            btn11AddALecturer.Click += btn11AddALecturer_Click;
            // 
            // btn12ReomoveALecturer
            // 
            btn12ReomoveALecturer.BackColor = Color.DarkGray;
            btn12ReomoveALecturer.Font = new Font("Segoe UI", 11F);
            btn12ReomoveALecturer.Location = new Point(12, 630);
            btn12ReomoveALecturer.Name = "btn12ReomoveALecturer";
            btn12ReomoveALecturer.Size = new Size(203, 50);
            btn12ReomoveALecturer.TabIndex = 11;
            btn12ReomoveALecturer.Text = "12. Remove a Lecturer";
            btn12ReomoveALecturer.TextAlign = ContentAlignment.MiddleLeft;
            btn12ReomoveALecturer.UseVisualStyleBackColor = false;
            // 
            // btnCalculations
            // 
            btnCalculations.BackColor = Color.DarkGray;
            btnCalculations.Font = new Font("Segoe UI", 11F);
            btnCalculations.Location = new Point(12, 686);
            btnCalculations.Name = "btnCalculations";
            btnCalculations.Size = new Size(203, 50);
            btnCalculations.TabIndex = 12;
            btnCalculations.Text = "Calculations";
            btnCalculations.TextAlign = ContentAlignment.MiddleLeft;
            btnCalculations.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DarkGray;
            btnExit.Font = new Font("Segoe UI", 11F);
            btnExit.Location = new Point(12, 742);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(203, 50);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.UseVisualStyleBackColor = false;
            // 
            // dgvDisplayInfo
            // 
            dgvDisplayInfo.BackgroundColor = Color.FromArgb(245, 246, 245);
            dgvDisplayInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDisplayInfo.Location = new Point(221, 68);
            dgvDisplayInfo.Name = "dgvDisplayInfo";
            dgvDisplayInfo.Size = new Size(1543, 724);
            dgvDisplayInfo.TabIndex = 14;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Segoe UI", 20F);
            lblDetails.ImageAlign = ContentAlignment.MiddleLeft;
            lblDetails.Location = new Point(232, 25);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(104, 37);
            lblDetails.TabIndex = 16;
            lblDetails.Text = "Details:";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.BackColor = Color.FromArgb(204, 205, 203);
            lblFirstName.Font = new Font("Segoe UI", 18F);
            lblFirstName.ImageAlign = ContentAlignment.MiddleLeft;
            lblFirstName.Location = new Point(232, 86);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(134, 32);
            lblFirstName.TabIndex = 17;
            lblFirstName.Text = "First Name:";
            lblFirstName.Visible = false;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.BackColor = Color.FromArgb(204, 205, 203);
            lblLastName.Font = new Font("Segoe UI", 18F);
            lblLastName.ImageAlign = ContentAlignment.MiddleLeft;
            lblLastName.Location = new Point(232, 142);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(131, 32);
            lblLastName.TabIndex = 18;
            lblLastName.Text = "Last Name:";
            lblLastName.Visible = false;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.BackColor = Color.FromArgb(204, 205, 203);
            lblCourse.Font = new Font("Segoe UI", 18F);
            lblCourse.ImageAlign = ContentAlignment.MiddleLeft;
            lblCourse.Location = new Point(232, 198);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(93, 32);
            lblCourse.TabIndex = 19;
            lblCourse.Text = "Course:";
            lblCourse.Visible = false;
            // 
            // lblMark1
            // 
            lblMark1.AutoSize = true;
            lblMark1.BackColor = Color.FromArgb(204, 205, 203);
            lblMark1.Font = new Font("Segoe UI", 18F);
            lblMark1.ImageAlign = ContentAlignment.MiddleLeft;
            lblMark1.Location = new Point(232, 254);
            lblMark1.Name = "lblMark1";
            lblMark1.Size = new Size(246, 32);
            lblMark1.TabIndex = 20;
            lblMark1.Text = "Assesment Mark One:";
            lblMark1.Visible = false;
            // 
            // lblMark2
            // 
            lblMark2.AutoSize = true;
            lblMark2.BackColor = Color.FromArgb(204, 205, 203);
            lblMark2.Font = new Font("Segoe UI", 18F);
            lblMark2.ImageAlign = ContentAlignment.MiddleLeft;
            lblMark2.Location = new Point(232, 310);
            lblMark2.Name = "lblMark2";
            lblMark2.Size = new Size(244, 32);
            lblMark2.TabIndex = 21;
            lblMark2.Text = "Assesment Mark Two:";
            lblMark2.Visible = false;
            // 
            // lblMark3
            // 
            lblMark3.AutoSize = true;
            lblMark3.BackColor = Color.FromArgb(204, 205, 203);
            lblMark3.Font = new Font("Segoe UI", 18F);
            lblMark3.ImageAlign = ContentAlignment.MiddleLeft;
            lblMark3.Location = new Point(232, 366);
            lblMark3.Name = "lblMark3";
            lblMark3.Size = new Size(262, 32);
            lblMark3.TabIndex = 22;
            lblMark3.Text = "Assesment Mark Three:";
            lblMark3.Visible = false;
            // 
            // lblMark4
            // 
            lblMark4.AutoSize = true;
            lblMark4.BackColor = Color.FromArgb(204, 205, 203);
            lblMark4.Font = new Font("Segoe UI", 18F);
            lblMark4.ImageAlign = ContentAlignment.MiddleLeft;
            lblMark4.Location = new Point(232, 422);
            lblMark4.Name = "lblMark4";
            lblMark4.Size = new Size(249, 32);
            lblMark4.TabIndex = 23;
            lblMark4.Text = "Assesment Mark Four:";
            lblMark4.Visible = false;
            // 
            // lblMark5
            // 
            lblMark5.AutoSize = true;
            lblMark5.BackColor = Color.FromArgb(204, 205, 203);
            lblMark5.Font = new Font("Segoe UI", 18F);
            lblMark5.ImageAlign = ContentAlignment.MiddleLeft;
            lblMark5.Location = new Point(232, 478);
            lblMark5.Name = "lblMark5";
            lblMark5.Size = new Size(244, 32);
            lblMark5.TabIndex = 24;
            lblMark5.Text = "Assesment Mark Five:";
            lblMark5.Visible = false;
            // 
            // btnSaveLearner
            // 
            btnSaveLearner.BackColor = Color.DarkGray;
            btnSaveLearner.Cursor = Cursors.Hand;
            btnSaveLearner.FlatAppearance.BorderColor = Color.Black;
            btnSaveLearner.Font = new Font("Segoe UI", 11F);
            btnSaveLearner.Location = new Point(232, 530);
            btnSaveLearner.Name = "btnSaveLearner";
            btnSaveLearner.Size = new Size(101, 36);
            btnSaveLearner.TabIndex = 25;
            btnSaveLearner.Text = "Save";
            btnSaveLearner.UseVisualStyleBackColor = false;
            btnSaveLearner.Visible = false;
            btnSaveLearner.Click += btnSaveLearner_Click;
            // 
            // tbxFirstName
            // 
            tbxFirstName.Cursor = Cursors.IBeam;
            tbxFirstName.Location = new Point(538, 95);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(230, 23);
            tbxFirstName.TabIndex = 26;
            tbxFirstName.Visible = false;
            // 
            // tbxLastName
            // 
            tbxLastName.Cursor = Cursors.IBeam;
            tbxLastName.Location = new Point(538, 151);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(230, 23);
            tbxLastName.TabIndex = 27;
            tbxLastName.Visible = false;
            // 
            // tbxMark1
            // 
            tbxMark1.Cursor = Cursors.IBeam;
            tbxMark1.Location = new Point(538, 263);
            tbxMark1.Name = "tbxMark1";
            tbxMark1.Size = new Size(98, 23);
            tbxMark1.TabIndex = 28;
            tbxMark1.Visible = false;
            // 
            // tbxMark2
            // 
            tbxMark2.Cursor = Cursors.IBeam;
            tbxMark2.Location = new Point(538, 319);
            tbxMark2.Name = "tbxMark2";
            tbxMark2.Size = new Size(98, 23);
            tbxMark2.TabIndex = 29;
            tbxMark2.Visible = false;
            // 
            // tbxMark3
            // 
            tbxMark3.Cursor = Cursors.IBeam;
            tbxMark3.Location = new Point(538, 377);
            tbxMark3.Name = "tbxMark3";
            tbxMark3.Size = new Size(98, 23);
            tbxMark3.TabIndex = 30;
            tbxMark3.Visible = false;
            // 
            // tbxMark4
            // 
            tbxMark4.Cursor = Cursors.IBeam;
            tbxMark4.Location = new Point(538, 433);
            tbxMark4.Name = "tbxMark4";
            tbxMark4.Size = new Size(98, 23);
            tbxMark4.TabIndex = 31;
            tbxMark4.Visible = false;
            // 
            // tbxMark5
            // 
            tbxMark5.Cursor = Cursors.IBeam;
            tbxMark5.Location = new Point(538, 487);
            tbxMark5.Name = "tbxMark5";
            tbxMark5.Size = new Size(98, 23);
            tbxMark5.TabIndex = 32;
            tbxMark5.Visible = false;
            // 
            // cmbCourse
            // 
            cmbCourse.FormattingEnabled = true;
            cmbCourse.Location = new Point(538, 207);
            cmbCourse.MaxDropDownItems = 3;
            cmbCourse.Name = "cmbCourse";
            cmbCourse.Size = new Size(230, 23);
            cmbCourse.TabIndex = 33;
            cmbCourse.Visible = false;
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.BackColor = Color.FromArgb(204, 205, 203);
            lblPosition.Font = new Font("Segoe UI", 18F);
            lblPosition.ImageAlign = ContentAlignment.MiddleLeft;
            lblPosition.Location = new Point(232, 254);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(103, 32);
            lblPosition.TabIndex = 34;
            lblPosition.Text = "Position:";
            lblPosition.Visible = false;
            // 
            // cmbPosition
            // 
            cmbPosition.Cursor = Cursors.Hand;
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(538, 265);
            cmbPosition.MaxDropDownItems = 3;
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(230, 23);
            cmbPosition.TabIndex = 35;
            cmbPosition.Visible = false;
            // 
            // btnSaveLecturer
            // 
            btnSaveLecturer.BackColor = Color.DarkGray;
            btnSaveLecturer.Cursor = Cursors.Hand;
            btnSaveLecturer.FlatAppearance.BorderColor = Color.Black;
            btnSaveLecturer.Font = new Font("Segoe UI", 11F);
            btnSaveLecturer.Location = new Point(339, 530);
            btnSaveLecturer.Name = "btnSaveLecturer";
            btnSaveLecturer.Size = new Size(101, 36);
            btnSaveLecturer.TabIndex = 36;
            btnSaveLecturer.Text = "Save";
            btnSaveLecturer.UseVisualStyleBackColor = false;
            btnSaveLecturer.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(204, 205, 203);
            ClientSize = new Size(1776, 1006);
            Controls.Add(btnSaveLecturer);
            Controls.Add(cmbPosition);
            Controls.Add(lblPosition);
            Controls.Add(cmbCourse);
            Controls.Add(tbxMark5);
            Controls.Add(tbxMark4);
            Controls.Add(tbxMark3);
            Controls.Add(tbxMark2);
            Controls.Add(tbxMark1);
            Controls.Add(tbxLastName);
            Controls.Add(tbxFirstName);
            Controls.Add(btnSaveLearner);
            Controls.Add(lblMark5);
            Controls.Add(lblMark4);
            Controls.Add(lblMark3);
            Controls.Add(lblMark2);
            Controls.Add(lblMark1);
            Controls.Add(lblCourse);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblDetails);
            Controls.Add(dgvDisplayInfo);
            Controls.Add(btnExit);
            Controls.Add(btnCalculations);
            Controls.Add(btn12ReomoveALecturer);
            Controls.Add(btn11AddALecturer);
            Controls.Add(btn10AddALearner);
            Controls.Add(btn9DisplayLecturerDetails);
            Controls.Add(btn8DisplayAvgGrades);
            Controls.Add(btn7DisplayAvgMarks);
            Controls.Add(btn6DisplayFailMarks);
            Controls.Add(btn5DisplayLowestMarks);
            Controls.Add(btn4DisplayHighestMarks);
            Controls.Add(btn3DisplayAllGrades);
            Controls.Add(btn2DisplayAllMarks);
            Controls.Add(btn1DisplayCourseDetails);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvDisplayInfo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1DisplayCourseDetails;
        private Button btn2DisplayAllMarks;
        private Button btn3DisplayAllGrades;
        private Button btn4DisplayHighestMarks;
        private Button btn5DisplayLowestMarks;
        private Button btn6DisplayFailMarks;
        private Button btn7DisplayAvgMarks;
        private Button btn8DisplayAvgGrades;
        private Button btn9DisplayLecturerDetails;
        private Button btn10AddALearner;
        private Button btn11AddALecturer;
        private Button btn12ReomoveALecturer;
        private Button btnCalculations;
        private Button btnExit;
        private DataGridView dgvDisplayInfo;
        private Label lblDetails;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblCourse;
        private Label lblMark1;
        private Label lblMark2;
        private Label lblMark3;
        private Label lblMark4;
        private Label lblMark5;
        private Button btnSaveLearner;
        private TextBox tbxFirstName;
        private TextBox tbxLastName;
        private TextBox tbxMark1;
        private TextBox tbxMark2;
        private TextBox tbxMark3;
        private TextBox tbxMark4;
        private TextBox tbxMark5;
        private ComboBox cmbCourse;
        private Label lblPosition;
        private ComboBox cmbPosition;
        private Button btnSaveLecturer;
    }
}
