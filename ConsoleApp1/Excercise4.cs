using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // Exercise 4
        //Write a program for a speed camera.For simplicity, ignore the details such as camera, sensors, etc
        //and focus purely on the logic.
        //Write a program that asks the user to enter the speed limit.Once set, the program asks for the speed
        //of a car.If the user enters a value less than the speed limit, program should display Ok on the
        //console.If the value is above the speed limit, the program should calculate the number of failure
        //points.
        //For every 5km/hr above the speed limit, 1 failure points should be incurred and displayed on the
        //console. If the number of failure points is above 12, the program should display License Suspended.
        static void Main(string[] args)
        {



            Console.Write("Enter the speed limit: ");
            int speedLimit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the speed of a car: ");
            int speedCar = Convert.ToInt32(Console.ReadLine());
         

            if (speedCar < speedLimit)
            {
                Console.WriteLine("OK");
            }
            else if (speedCar > speedLimit)
            {
                int numFailurePoints = (speedCar - speedLimit) / 5;
                Console.WriteLine(numFailurePoints);
                if (numFailurePoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
               
            }

        }
    }
}
