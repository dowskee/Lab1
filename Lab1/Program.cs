using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ToDO: Prompt the user to calculate the values of length and width of the classroom. Have the application display the area and perimeter of the classroom. 
namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {


            bool Answer = true;
            while (Answer == true)
            {
                //input

                double length, width, height;
                double Area, Perimeter, Volume;

                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
                Console.WriteLine("Enter Length:");
                length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width:");
                width = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Height:");
                height = double.Parse(Console.ReadLine());

                //processing

                Area = (length * width);
                Perimeter = 2 * (length + width);
                Volume = (length * width * height);

                //output

                Console.WriteLine("Area:" + Area);
                Console.WriteLine("Perimeter" + Perimeter);
                Console.WriteLine("Volume:" + Volume);


                //give result or message
                string UserChoice;
                Console.WriteLine("Continue? (Y/N?)");
                UserChoice = Console.ReadLine();
                if (UserChoice == "N" || UserChoice == "No" || UserChoice == "n" || UserChoice == "no")
                {
                    Answer = false;
                    Console.WriteLine("Goodbye for now!");
                }
            }
        }
    }
}
