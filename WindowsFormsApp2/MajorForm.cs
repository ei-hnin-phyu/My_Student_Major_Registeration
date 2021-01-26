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
    public partial class MajorForm : Form
    {
        private DBConnector _dBConnector;
        public MajorForm(DBConnector dBConnector)
        {
            InitializeComponent();
            _dBConnector = dBConnector;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sql = $"IF NOT EXISTS (Select * from Major where Name='{major.Text}') BEGIN INSERT INTO Major(Name,TeacherName) VALUES('{major.Text}','{teacher.Text}') END ELSE BEGIN UPDATE Major Set Name='{major.Text}',TeacherName='{teacher.Text}' WHERE Name='{major.Text}' END";
            _dBConnector.RunQuery(sql);
            MessageBox.Show("Added Successfully !", "Successful !", MessageBoxButtons.OK);
            this.Close();
        }
    }
}
