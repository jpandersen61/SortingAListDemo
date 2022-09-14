using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SortingAListDemo
{
    class StudentComparer : IComparer<Student>
    {
        //Implementation of the IComparer interface
        public int Compare(Student x, Student y)
        {
            //This is equivalent to happens in the next line
            //IComparable<string> ic = x.Name;
            //int result = ic.CompareTo(y.Name);
            int result = x.Name.CompareTo(y.Name);
            return result;
        }
    }
}
