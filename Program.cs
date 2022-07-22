namespace LineComparisionProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, y1, x2, y2, x3, y3, x4, y4;
            double length_l1, length_l2;

            Console.WriteLine("Line Comparison Problem");

            Console.WriteLine("Enter values x1,y1 and x2,y2 of line1");
            var l1 = Console.ReadLine();
            var l1_values = l1.Split(' ');
            x1 = Convert.ToInt32(l1_values[0]);
            y1 = Convert.ToInt32(l1_values[1]);
            x2 = Convert.ToInt32(l1_values[2]);
            y2 = Convert.ToInt32(l1_values[3]);

            Console.WriteLine("Enter values x3,y3 and x4,y4 of line2");
            var l2 = Console.ReadLine();
            var l2_values = l2.Split(' ');
            x3 = Convert.ToInt32(l2_values[0]);
            y3 = Convert.ToInt32(l2_values[1]);
            x4 = Convert.ToInt32(l2_values[2]);
            y4 = Convert.ToInt32(l2_values[3]);

            length_l1 = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            length_l2 = Math.Sqrt((Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2)));

            if (length_l1 == length_l2)
                Console.WriteLine("Both Lines are Equal");
            else if (length_l1 > length_l2)
                Console.WriteLine("Line1 is grater than Line2");
            else
                Console.WriteLine("Line2 is greater than Line1");

        }
    }
}