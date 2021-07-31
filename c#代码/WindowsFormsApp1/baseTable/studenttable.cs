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
    public partial class studentTable : Form
    {
        public studentTable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string classname = comboBoxstudent.Text;
            string sql = "select lxy_sno09 学号,lxy_sname09 姓名,lxy_gotcredit09 已修学分 from Lixy_student09 a,Lixy_class09 b where a.lxy_clno09 = b.lxy_clno09 and b.lxy_clname09 ='" + classname + "'";
            DataTable dt = sqlhelper.GetDataTable(sql);
            dataGridViewstudent.DataSource = dt;
        }
    }
}
