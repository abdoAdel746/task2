using System.Collections.Generic;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            String text = 
@"--------------------------------------
P - print numbers
A - add a number
M - disblay mean of the numbers
S - display the smallest number
L - display the largest number
E - Search For a number
C - clear the list
G - sort the list in asecding order
H - sort the list in ascending order
Q - quit
--------------------------------------
enter your choise: ";

            Char choiseEnd= ' ';
            while (choiseEnd != 'q' && choiseEnd != 'Q')
            {
                Console.Write(text);

                Char choise = Console.ReadLine()[0];
                switch (choise)
                {
                    case 'p':
                    case 'P':
                        if (numbers.Count > 0)
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.Write($"{numbers[i]} ");
                            }
                            Console.WriteLine("]");

                        }
                        else
                        {
                            Console.WriteLine("empty list []");

                        }

                        break;

                    case 'a':
                    case 'A':
                        Console.Write("enter number to add: ");
                        int addNumber = int.Parse(Console.ReadLine());
                        int addFlag = 1;
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] == addNumber)
                            {
                                addFlag = 0;
                            }
                        }
                        if (addFlag == 1)
                        {
                            numbers.Add(addNumber);
                            Console.Write($"{addNumber} is added succesfully");
                        }
                        else
                        {
                            Console.Write($"{addNumber} is decalred before choose another one");
                        }




                        Console.Write("the current list is [ ");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        Console.WriteLine("]");
                        break;

                    case 'm':
                    case 'M':
                        if (numbers.Count > 0)
                        {
                            Double sum = 0;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                sum += numbers[i];
                            }
                            Console.WriteLine($"the average mean is: {sum / numbers.Count}");

                        }
                        else
                        {
                            Console.WriteLine("unable to calculate the mean - no data");

                        }
                        break;
                    case 's':
                    case 'S':
                        if (numbers.Count > 0)
                        {
                            int min = int.MaxValue;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] < min)
                                {
                                    min = numbers[i];
                                }
                            }
                            Console.WriteLine(min);
                        }
                        else
                        {
                            Console.WriteLine("unable to determine the samllest number - list is embty");

                        }
                        break;
                    case 'L':
                    case 'l':
                        if (numbers.Count > 0)
                        {
                            int max = int.MinValue;
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > max)
                                {
                                    max = numbers[i];
                                }
                            }
                            Console.WriteLine(max);
                        }
                        else
                        {
                            Console.WriteLine("unable to determine the largest number - list is embty");

                        }
                        break;
                    case 'e':
                    case 'E':
                        Console.Write("enter the number you wnat to search for: ");
                        int search = int.Parse(Console.ReadLine());
                        int NumberFound = 0;
                        if (numbers.Count > 0)
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] == search)
                                {
                                    Console.WriteLine($"{search} is found at index number {i} in the list");
                                    NumberFound = 1;
                                }
                            }
                            if (NumberFound == 0)
                            {
                                Console.WriteLine($"{search} is not found in the list");

                            }
                        }
                        else
                        {
                            Console.WriteLine($"the list is embty [], we can't find your number {search}");

                        }
                        break;
                    case 'c':
                    case 'C':
                        if (numbers.Count > 0)
                        {
                            numbers.Clear();
                            Console.WriteLine("the list succesfuly cleared");

                        }
                        else
                        {
                            Console.WriteLine("the list is already empty []");

                        }
                        break;
                    case 'g':
                    case 'G':
                        if (numbers.Count > 0)
                        {
                            List<int> newList = numbers.OrderByDescending(x => x).ToList();
                            if (newList.Count > 0)
                            {
                                Console.Write("[ ");
                                for (int i = 0; i < newList.Count; i++)
                                {
                                    Console.Write($"{newList[i]} ");
                                }
                                Console.WriteLine("]");

                            }
                            else
                            {
                                Console.WriteLine("empty list []");

                            }

                        }
                        else
                        {
                            Console.WriteLine("unable to determine the largest number - list is embty");

                        }
                        break ;
                    case 'h':
                    case 'H':
                        if (numbers.Count > 0)
                        {
                            List<int> newList = numbers.OrderBy(x => x).ToList();
                            if (newList.Count > 0)
                            {
                                Console.Write("[ ");
                                for (int i = 0; i < newList.Count; i++)
                                {
                                    Console.Write($"{newList[i]} ");
                                }
                                Console.WriteLine("]");

                            }
                            else
                            {
                                Console.WriteLine("empty list []");

                            }

                        }
                        else
                        {
                            Console.WriteLine("unable to determine the largest number - list is embty");

                        }
                        break;
                    case 'q':
                    case 'Q':
                        Console.WriteLine("Good Bye");
                        choiseEnd = 'q';
                        break;
                    default:
                        Console.WriteLine("unkown selection, please try again");
                        Console.Write(text);
                        break;
                }
            }

           
        }
    }
}
