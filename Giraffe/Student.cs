using System;

namespace Giraffe
{
    class Student
    {
        // These variables are called class attributes

        public string name;
        public string major;
        public double gpa;


        public Student(string aName, string aMajor, double aGpa)
        {
            gpa = aGpa;
            name = aName;
            major = aMajor;


        }

        public Student()
        {

        }

        public bool HasHonors()
        {
            if(gpa >= 3.5)
            {
                return true;

            }
            return false;
        }
    }
}
