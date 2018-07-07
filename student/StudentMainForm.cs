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
    public partial class StudentMainForm : Form
    {
        public string Sno;
        public StudentMainForm(string str)
        {
            this.Sno = str;
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "server=111.231.69.100;port=3306;uid=linge;password=123456;Database=linge";
            string cmdstr = string.Format("select Cname,Grade from SC,Course where SC.Sno='{0}' AND SC.Cno=Course.Cno", Sno);


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
                    this.dataGridView1.Rows[index].Cells[i + 5].Value = reader[i].ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = "server=111.231.69.100;port=3306;uid=linge;password=123456;Database=linge";
            string cmdstr = string.Format("select * from Student where Student.Sno='{0}'", Sno);


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
