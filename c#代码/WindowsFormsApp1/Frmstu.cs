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
    public partial class frmstu : Form
    {
        public frmstu()
        {
            InitializeComponent();
        }

        private void 信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button成绩查询_Click(object sender, EventArgs e)
        {
            Frmstu_grade fg = new Frmstu_grade();
            fg.Show();
        }

        private void button课表查询_Click(object sender, EventArgs e)
        {
            Frmstu_course fc = new Frmstu_course();
            fc.Show();
        }

        private void frmstu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要退出系统吗？", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }

        private void frmstu_Load(object sender, EventArgs e)
        {
            
            string sql = "select lxy_gotcredit09 已修学分 from Lixy_student09 where lxy_sno09 = '" + globaldata.passData + "'";
           
            string constring = "server=DESKTOP-9I8PERS\\SQL2014;database=LixyMIS09;Integrated Security = true;";
            SqlConnection conn = new SqlConnection(constring);
          
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            object obj = cmd.ExecuteScalar();
            textBox1.Text = obj.ToString();
            conn.Close();

        }

        private void button绩点_Click(object sender, EventArgs e)
        {
            Frmstu_gpa fga = new Frmstu_gpa();
            fga.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stu_change sch = new stu_change();
            sch.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
