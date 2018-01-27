using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input text "False" or "True"
            string stringInput = Console.ReadLine();
            // Convert string variable to boolean 
            bool booleanOutput = Convert.ToBoolean(stringInput);
            //Check if boolean is True print "Yes" if is False print "No"
            Console.WriteLine(booleanOutput ? "Yes":"No");
        }
    }
}
