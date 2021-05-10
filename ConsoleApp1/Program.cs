using System;
using System.IO;
using métier;

namespace ConsoleApp1
{
    class Program : Iview
    {
        controller c = new controller();
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            MainMenu();
        }
        public void MainMenu()
        {
            Console.WriteLine("Welcome to our program, please choose your file Source \n");
            Console.WriteLine("Enter source :");
            string source = "";
            while (!Directory.Exists(source) && !File.Exists(source))
            {
                source = Console.ReadLine();
                if (!Directory.Exists(source) && !File.Exists(source))
                {
                    Console.WriteLine("Your source do not exist! Please try again:");
                }
            }
            c.source = source;
            //c.CountChar();
            //c.CountWord();
            //c.WriteSave();

            /*Console.WriteLine("Do you want to save your search ? (y,n) :");
            string validate = "";
            do
            {
                validate = Console.ReadLine();

                if (validate == "y")
                {
                    
                }
                else if (validate == "n")
                {
                    
                }
                else
                {
                    Console.WriteLine("Please try again! Enter \"y\" to save and \"n\" to cancel your work:");
                }
            } while (validate != "y" && validate != "n");*/
        }
    }
}
