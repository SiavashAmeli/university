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
    public partial class teacherForm : Form
    {
        public teacherForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            teacher tea = new teacher();
            person person = new person();
            person.p_id = Convert.ToInt32(textBox1.Text);
            person.FirstName = textBox2.Text;
            person.LastName = textBox3.Text;
            person.n_cod = Convert.ToInt32(textBox4.Text);
            person.address = textBox5.Text;
            person.phone = textBox6.Text;
            person.personType = "teacher";
            tea.p_id = Convert.ToInt32(textBox1.Text);
            tea.degree_of_education = textBox7.Text;
            

            db.persons.Add(person);
            db.teachers.Add(tea);
            db.SaveChanges();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void teacherForm_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
           
            List<showTeacher> students = (from pe in db.persons
                                          join t in db.teachers on pe.p_id equals t.p_id
                                          where
                                              pe.personType == "teacher"
                                          select (new showTeacher()
                                          {
                                              p_id = pe.p_id,
                                              FirstName = pe.FirstName,
                                              LastName = pe.LastName,
                                              n_cod = pe.n_cod,
                                              address = pe.address,
                                              phone = pe.phone,
                                             degree_of_education=t.degree_of_education

                                          })).ToList();
            foreach (var item in students)
            {
                dataGridView1.Rows.Add(item.p_id, item.FirstName, item.LastName, item.n_cod, item.address, item.phone, item.degree_of_education);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teacherForm teacherform = new teacherForm();
            Form1 mainForm = new Form1();
            teacherform.Hide();
            mainForm.Show();
        }
    }
}
