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
    public partial class classTable : Form
    {
        public classTable()
        {
            InitializeComponent();
        }

        private void lable1_Click_1(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            string major = comboBoxmajor.Text;
            string sql = "select lxy_clno09 班级编号,lxy_clname09 班级名称 from Lixy_class09 a,Lixy_major09 b where a.lxy_mno09=b.lxy_mno09 and lxy_mname09='"+major+"'";
            DataTable dt = sqlhelper.GetDataTable(sql);
            dataGridViewclass.DataSource = dt;
        }

        private void classTable_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
