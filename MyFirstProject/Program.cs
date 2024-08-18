using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program {
        static void Main(string[] args) {
            // Declaring Variables
            int x = 10, y = 20, z = 30;
            Console.WriteLine(x); Console.WriteLine(y); Console.WriteLine(z);

            // Working With Integers
            int age = 23;
            long bigNumber = 100000000L;
            Console.WriteLine(age);
            Console.WriteLine(bigNumber);
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            // Working With Decimals
            // Floats: 32 bit - 07 digits
            // Double: 64 bit - 16 digits
            // Decimal: 128 bit - 29 digits
            double negativeDouble = -55.25D;
            float negativeFloat = -21.001F;
            decimal negativeDecimal = -752.78M;
            Console.WriteLine(negativeDouble);
            Console.WriteLine(negativeFloat);
            Console.WriteLine(negativeDecimal);

            // Working with String and Chars
            string name = "Reda";
            Console.WriteLine(name);
            char letter = 'a';
            Console.WriteLine(letter);
            string sentence = "Your name is: ";
            Console.Write(sentence);
            Console.WriteLine(name);

            // Converting Strings to Numbers
            string textUserAge = "-23";
            int userAge = Convert.ToInt32(textUserAge);
            Console.WriteLine(userAge );
            string textBigNumber = "9999999";
            long AnotherBigNumber = Convert.ToInt64(textBigNumber);
            Console.WriteLine(AnotherBigNumber);
            string textFloatNumber = "-3,14";
            float myFloatNumber = Convert.ToSingle(textFloatNumber);
            Console.WriteLine(myFloatNumber);

            // Boolean data types
            bool isMale = true;
            bool isFemale = false;
            Console.WriteLine(isMale);
            Console.WriteLine(isFemale);

            // Operations
            int agentAge = 23;
            agentAge++;
            agentAge += 1;
            Console.WriteLine(agentAge);
            string firstName = "Reda ";
            string lastName = "Bouzad";
            string fullName = firstName + lastName;
            Console.WriteLine(fullName);
            int score_1 = 0;
            Console.WriteLine(score_1++);
            int score_2 = 0;
            Console.WriteLine(++score_2);

            // Using the Var keyword
            // The compiler take cares of the data type
            var moneyInBank = 40000;
            Console.WriteLine(moneyInBank);
            var yetAnotherBigNumber = 90000L;
            Console.WriteLine(yetAnotherBigNumber);

            // Working with consts
            const int tva = 20;
            Console.WriteLine(tva);

            // Exercice: Check if even or odd
            int number_1 = 30, number_2 = 15;
            int reminder = number_1 % number_2;
            Console.WriteLine(reminder);

            /*            // Reading data from the console
                        Console.Write("Enter your name: ");
                        string x_user_name = Console.ReadLine();
                        Console.Write("Enter your age: ");
                        int x_user_age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Hello " + x_user_name + " nice to meet you, your age is: " + x_user_age);

                        bool isCool = true;
                        if (x_user_age >= 18 || isCool)
                        {
                            Console.WriteLine("You are allowed to drink");
                        } else
                        {
                            Console.WriteLine("Banned!");
                        }*/


            /*          Console.WriteLine("What is 3 * 3 ? ");
                      int response = Convert.ToInt32(Console.ReadLine());
                      if (response == 9) {
                          Console.WriteLine("Correct! Good job");

                      }
                      else
                      {
                          Console.WriteLine("Wrong Answer");
                      }*/

            // Switch Statements
            /*        Console.WriteLine("Enter a day of the week: ");
                    int day = Convert.ToInt32(Console.ReadLine());
                    switch (day)
                    {
                        case 1: Console.WriteLine("Monday");
                            break;
                        case 2: Console.WriteLine("Tuesday");
                            break;
                        default: Console.WriteLine("Enter a value between 1 and 7");
                            break;

                    }*/

            // For Loop
            Console.WriteLine("-------------------------");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i+1);
            }
            Console.WriteLine("-------------------------");
            // While Loop
            int x_counter = 10;
            while (x_counter != 0)
            {
                Console.WriteLine(x_counter);
                x_counter--;
            }
            Console.WriteLine("-------------------------"); 
            Console.WriteLine(x_counter);


            /*            bool flag = false;
                        Console.WriteLine("enter the first number");
                        int my_number_1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the second number");
                        int my_number_2 = Convert.ToInt32(Console.ReadLine());
                        int correct_response = my_number_1 * my_number_2;
                        Console.WriteLine("Enter your response");
                        int user_response = Convert.ToInt32(Console.ReadLine());
                        while (!flag)
                        {
                            if(user_response == correct_response)
                            {
                                Console.WriteLine("Correct");
                                flag = true;
                            } else
                            {
                                Console.WriteLine("Wrong response try again");
                                user_response = Convert.ToInt32(Console.ReadLine());
                            }
                        }
                        do
                        {
                            Console.WriteLine("Hello");
                        } while (1 == 5);*/


            // Conditional Operator
            // condition ? true : false
            int ahmed_age = -10;
            string result = age >= 0 ? "Valid" : "Invalid";
            Console.WriteLine(result);

            // Numeric formating
            double value = -10D / 3D;
            Console.WriteLine(value);
            Console.WriteLine(string.Format("{0:0}", value));
            Console.WriteLine(string.Format("{0:0.0}", value));
            Console.WriteLine(string.Format("{0:0.#}", value)); // Removing Trailing Zeros
            Console.WriteLine(string.Format("$10 / $3 = / ${0:0.00}", value)); // Problem with negative numbers
            Console.WriteLine(value.ToString("C"));
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("en-GB")));
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));
            Console.WriteLine(value.ToString("C", CultureInfo.CreateSpecificCulture("en-AU")));

            // Int.TryParse
            /*          Console.WriteLine("Enter a number: ");
                      string numInput = Console.ReadLine();
                      *//*            int num = Convert.ToInt32(numInput);
                      *//*
                      int end_result = 0;
                      bool success = int.TryParse(numInput, out end_result);
                      if(success)
                      {
                          Console.WriteLine(end_result);
                      } else
                      {
                          Console.WriteLine("Failed to convert");
                      }*/


            // Exercice The 10 times table
            /*           Console.WriteLine("Select number: ");
                       int selected_number = Convert.ToInt32(Console.ReadLine());
                       for (int i = 1; i < 11; i++) {
                           Console.WriteLine("{0} x {1} = {2}", i, selected_number, i * selected_number);
                       }
                       Console.WriteLine("End of the Program");
                      */

            // Exercice FizzBuzz game:
            Console.WriteLine("------------------------------------------------");
            for (int i = 1;i < 16; i++) {
                if(i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine("FizzBuzz");
                } else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                } else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                } else {
                    Console.WriteLine(i);
                }
            }

            // Escaping chars
            Console.WriteLine($"Your name is {firstName}");
            string path = "C:\\Users\\Desktop\\Reda";
            string quote = "ahmed said \" stay cool \"";
            Console.WriteLine(path);
            Console.WriteLine(quote);
            path = @"C:\Users\Desktop\Reda";
            quote = @"ahmed said "" stay cool "" ";
            Console.WriteLine(path);
            Console.WriteLine(quote);
             
            // Compasate format
            string employeeFirstName = "Reda";
            string employeeLastName = "Bouzad";
            int employeeAge = 23;
            bool isMarried = false;
            Console.WriteLine("employee first name is {0}, employee last name is {1}, employee age is {2}, employee is married: {3}", employeeFirstName, employeeLastName, employeeAge, isMarried);

            // String Interpolation
            Console.WriteLine($"employee first name is {employeeFirstName}, employee last name is {employeeLastName}, employee age is {employeeAge}, employee is Married: {isMarried}");

            // String Concat
            string test = string.Concat("employee first name is ", employeeFirstName, ", employee last name is ", employeeLastName);
            Console.WriteLine(test);

            // Empty String
            string emptyString = string.Empty;

            // Comparing Strings 
            string message_1 = "Hello";
            string message_2 = "Hello";
            if(message_1.Equals(message_2))
            {
                Console.WriteLine("Same");
            } else
            {
                Console.WriteLine("Different");
            }

            // String Iteration Looping
            string another_message = "Hello World";
            // Console.WriteLine(another_message[1]);
            
    /*        for(int i = 0; i < another_message.Length; i++)
            {
                Console.Write(another_message[i]);
                System.Threading.Thread.Sleep(100);
            }*/

            Console.WriteLine();
            Console.WriteLine(another_message.Contains("#"));

            // Create Contains function
            // Always make sure to compare the right types of data
            // Char should be compared to char, string with string, int with int ....
            /*          Console.Write("Enter the char to look for: ");
                      char char_to_look_for = Convert.ToChar(Console.ReadLine());
                      Console.Write("Enter the sentence: ");
                      sentence = Console.ReadLine();
                      bool flag = false;
                      for(int i = 0;i < sentence.Length; i++)
                      {
                          Console.WriteLine(sentence[i]);
                          if (char_to_look_for.Equals(sentence[i]))
                          {
                              flag = true;
                              Console.WriteLine("Bingoo");
                          }
                      }
                      if(flag)
                      {
                          Console.WriteLine("Found");
                      }*/
            // Null or Empty
            /*          Console.Write("Enter your name: ");
                      name = Console.ReadLine();
                      if (!string.IsNullOrEmpty(name))
                      {
                          Console.WriteLine("Valid name");
                      } else
                      {
                          Console.WriteLine("Not valid name");
                      }*/


            // Print message in order and in reverse
            /*           Console.Write("Enter your message: ");
                       string message = Console.ReadLine();
                       Console.WriteLine($"message in order: {message}");
                       Console.Write("message in reverse: ");
                       for (int i = message.Length -1 ; i >= 0; i--)
                       {
                           Console.Write(message[i]);
                       } */

            // Password checker
            /*            Console.Write("Enter your password: ");
                        string password = Console.ReadLine();
                        Console.Write("Repeat your password: ");
                        string confirm_password = Console.ReadLine();
                        if (!string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirm_password)) {
                            if(confirm_password.Equals(password))
                            {
                                Console.WriteLine("Password match");
                            } else { Console.WriteLine("Password don't match");
                            }
                        } else
                        {
                            Console.WriteLine("Please make sure that both inputs are not empty");
                        }*/

            // Arrays
     /*       int[] numbers = new int[3];
            numbers[0] = 5;
            numbers[1] = 10;
            numbers[2] = 15;

            // For each loop
            foreach(int number in numbers) {
                Console.Write($"{number} ");
            }*/

            // Declaring and assiging an Array
            int[] lucky_numbers = new int[] {44, 85, 25, 14};
            Array.Sort(lucky_numbers);
            string[] lucky_friends = new string[] { "reda", "ahmed", "ali", "adam" };

            Array.Reverse(lucky_friends);
            foreach (int number in lucky_numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            foreach (var friend in lucky_friends)
            {
                Console.Write($"{friend} ");
            }

            // Array are fixed (size can't change)

            // We can clear an array
/*            Array.Clear(lucky_friends, 0, lucky_numbers.Length);
*/            /*          Console.WriteLine();
                      foreach (var friend in lucky_friends)
                      {
                          Console.Write($"{friend} ");
                      }*/
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            // We can also use default value
            lucky_friends[0] = default;
            Console.WriteLine("list of lucky friends: ");
            foreach (var friend in lucky_friends)
            {
                Console.Write($"{friend} ");
            }

            // Array.IndexOf
            Console.WriteLine();
            Console.WriteLine(Array.IndexOf(lucky_friends, "anas"));

            int[] unlucky_numbers = new int[]
            {
                420, 69, 13
            };
            // Lists
            List<int> list_numbers = new List<int>()
            {
                78, 88, 51, 29
            };
            list_numbers.Add(7);
            list_numbers.Add(10);

            for (int i = 0; i < list_numbers.Count; i++)
            {
                Console.WriteLine(list_numbers[i]);
            }

            // Dictionary
            // In a Dictionary the keys must be uniq and not null
            Dictionary<int, string> names = new Dictionary<int, string>()
            {
                {10, "Ahmed" },
                {20, "Adam" },
                {30, "Anouar" },
            };
            names.Add(1, "Reda");
            names.Add(2, "Ali");
            names.Add(3, "Ayoub");
            for (int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine("----------");
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }
            // Declaring a <string, string> Dictionary
            Dictionary<string, string> teachers = new Dictionary<string, string>() {
                {"Math", "Hassan" },
                {"Arabic", "Jawad" },
                {"French", "AbdelKader" },
            };

            // Not recomanded
            Console.WriteLine(teachers["Math"]);

            // The recomanded way
            if(teachers.TryGetValue("English", out string teacher))
            {
                Console.WriteLine(teacher);
            } else
            {
                Console.WriteLine("Teacher not Found");
            }
            Console.WriteLine(teachers.Remove("Math"));

            // Before Removing something always check first
            if (teachers.ContainsKey("Arabic"))
            {
                teachers.Remove("Arabic");
                Console.WriteLine("Arabic removed");
            } else
            {
                Console.WriteLine("Arabic not found");
            }

            // Exercice
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            for (int i = 0; i < 74 ; i++)
            {
                Console.WriteLine(i);
                if( i % 2 == 0 )
                {
                    evenNumbers.Add(i);
                } else
                {
                    oddNumbers.Add(i);
                }
            }

            Console.WriteLine("the even numbers are: ");
            foreach (var number in evenNumbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            Console.WriteLine("the odd numbers are: ");
            foreach (var number in oddNumbers)
            {
                Console.Write($"{number} ");
            }


            // Array of multiple
            int my_number_1 = 7;
            int my_number_2 = 5;
            int[] result_Array = new int[5];
            int counter = 0;
            Console.WriteLine();
            Console.WriteLine("------------------------------");
                for (int i = 1; i <= my_number_2; i++, counter++)
                {
                /*Console.WriteLine($"{my_number_1} x {i} = {my_number_1 * i} ");*/
                result_Array[counter] = my_number_1 * i;
                }
            Console.WriteLine("------------------------------");
            foreach (int number in result_Array)
            {
                Console.WriteLine(number);
            }

            welcomeMessage(name: "Reda");

            Console.ReadLine();

        }

        static void welcomeMessage(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
