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
    public partial class FrmTea : Form
    {
        public FrmTea()
        {
            InitializeComponent();
        }

        private void FrmTea_Load(object sender, EventArgs e)
        {

        }

        private void 成绩录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frmtea_course ftc = new Frmtea_course();
            ftc.Show();
        }

        private void FrmTea_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("您确定要退出系统吗？", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Application.ExitThread();
            else
                e.Cancel = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frmtea_grade fg = new Frmtea_grade();
            fg.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            changetea ct = new changetea();
            ct.Show();
        }
    }
}
