using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace SortingAListDemo
{
    class Student : IComparable<Student>
    {        
        public int Number { get; set; }
        public string Name { get; set; }

        //Implementation of the IComparable interface
        public int CompareTo(Student other)
        {
            //This is equivalent to happens in the next line
            //IComparable<string> ic = Name;
            //int result = ic.CompareTo(other.Name);
            int result = Name.CompareTo(other.Name);
            return result;
        }

        public override string ToString()
        {
            return $"{Number} - {Name}";
        }

    }
}
