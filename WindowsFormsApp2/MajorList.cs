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
    public partial class MajorList : Form
    {
        public MajorList(DBConnector dBConnector)
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("Major", typeof(string));
            dt.Columns.Add("No of student", typeof(string));
            dt.Columns.Add("Teacher Name", typeof(string));
            var query = "select m.Name,COUNT(DISTINCT st.Email) AS NoOfStudent,m.TeacherName from Major m LEFT JOIN Student st ON st.Major=m.Name GROUP BY m.Name,m.TeacherName";
            var dts = dBConnector.GetStudentDataTable(query);           
            if (dts.Rows.Count > 0)
            {
                foreach (DataRow s in dts.Rows)
                {
                    dt.Rows.Add(s.ItemArray);
                }
                grid.DataSource = dt;
            }
        }
    }
}
