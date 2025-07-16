using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCS
{
    internal class Assignment2
    {
        static void Main()
        {
            int chem, phy, math;
            Console.WriteLine("Enter Math marks:");
            math = Convert.ToInt16(Console.ReadLine()); 
            Console.WriteLine("Enter Physics marks:");
            phy = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Chem marks:");
            chem = Convert.ToInt16(Console.ReadLine());
            int total = math + phy + chem;
            int totalmathphy = math + phy;
            if(math >= 65 && phy >= 55 && chem >= 50 &&
            (total >= 180 || totalmathphy >= 140))
        {
                Console.WriteLine("Eligible ");
            }
        else
            {
                Console.WriteLine("Not Eligible");
            }
        }
    }
}
