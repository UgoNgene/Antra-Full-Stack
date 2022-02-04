using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{

    abstract class Person 
    {

        private int age;
        private decimal salary;
        private List<String> address = new List<string>();

        public abstract string Name();

        public int Age
        {
            get { return age; }
            set { age = value;}
        }
        public decimal Salary {
            get { return salary; }
            set {
                if (value > 0) salary = value;
                else Salary = 0;
            }
        }

        void CalculateSalary()
        {
            salary = 0;
        }
        protected void SetAddress(params string[] addies){
            
             foreach(String addresses in addies){
                address.Add(addresses);
            }
        }
 
    }

    class Student : Person
    {
        private List<String> courses = new List<string>();
        private double gpa;
        private List<Char> letterGrade = new List<Char>();
        private DateTime joinDate;

        Student(string studentID){
            
        }

        void CalculateSalary(double s)
        {
            s = 0.5 * (DateTime.Now.Year-joinDate.Year) ;
        }
        public override string Name()
        {
            Console.Write("Enter Name = ");
            String Name = Console.ReadLine();
            return Name;
        }

        protected void CalculateGpa(List<Char> letterGrade)
        {


        }
    }

    class Instructor : Person
    {

        public override string Name()
        {
            throw new NotImplementedException();
        }
    }

    class Course: ICourseService
    {
        List<String> enrolled = new List<string>();

        public void newCourse()
        {
            
        }
    }
}
