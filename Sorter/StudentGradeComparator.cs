using System;
namespace Strategy
{
    public class StudentGradeComparator : Comparator<Student>
    {
        public int Compare(Student o1, Student o2)
        {
            if(o1.Grade > o2.Grade)
            {
                return 1;
            }
            else if (o1.Grade == o2.Grade)
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
