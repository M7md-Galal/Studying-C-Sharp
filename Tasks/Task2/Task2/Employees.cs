using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA,
        SecurityOfficer
    }
    internal class Employees
    {
        public int Id { get; set; }
        //public int Securitylevel { get; set; }
        public SecurityLevel securityLevel { get; set; }
        public int Salary { get; set; }
        public int HireDate { get; set; }
        //public int Gender { get; set; }
        private char gender;
        public char Gender
        {
            get { return gender; }
            set 
            {
                if (value == 'M' || value == 'F')
                    gender = value;
                else
                    throw new ArgumentException("Gender Must be M or F Only");
            }
        }

        public override string ToString()
        {
            return $"Employee ID    : {Id}\n" +
                   $"Security Level : {securityLevel}\n" +
                   $"Salary         : {Salary}\n" +
                   $"Hiring Data    : {HireDate}\n" +
                   $"Gender         : {Gender}";
        }
    }
}
