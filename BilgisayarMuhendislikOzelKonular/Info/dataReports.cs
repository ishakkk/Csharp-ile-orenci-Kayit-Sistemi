using BilgisayarMuhendislikOzelKonular.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgisayarMuhendislikOzelKonular.Info
{
    public partial class dataReports : Form
    {
        public dataReports()
        {
            InitializeComponent();
        }
        DataTable tb = new DataTable();
        Form1 mainPage = new Form1();
        private void execute(string lesson)
        {
            float ort = 0;
            if (!String.IsNullOrEmpty(TB_fileName.Text))
            {
                string query = "SELECT studentInformations.name, studentInformations.lastName, studentInformations.birthPlace, studentInformations.birthYear, examsResults." + lesson + " FROM studentInformations"
                    + " INNER JOIN examsResults ON examsResults.studentNo = studentInformations.studentNo"
                    + " INNER JOIN lessons ON lessons.studentNo = studentInformations.studentNo  WHERE lessons." + lesson + " = 1 UNION ALL"
                    + " SELECT '','','','Ortalama', Avg(examsResults." + lesson + ") FROM examsResults";
                mainPage.conn.Open();
                SqlDataAdapter read = new SqlDataAdapter(query, mainPage.conn);
                read.Fill(tb);
                mainPage.conn.Close();
                tb.ExportToExcel("C:\\Users\\EnginERGEN\\Desktop\\" + TB_fileName.Text + ".xlsx");
            }
            else
            {
                MessageBox.Show("Lütfen dosya ismini giriniz !");
            }
        }
        private void B_average_Click(object sender, EventArgs e)
        {
            execute("bm100");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            execute("bm200");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            execute("bm300");
        }
    }
}
