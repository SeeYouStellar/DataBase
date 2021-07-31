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
using student;
namespace WindowsFormsApp1
{
    public partial class Frmstu_grade : Form
    {
        public Frmstu_grade()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            string cname = textBox1.Text;//课程名
            if(cname=="")
            {
                MessageBox.Show("输入不能为空!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string constring = "server=DESKTOP-9I8PERS\\SQL2014;database=LixyMIS09;Integrated Security = true;";
            System.Data.SqlClient.SqlConnection conn = new SqlConnection(constring);
            conn.Open();
            string sql = "select count(1) from Lixy_course09 where lxy_cname09 = '" + cname + "'";
            SqlCommand cmd2 = new SqlCommand(sql, conn);
            object obj = cmd2.ExecuteScalar();
            if (obj == null || obj == DBNull.Value || ((int)obj) == 0)
            {
                MessageBox.Show("这门课不存在，请重新输入!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string sql3 = "select lxy_grade09 成绩 from Lixy_course09 a,Lixy_report09 b where a.lxy_cno09=b.lxy_cno09 and b.lxy_sno09='" + globaldata.passData + "'and a.lxy_cname09 = '" + cname + "'";
            SqlCommand cmd3 = new SqlCommand(sql3, conn);
            object obj2 = cmd3.ExecuteScalar();
            if (obj2 == null || obj2 == DBNull.Value || ((int)obj2) == 0)
            {
                MessageBox.Show("这门课您未学,或老师还未登录成绩!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            conn.Close();

             
            sqlConnect con = new sqlConnect();
            string sql2 = "select lxy_grade09 成绩 from Lixy_course09 a,Lixy_report09 b where a.lxy_cno09=b.lxy_cno09 and b.lxy_sno09='" + globaldata.passData + "'and a.lxy_cname09 = '"+cname+"'";
            DataTable dt = sqlhelper.GetDataTable(sql2);
            dataGridView1.DataSource = dt;
            con.closeConnect();
        }
    }
}
