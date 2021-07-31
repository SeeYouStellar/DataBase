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
    public partial class changetea : Form
    {
        public changetea()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string newpass = textBox2.Text;//新密码
            string newpass_again = textBox3.Text;
            if (newpass == newpass_again)
            {
                string constring = "server=DESKTOP-9I8PERS\\SQL2014;database=LixyMIS09;Integrated Security = true;";
                SqlConnection conn = new SqlConnection(constring);
                conn.Open();
                string sql = "update Lixy_teacher09 set lxy_tpass09 = '" + newpass + "' where lxy_tno09 = '" + globaldata.passData + "'";
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
    }
}
