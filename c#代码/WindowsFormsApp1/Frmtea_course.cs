using student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp1
{
    public partial class Frmtea_course : Form
    {
        public Frmtea_course()
        {
            InitializeComponent();
        }

        private void Frmtea_course_Load(object sender, EventArgs e)
        {
            sqlConnect con = new sqlConnect();
            string sql = "select lxy_cno09 课程编号,lxy_cname09 课程 from teacher_course09 where lxy_tno09 = '" + globaldata.passData + "'";
            DataTable dt = sqlhelper.GetDataTable(sql);
            dataGridView1.DataSource = dt;
            con.closeConnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cno = textBox1.Text;
                sqlConnect con = new sqlConnect();
                string sql = "select a.lxy_sno09 学生编号,lxy_sname09 学生姓名 ,lxy_clno09 班级编号 from Lixy_report09 a,Lixy_student09 b where a.lxy_sno09 = b.lxy_sno09 and a.lxy_cno09 = '" + cno + "'";
                DataTable dt = sqlhelper.GetDataTable(sql);
                dataGridView1.DataSource = dt;
                con.closeConnect();
            }
            catch(Exception e_)
            {
                MessageBox.Show("输入错误!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string cno = textBox1.Text;
                string constring = "server=DESKTOP-9I8PERS\\SQL2014;database=LixyMIS09;Integrated Security = true;";
                SqlConnection conn = new SqlConnection(constring);
                string sql = "select avg_grade 平均成绩 from avg_grade2_09 where lxy_cno09 ='" + cno + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                object obj = cmd.ExecuteScalar();
                textBox2.Text = obj.ToString();
                conn.Close();
            }
            catch(Exception e_)
            {
                MessageBox.Show("输入错误!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
