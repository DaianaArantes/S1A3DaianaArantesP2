/*
 * Program ID: A3DaianaArantesP2
 * 
 * Purpose: Create program to create an interface that 
 * acts as a simple two number calculator
 * 
 * Revision History
 * 
 * Written Dec 2017 by Daiana Arantes
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3DaianaArantesP2
{
    class Program
    {
        static void Main(string[] args)
        {

            //declaration           
            string operation = null;         
            
            do
            {
                Console.WriteLine();
                Console.WriteLine("What do you want do do? ");
                Console.WriteLine();
                Console.WriteLine("Press + to SUM ");
                Console.WriteLine();
                Console.WriteLine("Press - to SUBTRACT ");
                Console.WriteLine();
                Console.WriteLine("Press * to MULTIPLY ");
                Console.WriteLine();
                Console.WriteLine("Press / to DIVIDE ");
                Console.WriteLine();
                Console.WriteLine("Or input EXIT to leave the program ");
                Console.WriteLine();
                operation = Console.ReadLine();

                //validate the input, cases +, -, *, / and exit
                switch (operation)
                {
                    case "+":

                        Program.Sum();

                        break;
                    case "-":

                        Program.Subtract();

                        break;
                    case "*":

                        Program.Multiply();

                        break;
                    case "/":

                        Program.Division();

                        break;
                    case "Exit":
                    case "EXIT":
                    case "exit":
                        operation = "Exit";
                        Console.WriteLine("You choose to exit, thank you!");
                        Console.WriteLine();
break;
                    default:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Incorret operation," +
                            "please input +, -, *, / or EXIT: ");
                        break;
                }
             //if the input is exit, then the program will close
            } while (operation != "Exit");
       
        }

        //method to receive value from user
        public static double ReceiveValue()
        {
            double value = 0;
            bool valueReceived = false;

            do
            {
                //try to execute parse
                try
                {
                    value = double.Parse(Console.ReadLine());
                    valueReceived = true;
                }
                //catch null character exception from user
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine();
                    valueReceived = false;
                    Console.WriteLine("Your insert is a null value," +
                        "please insert a valid number!");
                }
                //catch wrong character exception from user
                catch (FormatException ex)
                {
                    Console.WriteLine();
                    valueReceived = false;
                    Console.WriteLine("You inserted an invalid character," + 
                        " please insert a valid number!");
                }
                //catch overflow exception from user
                catch (OverflowException ex)
                {
                    Console.WriteLine();
                    valueReceived = false;
                    Console.WriteLine("You inserted an unsupported" +
                        " value, please" + 
                        "insert a number between " + Double.MinValue +
                        " and " + Double.MaxValue);
                }
                //catch other exceptions 
                catch (Exception ex)
                {
                    valueReceived = false;
                    Console.WriteLine(ex.Message + ". Please insert a" +
                        " valid number!");
                }

            } while (!valueReceived);

            return value;
        }

        public static void Sum()
        {
            double value1 = 0;
            double value2 = 0;
            double result = 0;

            //ask first and second input from user and executes sum
            Console.Clear();
            Console.WriteLine("You selected SUM");
            Console.WriteLine();
            Console.WriteLine("Now please insert the first number: ");
            Console.WriteLine();
            value1 = Program.ReceiveValue();
            Console.WriteLine();
            Console.WriteLine("Now please insert the second number: ");
            Console.WriteLine();
            value2 = Program.ReceiveValue();
            Console.WriteLine();
            result = value1 + value2;
            Console.Clear();
            Console.WriteLine("The result of the Sum is " + result);
        }

        public static void Subtract()
        {
            double value1 = 0;
            double value2 = 0;
            double result = 0;

            //ask first and second input from user and executes subtraction
            Console.Clear();
            Console.WriteLine("You selected SUBTRACT");
            Console.WriteLine();
            Console.WriteLine("Now please insert the first number: ");
            Console.WriteLine();
            value1 = Program.ReceiveValue();
            Console.WriteLine();
            Console.WriteLine("Now please insert the second number: ");
            Console.WriteLine();
            value2 = Program.ReceiveValue();
            Console.WriteLine();
            result = value1 - value2;
            Console.Clear();
            Console.WriteLine("The result of the Subtraction is " + result);
        }

        public static void Multiply()
        {
            double value1 = 0;
            double value2 = 0;
            double result = 0;

            //ask first and second input from user and executes multiplication
            Console.Clear();
            Console.WriteLine("You selected MULTIPLY");
            Console.WriteLine();
            Console.WriteLine("Now please insert the first number: ");
            Console.WriteLine();
            value1 = Program.ReceiveValue();
            Console.WriteLine();
            Console.WriteLine("Now please insert the second number: ");
            Console.WriteLine();
            value2 = Program.ReceiveValue();
            Console.WriteLine();
            result = value1 * value2;
            Console.Clear();
            Console.WriteLine("The result of the Multiplication is " +
                result);
        }

        public static void Division()
        {
            double value1 = 0;
            double value2 = 0;
            double result = 0;

            //ask first and second input from user and executes sum
            // uses if when the division is by zero (infinity)
            try { 
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("You selected DIVIDE");
                Console.WriteLine();
                Console.WriteLine("Now please insert the first number: ");
                Console.WriteLine();
                value1 = Program.ReceiveValue();
                Console.WriteLine();
                Console.WriteLine("Now please insert the second number: ");
                Console.WriteLine();
                value2 = Program.ReceiveValue();
                Console.WriteLine();
                result = value1 / value2;
                Console.Clear();

                if (Double.IsInfinity(result))
                {
                    Console.WriteLine();
                    throw new Exception("A division may not be done" +
                        " by using 0");
                    Console.WriteLine();
                }

                Console.WriteLine("The result of the Division is " + result);

            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
                Console.WriteLine();
            }
        }
    }

}