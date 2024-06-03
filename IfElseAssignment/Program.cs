namespace IfElseAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number == 90 || number > 90)
                Console.WriteLine("A");
            else if (number >= 80 && number <= 89)
                Console.WriteLine("B");
            else if (number >= 70 && number <= 79)
                Console.WriteLine("C");
            else if (number >= 60 && number <= 69)
                Console.WriteLine("D");
            else
                Console.WriteLine("F");
        }
    }
}
