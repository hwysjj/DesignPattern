using System;
namespace Strategy
{
    public class Student : Comparable<Student>
    {
        public float Grade { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, float grade, int age)
        {
            this.Grade = grade;
            this.Name = name;
            this.Age = age;
        }

        public sbyte CompareTo(Student stu)
        {
            if (this.Grade > stu.Grade)
            {
                return 1;
            }
            else if (this.Grade == stu.Grade)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.Name}, Grade: {this.Grade}, Age: {this.Age};";
        }

    }
}
