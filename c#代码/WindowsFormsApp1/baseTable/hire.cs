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
namespace WindowsFormsApp1.baseTable
{
    public partial class hire : Form
    {
        public hire()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                string tname = textBox1.Text;
                string constring = "server=DESKTOP-9I8PERS\\SQL2014;database=LixyMIS09;Integrated Security = true;";
                System.Data.SqlClient.SqlConnection con = new SqlConnection(constring);
                con.Open();
                string sql = "select count(1) from Lixy_teacher09 where lxy_tname09 = '" + tname + "'";
                SqlCommand cmd2 = new SqlCommand(sql, con);
                object obj = cmd2.ExecuteScalar();
                if (obj == null || obj == DBNull.Value || ((int)obj) == 0)
                {
                    MessageBox.Show("该教师不存在，请重新输入!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand cmd = new SqlCommand("sp_hire09", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tname", tname);  //给输入参数赋值

                cmd.ExecuteNonQuery();
                MessageBox.Show("成功删除一个教师!", "删除提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                con.Close();
            
        }
    }
}
