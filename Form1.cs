using System;
using System.Drawing;
using System.Xml.Linq;

namespace LAB3
{
    public partial class Form1 : Form
    {
        List<Student> list = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            string year = Birth.Text;
            string id = ID.Text;
            string height = Height.Text;
            string grade = Grade.Text;
            string major = Major.Text;
            
            int iYear = Int32.Parse(year);
            int G = Int32.Parse(grade);

            Student newStudent = new Student(name,iYear,id,height,G,major);
            this.list.Add(newStudent);
            


            BindingSource source = new BindingSource();
            source.DataSource = this.list;
            this.dataGridView1.DataSource = source;
            
            this.Name.Text = "";
            this.Birth.Text = "";
            this.ID.Text = "";
            this.Height.Text = "";
            this.Grade.Text = "";
            this.Major.Text = "";

            //Max
            Max.Text = (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[1].FormattedValue.ToString() != string.Empty
                        select Convert.ToInt32(row.Cells[4].FormattedValue)).Max().ToString();
            int max = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                if (max < int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()))
                {
                    max = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
            }

            Max.Text = max.ToString();

            int[] cmax = new int[dataGridView1.Rows.Count];
            cmax = (from DataGridViewRow row in dataGridView1.Rows
                 where row.Cells[1].FormattedValue.ToString() != string.Empty
                 select Convert.ToInt32(row.Cells[4].FormattedValue)).ToArray();

            Max.Text = cmax.Max().ToString();

            //Min 
            Min.Text = (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[1].FormattedValue.ToString() != string.Empty
                        select Convert.ToInt32(row.Cells[4].FormattedValue)).Min().ToString();
            int min = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                if (min < int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()))
                {
                    min = int.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
            }

            Min.Text = min.ToString();

            int[] cmin = new int[dataGridView1.Rows.Count];
            cmin = (from DataGridViewRow row in dataGridView1.Rows
                  where row.Cells[1].FormattedValue.ToString() != string.Empty
                  select Convert.ToInt32(row.Cells[4].FormattedValue)).ToArray();

            Min.Text = cmin.Min().ToString();

            //Sum of study
            int nr = dataGridView1.Rows.Count;
            ST.Text = nr.ToString();

        

        }
    }
}