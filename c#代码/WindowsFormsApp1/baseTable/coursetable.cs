using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.baseTable
{
    public partial class courseTable : Form
    {
        public courseTable()
        {
            InitializeComponent();
        }

        private void courseTable_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string classname = comboBoxcourse.Text;
            string sql = "select lxy_cname09 课程名称名称,lxy_ccredit09 学分,lxy_cterm09 开课学期 from Lixy_class09 a,Lixy_course09 b,Lixy_rangecourse09 c where a.lxy_clno09=c.lxy_clno09 and b.lxy_cno09=c.lxy_cno09 and lxy_clname09='" + classname + "'";
            DataTable dt = sqlhelper.GetDataTable(sql);
            dataGridViewcourse.DataSource = dt;
        }
    }
}
