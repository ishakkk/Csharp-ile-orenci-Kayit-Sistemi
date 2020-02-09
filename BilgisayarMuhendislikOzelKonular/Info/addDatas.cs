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
    public partial class addDatas : Form
    {
        public addDatas()
        {
            InitializeComponent();
        }
        private Form1 mainPage = new Form1();
        private void addDatas_Load(object sender, EventArgs e)
        {
            MenuStrip menu = new MenuStrip();
            menu = mainPage.MENU_mainMenu;
            this.Width = menu.Width;
            this.Controls.Add(menu);
        }

        private static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=students;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public SqlConnection conn = new SqlConnection(connString);
        enum dataType
        {
            student,lesson,result
        }
        private bool addData(dataType type)
        {
            void addDatabase(string query)
            {
                conn.Open();
                try
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show(type.ToString()+" başarıyla eklendi.");
                    }
                }
                catch
                {
                    MessageBox.Show("Kişiyi Eklerken Hata Oluştu");

                }
                conn.Close();
            }
            if (type == dataType.student)
            {
                if (!String.IsNullOrEmpty(TB_studentNo.Text) || !String.IsNullOrEmpty(TB_name.Text) || !String.IsNullOrEmpty(TB_lastName.Text) || !String.IsNullOrEmpty(TB_birthYear.Text) || !String.IsNullOrEmpty(TB_birthPlace.Text))
                {
                    addDatabase("INSERT INTO studentInformations(studentNo, name,lastName,birthYear,birthPlace) VALUES('"+TB_studentNo.Text+ "','" + TB_name.Text + "', '" + TB_lastName.Text + "', '" + TB_birthYear.Text + "','" + TB_birthPlace.Text + "')");
                }
                else
                {
                    MessageBox.Show("Lütfen değerleri boş girmeyiniz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else if(type == dataType.lesson)
            {
                addDatabase("INSERT INTO lessons(studentNo, bm100,bm200,bm300) VALUES('" + TB_lessonsStudentNo.Text + "','" + Convert.ToInt16(CLB_studentLessons.GetItemChecked(0))+ "', '" + Convert.ToInt16(CLB_studentLessons.GetItemChecked(1)) + "', '" + Convert.ToInt16(CLB_studentLessons.GetItemChecked(2)) + "')");
            }
            else
            {
                TextBox bm100 = new TextBox(), bm200=new TextBox(), bm300=new TextBox();
                bm100.Text = "0.0";
                bm200.Text = "0.0";
                bm300.Text = "0.0";
                foreach (Control c in addNewResultGroup.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox txt = (TextBox)c;
                        if(txt.Name == "TB_BM100")
                        {
                            bm100 = txt;
                        }
                        if (txt.Name == "TB_BM200")
                        {
                            bm200 = txt;
                        }
                        if (txt.Name == "TB_BM300")
                        {
                            bm300 = txt;
                        }
                    }
                }
                addDatabase("INSERT INTO examsResults(studentNo, bm100,bm200,bm300) VALUES('" + TB_resultsStudentNo.Text + "'," +Convert.ToDouble(bm100.Text)+ ", " + Convert.ToDouble(bm200.Text) + ", " + Convert.ToDouble(bm300.Text) + ")");
            }

            return true;
        }
        private int loc = 0;
        private void TB_resultsStudentNo_TextChanged(object sender, EventArgs e)
        {
            loc = 0;
            addNewResultGroup.Controls.Clear();
            string query = "SELECT bm100 = "
            +" CASE "
                    +"WHEN bm100 = 1 THEN 'BM100' "
                    +"ELSE null"
                    +" END, "
            +"bm200 ="
                 +"CASE "
                     +"WHEN bm200 = 1 THEN 'BM200' "
                     +"ELSE null"
                     +" END, "
            +"bm300 ="
                 +"CASE"
                    +" WHEN bm300 = 1 THEN 'BM300'"
                    +" ELSE null"
                     +" END FROM lessons WHERE studentNo = '"+TB_resultsStudentNo.Text+"'";
            // Veritabanından veri alımı
            int i = 0;
            SqlCommand cmd = new SqlCommand(query,conn);
            conn.Open();
            SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.SingleRow);
            if (reader.Read())
            {
                while (i < 3)
                {
                    if (!String.IsNullOrEmpty(reader[i].ToString()))
                    {
                        Control[] objs = new Control[2];
                        Label side = new Label();
                        TextBox results = new TextBox();
                        objs[0] = side;
                        objs[1] = results;
                        side.Text = reader[i].ToString();
                        side.Location = new Point(6, 63 + loc);
                        results.Location = new Point(112, 60 + loc);
                        results.Name = "TB_" + reader[i].ToString();
                        addNewResultGroup.Controls.AddRange(objs);
                        loc += 30;
                    }
                    i++;
                }
            }
            conn.Close();
            //

            
        }

        private void B_addPerson_Click(object sender, EventArgs e)
        {
            addData(dataType.student);
        }

        private void B_addLesson_Click(object sender, EventArgs e)
        {
            addData(dataType.lesson);
        }

        private void B_addResults_Click(object sender, EventArgs e)
        {
            addData(dataType.result);
        }
    }
}
