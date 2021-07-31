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
    public partial class Frmstu_course : Form
    {
        public Frmstu_course()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string term = comboBox1.Text;
            int cterm = 0 ;
            if (term == "大一上")
                cterm = 1;
            else if (term == "大一下")
                cterm = 2;
            else if (term == "大二上")
                cterm = 3;
            else if (term == "大二下")
                cterm = 4;
            else if (term == "大三上")
                cterm = 5;
            else if (term == "大三下")
                cterm = 6;
            else if (term == "大四上")
                cterm = 7;
            else
                cterm = 8;
            sqlConnect con = new sqlConnect();
            string sql =
                "select a.lxy_cname09 课程名称 ,a.lxy_ccredit09 学分 from Lixy_course09 a,Lixy_student09 b,Lixy_class09 c,Lixy_rangecourse09 d where a.lxy_cterm09 = "+ cterm +"and b.lxy_clno09 = c.lxy_clno09 and d.lxy_clno09 = c.lxy_clno09 and d.lxy_cno09 = a.lxy_cno09 and b.lxy_sno09='"+globaldata.passData+"'";
            DataTable dt = sqlhelper.GetDataTable(sql);
            dataGridView1.DataSource = dt;
            con.closeConnect();
        }
    }
}
