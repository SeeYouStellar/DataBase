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
    public partial class stu_change : Form
    {
        public stu_change()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newpass = textBox2.Text;//新密码
            string newpass_again = textBox3.Text;
            if(newpass == newpass_again)
            {
                string constring = "server=DESKTOP-9I8PERS\\SQL2014;database=LixyMIS09;Integrated Security = true;";
                SqlConnection conn = new SqlConnection(constring);
                conn.Open();
                string sql = "update Lixy_student09 set lxy_spass09 = '" + newpass + "' where lxy_sno09 = '" + globaldata.passData + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功!", "成功提醒", MessageBoxButtons.OK, MessageBoxIcon.None);
                conn.Close();
            }
            else
            {
                MessageBox.Show("两次输入不同，请重新输入!", "错误提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void stu_change_Load(object sender, EventArgs e)
        {

        }
    }
}
