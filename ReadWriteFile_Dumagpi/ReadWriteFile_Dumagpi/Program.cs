using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ReadWriteFile_Dumagpi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "Apple", "Banana", "Orange", "Mango", "Grapes" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);

            }
            string txtFile = System.IO.File.ReadAllText(@"C:\Users\Justiniane\OneDrive\Desktop\ReadAndWrite\ReadAndWrite\bin\Debug\Fruits.txt");
            File.WriteAllText(@"C:\Users\Justiniane\OneDrive\Desktop\ReadAndWrite\ReadAndWrite\bin\Debug\Fruits.txt", "");
            using (StreamWriter sw = File.AppendText(@"C:\Users\Justiniane\OneDrive\Desktop\ReadAndWrite\ReadAndWrite\bin\Debug\Fruits.txt"))
            {

                sw.WriteLine("Banana");
                sw.WriteLine("Mango");
                sw.WriteLine("Avocado");
                sw.WriteLine("Orange");
                sw.WriteLine("Apple");
            }



            using (StreamReader sr = File.OpenText(@"C:\Users\Justiniane\OneDrive\Desktop\ReadAndWrite\ReadAndWrite\bin\Debug\Fruits.txt"))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);

                }
            }

            int counter = 0;
            string line;

            //File.WriteAllText(@"C:\Users\Justiniane\OneDrive\Desktop\ReadAndWrite\ReadAndWrite\bin\Debug\Fruits.txt", "");

            Console.Write("\nInput a fruit to Search: ");
            string txtfruit = Console.ReadLine();


            //txtfruit = txtfruit.ToLower()
            System.IO.StreamReader myfile = new System.IO.StreamReader(@"C:\Users\Justiniane\OneDrive\Desktop\ReadAndWrite\ReadAndWrite\bin\Debug\Fruits.txt");

            bool Test = true;

            while ((line = myfile.ReadLine()) != null)
            {
                if (line.ToLower().Contains(txtfruit.ToLower()))
                {
                    Test = true;
                    break;
                }
                else
                {
                    Test = false;
                }
                counter++;
            }
            if (Test == true)
            {
                Console.WriteLine("Fruit has been Found!\n");
            }
            else
            {
                Console.WriteLine("Fruit Not Found :((\n");
            }
            Console.Read();

            {
                Console.WriteLine("Press 'E' to exit.");

                while (true)
                {
                    if (Console.ReadKey(true).KeyChar == 'E')
                    {
                        Console.WriteLine("Are you sure you want to exit? (y/n)");

                        if (Console.ReadKey(true).KeyChar == 'y')
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine("Exiting...");
            }
        }
    }
}
