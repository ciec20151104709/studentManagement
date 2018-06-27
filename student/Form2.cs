using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static Form fr = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if (fr == null)
            {
                Form3 fr2 = new Form3();
                fr2.Show();
                MessageBox.Show("您已成功进入----学生管理！");
            }
            else
            {
                fr.TopLevel = true;
            }
        }
        public static Form fw = null;
        private void button2_Click(object sender, EventArgs e)
        {
            if (fw == null)
            {
                Form4 fw3 = new Form4();
                fw3.Show();
                MessageBox.Show("您已成功进入----成绩信息！");
            }
            else
            {
                fw.TopLevel = true;
            }
        }
        public static Form fe = null;
        private void button3_Click(object sender, EventArgs e)
        {
            if (fe == null)
            {
                Form5 fe2 = new Form5();
                fe2.Show();
                MessageBox.Show("您已成功进入----选课信息！");
            }
            else
            {
                fe.TopLevel = true;
            }
        }
        public static Form fu = null;
        private void button4_Click(object sender, EventArgs e)
        {
            if (fu == null)
            {
                Form10 fr2 = new Form10();
                fr2.Show();
                MessageBox.Show("您已成功进入----用户管理！");
            }
            else
            {
                fr.TopLevel = true;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
