using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    { //Exercise 3
        //Write a program and ask the user to enter the width and height of an image. Then tell if the image is
        //landscape or portrait
        static void Main(string[] args)
        {

            Console.WriteLine("Let see if this image is a landscape or portrait one : ");

            Console.Write("Enter the height of your image: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the width of your image: ");
            double width = Convert.ToDouble(Console.ReadLine());

            string result;
            if (height < width)
            {
                result = "landscape";
            }
            else if (height > width)
            {
                result = "portrait";
                
            }
            else
            {
                result = "Man, Please";
               
            }
            Console.WriteLine(result);

        }

    }
}
