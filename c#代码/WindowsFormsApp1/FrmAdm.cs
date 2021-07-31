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
using System.Configuration;
using WindowsFormsApp1.baseTable;
using student;

namespace WindowsFormsApp1
{
    public partial class FrmAdm : Form
    {
        public FrmAdm()
        {
            InitializeComponent();
        }

        private void FrmAdm_Load(object sender, EventArgs e)
        {

        }

        private void FrmAdm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要退出系统吗？", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }

        private void 教师信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlConnect con = new sqlConnect();
            string sql = "select lxy_tno09 教师编号,lxy_tname09 教师名称,lxy_tsex09 性别,lxy_tbirth09 出生日期,lxy_tpass09 密码 from Lixy_teacher09";
            DataTable dt = sqlhelper.GetDataTable(sql);
            dgvgradelist.DataSource = dt;
            con.closeConnect();
        }

        private void 生源地信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlConnect con = new sqlConnect();
            string sql = "select lxy_ltown09 区县名,lxy_lcity09 市名,lxy_lprovince09 省份,lxy_lnum09 区县人数 from Lixy_location09";
            DataTable dt = sqlhelper.GetDataTable(sql);
            dgvgradelist.DataSource = dt;
            con.closeConnect();
        }

        private void 专业信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlConnect con = new sqlConnect();
            string sql = "select lxy_mname09 专业名称 from Lixy_major09";
            DataTable dt = sqlhelper.GetDataTable(sql);
            dgvgradelist.DataSource = dt;
            con.closeConnect();
        }

        private void 班级信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlConnect con = new sqlConnect();
            classTable ctable = new classTable();
            ctable.Show();
            con.closeConnect();
            con.closeConnect();
        }
        

        private void 课程信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlConnect con = new sqlConnect();
            courseTable cotable = new courseTable();
            cotable.Show();
            con.closeConnect();
        }


        private void 学生信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sqlConnect con = new sqlConnect();
            studentTable stable = new studentTable();
            stable.Show();
            con.closeConnect();
        }

        private void dgvgradelist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void 教师信息更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 学生信息更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 删除教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hire h = new hire();
            h.Show();
        }

        private void 添加教师信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addteacher at = new addteacher();
            at.Show();
        }

        private void 删除学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string constring = "server=DESKTOP-9I8PERS\\SQL2014;database=LixyMIS09;Integrated Security = true;";
            System.Data.SqlClient.SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("sp_delete09", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@min_credit", 60);  //给输入参数赋值
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("成功删除一条学生记录!", "删除提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            con.Close();
        }

        private void 添加学生信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addstudent ast = new addstudent();
            ast.Show();
        }
    }
}
