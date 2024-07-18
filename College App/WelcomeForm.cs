using College_App.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace College_App
{
    internal partial class WelcomeForm : Form
    {
        private string _cs;
        public DBContext dbcontext { get; set; }
        public DataTable students { get; set; }
        public WelcomeForm(string cs)
        {
            InitializeComponent();
            _cs = cs;
            dbcontext = new DBContext(_cs);
            ShowStudents();

        }
        public void ShowStudents()
        {
            students = dbcontext.ExecuteQuery("SELECT Fullname, ID FROM Students", null);
            dgv_welcomeStudents.DataSource = students;
        }

        private void button_apply_Click(object sender, EventArgs e)
        {
            string user_input = txt_welcomeStudent.Text;
            if (string.IsNullOrEmpty(user_input))
            {
                MessageBox.Show("Please enter or select a valid name");
                return;
            }

            SqlParameter[] name = { new SqlParameter("@student", user_input) };
            int result = dbcontext.ExecuteNonQuery("INSERT INTO Students(FullName) VALUES(@student);", name);
            if (result < 1)
            {
                MessageBox.Show("Name already exists or a database error has occurred");
                return;
            }

            MessageBox.Show($"{user_input} added to the RSVP list");
            students.Rows.Add(user_input);
        }

        private void button_board_Click(object sender, EventArgs e)
        {
            BoardForm boardForm = new BoardForm(_cs);
            boardForm.Show();
            this.Hide();
        }

        private void dgv_welcomeStudents_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_welcomeStudents.Rows[e.RowIndex];

                string students = row.Cells["FullName"].Value.ToString();
                int id = Convert.ToInt32(row.Cells["ID"].Value);

                StudentForm studentForm = new StudentForm(_cs, id);
                studentForm.Show();
                this.Hide();
            }
        }
    }
}
