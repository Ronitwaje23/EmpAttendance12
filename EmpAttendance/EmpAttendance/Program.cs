using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpAttendance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to employee wage problam");
            EmpAttendance E=new EmpAttendance();
            E.EmployeeAttendance();
            Console.ReadLine();
        }
    }
}
