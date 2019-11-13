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
    public struct Student
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public string Sex { get; set; }
        public string Classid { get; set; }
        public string Birthdate { get; set; }
        public void SetValues(string name, string id, string sex, string classid, string birthdate)
        {
            Name = name;
            Id = id;
            Sex = sex;
            Classid = classid;
            Birthdate = birthdate;
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != null)
            {
                foreach (Student student in students)
                    if (student.Id == comboBox1.Text)
                    {
                        textBox1.Text = student.Id;
                        textBox2.Text = student.Sex;
                        textBox3.Text = student.Name;
                        textBox4.Text = student.Classid;
                        textBox5.Text = student.Birthdate;
                    }
            }
        }

        Student[] students = new Student[10];
        private void Form1_Load(object sender, EventArgs e)
        {
            students[0].SetValues("曹打龙", "1010270802", "女", "03", "01-21");
            students[1].SetValues("曹刺客", "1010270805", "男", "02", "12-01");
            students[2].SetValues("曹打野", "1010270807", "男", "01", "12-03");
            students[3].SetValues("曹上单", "1010270808", "女", "03", "12-04");
            students[4].SetValues("曹下单", "1010270809", "男", "03", "10-31");
            students[5].SetValues("曹辅助", "101027080A", "女", "02", "02-28");
            students[6].SetValues("曹射手", "101027080B", "女", "02", "03-29");
            students[7].SetValues("曹太坑", "101027080C", "男", "01", "04-31");
            students[8].SetValues("曹法师", "101027080D", "女", "02", "01-31");
            students[9].SetValues("曹反野", "101027080E", "女", "02", "01-11");
            comboBox1.DataSource = students;
            comboBox1.DisplayMember = "Id";
            comboBox1.ValueMember = "Id";
            comboBox1.Text = "";
        }
    }
}
