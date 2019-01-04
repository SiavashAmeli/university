using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using windowsApp.Model;

namespace windowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            person stu = new person();
            course co = new course();
            //List<course> cours = (from c in db.
            //foreach (var item in cours)
            //{
            //    dataGridView1.Rows.Add(it);
            //}
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Model1 db = new Model1();
            //student stu = new student();
            //person person = new person();
            //person.p_id =Convert.ToInt32( textBox1.Text);
            //person.FirstName = textBox2.Text;
            //person.LastName = textBox3.Text;
            //person.n_cod = Convert.ToInt32(textBox4.Text);
            //person.address = textBox5.Text;
            //person.phone = textBox6.Text;
            //stu.p_id = Convert.ToInt32(textBox1.Text);
            //stu.enteringDate = System.DateTime.Now;

            //db.persons.Add(person);
            //db.students.Add(stu);
            //db.SaveChanges();
            courseForm courseform = new courseForm();
            Form1 mainForm = new Form1();
            mainForm.Hide();
            courseform.Show();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            studentForm studentform = new studentForm();
            mainForm.Hide();
            studentform.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            teacherForm teacherform = new teacherForm();
            Form1 mainForm = new Form1();
            mainForm.Hide();
            teacherform.Show();
        }
    }
}
