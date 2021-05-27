using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesLibrary;

namespace TesterProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.FirstName = "Lavagust";
            s1.LastName = "Fox";
            s1.Id = "LFox";
            s1.Gpa = 3.5f;
           
            Console.WriteLine(s1);
        }
    }
}
