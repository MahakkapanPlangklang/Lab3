using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Student
    {
        public string name;
        public string id;
        public int birth;
        public string height;
        public int grade;
        public string major;
        public string st;
        public string demo;
        public int num;

        public Student(string name,int birth, string id, string height, int grade, string major)
        {
            //(string name, string id, int birth, string height, string grade, string major)
            this.name = name;
            this.birth = birth;
            this.id = id;
            this.height = height;
            this.grade = grade;
            this.major = major;
            
        }
        public string Name
        {
            get { return name; }
        }
        public int Birth
        {
            get { return this.birth; }
        }
        public string ID
        {
            get { return this.id; }
        }
        public string Height
        {
            get { return this.height; }
        }
        public int Grade
        {
            get { return this.grade; }
        }
        public string Major
        {
            get { return this.major; }
        }
        public string Demo
        {
            get { return this.major; }
        }
        public int myAge()
        {
            int fAge = 2023 - 4;
            return fAge;
        }

        //public List<int> returnList()
        
            //List<int> GP = new List<int>();
            //GP.Add(1);
            //return GP;
        
    }
}
