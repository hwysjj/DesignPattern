using System;
namespace Strategy
{
    public class StudentAgeComparator : Comparator<Student>
    {
        public int Compare(Student o1, Student o2)
        {
            if (o1.Age > o2.Age)
            {
                return 1;
            }
            else if (o1.Age == o2.Age)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
