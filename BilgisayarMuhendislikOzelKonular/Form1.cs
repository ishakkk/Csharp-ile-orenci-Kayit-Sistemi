using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BilgisayarMuhendislikOzelKonular.Database;
using BilgisayarMuhendislikOzelKonular.Info;


namespace BilgisayarMuhendislikOzelKonular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=students;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlConnection conn = new SqlConnection(connString);
        DataTable table = new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM studentInformations ORDER BY id ASC";
            SqlCommand cmd = new SqlCommand(query, conn);
                    
            conn.Open();
            using (SqlDataAdapter adap = new SqlDataAdapter(cmd))
            {
                adap.Fill(table);
            }
            conn.Close();
        }
        
        private void veritabanıOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createDatabase db = new createDatabase();
            db.Show();
        }

        private bool createTable(int tableId)
        {
            string query = "";
            try
            {
                switch(tableId)
                {
                    case 0:
                        query = "CREATE TABLE [dbo].[studentInformations] ("
	                        + "[studentId] INT NOT NULL PRIMARY KEY IDENTITY,"
                            + "[studentNo] NCHAR(10) NOT NULL, "
                            + "[name] NCHAR(20) NOT NULL, "
                            + "[lastName] NCHAR(20) NOT NULL,"
                            + " [birthPlace] NCHAR(10) NOT NULL,"
                            + "[birthYear] NCHAR(4) NOT NULL)";
                        break;
                    case 1:
                        query = "CREATE TABLE [dbo].[lessons] ("
                            + "[lessonId] INT NOT NULL PRIMARY KEY IDENTITY,"
                            + "[studentNo] NCHAR(10) NOT NULL, "
                            + "[bm100] int NOT NULL, "
                            + "[bm200] int NOT NULL,"
                            + " [bm300]int NOT NULL)";
                        break;
                    case 2:
                        query = "CREATE TABLE [dbo].[examsResults] ("
                            + "[resultId] INT NOT NULL PRIMARY KEY IDENTITY,"
                            + "[studentNo] NCHAR(10) NOT NULL, "
                            + "[bm100] float NOT NULL, "
                            + "[bm200] float NOT NULL,"
                            + "[bm300] float NOT NULL)";
                        break;
                }
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Connection.Open();
                    int res = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
                    if (res != 0)
                    {
                        MessageBox.Show(tableId + " nolu tablo başarıyla oluşturuldu.", "Başarılı");
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Tablo oluşturulurken hata oluştu. "+e.GetBaseException());
            }
            return true;
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createTable(1);
        }

        private void dersNotlarıTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createTable(2);
        }

        private void öğrenciTablosuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createTable(0);
        }
        
        private void kayıtEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new addDatas()).Show();
        }

        private void kayıtGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateDatas update = new updateDatas();
            update.Show();
        }

        private void kayıtSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteDatas delete = new deleteDatas();
            delete.Show();
        }

        private void B_addPerson_Click(object sender, EventArgs e)
        {

        }
        int num = 0;

        private void getInfo(int b)
        {
            string studentNo="";
            if (b != 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i][1].ToString() == TB_studentNo.Text)
                    {
                        studentNo = table.Rows[i][1].ToString();
                        TB_name.Text = table.Rows[i][2].ToString();
                        TB_lastName.Text = table.Rows[i][3].ToString();
                        TB_birthYear.Text = table.Rows[i][4].ToString();
                        TB_birthPlace.Text = table.Rows[i][5].ToString();
                        num = i;
                        break;
                    }
                }
            }
            else
            {
                if (num < table.Rows.Count && num>=0)
                {
                    studentNo = table.Rows[num][1].ToString();
                    TB_name.Text = table.Rows[num][2].ToString();
                    TB_lastName.Text = table.Rows[num][3].ToString();
                    TB_birthYear.Text = table.Rows[num][4].ToString();
                    TB_birthPlace.Text = table.Rows[num][5].ToString();
                }
            }
            // Ders Kayıtlarını Al
            string query = "SELECT * FROM lessons WHERE studentNo = '" + studentNo + "'";
            SqlCommand cmd = new SqlCommand(query,conn);
            conn.Open();
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (read[2].ToString() == "1")
                {
                    CLB_studentLessons.SetItemChecked(0, true);
                }
                if (read[3].ToString() == "1")
                {
                    CLB_studentLessons.SetItemChecked(1, true);
                }
                if (read[4].ToString() == "1")
                {
                    CLB_studentLessons.SetItemChecked(2, true);
                }
            }
            read.Close();
            // Ders Kayıtlarını Al
            query = "SELECT * FROM examsResults WHERE studentNo = '" + studentNo + "'";
            cmd.CommandText = query;
            read = cmd.ExecuteReader();
            while (read.Read())
            {
                TB_bm100.Text = read[2].ToString();
                TB_bm200.Text = read[3].ToString();
                TB_bm300.Text = read[4].ToString();
            }

            conn.Close();
        }
           
        //

        private void kayıtGösterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(TB_studentNo.Text))
            {
                getInfo(-1);
            }
            else
            {
                MessageBox.Show("Kayıt göstermek için lütfen öğrenci numarası giriniz !");
            }
        }

        private void sonrakiKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (num+1 < table.Rows.Count)
            {
                num++;
            }
            getInfo(0);
        }

        private void öncekiKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (num-1 >=0)
            {
                num--;
            }
            getInfo(0);
        }

        private void toplamKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Toplam Kayıt Sayısı : "+table.Rows.Count);
        }

        private void aktifKayıtSırasıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aktif Kayıt Sırası : "+(num + 1));
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Engin ERGEN 15-155-056");
        }

        private void verilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataReports reports = new dataReports();
            reports.Show();
        }

    }
}
