using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class DBConnector
    {
        SqlConnection cnn;
        public static DBConnector Instance = new DBConnector();
        public void CreateDatabaseIfNotExists(string connectionString, string dbName)
        {
            SqlCommand cmd = null;
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (cmd = new SqlCommand($"If(db_id(N'{dbName}') IS NULL) CREATE DATABASE [{dbName}]", connection))
                {
                    cmd.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public DBConnector()
        {
            
            string connetionString = "Data Source= localhost; Initial Catalog = ;Integrated Security = SSPI;";
            CreateDatabaseIfNotExists(connetionString, "QSSTestDB");
            try
            {
                string connStr = "Data Source= localhost; Initial Catalog =QSSTestDB ;Integrated Security = SSPI;";
                cnn = new SqlConnection(connStr);
                cnn.Open();
                string studentTableQuery = "If(object_id('Student') IS NULL) CREATE TABLE Student (Name CHAR(30) NOT NULL,Email CHAR(50) NOT NULL ,NRC CHAR(20) NOT NULL ,Major CHAR(20),Dob date,Age int)";
                RunQuery(studentTableQuery);
                string majorQuery = "If(object_id('Major') IS NULL) CREATE TABLE Major (Name CHAR(30),TeacherName CHAR(20))";
                RunQuery(majorQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! ");
            }
        }
        public void RunQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, cnn);
            command.ExecuteNonQuery();
            command.Dispose();
        }
        public void Export(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, cnn);
            try
            {
                DataTable dt = new DataTable();
                sda.Fill(dt);

                //Microsoft.Office.Interop.Excel.Application xlAppToUpload = new Microsoft.Office.Interop.Excel.Application();
                //xlAppToUpload.Workbooks.Add();

                //Microsoft.Office.Interop.Excel.Worksheet xlWorkSheetToUpload = default(Microsoft.Office.Interop.Excel.Worksheet);
                //xlWorkSheetToUpload = xlAppToUpload.Sheets["Sheet1"];

                //xlAppToUpload.Visible = true;

                //if (dt.Rows.Count > 0)
                //{
                //    var iRowCnt = 0; 

                //    // SHOW THE HEADER BOLD AND SET FONT AND SIZE.
                //    xlWorkSheetToUpload.Cells[1, 1].value = "Employee Details";
                //    xlWorkSheetToUpload.Cells[1, 1].FONT.NAME = "Calibri";
                //    xlWorkSheetToUpload.Cells[1, 1].Font.Bold = true;
                //    xlWorkSheetToUpload.Cells[1, 1].Font.Size = 20;

                //    // MERGE CELLS OF THE HEADER.
                //    xlWorkSheetToUpload.Range["A1:E1"].MergeCells = true;

                //    // SHOW COLUMNS ON THE TOP.
                //    xlWorkSheetToUpload.Cells[iRowCnt - 1, 1].value = "Employee Name";
                //    xlWorkSheetToUpload.Cells[iRowCnt - 1, 2].value = "Mobile";
                //    xlWorkSheetToUpload.Cells[iRowCnt - 1, 3].value = "PresentAddress";
                //    xlWorkSheetToUpload.Cells[iRowCnt - 1, 4].value = "Country";
                //    xlWorkSheetToUpload.Cells[iRowCnt - 1, 5].value = "Email Address";

                //    // NOW WRITE DATA TO EACH CELL.
                //    for (var i = 0; i <= dt.Rows.Count - 1; i++)
                //    {
                //        xlWorkSheetToUpload.Cells[iRowCnt, 1].value = dt.Rows[i]["EmpName"];
                //        xlWorkSheetToUpload.Cells[iRowCnt, 2].value = dt.Rows[i]["Mobile"];
                //        xlWorkSheetToUpload.Cells[iRowCnt, 3].value = dt.Rows[i]["PresentAddress"];
                //        xlWorkSheetToUpload.Cells[iRowCnt, 4].value = dt.Rows[i]["Country"];
                //        xlWorkSheetToUpload.Cells[iRowCnt, 5].value = dt.Rows[i]["Email"];

                //        iRowCnt = iRowCnt + 1;
                //    }

                //    // FINALLY, FORMAT THE EXCEL SHEET USING EXCEL'S AUTOFORMAT FUNCTION.
                //    xlAppToUpload.ActiveCell.Worksheet.Cells[4, 1].AutoFormat();
                //    xlAppToUpload = null;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "You got an Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public List<Student> GetData(string query)
        {
            var students = new List<Student>();
            SqlCommand cmd = new SqlCommand(query, cnn);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    var stu = new Student();
                    stu.Name = reader["Name"].ToString();
                    stu.Email= reader["Email"].ToString();
                    stu.Nrc = reader["NRC"].ToString();
                    stu.Major = reader["Major"].ToString();
                    stu.Dob = reader["Dob"].ToString();
                    students.Add(stu);
                }
            }
            return students;
        }
        public DataTable GetStudentDataTable(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(query, cnn);                
                sda.Fill(dt);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
        public void Close()
        {
            cnn.Close();
        }
    }
}
