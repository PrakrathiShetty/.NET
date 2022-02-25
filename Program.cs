using System;
using System.IO;

namespace Exercises
{
    class FileRead
    {
       public static void Main()
        {
            string fileName;
            while(true)
            {
                Console.WriteLine("\n ......MENU....");
                Console.WriteLine("\n1.create a file");
                Console.WriteLine("\n2.existance of the file");
                Console.WriteLine("\n3.read the conents of the file");
                Console.WriteLine("\n4.exit");
                Console.WriteLine("\n enter your choice");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        Console.Write("\n enter the file name to create\n");
                        fileName = Console.ReadLine();
                        Console.WriteLine("\n write the contents to the file:\n");
                        string r = Console.ReadLine();
                        using (StreamWriter fileStr = File.CreateText(fileName))
                        {
                            fileStr.WriteLine(r);
                        }
                        Console.WriteLine("\n file created");
                        break;
                    case 2:
                        Console.Write("\n enter the file:");
                        fileName = Console.ReadLine();
                        if(File.Exists(fileName))
                        {
                            Console.WriteLine("file exists...");
                        }
                        else
                        {
                            Console.WriteLine("File does not exists in the current directory");
                        }
                        break;
                    case 3:
                        Console.Write("enter the file name to read the contents:\n");
                        fileName = Console.ReadLine();
                        if (File.Exists(fileName))
                        {
                            using (StreamReader sr = File.OpenText(fileName))
                            {
                                string s = " ";
                                Console.WriteLine("here is the content of the file:");
                                while ((s = sr.ReadLine()) != null)
                                {
                                    Console.WriteLine(s);
                                }
                                Console.WriteLine("");

                            }
                        }
                        else
                        {
                            Console.WriteLine("File does not exists");
                        }
                        break;
                    case 4:
                        Console.WriteLine("\nExiting....");
                        return;
                    default:
                        Console.WriteLine("\n Invalid choice");
                        break;



                }
            }
        }
    }
}
