using College_App.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace College_App
{
    internal partial class BoardForm : Form
    {
        private string _cs;
        public DBContext dbcontext { get; set; }
        public DataTable courses { get; set; }
        public BoardForm(string cs)
        {
            InitializeComponent();
            _cs = cs;
            dbcontext = new DBContext(_cs);
            ShowCourses();
        }
        public void ShowCourses()
        {
            courses = dbcontext.ExecuteQuery("SELECT CourseName, ID FROM Courses", null);
            dgv_courses.DataSource = courses;
        }
        public void dgv_courses_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_courses.Rows[e.RowIndex];
                string courses = row.Cells["CourseName"].Value.ToString();

                
            }
        }
    }
}
