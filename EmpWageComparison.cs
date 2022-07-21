namespace LineComparisionProblem

{
    class EmpWageComputation
    {
        static void Empwage(string[] args)
        {
            int employeePresent = 2;
            int employeePartTimePresent = 1;
            int EMP_RATE_PER_HOUR = 20;

            int empWage = 0;
            int empHrs = 0;

            Random random = new Random();

            int empCheck = random.Next(0, 2);

            if (employeePartTimePresent == empCheck)
            {
                Console.WriteLine("Employee is present");
                empHrs = 4;
            }
            else if (employeePresent == empCheck)
            {
                Console.WriteLine("Employee is present");
                empHrs = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }
}
