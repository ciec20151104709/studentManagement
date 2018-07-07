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
    public partial class SelectNewCourse : Form
    {
        public string Sno;
        public SelectNewCourse(string str)
        {
            this.Sno = str;
            InitializeComponent();
        }

        private void SelectNewCourse_Load(object sender, EventArgs e)
        {
            string constr = "server=111.231.69.100;port=3306;uid=linge;password=123456;Database=linge";
            string cmdstr = string.Format("select Course.Cno,Cname from SC,Course where SC.Sno='{0}' AND SC.Cno=Course.Cno", Sno);
            string cmdstr2 = string.Format("select Cno,Cname,Cpno from Course where not exists(select 1 from SC where SC.Cno=Course.Cno AND SC.Sno='{0}')", Sno);

            MySqlConnection mycon = new MySqlConnection(constr);
            MySqlConnection mycon1 = new MySqlConnection(constr);
            mycon1.Open();
            mycon.Open();

            MySqlCommand cmd = new MySqlCommand(cmdstr, mycon);
            MySqlDataReader reader = cmd.ExecuteReader();

            MySqlCommand cmd1 = new MySqlCommand(cmdstr2, mycon1);
            MySqlDataReader reader1 = cmd1.ExecuteReader();

            object[] value = new object[10];
            this.dataGridView1.Rows.Clear();
            while (reader.Read())
            {
                int index = this.dataGridView1.Rows.Add();
                for (int i = 0; i < reader.GetValues(value); i++)
                {
                    this.dataGridView1.Rows[index].Cells[i].Value = reader[i].ToString();
                }
            }

            object[] value1 = new object[10];
            this.dataGridView2.Rows.Clear();
            while (reader1.Read())
            {
                int index1 = this.dataGridView2.Rows.Add();
                for (int i = 0; i < reader1.GetValues(value1); i++)
                {
                    this.dataGridView2.Rows[index1].Cells[i].Value = reader1[i].ToString();
                }
            }
            mycon.Close();
            mycon1.Close();
            private void button1_Click(object sender, EventArgs e)
            {
                string constr = "server=111.231.69.100;port=3306;uid=linge;password=123456;Database=linge";
                string cmdstr = string.Format("insert into SC values('{0}','{1}',null)", this.Sno, textBox1.Text);
                MySqlConnection mycon = new MySqlConnection(constr);
                mycon.Open();
                try
                {
                    MySqlCommand cmd = new MySqlCommand(cmdstr, mycon);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("选课成功");
                    mycon.Close();
                }
                catch
                {
                    MessageBox.Show("选课失败！");
                }
            }
        }
    }
}