using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader istream = new StreamReader(@"triangle.txt");
            string currentLine = istream.ReadLine();
            decimal number=decimal.Parse(currentLine);
            decimal [] lastStage={number};
            decimal [] currentStage={0};
            for (int lane = 1; !istream.EndOfStream; lane++)
            {
                currentLine = istream.ReadLine();
                currentStage = new decimal[lane + 1];
                for (int i = 0; i < lane; i++)
                {
                    number = decimal.Parse(currentLine.Substring(i * 3, 2)) + lastStage[i];
                    if (currentStage[i] < number)
                        currentStage[i] = number;
                    currentStage[i + 1] = number;
                }
                lastStage = currentStage;
            }
            decimal max = currentStage[0];
            foreach (var dec in currentStage)
                if (dec > max) max = dec;
            Console.WriteLine("The maximal path is: " + max);
            istream.Dispose();
            Console.ReadKey();
        





        }
    }
}
