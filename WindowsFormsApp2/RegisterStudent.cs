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
    public partial class RegisterStudent : Form
    {
        private DBConnector _dbConnector;
        public RegisterStudent()
        {
            InitializeComponent(); 
        }
        public RegisterStudent(DBConnector dBConnector)
        {
            InitializeComponent();
            _dbConnector = dBConnector;
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name.Text) && string.IsNullOrWhiteSpace(email.Text) && string.IsNullOrWhiteSpace(nrc.Text))
                {
                    MessageBox.Show("Fill require field (Name,NRC and Email)!!", "Require!!", MessageBoxButtons.OK);
                }
                else
                {
                    var query = $"Insert or Replace into Student(Name,Email,NRC,Major,Dob,Age) values('{name.Text}','{email.Text}','{nrc.Text}','{major.Text}','{datePicker.Value}',{age.Text}) ";
                    // var updateQuery = $"Update Student Set Name='{name.Text}',Email='{email.Text}',NRC='{nrc.Text}',Major='{major.Text}',Dob='{datePicker.Value}'";
                    _dbConnector.RunQuery(AddOrUpdateQuery());
                    MessageBox.Show("Added Successfully !", "Successful !", MessageBoxButtons.OK);
                    this.Close();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Cannot set data "+ex.Message);
            }
        }
        private string AddOrUpdateQuery()
        {          
            var sql = $"IF NOT EXISTS (Select * from Student where Email='{email.Text}') BEGIN INSERT INTO Student(Name,Email,NRC,Major,Dob,Age) VALUES('{name.Text}','{email.Text}','{nrc.Text}','{major.Text}','{datePicker.Value}',{age.Text}) END ELSE BEGIN UPDATE Student Set Name='{name.Text}',NRC='{nrc.Text}',Major='{major.Text}',Dob='{datePicker.Value}',Age={age.Text} WHERE Email='{email.Text}' END";
            return sql;
        }
    }
}
