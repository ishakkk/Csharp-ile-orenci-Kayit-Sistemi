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

namespace BilgisayarMuhendislikOzelKonular.Database
{
    public partial class createDatabase : Form
    {
        public createDatabase()
        {
            InitializeComponent();
        }
        Form1 mainPage = new Form1();
        private static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;Integrated Security=True;Connect Timeout=30";
        SqlConnection myConn = new SqlConnection(connString);

        private void createDatabase_Load(object sender, EventArgs e)
        {
            MenuStrip menu = new MenuStrip();
            menu = mainPage.MENU_mainMenu;
            this.Width = menu.Width;
            this.Controls.Add(menu);
        }

        private void B_createDatabase_Click(object sender, EventArgs e)
        {
           string str = "CREATE DATABASE "+TXT_databaseName.Text;

            SqlCommand myCommand = new SqlCommand(str, myConn);

            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                MessageBox.Show("Veritabanınız oluşturuldu.", TXT_databaseName.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainPage.Show();
                this.Hide();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), TXT_databaseName.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }
    }
}
