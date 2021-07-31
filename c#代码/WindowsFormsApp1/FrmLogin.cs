using WindowsFormsApp1;
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

namespace WindowsFormsApp1
{
    public partial class FrmLogin : Form
    {
        sqlConnect con = new sqlConnect();
        public DataSet ds = new DataSet();
        private string sql;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtPwd.Text == "")
                {
                    MessageBox.Show("密码或账号不能为空", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }
                if (role.Text == "管理员")
                {
                    sql = "SELECT lxy_conacc09,lxy_passward09 FROM Lixy_controlacc09" + "  where lxy_conacc09=" + "'" + txtName.Text + "'";
                    ds = con.Getds(sql);
                    string DeptNo1 = ds.Tables[0].Rows[0][0].ToString();
                    string DeptNo2 = ds.Tables[0].Rows[0][1].ToString();

                    if (txtName.Text != DeptNo1.Trim() || txtPwd.Text != DeptNo2.Trim())
                        MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        globaldata.passData = txtName.Text;
                        FrmAdm fmain = new FrmAdm();
                        fmain.Show();
                        this.Hide();
                    }
                }

                if (role.Text == "学生")
                {
                    sql = "SELECT lxy_sno09,lxy_spass09 FROM Lixy_student09" + "  where lxy_sno09=" + "'" + txtName.Text + "'";
                    ds = con.Getds(sql);
                    string DeptNo1 = ds.Tables[0].Rows[0][0].ToString();
                    string DeptNo2 = ds.Tables[0].Rows[0][1].ToString();
                    if (txtName.Text != DeptNo1.Trim() || txtPwd.Text != DeptNo2.Trim())
                        MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        globaldata.passData = txtName.Text;
                        frmstu fmain = new frmstu();
                        fmain.Show();
                        this.Hide();
                    }
                }

                if (role.Text == "教师")
                {
                    sql = "SELECT lxy_tno09,lxy_tpass09 FROM Lixy_teacher09" + "  where lxy_tno09=" + "'" + txtName.Text + "'";
                    ds = con.Getds(sql);
                    string DeptNo1 = ds.Tables[0].Rows[0][0].ToString();
                    string DeptNo2 = ds.Tables[0].Rows[0][1].ToString();
                    if (txtName.Text != DeptNo1.Trim() || txtPwd.Text != DeptNo2.Trim())
                        MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        globaldata.passData = txtName.Text;
                        FrmTea fmain = new FrmTea();
                        fmain.Show();
                        this.Hide();
                    }
                }
                con.closeConnect();
            }
            catch(Exception e_)
            {
                MessageBox.Show("错误的账户名","错误提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 角色_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
