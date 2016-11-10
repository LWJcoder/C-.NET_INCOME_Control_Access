using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INCOME
{
    public partial class change : Form
    {
        public change()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             string psw = password1.Text,
                psw0 = password2.Text;
            //得到用户名
             string username = Form1.strName;

            if (psw != psw0) {
                MessageBox.Show("两次密码不一致，请重新输入");
            }

            //注册
            System.Data.OleDb.OleDbConnection conn = new
              System.Data.OleDb.OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data source=" +
                @"USER_TABLE1.mdb";
            try
            {
                string queryString = "UPDATE USER_TABLE SET USER_PSW = '" + psw0 + "' WHERE USER_ID =  '" + username+"'";
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(queryString,conn);
                conn.Open();
               int i =  command.ExecuteNonQuery();

               if (i == 1)
               {
                   this.Close();
                   MessageBox.Show("修改成功~~");
               }
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

    }
}
