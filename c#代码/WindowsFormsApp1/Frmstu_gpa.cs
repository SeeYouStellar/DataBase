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
    public partial class Frmstu_gpa : Form
    {
        public Frmstu_gpa()
        {
            InitializeComponent();
        }

        private void label专业_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //专业排名存储过程调用
            string constring = "server=DESKTOP-9I8PERS\\SQL2014;database=LixyMIS09;Integrated Security = true;";
            System.Data.SqlClient.SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Lixy_stu_major_rank", con);
            cmd.CommandType = CommandType.StoredProcedure;  //改变命令类型
            cmd.Parameters.AddWithValue("@Sno", globaldata.passData);  //给输入参数赋值
            cmd.Parameters.Add("@majorrank", SqlDbType.Int);
            cmd.Parameters["@majorrank"].Direction = ParameterDirection.Output;//定义输出变量
            cmd.ExecuteNonQuery();
            string asde = cmd.Parameters["@majorrank"].Value.ToString();//获取输出变量
            textBox1.Text = asde;

            //班级排名存储过程调用
            SqlCommand cmd2 = new SqlCommand("Lixy_stu_class_rank", con);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@Sno", globaldata.passData);  //给输入参数赋值
            cmd2.Parameters.Add("@classrank", SqlDbType.Int);
            cmd2.Parameters["@classrank"].Direction = ParameterDirection.Output;
            cmd2.ExecuteNonQuery();
            string asde2 = cmd2.Parameters["@classrank"].Value.ToString();
            textBox2.Text = asde2;

            string sql = "select lxy_cname09 课程名称 ,lxy_grade09 分数 from Lixy_course09 a,Lixy_report09 b where a.lxy_cno09=b.lxy_cno09 and b.lxy_sno09='"+globaldata.passData+"'";
            DataTable dt = sqlhelper.GetDataTable(sql);
            dataGridView1.DataSource = dt;

            sql = "select GPA from gpa_2_09 where lxy_sno09 = '" + globaldata.passData + "'";
            SqlCommand cmd3 = new SqlCommand(sql, con);
            
            object obj = cmd3.ExecuteScalar();
            textBoxgpa.Text = obj.ToString();

            con.Close();
        }
    }
}
