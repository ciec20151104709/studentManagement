using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace student
{
    public partial class Formlogin : System.Windows.Forms.Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }
            private void button2_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
            private void textBox3_TextChanged(object sender, EventArgs e)
            {
                MessageBox.Show("学生信息管理系统");
            }
        public static Form fm = null;
        private static int ErrorTimes = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            { MessageBox.Show("提示：请输入用户名和密码！", "警告"); }
            MySqlConnection conn = new MySqlConnection("server=localhost;user = root;password=;Integrated Security=true;DataBase=student");
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from admin where 用户名='" + textBox1.Text.Trim() + "' and 密码='" + textBox2.Text.Trim() + "'", conn);
            MySqlDataReader sdr = cmd.ExecuteReader();
            sdr.Read();
            if (sdr.HasRows)
            {
                MessageBox.Show("登录成功!", "提示");
                Form2 fm = new Form2();
                fm.Show();
                this.Hide();
            }
            else
            {
                ErrorTimes++;
                MessageBox.Show("用户名或密码不正确！您还有" + (3 - ErrorTimes) + "次输入密码的机会，请重新输入!如果超过3次，系统将自动关闭");
                if (ErrorTimes >= 3)
                {
                    ErrorTimes = 0;
                    conn.Close();
                }
            }
        }
    }
}
