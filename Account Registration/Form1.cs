using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

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

            public static String Name = " ";
            public static String Address = " ";
            public static String Program = " ";
            public static long Age = 0;
            public static long ContactNo = 0;
            public static long StudentNo = 0;

            public static String GetName(string Name)
            {
                return Name;
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
            string[] ListOfPrograms = new string[]
            {
                "BS Information Technology",
                "BS Computer Science",
                "BS in Accountancy",
                "BS in Hospitality Management",
                "BS in Tourism Management",
            };
            for (int i = 0; i < 6; i++)
            {
               cbPrograms.Items.Add(ListOfPrograms[i]);
            }
            

        }

        /////return methods 

        public static int SetStudentNo = 0;
        public static int Set_ContactNo = 0;

        public static string SetProgram = " ";
        public static string SetGender = " ";
        public static string SetBirtday = " ";
        public static string SetFullName = " ";


        private string _FullName;
        private long _ContactNo;
        private int _Age;
        private long _StudentNo;
        public long StudentNumber(string studNum)
        {

            _StudentNo = long.Parse(studNum);

            return _StudentNo;
        }

        public long ContactNo(string Contact)
        {
            if (Regex.IsMatch(Contact, @"^[0-9]{10,11}$"))
            {
                _ContactNo = long.Parse(Contact);
            }

            return _ContactNo;
        }

        public string FullName(string LastName, string FirstName, string MiddleInitial)
        {
            if (Regex.IsMatch(LastName, @"^[a-zA-Z]+$") || Regex.IsMatch(FirstName, @"^[a-zA-Z]+$") || Regex.IsMatch(MiddleInitial, @"^[a-zA-Z]+$"))
            {
                _FullName = LastName + ", " + FirstName + ", " + MiddleInitial;
            }

            return _FullName;
        }

        public int Age(string age)
        {
            if (Regex.IsMatch(age, @"^[0-9]{1,3}$"))
            {
                _Age = Int32.Parse(age);
            }

            return _Age;
        }

        private void button1_Click(object sender, EventArgs e)
        {


            StudentInfoClass.Name = LastNameTextBox.Text;
            StudentInfoClass.Name = FirstNameTextBox.Text;
            StudentInfoClass.Name = MiddleNameTextBox.Text;



            StudentInfoClass.Age = long.Parse(AgeTextBox.Text);
            StudentInfoClass.ContactNo = long.Parse(ContactNoTextBox.Text);
            StudentInfoClass.StudentNo = long.Parse(StudentNoTextBox.Text);

            
            this.Hide();

            Form2 frmConfirm = new Form2();
            if (frmConfirm.ShowDialog() == DialogResult.OK)
            {
               
                FirstNameTextBox.Clear();
                LastNameTextBox.Clear();
                MiddleNameTextBox.Clear();
              
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

        private void C_Click(object sender, EventArgs e)
        {

        }

        private void ContactNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
