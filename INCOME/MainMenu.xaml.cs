using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INCOME
{
    public partial class incomeAll : Form
    {
        private Image im;

        public incomeAll()
        {
            InitializeComponent();
            this.im = Image.FromFile(System.IO.Path.GetFullPath("30.jpg"));
            this.BackgroundImage = this.im;
        }

      
       

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            income INCOME = new income();
            INCOME.Show();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            String str = "SELECT * FROM szgl";
            ShowAllData(str);
        }

        private void 关于作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("————————————————————————廖文俊 13软件工程1班 201341404101——————————————————");
        }

        private void 联系作者ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("———————————————————QQ: 1172081598——————————————————");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowAll_Click(object sender, EventArgs e)
        {
             String str = "SELECT * FROM szgl";
             ShowAllData(str);
        }

        private void ShowAllData(string str)
        {
          OleDbConnection conn =  connDB();
            try
            {

                //System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(str);
               // command.Connection = conn;

                conn.Open();

                
                System.Data.OleDb.OleDbDataAdapter da = new OleDbDataAdapter(str, conn);
                System.Data.DataSet ds = new DataSet();
                da.Fill(ds,"name");
                dataGridView1.DataSource = ds.Tables["name"];
               
               
                //insert(conn, command);
                //return 0;

            }



            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex.ToString());

                

            }
            finally
            {
                conn.Close();
            }
        
           
        }

        private OleDbConnection connDB()
        {
            System.Data.OleDb.OleDbConnection conn = new
        System.Data.OleDb.OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data source = szglDB1.mdb";
            return conn;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void admin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "登录用户： " + Form1.strName;
            toolStripStatusLabel2.Text = " || 登录时间： " + DateTime.Now.ToLongTimeString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void calAll_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = connDB();
            string sqlQuery1 = "SELECT SUM(INCOME_NUM) FROM szgl",
                sqlQuery2 = "SELECT SUM(OUTCOME_NUM) FROM szgl";
           

            try {
                conn.Open();
                OleDbCommand command = new OleDbCommand(sqlQuery1, conn);
                string a = command.ExecuteScalar().ToString();
           

              /*  System.Data.OleDb.OleDbDataAdapter da = new OleDbDataAdapter(sqlQuery1, conn);
                System.Data.DataSet ds = new DataSet();
                DataTable dt1 = ds.Tables[0];
                da.Fill(ds, "name");
                dataGridView2.DataSource = ds.Tables["name"];

                System.Data.OleDb.OleDbDataAdapter da1 = new OleDbDataAdapter(sqlQuery2, conn);
                System.Data.DataSet ds1 = new DataSet();
                DataTable dt2 = ds1.Tables[0];
                da.Fill(ds1, "name");
                dataGridView3.DataSource = ds1.Tables["name"];
*/
                myIncome.Text = a;
                OleDbCommand command1 = new OleDbCommand(sqlQuery2, conn);
               string b = command1.ExecuteScalar().ToString();
               outcomeAll.Text = b;
                int A = int.Parse(a);
                int B = int.Parse(b);
               AllNum.Text = (A-B).ToString();
            }
            catch (Exception ex) {
                MessageBox.Show("Failed to connect to data source" + ex.ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
