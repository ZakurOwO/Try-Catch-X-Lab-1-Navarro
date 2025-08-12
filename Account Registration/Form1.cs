using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_Registration
{



    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public class StudentInfoClass
        {
            public delegate long DelegateNumber(long number);
            public delegate string DelegateText(string txt);

            public static String FirstName = " ";
            public static String LastName = " ";
            public static String MiddleName = " ";
            public static String Address = " ";
            public static String Program = " ";
            public static long Age = 0;
            public static long ContactNo = 0;
            public static long StudentNo = 0;

            public static String GetFirstName(string FirstName)
            {
                return FirstName;
            }
            public static String GetLastName(string LastName)
            {
                return LastName;
            }
            public static String GetMiddleName(string MiddleName)
            {
                return MiddleName;
            }
            public static String GetAddress(string Address)
            {
                return Address;
            }
            public static String GetProgram(String Program)
            {
                return Program;
            }
            public static long GetAge(long Age)
            {
                return Age;
            }
            public static long GetContactNo(long ContactNo)
            {
                return ContactNo;
            }
            public static long GetStudentNo(long StudentNo)
            {
                return StudentNo;
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            StudentInfoClass.FirstName = FirstNameTextBox.Text;
            StudentInfoClass.LastName = LastNameTextBox.Text;
            StudentInfoClass.MiddleName = MiddleNameTextBox.Text;
            StudentInfoClass.Address = AddressTextBox.Text;
            StudentInfoClass.Program = ProgramTextBox.Text;
            StudentInfoClass.Age = long.Parse(AgeTextBox.Text);
            StudentInfoClass.ContactNo = long.Parse(ContactNoTextBox.Text);
            StudentInfoClass.StudentNo = long.Parse(StudentNoTextBox.Text);

            
            Form2 frmConfirm = new Form2();
            if (frmConfirm.ShowDialog() == DialogResult.OK)
            {
            
                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
                MiddleNameTextBox.Clear();
                AddressTextBox.Clear();
                ProgramTextBox.Clear();
                AgeTextBox.Clear();
                ContactNoTextBox.Clear();
                StudentNoTextBox.Clear();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
