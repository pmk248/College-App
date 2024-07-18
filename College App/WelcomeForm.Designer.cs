namespace College_App
{
    partial class WelcomeForm
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
            dgv_welcomeStudents = new DataGridView();
            label1 = new Label();
            txt_welcomeStudent = new TextBox();
            button_board = new Button();
            button_apply = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_welcomeStudents).BeginInit();
            SuspendLayout();
            // 
            // dgv_welcomeStudents
            // 
            dgv_welcomeStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_welcomeStudents.Location = new Point(223, 134);
            dgv_welcomeStudents.Name = "dgv_welcomeStudents";
            dgv_welcomeStudents.RowHeadersWidth = 62;
            dgv_welcomeStudents.Size = new Size(360, 225);
            dgv_welcomeStudents.TabIndex = 0;
            dgv_welcomeStudents.CellContentClick += dgv_welcomeStudents_CellContentClick_1;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.MenuBar;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(799, 56);
            label1.TabIndex = 1;
            label1.Text = "Welcome, please sign up or choose your name.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_welcomeStudent
            // 
            txt_welcomeStudent.Font = new Font("Segoe UI", 12F);
            txt_welcomeStudent.Location = new Point(223, 77);
            txt_welcomeStudent.Name = "txt_welcomeStudent";
            txt_welcomeStudent.Size = new Size(360, 39);
            txt_welcomeStudent.TabIndex = 2;
            // 
            // button_board
            // 
            button_board.Font = new Font("Segoe UI", 12F);
            button_board.Location = new Point(471, 395);
            button_board.Name = "button_board";
            button_board.Size = new Size(112, 43);
            button_board.TabIndex = 3;
            button_board.Text = "Board";
            button_board.UseVisualStyleBackColor = true;
            button_board.Click += button_board_Click;
            // 
            // button_apply
            // 
            button_apply.Font = new Font("Segoe UI", 12F);
            button_apply.Location = new Point(223, 395);
            button_apply.Name = "button_apply";
            button_apply.Size = new Size(112, 43);
            button_apply.TabIndex = 4;
            button_apply.Text = "Apply";
            button_apply.UseVisualStyleBackColor = true;
            button_apply.Click += button_apply_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_apply);
            Controls.Add(button_board);
            Controls.Add(txt_welcomeStudent);
            Controls.Add(label1);
            Controls.Add(dgv_welcomeStudents);
            Name = "WelcomeForm";
            Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)dgv_welcomeStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgv_welcomeStudents;
        private Label label1;
        private TextBox txt_welcomeStudent;
        private Button button_board;
        private Button button_apply;
    }
}
