namespace Tasks
{
    internal class Program
    {

        static void Main(string[] args)
        {
            char answer;
            bool isFound = false;
            int found = 0;
            do
            {

                List<int> numbers = new List<int>() { 1, 2, 3 };
                Console.WriteLine("Enter your choice");
                Console.WriteLine("P -> Print Numbers");
                Console.WriteLine("A -> Add number to list");
                Console.WriteLine("S -> Disply the smallest number");
                Console.WriteLine("L -> Display the largest number");
                Console.WriteLine("F -> Find number");
                Console.WriteLine("C -> Clear List");
                Console.WriteLine("Q -> Queit from program");
                answer = char.Parse(Console.ReadLine().ToUpper());

                if (answer == 'P')
                {
                    if (numbers.Count == 0)
                    {
                        Console.WriteLine("List is empty");
                    }
                    else
                    {
                        Console.Write("[");
                        for (int i = 0; i < numbers.Count(); i++)
                        {
                            Console.Write(numbers[i] + " ");
                        }
                        Console.Write("]");
                    }
                }
                else if (answer == 'A')
                {
                    do
                    {
                        Console.WriteLine("Enter number to list");
                        int value = int.Parse(Console.ReadLine());
                        numbers.Add(value);
                        Console.WriteLine("Do you want to enter another number");
                        answer = char.Parse(Console.ReadLine());
                        Console.WriteLine("Number Added");
                    } while (answer == 'y' || answer == 'Y');
                }
                else if (answer == 'S')
                {
                    int small = numbers[0];
                    for (int i = 0; i < numbers.Count(); i++)
                    {
                        if (numbers[i] < small)
                        {
                            small = numbers[i];
                        }
                    }
                    Console.WriteLine($"The smallest number is {small}");
                }
                else if (answer == 'L')
                {
                    int large = numbers[0];
                    for (int i = 0; i < numbers.Count(); i++)
                    {
                        if (numbers[i] > large)
                        {
                            large = numbers[i];
                        }
                    }
                    Console.WriteLine($"The smallest number is {large}");
                }
                else if (answer == 'F')
                {
                    Console.WriteLine("Enter number that you want to search about it");
                    int number = int.Parse(Console.ReadLine());
                    for (int i = 0; i < numbers.Count(); i++)
                    {
                        if (numbers[i] == number)
                        {
                            found = numbers[i];
                            isFound = true;
                        }
                    }
                    if (isFound)
                    {
                        Console.WriteLine($"Number is found {found}");
                    }
                    else
                        Console.WriteLine($"Number is not found");

                }
                else if (answer == 'C')
                {
                    numbers.Clear();
                }
                else if (answer == 'Q')
                {
                    Console.WriteLine("Goodbye");
                    break;
                }
            } while (answer != 'A' || answer != 'P' || answer != 'L' || answer != 'S' || answer != 'F' || answer != 'C' || answer != 'Q');



        }
    }
}