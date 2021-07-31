using student;
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

namespace WindowsFormsApp1
{
    public partial class Frmtea_grade : Form
    {
        public Frmtea_grade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //不能为空
                string sno = textBox1.Text;
                if (sno == "")
                {
                    MessageBox.Show("学号不能为空!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string cno = textBox2.Text;
                if (cno == "")
                {
                    MessageBox.Show("课程号不能为空!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string grade = textBox_grade1.Text;
                if (grade == "")
                {
                    MessageBox.Show("成绩不能为空!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string constring = "server=DESKTOP-9I8PERS\\SQL2014;database=LixyMIS09;Integrated Security = true;";
                SqlConnection conn = new SqlConnection(constring);
                conn.Open();
                //判断是否已有成绩
                string sql3 = "select count(1) from Lixy_report09 where lxy_sno09 = '" + sno + "' and lxy_cno09 = '" + cno + "'";
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                object obj2 = cmd3.ExecuteScalar();
                if (obj2 == null || obj2 == DBNull.Value || ((int)obj2) == 0)
                {
                    string sql2 = "insert into Lixy_report09 values('" + globaldata.passData + "','" + cno + "','" + sno + "'," + grade + ")";
                    SqlCommand cmd2 = new SqlCommand(sql2, conn);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("录入成功", "成功提醒", MessageBoxButtons.OK, MessageBoxIcon.None);
                    //更改绩点
                    string sql = "select lxy_gotcredit09 from Lixy_student09 where lxy_sno09 = '" + sno + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    object obj = cmd.ExecuteScalar();
                    if (obj == null || obj == DBNull.Value || ((int)obj) == 0)
                    {
                        MessageBox.Show("输入有误，请重新输入!", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    textBox_gotcredit.Text = obj.ToString();
                }
                else
                    MessageBox.Show("该学生该门课已有成绩!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);


                conn.Close();
            }
            catch(Exception e_)
            {
                MessageBox.Show("错误输入", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sno = textBox1.Text;
                string constring = "server=DESKTOP-9I8PERS\\SQL2014;database=LixyMIS09;Integrated Security = true;";
                SqlConnection conn = new SqlConnection(constring);
                conn.Open();

                string sql = "select lxy_gotcredit09 from Lixy_student09 where lxy_sno09 = '" + sno + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                object obj = cmd.ExecuteScalar();
                if (obj == null || obj == DBNull.Value || ((int)obj) == 0)
                {
                    MessageBox.Show("输入有误，请重新输入!", "登录提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                textBox_gotcredit.Text = obj.ToString();
                conn.Close();
            }
            catch(Exception e_)
            {
                MessageBox.Show("错误输入", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string sno = textBox1.Text;
                if (sno == "")
                {
                    MessageBox.Show("学号不能为空!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string cno = textBox2.Text;
                if (cno == "")
                {
                    MessageBox.Show("课程号不能为空!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string grade = textBox_grade1.Text;
                if (grade == "")
                {
                    MessageBox.Show("成绩不能为空!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //还未有成绩，不能修改
                string constring = "server=DESKTOP-9I8PERS\\SQL2014;database=LixyMIS09;Integrated Security = true;";
                SqlConnection conn = new SqlConnection(constring);
                conn.Open();
                string sql3 = "select count(1) from Lixy_report09 where lxy_sno09 = '" + sno + "' and lxy_cno09 = '" + cno + "'";
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                object obj2 = cmd3.ExecuteScalar();
                if (obj2 == null || obj2 == DBNull.Value || ((int)obj2) == 0)
                {
                    MessageBox.Show("该学生该门课无成绩!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string sql2 = "insert into Lixy_report09 values('" + globaldata.passData + "','" + cno + "','" + sno + "'," + grade + ")";
                SqlCommand cmd2 = new SqlCommand(sql2, conn);

                MessageBox.Show("修改成功", "成功提醒", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            catch(Exception e_)
            {
                MessageBox.Show("错误输入", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void textBox_gotcredit_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
