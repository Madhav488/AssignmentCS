using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentCS
{
    internal class Assignment2_2
    {
        static void Main()
        {
            double bill,final, chargePerUnit, surcharge=0;
            Console.WriteLine("Enter Id");
            int id = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Units");
            int units = Convert.ToInt16(Console.ReadLine());
            if (units < 200)
            {
                chargePerUnit = 1.20;
            }
            else if (units < 400)
            {
                chargePerUnit = 1.50;
            }
            else if (units < 600)
            {
                chargePerUnit = 1.80;
            }
            else
            {
                chargePerUnit = 2.00;
            }

            
            bill = units * chargePerUnit;

            if (bill > 400)
            {
                surcharge = bill * 0.15;
            }

            final = bill + surcharge;

           
            if (final < 100)
            {
                final = 100;
            }

            
            Console.WriteLine("\nElectricity Bill");
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Customer IDNO : {id}");
            Console.WriteLine($"Customer Name : {name}");
            Console.WriteLine("Unit Consumed : {0}", units);
            Console.WriteLine($"Amount Charges @Rs. {chargePerUnit} per unit : {bill}");
            Console.WriteLine($"Surchage Amount : {surcharge}");
            Console.WriteLine($"Net Amount Paid By the Customer : {final}");
        }
    }
}
