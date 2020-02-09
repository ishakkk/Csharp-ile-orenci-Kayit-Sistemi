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
    public partial class updateDatas : Form
    {
        public updateDatas()
        {
            InitializeComponent();
        }
        Form1 mainPage = new Form1();
        private SqlDataAdapter da;
        private DataSet ds;
        private void listPeople(string table)
        {
            string query = "";
            if (table == "studentInformations")
            {
                query = "SELECT * FROM " + table + "";
            }
            else
            {
                query = "SELECT studentInformations.name,studentInformations.lastName,* FROM " + table + " INNER JOIN studentInformations ON studentInformations.studentNo = " + table + ".studentNo";
            }
            
            try
            {
                dataGridView1.DataSource = null;
                mainPage.conn.Open();
                da = new SqlDataAdapter(query, mainPage.conn);
                ds = new DataSet();
                da.Fill(ds, "studentInformations");
                if (ds.Tables[0].Rows.Count == 0)
                {
                    return;
                }
                else
                {
                    dataGridView1.DataSource = ds.Tables["studentInformations"];
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata : " + ex);

            }
            finally
            {
                mainPage.conn.Close();
            }
        }

        //

        private bool updateDataGridView(int item)
        {
            updateLessonGroup.Enabled = false;
            updateResultGroup.Enabled = false;
            updateStudentGroup.Enabled = false;
            switch (item)
            {
                case 0:
                    listPeople("studentInformations");
                    updateStudentGroup.Enabled = true;
                    break;
                case 1:
                    listPeople("lessons");
                    updateLessonGroup.Enabled = true;
                    break;
                case 2:
                    listPeople("examsResults");
                    updateResultGroup.Enabled = true;
                    break;
                default:
                    MessageBox.Show("Herhangi bir tablo çağırılmadı.");
                    return false;
            }
            selectedItem = comboBox1.SelectedIndex;
            return true;
        }

        //
        int selectedItem = 0;
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDataGridView(comboBox1.SelectedIndex);
        }

        private void updateDatas_Load(object sender, EventArgs e)
        {         
            MenuStrip menu = new MenuStrip();
            menu = mainPage.MENU_mainMenu;
            menu.Width = this.Width;
            this.Controls.Add(menu);
        }
        int loc = 0;

        private void B_updateLesson_Click(object sender, EventArgs e)
        {
            MessageBox.Show(CLB_studentLessons.GetItemCheckState(0).ToString());
            string query = "UPDATE lessons SET bm100 = " + (int)CLB_studentLessons.GetItemCheckState(0)+ " , bm200 = " + (int)CLB_studentLessons.GetItemCheckState(1) + ", bm300 = " + (int)CLB_studentLessons.GetItemCheckState(2) +" WHERE studentNo = '" + TB_lessonsStudentNo.Text + "'";
            updateData(query);
            updateDataGridView(1);
        }
        private bool updateData(string query)
        {
            mainPage.conn.Open();

            try
            {
                using (SqlCommand command = new SqlCommand(query, mainPage.conn))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Öğrenci güncellendi.");
                }
            }
            catch
            {
                MessageBox.Show("Kişiyi Güncellerken Hata Oluştu");

            }

            mainPage.conn.Close();
            return true;
        }
        private void B_updateStudent_Click(object sender, EventArgs e)
        {
            string query = "UPDATE studentInformations SET studentNo = '" + TB_studentNo.Text + "' , name = '" + TB_name.Text + "', lastName = '" + TB_lastName.Text + "' ,birthPlace = '" + TB_birthPlace.Text + "', birthYear = '" + TB_birthYear.Text + "' WHERE id = '" + studentId+ "'";
            updateData(query);
            updateDataGridView(0);
        }
        int studentId = -1;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                if (selectedItem == 0)
                {
                    studentId = Convert.ToInt32(row.Cells["id"].Value.ToString());
                    TB_studentNo.Text = row.Cells["studentNo"].Value.ToString();
                    TB_name.Text = row.Cells["name"].Value.ToString();
                    TB_lastName.Text = row.Cells["lastName"].Value.ToString();
                    TB_birthPlace.Text = row.Cells["birthPlace"].Value.ToString();
                    TB_birthYear.Text = row.Cells["birthYear"].Value.ToString();
                }
                else if (selectedItem == 1)
                {
                    TB_lessonsStudentNo.Text = row.Cells["studentNo"].Value.ToString();
                    if (row.Cells["bm100"].Value.ToString() == "1")
                    {
                        CLB_studentLessons.SetItemChecked(0, true);
                    }
                    if (row.Cells["bm200"].Value.ToString() == "1")
                    {
                        CLB_studentLessons.SetItemChecked(1, true);
                    }
                    if (row.Cells["bm300"].Value.ToString() == "1")
                    {
                        CLB_studentLessons.SetItemChecked(2, true);
                    }
                }
                else if (selectedItem == 2)
                {
                    updateResultGroup.Controls.Clear();
                    int i = 4;
                    TB_resultsStudentNo.Text = row.Cells["studentNo"].Value.ToString();
                    while (i < 7)
                    {
                        if (row.Cells[i].Value.ToString() != "0")
                        {
                            row.HeaderCell.Value = "BM"+(i*100-300).ToString();
                            Control[] objs = new Control[2];
                            Label side = new Label();
                            TextBox results = new TextBox();
                            objs[0] = side;
                            objs[1] = results;
                            side.Text = row.HeaderCell.Value.ToString();
                            side.Location = new Point(6, 63 + loc);
                            results.Location = new Point(112, 60 + loc);
                            results.Name = "TB_" + row.HeaderCell.Value.ToString();
                            updateResultGroup.Controls.AddRange(objs);
                            loc += 30;
                        }
                        i++;
                    }
                    loc = 0;
                }
            }
        }

        private void B_updateResults_Click(object sender, EventArgs e)
        {
            TextBox bm100 = new TextBox(), bm200 = new TextBox(), bm300 = new TextBox();
            bm100.Text = "0.0";
            bm200.Text = "0.0";
            bm300.Text = "0.0";
            foreach (Control c in updateResultGroup.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = (TextBox)c;
                    if (txt.Name == "TB_BM100")
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
            string query = "UPDATE examsResults SET bm100 = " + float.Parse(bm100.Text) + " , bm200 = " + float.Parse(bm200.Text) + ", bm300 = " + float.Parse(bm300.Text) + " WHERE studentNo = '" + TB_resultsStudentNo.Text + "'";
            updateData(query);
            updateDataGridView(2);
        }
    }
}
