using System;
public class Exercise25
{
    public static void Main()
    {
        bool loop = true;
        while (loop)
        {
            Console.Clear();
            int num1, num2, opt;



            Console.Write("----------------------calculator-------------------------\n");



            Console.Write("Enter the first Number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second Number :");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.Write("\nMenu :\n");
            Console.Write("1.+\n2.-\n3.*\n4./\n5.Exit\n");
            Console.Write("\nInput your choice :");
            opt = Convert.ToInt32(Console.ReadLine());
            //int result;


           /* static int Addition(int num1, int num2)
            {
                int result = num1 + num2;
                return result;
              
            }*/



         
                switch (opt)
                {
                    case 1:
                       // result = Addition(num1, num2);
                        Console.Write("The Addition of  {0} and {1} is: {2}\n", num1, num2, num1 + num2);
                        break;

                    case 2:
                        Console.Write("The Substraction of {0}  and {1} is: {2}\n", num1, num2, num1 - num2);
                        break;

                    case 3:
                        Console.Write("The Multiplication of {0}  and {1} is: {2}\n", num1, num2, num1 * num2);
                        break;

                    case 4:
                        if (num2 == 0)
                        {
                            Console.Write("The second integer is zero. Devide by zero.\n");
                        }
                        else
                        {
                            Console.Write("The Division of {0}  and {1} is : {2}\n", num1, num2, num1 / num2);
                        }
                        break;

                    case 5:
                        break;

                    default:
                        Console.Write("Input correct option\n");
                        break;

                }
            return;
           

           


        }

    }
}
