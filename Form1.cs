using System;

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
            
           //Student M  = new Student("Titan",2003);
            //Student M2 = new Student("Te",2003);
            //Student M3 = new Student("Tes",2003);
            //M.name= "Titan";
            //M.id = "1";
            //M._age = 2;
            //M.birth = 2003;
            // M2.name = "Te";
            // M2.id = "2";
            // M2._age = 3;
            // M3.name = "Tes";
            // M3.id = "3";
            //M3._age = 4;
            

            //int MA = 2023 - M.birth;
            //Name.Text = st[0];
           // Birth.Text = M.birth.ToString();
            //Age.Text = MA.ToString();
            //AVG.Text = myAge().ToString();

            //Name.Text = M.id;


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

            int L = 0 + G;

            
            

           //// if (n != 0)
          //  { list.Add(newStudent);
       // } while (n != 0);
            //this.AVG.Text=string.Format("Max {0}",list.Max().ToString());
            //this.AVG.Text = string.Format(L.ToString());
            


            BindingSource source = new BindingSource();
            source.DataSource = this.list;
            this.dataGridView1.DataSource = source;
            
            this.Name.Text = "";
            this.Birth.Text = "";
            this.ID.Text = "";
            this.Height.Text = "";
            this.Grade.Text = "";
            this.Major.Text = "";

            //BindingList<Student> blist= new BindingList<Student>(this.list);
            //BindingSource bs = new BindingSource(blist,null);
            //this.dataGridView1= new DataGridView();
            Max.Text = (from DataGridViewRow row in dataGridView1.Rows
                      where row.Cells[1].FormattedValue.ToString() != string.Empty
                      select Convert.ToInt32(row.Cells[4].FormattedValue)).Max().ToString();


            // Max
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

            //test
            int st= 0;
            if

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Name.Text = "";
            this.Birth.Text = "";
            this.ID.Text = "";
            this.Height.Text = "";
           this.Grade.Text = "";
            this.Major.Text = "";
        }

        
    }
}