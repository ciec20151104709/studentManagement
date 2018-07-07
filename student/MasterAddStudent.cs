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
    public partial class MasterAddStudent : Form
    {
        public partial class MasterAddStudent : Form
        {
            public MasterAddStudent()
            {
                InitializeComponent();
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                Form tempChild = this.ActiveMdiChild;
                MySqlConnection con;
                string constr = "server=111.231.69.100;port=3306;uid=linge;password=123456;Database=linge";
                con = new MySqlConnection(constr);

                try
                {
                    con.Open();
                    string str1 = string.Format("insert into Student values('{0}','{1}','{2}',{3},'{4}')", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                    MySqlCommand cmd1 = new MySqlCommand(str1, con);

                    string str2 = string.Format("insert into student_table values('{0}','123456')", textBox1.Text);
                    MySqlCommand cmd2 = new MySqlCommand(str2, con);

                    if (cmd1.ExecuteNonQuery() > 0)
                    {
                        cmd2.ExecuteNonQuery();
                        if (tempChild != null)
                        {
                            foreach (Control control in tempChild.Controls)
                            {
                                if (control is TextBox)
                                {
                                    control.Text = "";
                                }
                            }
                        }

                    }
                    MessageBox.Show("数据已记录！");
                    con.Close();
                }
                catch
                {

                    MessageBox.Show("当前输入的学号或名字有重复\n插入数据失败！");
                }


            }

            private void textBox1_TextChanged(object sender, EventArgs e)
            {

            }
        }
    }

