using System;

namespace Slotkin_ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string doAnother;
            do
            {
                try
                {
                    Console.Write("Please enter num1: ");
                    string num1str = Console.ReadLine();
                    int num1 = int.Parse(num1str);

                    Console.Write("Please enter num2: ");
                    string num2str = Console.ReadLine();
                    int num2 = int.Parse(num2str);

                    Console.WriteLine("Num1/Num2: {0}", num1 / num2);
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Not a number!");
                }
                catch (System.OverflowException)
                {
                    Console.WriteLine("Number is too large or small!");
                }

                catch (Exception exc)
                {
                    //Console.WriteLine("There was an error!");  //generic message, doesn't give end user reason why
                    Console.WriteLine("Error! " + exc.Message + "\nException type: " + exc.GetType());
                }
                finally
                {
                    Console.WriteLine("This section always excecutes!");
                }

                Console.Write("Do another (y/n): ");
                doAnother = Console.ReadLine();

            } while (doAnother == "y");
        }
    }
}
