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
    public partial class DelectStudent : Form
    {
        public partial class DeleteStudent : Form
        {
            public DeleteStudent()
            {
                InitializeComponent();
            }

            private void button1_Click(object sender, EventArgs e)
            {
                string constr = "server=111.231.69.100;port=3306;uid=linge;password=123456;Database=linge";
                string cmdstr = "select Student.Sno,Sname,Ssex,Sage,Sdept,Course.Cname,SC.Grade from Student,SC,Course where Student.Sno=SC.Sno AND SC.Cno=Course.Cno";

                MySqlConnection mycon = new MySqlConnection(constr);
                mycon.Open();

                MySqlCommand cmd = new MySqlCommand(cmdstr, mycon);
                MySqlDataReader reader = cmd.ExecuteReader();

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
            }

            private void button2_Click(object sender, EventArgs e)
            {
                string constr = "server=111.231.69.100;port=3306;uid=linge;password=123456;Database=linge";
                string cmdstr1 = string.Format("delete from Student where Sno='{0}'", textBox1.Text);

                MySqlConnection mycon1 = new MySqlConnection(constr);
                mycon1.Open();

                MySqlCommand cmd1 = new MySqlCommand(cmdstr1, mycon1);



                string cmdstr3 = string.Format("delete from SC where Sno='{0}'", textBox1.Text);

                MySqlConnection mycon3 = new MySqlConnection(constr);
                mycon3.Open();

                MySqlCommand cmd3 = new MySqlCommand(cmdstr3, mycon3);


                string cmdstr4 = string.Format("delete from student_table where uid='{0}'", textBox1.Text);

                MySqlConnection mycon4 = new MySqlConnection(constr);
                mycon4.Open();

                MySqlCommand cmd4 = new MySqlCommand(cmdstr4, mycon4);


                try
                {
                    cmd1.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    MessageBox.Show("删除成功");
                    textBox1.Text = "";
                }
                catch
                {
                    MessageBox.Show("删除失败");
                }
            }
        }
    }
