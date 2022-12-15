using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //c# program write prime numpers from n1 to n2
            int n1, n2, i, j, flag;                        /*n1=number 1
                                                          * n2=number 2
                                                          * i= number of first loop
                                                          * j= number of nested loop
                                                          * flag= condition */
            Console.WriteLine("write the first number");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("write the second number");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine(" the numbers between " + n1 + " and " + n2);

            for (i = 2; i <= n2; i++)
            {
                flag = 1;
                for (j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                    Console.Write(i + " ,");    
                  
            }
        }
    }
}



