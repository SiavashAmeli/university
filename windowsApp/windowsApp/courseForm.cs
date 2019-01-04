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
    public partial class courseForm : Form
    {
        public Model1 db = new Model1();
        
        public courseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             course co = new course();
            co.course_cod =Convert.ToInt32( textBox1.Text);
            co.name = textBox2.Text;
            co.units_number = Convert.ToInt32(textBox3.Text);
            db.courses.Add(co);
            db.SaveChanges();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            
        }

        private void courseForm_Load(object sender, EventArgs e)
        {
            List<course> co= (from c in db.courses select c).ToList();
            foreach (var item in co)
            {
                dataGridView1.Rows.Add(item.course_cod, item.name, item.units_number);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            courseForm courseform = new courseForm();
            Form1 mainForm = new Form1();
            courseform.Hide();
            mainForm.Show();
        }
    }
}
