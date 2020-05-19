using System;
using System.Linq;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var stu1 = new Student("Jack", 100, 18);
            var stu2 = new Student("Helen", 98, 22);
            var stu3 = new Student("May", 99, 29);

            Student[] stuArrComparable = { stu1, stu2, stu3 };
            Student[] stuArrAgeComparator = { stu1, stu2, stu3 };
            Student[] stuArrGradeComparator = { stu1, stu2, stu3 };

            // Comparable only can sort by the specific property defined in class
            // cannot be extended
            SortWithComparable(stuArrComparable);

            // Comparator using strategy pattern which can sort by any property
            // Easy to extend
            SortWithAgeComparator(stuArrAgeComparator);
            SortWithGradeComparator(stuArrGradeComparator);

            ConsoleWrite(stuArrComparable, "Sorted With Comparable");
            ConsoleWrite(stuArrAgeComparator, "Sorted With Age Comparable");
            ConsoleWrite(stuArrGradeComparator, "Sorted With Grade Comparable");

        }

        static void SortWithComparable(Student[] arr)
        {
            SorterComparable<Student>.Sort(arr);
        }

        static void SortWithAgeComparator(Student[] ageArr)
        {
            SorterComparator<Student>.Sort(ageArr,
                new StudentAgeComparator());
        }

        static void SortWithGradeComparator(Student[] gradeArr)
        {
            SorterComparator<Student>.Sort(gradeArr,
                new StudentGradeComparator());
        }

        static void ConsoleWrite(Student[] arr, string title)
        {
            Console.WriteLine($"\n---{title}---");
            arr.ToList().ForEach(x =>
                Console.WriteLine(x.ToString()));
        }

    }
}
