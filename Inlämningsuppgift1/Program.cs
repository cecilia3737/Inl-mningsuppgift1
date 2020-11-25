using System;
using System.Collections.Generic;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum;
            List<int> arrayOfSum = new List<int>();

            while (true)
            {
                Console.Write("Enter first operator: ");
                string operatorOne = Console.ReadLine();
                Console.Write("Enter Second operator: ");
                string operatorTwo = Console.ReadLine();

                Console.Write("Enter first number: ");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number: ");
                int numberTwo = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter third number: ");
                int numberThree = Convert.ToInt32(Console.ReadLine());

                
                    if (operatorOne == "+")
                    {
                        if (operatorTwo == "+")
                        {
                            sum = numberOne + numberTwo + numberThree;
                            Console.WriteLine(numberOne + " + " + numberTwo + " + " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }

                        }
                        else if (operatorTwo == "-")
                        {
                            sum = numberOne + numberTwo - numberThree;
                            Console.WriteLine(numberOne + " + " + numberTwo + " - " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }
                        else if (operatorTwo == "*")
                        {
                            sum = numberOne + numberTwo * numberThree;
                            Console.WriteLine(numberOne + " + " + numberTwo + " * " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }
                        else if (operatorTwo == "/")
                        {
                            sum = numberOne + numberTwo / numberThree;
                            Console.WriteLine(numberOne + " + " + numberTwo + " / " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }
                    }
                    else if (operatorOne == "-")
                    {
                        if (operatorTwo == "+")
                        {
                            sum = numberOne - numberTwo + numberThree;
                            Console.WriteLine(numberOne + " - " + numberTwo + " + " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }
                        else if (operatorTwo == "-")
                        {
                            sum = numberOne - numberTwo - numberThree;
                            Console.WriteLine(numberOne + " - " + numberTwo + " - " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }
                        else if (operatorTwo == "*")
                        {
                            sum = numberOne - numberTwo * numberThree;
                            Console.WriteLine(numberOne + " - " + numberTwo + " * " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }
                        else if (operatorTwo == "/")
                        {
                            sum = numberOne - numberTwo / numberThree;
                            Console.WriteLine(numberOne + " - " + numberTwo + " / " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }
                    }
                    else if (operatorOne == "*")
                    {
                        if (operatorTwo == "+")
                        {
                            sum = numberOne * numberTwo + numberThree;
                            Console.WriteLine(numberOne + " * " + numberTwo + " + " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }
                        else if (operatorTwo == "-")
                        {
                            sum = numberOne * numberTwo - numberThree;
                            Console.WriteLine(numberOne + " * " + numberTwo + " - " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }
                        else if (operatorTwo == "*")
                        {
                            sum = numberOne * numberTwo * numberThree;
                            Console.WriteLine(numberOne + " * " + numberTwo + " * " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }
                        else if (operatorTwo == "/")
                        {
                            sum = numberOne * numberTwo / numberThree;
                            Console.WriteLine(numberOne + " * " + numberTwo + " / " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }
                    }
                    else if (operatorOne == "/")
                    {
                        if (operatorTwo == "+")
                        {
                            sum = numberOne / numberTwo + numberThree;
                            Console.WriteLine(numberOne + " / " + numberTwo + " + " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }
                        else if (operatorTwo == "-")
                        {
                            sum = numberOne / numberTwo - numberThree;
                            Console.WriteLine(numberOne + " / " + numberTwo + " - " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }
                        else if (operatorTwo == "*")
                        {
                            sum = numberOne / numberTwo * numberThree;
                            Console.WriteLine(numberOne + " / " + numberTwo + " * " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }
                        else if (operatorTwo == "/")
                        {
                            sum = numberOne / numberTwo / numberThree;
                            Console.WriteLine(numberOne + " / " + numberTwo + " / " + numberThree + " = " + sum);
                            arrayOfSum.Add(sum);

                            if (sum < 100)
                            {
                                Console.WriteLine("Less then a hundred");
                            }
                            else if (sum > 100)
                            {
                                Console.WriteLine("More then a hundred");
                            }
                            else
                            {
                                Console.WriteLine("Cool, now you have a hundred, clap clap");
                            }
                        }

                    }

                Console.WriteLine("Another try? y or n");
                string userchoice = Console.ReadLine();
                if (userchoice == "y")
                {
                    continue;
                }
                else
                {
                    foreach (int item in arrayOfSum)
                    {

                        Console.WriteLine(item);
                    }
                    break;
                }


            }
            

        }
    }
}
