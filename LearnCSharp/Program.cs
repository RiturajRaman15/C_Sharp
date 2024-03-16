using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    internal class Program
    {
        // Method Declaration
        static void greet()
        {
            Console.WriteLine("Hello World!");
        }

        static void greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static int add(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            /*
            // Display Output
            Console.WriteLine("Hello World!"); // With new line
            Console.Write("Welcome to C# Programming"); // Without new line

            // Read Input
            Console.ReadLine(); // Returns string type

            // Variable Declaration
            int number = 10;
            string name = "John Doe";
            bool isTrue = true;
            double price = 10.5;
            float price1 = 10.5f;

            // Display Variable
            Console.WriteLine(number);
            Console.WriteLine(name);
            Console.WriteLine(isTrue);
            Console.WriteLine(price);
            Console.WriteLine(price1);
            Console.WriteLine("Number: {0}, Name: {1}, IsTrue: {2}, Price: {3}",
                               number, name, isTrue, price );
            Console.WriteLine("Name: "+name+", Number: "+number+", Price: "+price+", IsTrue: "+isTrue);

            //Type casting
                //1. Implicit Type Casting
                    //char -> int -> long -> float -> double
                    char ch = 'G';
                    int num = ch;
                    Console.WriteLine("ASCII value of: " + ch + " is: " + num);

                //2. Explicit Type Casting
                //double -> float -> long -> int -> char
                    double d = 5673.74;
                    int i = (int)d;
                    int c = Convert.ToInt32(4.55);
                    Console.WriteLine("Double value: " + d + ", Integer of d: " + i);
                    Console.WriteLine(c);

            // Operators
            // Arithmetic Operators
            int a = 10;
            int b = 20;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(b / a);
            Console.WriteLine(b % a);

            // Relational Operators
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);
            Console.WriteLine(a > b);
            Console.WriteLine(a < b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a <= b);

            // Logical Operators
            bool c = true;
            bool d = false;
            Console.WriteLine(c && d);
            Console.WriteLine(c || d);
            Console.WriteLine(!c);

            // Bitwise Operators
            int e = 5; // 101
            int f = 10; // 1010
            Console.WriteLine(e & f); // 0
            Console.WriteLine(e | f); // 15
            Console.WriteLine(e ^ f); // 15
            Console.WriteLine(~e); // -6
            Console.WriteLine(f << 2); // 40
            Console.WriteLine(f >> 2); // 2
            Console.WriteLine(f >> 1);
            Console.WriteLine(f >> 0);

            // Assignment Operators
            int g = 10;
            g += 5;
            Console.WriteLine(g);
            g -= 5;
            Console.WriteLine(g);
            g *= 5;
            Console.WriteLine(g);
            g /= 5;
            Console.WriteLine(g);
            g %= 5;
            Console.WriteLine(g);
            g &= 5;
            Console.WriteLine(g);
            g |= 5;
            Console.WriteLine(g);
            g ^= 5;
            Console.WriteLine(g);
            g <<= 5;
            Console.WriteLine(g);
            g >>= 5;
            Console.WriteLine(g);

            // Ternary Operator
            int h = 10;
            int i = 20;
            int result = (h > i) ? h : i;
            Console.WriteLine(result);

            // Null Coalescing Operator
            int? j = 4;
            int k = j ?? 5;
            Console.WriteLine(k);

            // Maths Class
            Console.WriteLine(Math.Max(10, 20));
            Console.WriteLine(Math.Min(10, 20));
            Console.WriteLine(Math.Sqrt(64));
            Console.WriteLine(Math.Abs(-4.7));
            Console.WriteLine(Math.Round(9.99));

            // String
            string firstName = "John";
            string lastName = "Doe";
            string fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
            Console.WriteLine(fullName.Length);
            Console.WriteLine(fullName.ToUpper());
            Console.WriteLine(fullName.ToLower());
            Console.WriteLine(fullName.Trim()); // Remove leading and trailing white spaces
            Console.WriteLine(fullName.Contains("John"));
            Console.WriteLine(fullName[0]);
            Console.WriteLine(fullName.IndexOf("Doe"));
            Console.WriteLine(fullName.Substring(5));
            Console.WriteLine(fullName.Substring(3, 4));
            Console.WriteLine(string.Concat(firstName," ", lastName));

            // String Interpolation
            string name1 = "John";
            int age = 25;
            Console.WriteLine($"My name is {name1} and I am {age} years old.");
            
            // String Format
            string name2 = "John";
            int age1 = 25;
            Console.WriteLine(string.Format("My name is {0} and I am {1} years old.", name2, age1));

            // String Builder
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello");
            sb.Append("World");
            sb.Append("!");
            Console.WriteLine(sb);
            Console.WriteLine(sb.ToString());

            // Conditional Statements
            int number = 10;
            if (number > 5)
            {
                Console.WriteLine("Number is greater than 5");
            }
            else if (number == 5)
            {
                Console.WriteLine("Number is equal to 5");
            }
            else
            {
                Console.WriteLine("Number is less than 5");
            }

            // Switch Statement
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid Day");
                    break;
            }

            // Loop
            // While Loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i);
                i++;
            }

            // Do While Loop
            int j = 0;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j < 5);

            // For Loop
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine(k);
            }

            // For Each Loop
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            // Break Statement
            for (int l = 0; l < 10; l++)
            {
                if (l == 4)
                {
                    break;
                }
                Console.WriteLine(l);
            }

            // Continue Statement
            for (int m = 0; m < 10; m++)
            {
                if (m == 4)
                {
                    continue;
                }
                Console.WriteLine(m);
            }

            // Array Declaration
            // Empty Array
            int[] numbers = new int[5];

            // Array with values
            int[] numbers1 = new int[5] { 10, 20, 30, 40, 50 };
            int[] numbers2 = { 10, 20, 30, 40, 50 };

            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            // Display Array
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);

            //Display Array using For Loop
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Array Length
            Console.WriteLine(numbers.Length);

            // Multi-Dimensional Array
            int[,] numbers3 = new int[2, 2];
            int[,] numbers4 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] numbers5 = new int[,] { { 1, 2 }, { 3, 4 } };
            int[,] numbers6 = { { 1, 2 }, { 3, 4 } };

            // Display Multi-Dimensional Array
            Console.WriteLine(numbers4[0, 0]);
            Console.WriteLine(numbers4[0, 1]);

            // Display Multi-Dimensional Array using For Loop
            for (int i = 0; i < numbers4.GetLength(0); i++)
            {
                for (int j = 0; j < numbers4.GetLength(1); j++)
                {
                    Console.WriteLine(numbers4[i, j]);
                }
            }

            // Jagged Array
            int[][] numbers7 = new int[][] // 3 Rows
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5 },
                new int[] { 6 }
            };

            int[][] numbers8 = new int[4][] // 4 Rows
            {
                new int[3] { 1, 2, 3 },
                new int[2] { 4, 5 },
                new int[1] { 6 },
                new int[2] { 7, 8 }
            };

            int[][] numbers9 = new int[3][]; // 3 Rows

            int[][] numbers10 =
            {
                new int[3] { 10, 20, 30 },
                new int[2] { 40, 50 },
                new int[1] { 60 }
            };

            // Display Jagged Array
            Console.WriteLine(numbers7[0][0]);
            Console.WriteLine(numbers7[0][1]);

            // Display Jagged Array using For Loop
            for (int i = 0; i < numbers10.Length; i++)
            {
                for (int j = 0; j < numbers10[i].Length; j++)
                {
                    Console.WriteLine(numbers10[i][j]);
                }
            }

            // Method Call
            greet();
            greet("Rituraj");
            int result = add(10, 20);
            Console.WriteLine(result);
            
            // Object Oriented Programming: Class and Object
            Player p1 = new Player();
            Console.WriteLine(p1.name);
            Console.WriteLine(p1.score);
            p1.changeScore(8);
            */

            // Generic data type
            // List
            List<int> numbers = new List<int>();
            numbers.Add(10);

            // Display List
            Console.WriteLine(numbers[0]);

            // List using For Loop
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            // Dictionary
            Dictionary<string, string> country = new Dictionary<string, string>();
            country.Add("India", "New Delhi");

            // Display Dictionary
            Console.WriteLine(country["India"]);

            // Dictionary using For Each Loop
            foreach (KeyValuePair<string, string> item in country)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            // Set
            HashSet<int> numbers1 = new HashSet<int>();
            numbers1.Add(10);

            // Display Set
            foreach (int number in numbers1)
            {
                Console.WriteLine(number);
            }

            // Queue
            Queue<int> numbers2 = new Queue<int>();
            numbers2.Enqueue(10);

            // Display Queue
            foreach (int number in numbers2)
            {
                Console.WriteLine(number);
            }

            // Stack
            Stack<int> numbers3 = new Stack<int>();
            numbers3.Push(10);

            // Display Stack
            foreach (int number in numbers3)
            {
                Console.WriteLine(number);
            }

            // Tuple
            Tuple<int, string, string> person = new Tuple<int, string, string>(1, "John", "Doe");

            // Display Tuple
            Console.WriteLine(person.Item1);


            Console.ReadLine();
        }
    }
}
