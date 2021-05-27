using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignatureLibrary
{
    public class Signature
    {   /// <summary>
    /// Method to print header at the start of a console application
    /// </summary>
    /// <param name="title"> Title to display </param>
        public static void Hseader(string title)
        {
            Console.Title = title;
            Console.WriteLine("CSF2: Homework" + title );
        }
    }
}
