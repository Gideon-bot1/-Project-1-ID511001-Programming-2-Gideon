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
            lblDetails.Location = new Point(215, 25);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(98, 37);
            lblDetails.TabIndex = 16;
            lblDetails.Text = "Details";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(204, 205, 203);
            ClientSize = new Size(1776, 1006);
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
    }
}
