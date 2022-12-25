namespace prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startnum, endnum, i, j; 
            Console.WriteLine("please, enter the starting number ");
             startnum = int.Parse(Console.ReadLine());

            Console.WriteLine(" please, enter the end number ");
             endnum = int.Parse (Console.ReadLine());

            Console.WriteLine("the list of the prime numbers from stating number ana end number is :");

            for (i = startnum;i<= endnum; i++)
            {     if (i==0 || i==1)
                    continue;
                for ( j = 2; j <=i; j++)
                {
                    if (i % j == 0)
                        break;                   
                }
              if (i==j)
                    Console.WriteLine(i);
            } 
        }
    }
}