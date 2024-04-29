using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amaliy_Topshiriq_2.Resources
{
    internal class StudentDataClass
    {   private int id;
        private String firstName;
        private String lastName;
        private int age;
        private String login;
        private String password;

        public StudentDataClass (int id, String firstName,String lastName, int age,String login, String password)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.login = login;
            this.password = password;
        }
        public StudentDataClass() { }
        public int getId() { return id; }
        public String getFirstName() { return firstName; }
        public String getLastName() { return lastName; }
        public int getAge() { return age; }
            
        public String getLogin() { return login; }
            
        public String getPassword() { return password; }

        public void setName(String firstName)
        {
            this.firstName = firstName;
        }
        public void setLastName(String lastName)
        {
            this.lastName=lastName;
        }
        public void setAge(int age) {  this.age = age; }
        public void setLogin(String login) {  this.login = login; }
        public void setPassword(String password) {  this.password = password; }

        public void setID(int id) { this.id = id;}
    }
}
