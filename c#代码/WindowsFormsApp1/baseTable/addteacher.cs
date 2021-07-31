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

namespace WindowsFormsApp1.baseTable
{
    public partial class addteacher : Form
    {
        public addteacher()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string tno = textBox_tno.Text;
                if (tno == "")
                {
                    MessageBox.Show("教师编号不能为空", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string tname = textbox_tname.Text;
                if (tname == "")
                {
                    MessageBox.Show("教师名字不能为空", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string tsex = comboBox_sex.Text;
                string ttitle = comboBox_title.Text;
                string ttel = textBox_tel.Text;
                string tpass = textBox_pass.Text;
                string dbirth = dateTimePicker1.Value.ToShortDateString();
                string sql = "insert into Lixy_teacher09 values('" + tno + "','" + tname + "','" + tsex + "'," + dbirth + ",'" + ttitle + "','" + ttel + "','" + tpass + "')";

                string constring = "server=DESKTOP-9I8PERS\\SQL2014;database=LixyMIS09;Integrated Security = true;";
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                string sql2 = "select count(1) from Lixy_teacher09 where lxy_tno09 = '" + tno + "'";
                SqlCommand cmd2 = new SqlCommand(sql2, con);

                object obj = cmd2.ExecuteScalar();
                if (obj != null && obj != DBNull.Value && ((int)obj) != 0)
                {
                    MessageBox.Show("该用户已存在", "错误信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("成功添加教师" + tname, "成功提示", MessageBoxButtons.OK, MessageBoxIcon.None);


                }
                con.Close();
                return;
            }
            catch(Exception e_)
            {
                MessageBox.Show("错误的输入", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
