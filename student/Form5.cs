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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        string strcon = "Server=TC-PC;Integrated Security=true;DataBase=学生";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“学生DataSet.course”中。您可以根据需要移动或删除它。
            this.courseTableAdapter.Fill(this.学生DataSet.course);
            con = new SqlConnection(strcon);
            da = new SqlDataAdapter("select * from course", con);
            ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void 添加_Click(object sender, EventArgs e)
        {
            Form9 f2 = new Form9();
            f2.Show();
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e)
        { this.Close(); }
        private void button3_Click(object sender, EventArgs e)
        {
            string str = dataGridView1.SelectedCells[0].Value.ToString();
            string sql = "delete  from course where cno='" + str + "'";
            string consqlserver = "Server=TC-PC;Integrated Security=true;DataBase=学生";
            SqlConnection con = new SqlConnection(consqlserver);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("您已成功删除数据！");
            da.Update(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}

    }
}
