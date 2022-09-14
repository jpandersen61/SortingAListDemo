using System;
using System.Collections.Generic;

namespace SortingAListDemo
{
    enum ComparisonMethods
    {
        methIComparer,
        methIComparable,
        methDelegate,
        methNone
    }

    class Program
    {
        const ComparisonMethods method = ComparisonMethods.methNone;

        //Implementing IComparer<Student>
        static int Compare(Student s1, Student s2)
        {
            //This is equivalent to happens in the next line
            //IComparable<string> ic = s1.Name;
            //int result = ic.CompareTo(s2.Name);
            int result = s1.Name.CompareTo(s2.Name);
            return result;
        }

        static void Main(string[] args)
        {
            //Setting up stuff for IComparer method
            StudentComparer sc = new StudentComparer();
            IComparer<Student> isc = sc;

            //Setting up stuff for delegate method
            Comparison<Student> compareMethod = Compare;

            //Creating list
            List<Student> sList = new List<Student>();
            Student s1 = new Student() { Number = 1, Name = "John" };
            Student s2 = new Student() { Number = 2, Name = "James" };
            Student s3 = new Student() { Number = 3, Name = "James" };
            Student s4 = new Student() { Number = 4, Name = "Jane" };
            Student s5 = new Student() { Number = 5, Name = "John" };

            sList.Add(s1);
            sList.Add(s2);
            sList.Add(s3);
            sList.Add(s4);
            sList.Add(s5);

            //Selecting the method
            switch (method)
            {
                case ComparisonMethods.methIComparer:
                    //Sorting by using IComparer<Student>
                    sList.Sort(isc);
                    break;

                case ComparisonMethods.methIComparable:
                    //Sorting by using IComparable<Student>
                    sList.Sort();
                    break;

                case ComparisonMethods.methDelegate:
                    //By using Comparison<Student> delegate
                    sList.Sort(compareMethod);
                    break;

                default:
                    //We reach here if no methNone is chosen
                    break;
            }

            Console.WriteLine("Student list");
            foreach (var s in sList)
            {
                Console.WriteLine(s);
            }
        }
    }
}
