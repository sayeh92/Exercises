using System;
public class Exercise25
{
    public static void Main()
    {
        int num1 = 0;
        int num2 = 0;
        int opt;
        bool loop = true;

       
       while(loop){

            Console.Clear();

            Console.Write("----------------------calculator-------------------------\n");

            Console.Write("Enter the first Number :");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second Number :");
            num2 = Convert.ToInt32(Console.ReadLine());
            Menu();

          


            opt = Convert.ToInt32(Console.ReadLine());
         

            

            switch (opt)
            {
                case 1:
                  
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
                    loop = false;
                    break;

                default:
                    Console.Write("Input correct option\n");
                    break;

           }

            Console.WriteLine("Press any key to continue.");
            Console.ReadKey(); //without this line, the loop will work but the switch cases will not work. it is just a loop of menu without any adding and so on.

            static void Menu()
             {
                 Console.WriteLine("----- Menu -----");
                 Console.WriteLine("1: +");
                 Console.WriteLine("2: -");
                 Console.WriteLine("3: *");
                 Console.WriteLine("4: /");
                 Console.WriteLine("5: exit");

             }


        }
    }
         
  }
