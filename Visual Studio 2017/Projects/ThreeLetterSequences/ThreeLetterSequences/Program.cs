using System;

namespace ThreeLetterSequences
{
    class Program
    {
        static void Main(string[] args)
            
        {
            string path = @"C:\Users\we\Documents\Projects\book.txt";

            string data = System.IO.File.ReadAllText(path).ToLowerInvariant();

            int count = 0;
         

            for (int i = 0; i < data.Length-2; i++)
            {
                if (data[i] == 't' && data[i + 1] == 'r' && data[i + 2] == 'a')
                {
                    count++;

                }
                   
                {
                    int result = count;
                    Console.WriteLine(result);
                }
            }

            











        }
    }
}