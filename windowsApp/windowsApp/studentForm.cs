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
    public partial class studentForm : Form
    {
        public studentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            student stu = new student();
            person person = new person();
            person.p_id = Convert.ToInt32(textBox1.Text);
            person.FirstName = textBox2.Text;
            person.LastName = textBox3.Text;
            person.n_cod = Convert.ToInt32(textBox4.Text);
            person.address = textBox5.Text;
            person.phone = textBox6.Text;
            person.personType = "student";
            stu.p_id = Convert.ToInt32(textBox1.Text);
            stu.enteringDate = System.DateTime.Now;

            db.persons.Add(person);
            db.students.Add(stu);
            db.SaveChanges();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void studentForm_Load(object sender, EventArgs e)
        {
            Model1 db = new Model1();
            //person p = new person();
            //student s = new student();
            List<showStudent> students = (from pe in db.persons
                                          join st in db.students on pe.p_id equals st.p_id
                                          where
                                              pe.personType == "student"
                                          select (new showStudent()
                                          {
                                              p_id = pe.p_id,
                                              FirstName = pe.FirstName,
                                              LastName = pe.LastName,
                                              n_cod = pe.n_cod,
                                              address = pe.address,
                                              phone = pe.phone,
                                              enteringDate = st.enteringDate

                                          })).ToList();
            foreach (var item in students)
            {
                dataGridView1.Rows.Add(item.p_id, item.FirstName, item.LastName, item.n_cod, item.address, item.phone, item.enteringDate);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentForm studentform = new studentForm();
            Form1 mainForm = new Form1();
            studentform.Hide();
            mainForm.Show();
        }
    }
}
