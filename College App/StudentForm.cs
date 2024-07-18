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

namespace College_App
{
    public partial class StudentForm : Form
    {
        private string _cs;
        //public DBContext dbcontext { get; set; }
        public StudentForm(string cs, int id)
        {
            InitializeComponent();
            
        }
    }
}
