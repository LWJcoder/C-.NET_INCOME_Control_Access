﻿using System;
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
    public partial class REGISTER : Form
    {
        private string valNum;
        public REGISTER()
        {
            InitializeComponent();
        }

        private void REGISTER_Load(object sender, EventArgs e)
        {
            Vali();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Vali()
        {

            Random r = new Random();
            string[] fontString = new string[] { "黑体", "幼圆", "楷体", "华文仿宋" };
            Color[] colorArray = new Color[] { Color.Blue, Color.Black, Color.Yellow, Color.Green };

            string strNumbers = "";

            Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
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
            pictureBox2.Image = bmp;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string psw = psw1.Text,
                psw0 = psw2.Text,
            username0 = username.Text;

            if(vali1.Text.Equals(valNum)){
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
                string queryString = "INSERT INTO USER_TABLE(USER_ID, USER_PSW) VALUES ('" + username0 + "','" + psw0 + "') ";
                System.Data.OleDb.OleDbCommand command = new System.Data.OleDb.OleDbCommand(queryString,conn);
                conn.Open();
               int i =  command.ExecuteNonQuery();

               if (i == 1)
               {
                   this.Close();
                   MessageBox.Show("注册成功~~");
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
            else if (vali1.Text.Equals(""))
            {
                MessageBox.Show("输入验证码");
            }else{
                MessageBox.Show("验证码不正确");
            }
        }
    }
}
