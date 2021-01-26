using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Main : Form
    {
        DBConnector _DBConnector;
        public Main()
        {
            InitializeComponent();
            _DBConnector = DBConnector.Instance;          
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {            
            RegisterStudent registerStudent = new RegisterStudent(_DBConnector);
            registerStudent.ShowDialog(this);
        }

        private void search_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(_DBConnector);
            searchForm.ShowDialog(this);
        }

        private void studentList_Click(object sender, EventArgs e)
        {
            StudentList studentList = new StudentList(_DBConnector);
            studentList.ShowDialog(this);
        }

        private void majorForm_Click(object sender, EventArgs e)
        {
            MajorForm majorForm = new MajorForm(_DBConnector);
            majorForm.ShowDialog(this);
        }

        private void majorList_Click(object sender, EventArgs e)
        {
            MajorList majorList = new MajorList(_DBConnector);
            majorList.ShowDialog(this);
        }
    }
}
