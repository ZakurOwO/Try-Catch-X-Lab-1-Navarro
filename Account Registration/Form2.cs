using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Account_Registration.Form1;

namespace Account_Registration
{
    public partial class Form2 : Form
    {
        private StudentInfoClass.DelegateText DelProgram;
        private StudentInfoClass.DelegateText Name;
        private StudentInfoClass.DelegateText DelAddress;
        private StudentInfoClass.DelegateNumber DelAge;
        private StudentInfoClass.DelegateNumber DelContactNo;
        private StudentInfoClass.DelegateNumber DelStudentNo;

        public Form2()
        {
            InitializeComponent();


            DelProgram = new StudentInfoClass.DelegateText(StudentInfoClass.GetProgram);
            Name = new StudentInfoClass.DelegateText(StudentInfoClass.GetLastName);
            DelAddress = new StudentInfoClass.DelegateText(StudentInfoClass.GetAddress);
            DelAge = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetAge);
            DelContactNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudentNo = new StudentInfoClass.DelegateNumber(StudentInfoClass.GetStudentNo);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            LabelProgram.Text = DelProgram(StudentInfoClass.Program);
            LabelLastName.Text = Name(StudentInfoClass.LastName);
           
            
            LabelAge.Text = DelAge(StudentInfoClass.Age).ToString();
            LabelContactNo.Text = DelContactNo(StudentInfoClass.ContactNo).ToString();
            LabelStudentNo.Text = DelStudentNo(StudentInfoClass.StudentNo).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}