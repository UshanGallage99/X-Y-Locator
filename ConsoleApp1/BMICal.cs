using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using GemBox.Spreadsheet;
using Aspose.Cells;
using System.Globalization;

namespace ConsoleApp1
{
    class Locator
    {
        static void Main(String[] args)
        {
            //gettng x value
            Console.Write("Enter Your Start x - index ? ");
            int x = Convert.ToInt32(Console.ReadLine());

            //gettng y value
            Console.Write("Enter Your Start y - index ? ");
            int y = Convert.ToInt32(Console.ReadLine());

            StreamWriter writer = new StreamWriter("Locator.txt");

            int[] steps = new int[5];
            string[] instruction = new string[5];
            int i = 0;

                //gettng moving instruction
            do
            {
                instruction[i] = Console.ReadLine();
                    
                    if (instruction[i] == "E")
                    {
                        break;
                    }
                steps[i] = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < steps[i]; j++)
            {
                switch (instruction[i])
                {
                    case "L":
                        x -= 1;
                        break;
                    case "R":
                        x += 1;
                        break;
                    case "U":
                        y += 1;
                        break;
                    case "D":
                        y -= 1;
                        break;
                }
            }

            i++;
            writer.WriteLine(instruction[i] + " " + steps[i]);
            } 
            while (instruction[i] != "E");       

            //display the output
            Console.WriteLine("Now,you are in : (" + x + "," + y + ")");
            writer.Close();
        }
    }
}
