using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class SearchForm : Form
    {
        private string rbn="Name";
        private DBConnector _dBConnector;
        public SearchForm(DBConnector dBConnector)
        {
            InitializeComponent();
            rName.Checked = true;
            _dBConnector = dBConnector;
        }

        private void CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rBtn = sender as RadioButton;
            rbn = rBtn.Text;
        }
        private void AddToGrid(string query)
        {
            DataTable dt = new DataTable();
            var dts = _dBConnector.GetStudentDataTable(query);
            if (dts.Rows.Count > 0)
            {
                foreach (DataColumn s in dts.Columns)
                {
                    dt.Columns.Add(s.ColumnName, typeof(string));
                }
                foreach (DataRow s in dts.Rows)
                {
                    dt.Rows.Add(s.ItemArray);
                }
                grid.DataSource = dt;
            }
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            grid.DataSource = null;
            if (rbn == "Name" && !string.IsNullOrWhiteSpace(searchTxt.Text) && !string.IsNullOrEmpty(searchTxt.Text))
            {
                var query = "select * from student where Name='"+searchTxt.Text+"'";
                AddToGrid(query);    
            }
            else if (rbn == "Email" && !string.IsNullOrWhiteSpace(searchTxt.Text) && !string.IsNullOrEmpty(searchTxt.Text))
            {
                var query = "select * from student where Email='" + searchTxt.Text + "'";
                AddToGrid(query);
            }
            if (rbn == "Major" && !string.IsNullOrWhiteSpace(searchTxt.Text) && !string.IsNullOrEmpty(searchTxt.Text))
            {
                var query = "select * from student where Major='" + searchTxt.Text + "'";
                AddToGrid(query);
            }
        }
        private void export_Click(object sender, EventArgs e) 
        {
            if (grid.DataSource != null)
            {
                string folderPath = "C:\\Excel\\";
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                //Codes for the Closed XML
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add((DataTable)grid.DataSource, "Students");
                    wb.SaveAs(folderPath + "StudentExport_" + Guid.NewGuid().ToString() + ".xlsx");
                }
            }

        }
    }
}
