using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace INCOME
{
    public partial class income : Form
    {
        private Image im;
        public income()
        {
            InitializeComponent();
            this.im = Image.FromFile(System.IO.Path.GetFullPath("30.jpg"));
            this.BackgroundImage = this.im;
        }

        public int insertDb(string queryString) {
            System.Data.OleDb.OleDbConnection conn = new
         System.Data.OleDb.OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data source = szglDB1.mdb";
            try
            {
  
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(queryString);
                command.Connection = conn;

                conn.Open();
                command.ExecuteNonQuery();
               
                this.Hide();
                return 0; 
                //insert(conn, command);
                //return 0;
               
            }



            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source" + ex.ToString());

                return 1;
               
            }
            finally
            {
                conn.Close();
            }
        
        }

 
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void income_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string INCOME_NUM_Text = hasNumber(INCOME_NUM.Text),
                OUTCOME_NUM_Text = hasNumber(OUTCOME_NUM.Text),
                OUTCOME_R_Text = hasText(OUTCOME_R.Text),
                INCOME_R_Text = hasText(INCOME_R.Text);
            string queryString = "INSERT INTO  szgl (INCOME_NUM, INCOME_R, OUTCOME_NUM, OUTCOME_R) VALUES ( '" + INCOME_NUM_Text + "' , '" + INCOME_R_Text + "' , '" + OUTCOME_NUM_Text + "' , '" + OUTCOME_R_Text + "')";
            insertDb(queryString);
        }

        private string hasText(string p)
        {
            if (p == "") return "...";
            else return  p;
            throw new NotImplementedException();
        }

        private string hasNumber(string p)
        {
            if (p == "") return "0";
            else return p;
            throw new NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void INCOME_NUM_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
