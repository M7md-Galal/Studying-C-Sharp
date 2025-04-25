namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employees
            {
                Id = 1,
                Salary = 5000,
                securityLevel = SecurityLevel.Developer,
                HireDate = 22,
                Gender = 'M'
            };
            Console.WriteLine(emp.ToString());

            Employees[] employees = new Employees[3];

            employees[0] = new Employees
            {
                Id = 1,
                Salary = 5000,
                securityLevel = SecurityLevel.Developer,
                HireDate = 22,
                Gender = 'M'
            };
            employees[1] = new Employees
            {
                Id = 2,
                Salary = 6000,
                securityLevel = SecurityLevel.Secretary,
                HireDate = 22,
                Gender = 'F'
            };
            employees[2] = new Employees
            {
                Id = 3,
                Salary = 7000,
                securityLevel = SecurityLevel.SecurityOfficer,
                HireDate = 22,
                Gender = 'M'
            };


            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
            }


        }
    }
}
