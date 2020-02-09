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
    public partial class deleteDatas : Form
    {
        public deleteDatas()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        DataSet ds;
        Form1 mainPage = new Form1();
        string query = "";
        private string listPeople(string table)
        {
            try
            {
                query = "SELECT  * FROM "+table+"";
                tableRows.DataSource = null;
                mainPage.conn.Open();
                da = new SqlDataAdapter(query, mainPage.conn);
                ds = new DataSet();
                da.Fill(ds, table);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    return table;
                }
                else
                {
                    tableRows.DataSource = ds.Tables[table];
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Hata : " + ex);

            }
            finally
            {
                mainPage.conn.Close();
                //da.Dispose(); 
            }
            return table;
        }

        private void deleteDatas_Load(object sender, EventArgs e)
        {
            MenuStrip menu = new MenuStrip();
            menu = mainPage.MENU_mainMenu;
            menu.Width = this.Width;
            this.Controls.Add(menu);
        }
        string tableName = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    tableName = listPeople("studentInformations");
                    selectedItemComboBox = 0;
                    break;
                case 1:
                    tableName = listPeople("lessons");
                    selectedItemComboBox = 1;
                    break;
                case 2:
                    tableName = listPeople("examsResults");
                    selectedItemComboBox = 2;
                    break;
                default:
                    MessageBox.Show("Hiçbir tablo seçilmedi !");
                    selectedItemComboBox = -1;
                    break;
            }
        }
        int getStudentNo = 0;
        int selectedItemComboBox = -1;
        private void tableRows_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if(selectedItemComboBox != -1)
                {
                    DataGridViewRow row = this.tableRows.Rows[e.RowIndex];
                    getStudentNo = Convert.ToInt32(row.Cells["id"].Value);
                }
                
            }
        }

        private void deleteTableRow_Click(object sender, EventArgs e)
        {
            string deleteQuery = "DELETE FROM "+tableName+" WHERE id = "+getStudentNo+"";
            mainPage.conn.Open();
            try
            {
                using (SqlCommand command = new SqlCommand(deleteQuery, mainPage.conn))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Kişi Başarıyla Silindi !");
                }
                mainPage.conn.Close();
                listPeople(tableName);
            }
            catch
            {
                MessageBox.Show("Kişiyi Silerken Hata Oluştu");

            }
        }
    }
}
