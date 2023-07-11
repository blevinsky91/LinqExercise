using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExercise
{
    class Program
    {
        //Static array of integers
        private static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

        static void Main(string[] args)
        {
            /*
             * 
             * Complete every task using Method OR Query syntax. 
             * You may find that Method syntax is easier to use since it is most like C#
             * Every one of these can be completed using Linq and then printing with a foreach loop.
             * Push to your github when completed!
             * 
             */

            //TODO: Print the Sum of numbers - done 

            Console.WriteLine(numbers.Sum());
            Console.WriteLine();

            //TODO: Print the Average of numbers - done

            Console.WriteLine(numbers.Average());
            Console.WriteLine();

            //TODO: Order numbers in ascending order and print to the console - done

            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //TODO: Order numbers in descending order and print to the console - done

            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //TODO: Print to the console only the numbers greater than 6 - done

            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //TODO: Order numbers in any order (ascending or desc) but only print 4 of them **foreach loop only!** - done

            numbers.OrderByDescending(x => x).Take(4).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();

            //TODO: Change the value at index 4 to your age, then print the numbers in descending order - done

            numbers.SetValue(31, 4);
            var desc = numbers.OrderByDescending(x => x);
            foreach (var item in desc)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // List of employees ****Do not remove this****
            var employees = CreateEmployees();
            Console.WriteLine();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in ascending order by FirstName. - done

            employees.Where(x => x.FirstName.ToLower().StartsWith('c') || x.FirstName
            .ToLower().StartsWith('s')).OrderBy(x => x.FirstName)
            .ToList().ForEach(x => Console.WriteLine(x.FullName));
            Console.WriteLine();


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result. - done

            var over26 = employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName);
            foreach (var person in over26)
            {
                Console.WriteLine($"Full name: {person.FullName}, Age: {person.Age}");
            }
            Console.WriteLine();

            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35. - done

            IEnumerable<Employee> filter = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35);

            var sum = filter.Sum(x => x.YearsOfExperience);
            Console.WriteLine($"Sum of Years Of Age: {sum}");
            Console.WriteLine();
            double average = filter.Average(x => x.YearsOfExperience);
            Console.WriteLine($"Average of Years Of Age: {Math.Round(average)}");
            Console.WriteLine();


            //TODO: Add an employee to the end of the list without using employees.Add() - done

            Employee newEmployee = new Employee("Brandon", "Levinsky", 32, 1);
            employees.Append(newEmployee).ToList().ForEach(x => Console.WriteLine(x.FullName));
            foreach (var item in employees)
            {
                Console.WriteLine(item.FullName);
            }


            Console.WriteLine();

            Console.ReadLine();
        }

        #region CreateEmployeesMethod
        private static List<Employee> CreateEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee("Cruz", "Sanchez", 25, 10));
            employees.Add(new Employee("Steven", "Bustamento", 56, 5));
            employees.Add(new Employee("Micheal", "Doyle", 36, 8));
            employees.Add(new Employee("Daniel", "Walsh", 72, 22));
            employees.Add(new Employee("Jill", "Valentine", 32, 43));
            employees.Add(new Employee("Yusuke", "Urameshi", 14, 1));
            employees.Add(new Employee("Big", "Boss", 23, 14));
            employees.Add(new Employee("Solid", "Snake", 18, 3));
            employees.Add(new Employee("Chris", "Redfield", 44, 7));
            employees.Add(new Employee("Faye", "Valentine", 32, 10));

            return employees;
        }
        #endregion
    }
}
