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
            double G = Double.Parse(grade);

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
                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Max().ToString();
            double max = 0;
            for (int i = 1; i <= dataGridView1.Rows.Count - 1; i++)
            {
                if (max < double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()))
                {
                    max = double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                }
            }

            Max.Text = max.ToString();

            double[] cmax = new double[dataGridView1.Rows.Count];
            cmax = (from DataGridViewRow row in dataGridView1.Rows
                 where row.Cells[1].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();
            
            Max.Text = cmax.Max().ToString();

            //Min 
            Min.Text = (from DataGridViewRow row in dataGridView1.Rows
                        where row.Cells[1].FormattedValue.ToString() != string.Empty
                        select Convert.ToDouble(row.Cells[4].FormattedValue)).Min().ToString();
            double min = 0;
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                if (min < double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString()))
                {
                    min = double.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
            }

            Min.Text = min.ToString();

            double[] cmin = new double[dataGridView1.Rows.Count];
            cmin = (from DataGridViewRow row in dataGridView1.Rows
                  where row.Cells[1].FormattedValue.ToString() != string.Empty
                  select Convert.ToDouble(row.Cells[4].FormattedValue)).ToArray();

            Min.Text = cmin.Min().ToString();

            //Sum of study
            int nr = dataGridView1.Rows.Count;
            ST.Text = nr.ToString();

        

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}