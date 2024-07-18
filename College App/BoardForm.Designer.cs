namespace College_App
{
    partial class BoardForm
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
            dgv_courses = new DataGridView();
            txt_totalProfits = new TextBox();
            label1 = new Label();
            txt_lecturerBalance = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_courses).BeginInit();
            SuspendLayout();
            // 
            // dgv_courses
            // 
            dgv_courses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_courses.Location = new Point(21, 142);
            dgv_courses.Name = "dgv_courses";
            dgv_courses.RowHeadersWidth = 62;
            dgv_courses.Size = new Size(360, 287);
            dgv_courses.TabIndex = 0;
            dgv_courses.CellContentClick += dgv_courses_CellContentClick_1;
            // 
            // txt_totalProfits
            // 
            txt_totalProfits.Font = new Font("Segoe UI", 15F);
            txt_totalProfits.Location = new Point(419, 380);
            txt_totalProfits.Name = "txt_totalProfits";
            txt_totalProfits.Size = new Size(360, 47);
            txt_totalProfits.TabIndex = 2;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.MenuBar;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(21, 22);
            label1.Name = "label1";
            label1.Size = new Size(767, 60);
            label1.TabIndex = 4;
            label1.Text = "Course Standings\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_lecturerBalance
            // 
            txt_lecturerBalance.Font = new Font("Segoe UI", 15F);
            txt_lecturerBalance.Location = new Point(419, 183);
            txt_lecturerBalance.Name = "txt_lecturerBalance";
            txt_lecturerBalance.Size = new Size(360, 47);
            txt_lecturerBalance.TabIndex = 5;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(419, 142);
            label2.Name = "label2";
            label2.Size = new Size(354, 38);
            label2.TabIndex = 6;
            label2.Text = "Lecturer Balance";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(419, 333);
            label3.Name = "label3";
            label3.Size = new Size(360, 38);
            label3.TabIndex = 7;
            label3.Text = "Total Profits (over 30%)";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BoardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_lecturerBalance);
            Controls.Add(label1);
            Controls.Add(txt_totalProfits);
            Controls.Add(dgv_courses);
            Name = "BoardForm";
            Text = "BoardForm";
            ((System.ComponentModel.ISupportInitialize)dgv_courses).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_courses;
        private TextBox txt_totalProfits;
        private Label label1;
        private TextBox txt_lecturerBalance;
        private Label label2;
        private Label label3;
    }
}