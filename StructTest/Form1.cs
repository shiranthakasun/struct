using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StructTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        struct Student
        {
            public int Id;
            public string name;

            public int MyProperty { get; set; }
        }

       

        public Form1(string name)
        {
            name = "shirantha";
            name = "Kass";
        }

        public int IncrementId(int stuId)
        {
            int Id=stuId;
            Id++; 


            return Id/0 ;
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            DateTime DateTimeNow=DateTime.Now;
            label1.Text = Convert.ToString(DateTimeNow);

            Student Stu1=new Student();
            Stu1.name = "Kasun";
            Stu1.Id = 12345;

            IncrementId(Stu1.Id);
            label2.Text = Stu1.name;
            label3.Text = Convert.ToString(Stu1.Id);

           

         }
    }
}
