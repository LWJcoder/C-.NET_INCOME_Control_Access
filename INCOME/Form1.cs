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
using System.Web;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;


namespace INCOME
{
    public partial class Form1 : Form
    {
        private static string valNum;
        public static string strName;
        private Image im;
        public Form1()
        {
            InitializeComponent();
            this.im = Image.FromFile(System.IO.Path.GetFullPath("30.jpg"));
            this.BackgroundImage = this.im;
        }

        private void Form1_Load(object sender, EventArgs e) { Vali(); }

        private void From1_Paint(object sender, PaintEventArgs e) {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 密码_Click(object sender, EventArgs e)
        {
        }



        public int dbConnect()
        {
        
            System.Data.OleDb.OleDbConnection conn = new
              System.Data.OleDb.OleDbConnection();
            // TODO: Modify the connection string and include any
            // additional required properties for your database.
            conn.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                @"Data source=" +
                @"USER_TABLE1.mdb";
            try
            {
                string queryString = "SELECT * FROM [USER_TABLE] WHERE ( USER_ID = '" + USERNAME.Text  + "' and USER_PSW = '" + PSW.Text + "')";
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(queryString, conn);
           
                    conn.Open();
                    string str = command.ExecuteScalar().ToString();

                    if (str == "")
                    {
                        return 1;
                    }
                    else
                    {
                       
                        return 0;
                    }
                }
                
              
            
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source"+ ex.ToString());
                return 1;
            }
            finally
            {
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int obj;
           obj =  dbConnect();
           if (obj == 1)
           {
               MessageBox.Show("没有此用户或密码错误.");
               
           }
           else if(obj == 0) {
               incomeAll m = new incomeAll();
               m.Show();
               this.Hide();
           
           }
               
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    


        private void label1_Click_1(object sender, EventArgs e)
        {

        }

    
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            strName = USERNAME.Text; 
            int obj;   
            if(vali.Text.Equals(valNum)){
           obj =  dbConnect();
        
           if (obj == 1)
           {
               MessageBox.Show("没有此用户或密码错误.");
               
           }
           else if(obj == 0) {
               incomeAll m = new incomeAll();
               m.Show();
               this.Hide();
           
           }
               
         
        }else if(vali.Text.Equals("")){
              MessageBox.Show("请填写验证码.");
            }else{
              MessageBox.Show("验证码错误.");
        }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
    
        }

        //验证码
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Vali();
        }

        private void Vali() {

            Random r = new Random();
            string[] fontString = new string[] { "黑体", "幼圆", "楷体", "华文仿宋" };
            Color[] colorArray = new Color[] { Color.Blue, Color.Black, Color.Yellow, Color.Green };

            string strNumbers = "";

            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bmp);

            //生成4个数字、点、字体、颜色，画出来
            for (int i = 0; i < 4; i++)
            {

                strNumbers += r.Next(0, 9);

                Point pt = new Point(i * 20, 0);
                g.DrawString(strNumbers[i].ToString(), new Font(fontString[i], 20),
                    new SolidBrush(colorArray[r.Next(3)]), pt);
            }
            //save 验证码，用于验证
            valNum = strNumbers.ToString();

            //随机画几条直线
            for (int i = 0; i < 10; i++)
            {
                Point p1 = new Point(r.Next(bmp.Width), r.Next(bmp.Height));
                Point p2 = new Point(r.Next(bmp.Width), r.Next(bmp.Height));
                g.DrawLine(new Pen(colorArray[i % 4]), p1, p2);
            }

            //随机画一些点
            for (int i = 0; i < 200; i++)
            {
                bmp.SetPixel(r.Next(bmp.Width), r.Next(bmp.Height), colorArray[i % 4]);
            }
            pictureBox1.Image = bmp;
        }

    }

}
