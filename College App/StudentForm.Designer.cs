namespace College_App
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgv_courses = new DataGridView();
            txt_course = new TextBox();
            button_signup = new Button();
            button_checkBalance = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.MenuBar;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(767, 60);
            label1.TabIndex = 5;
            label1.Text = "Welcome dear student";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgv_courses
            // 
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_courses.Location = new Point(224, 128);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.RowHeadersWidth = 62;
            dgv_courses.Size = new Size(360, 225);
            dgv_courses.TabIndex = 6;
            // 
            // txt_course
            // 
            txt_course.Location = new Point(224, 86);
            txt_course.Name = "txt_course";
            txt_course.Size = new Size(360, 31);
            txt_course.TabIndex = 7;
            // 
            // button_signup
            // 
            button_signup.Font = new Font("Segoe UI", 12F);
            button_signup.Location = new Point(472, 371);
            button_signup.Name = "button_signup";
            button_signup.Size = new Size(112, 63);
            button_signup.TabIndex = 8;
            button_signup.Text = "Signup";
            button_signup.UseVisualStyleBackColor = true;
            // 
            // button_checkBalance
            // 
            button_checkBalance.Font = new Font("Segoe UI", 12F);
            button_checkBalance.Location = new Point(224, 371);
            button_checkBalance.Name = "button_checkBalance";
            button_checkBalance.Size = new Size(112, 63);
            button_checkBalance.TabIndex = 9;
            button_checkBalance.Text = "Balance";
            button_checkBalance.UseVisualStyleBackColor = true;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_checkBalance);
            Controls.Add(button_signup);
            Controls.Add(txt_course);
            Controls.Add(dgv_courses);
            Controls.Add(label1);
            Name = "StudentForm";
            Text = "StudentForm";
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgv_courses;
        private TextBox txt_course;
        private Button button_signup;
        private Button button_checkBalance;
    }
}