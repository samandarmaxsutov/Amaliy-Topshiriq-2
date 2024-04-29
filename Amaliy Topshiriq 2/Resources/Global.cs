using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliy_Topshiriq_2.Resources
{
    internal  class Global
    {
        private static Global globalA = null;
        public  List<StudentDataClass> studentsList = new List<StudentDataClass>();
        private int lastID = 1;
        private Global() {

            

            StudentDataClass student = new StudentDataClass(
                0,
                "Samandar",
                "Maxsutov",
                18,
                "login",
                "parol"
                );
           addStudent( student );
        }
       
        public static Global getGlobal()
        {   if (globalA == null)
            {
                globalA = new Global();
                
            }
            return globalA;
        }

        private Form1 form1 = null;
        private  SignUpScreen signUpScreen = null;
        private  Dashobord dashobord = null;

        public Form1 GetForm1() { 
            if (form1 == null)
                form1 = new Form1();
            return form1; }
        public SignUpScreen GetSignUpScreen() {
            if (signUpScreen == null)
                signUpScreen = new SignUpScreen();
            return signUpScreen; }

        public Dashobord GetDashobord() {
            if (dashobord == null) 
                    dashobord =  new Dashobord();
            return dashobord; 
        }

        public String addStudent(StudentDataClass student)
        {
            student.setID( lastID );
            studentsList.Add(student);
            lastID++;
            return "Student qo'shildi";
        }

        public StudentDataClass GetStudentById(int id)
        {
            foreach (StudentDataClass student in studentsList)
            {
                if(student.getId() == id)
                {
                    return student;
                }
            }
            return null;
        }

        public StudentDataClass FindStudent(string password,string login)
        {
            foreach(StudentDataClass student in studentsList)
            {
                if (student.getPassword() == password && student.getLogin() == login)
                {
                    return student;
                }
            }
            return null;
        }
    }
}
