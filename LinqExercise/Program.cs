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

            //TODO: Print the Sum of numbers
            Console.WriteLine("Sum of numbers: ");
            Console.WriteLine(numbers.Sum());

            //TODO: Print the Average of numbers
            Console.WriteLine("Average of numbers: ");
            Console.WriteLine(numbers.Average());

            //TODO: Order numbers in ascending order and print to the console
            Console.WriteLine("Numbers in ascending order: ");
            numbers.OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x));

            //TODO: Order numbers in decsending order and print to the console
            Console.WriteLine("Numbers in descending order: ");
            numbers.OrderByDescending(x => x).ToList().ForEach(x => Console.WriteLine(x));

            //TODO: Print to the console only the numbers greater than 6
            Console.WriteLine("Numbers greater than 6: ");
            numbers.Where(x => x > 6).ToList().ForEach(x => Console.WriteLine(x));

            //TODO: Order numbers in any order (acsending or desc) but only print 4 of them **foreach loop only!**
            Console.WriteLine("Order numbers in ascending order and print four of them: ");
            var ordered = numbers.OrderBy(x => x);
            
            foreach (var item in ordered.Take(4))
            {
                Console.WriteLine(item);
            }

            //ALSO: numbers.OrderBy(x => x).Take(4).ToList().ForEach(x => Console.WriteLine(x));


            //TODO: Change the value at index 4 to your age, then print the numbers in decsending order
            Console.WriteLine("Age");
            numbers.SetValue(21, 4); 
            //OR: numbers[4] = 21; 
            //OR: numbers.Select(x, i) ==> i == 4 ? 27 : x).OrderBy(x => x).ToList().ForEach(x => Console.WriteLine(x)); 

            foreach (var item in numbers.OrderByDescending(x => x))
            {
                Console.WriteLine(item);
            }

            // List of employees ****Do not remove this****
            List<Employee> employees = CreateEmployees();

            //TODO: Print all the employees' FullName properties to the console only if their FirstName starts with a C OR an S and order this in acesnding order by FirstName.
            Console.WriteLine("FirstName starting with C or S in ascending order");
                           employees.Where(x => x.FirstName.StartsWith('C') || x.FirstName[0] == 'S')
                                    .OrderBy(x => x.FirstName)
                                    .ToList()
                                    .ForEach(x => Console.WriteLine(x.FullName));


            //TODO: Print all the employees' FullName and Age who are over the age 26 to the console and order this by Age first and then by FirstName in the same result.
            Console.WriteLine("employees whose ages greater than 26- order them by age then firstname");
            employees.Where(x => x.Age > 26).OrderBy(x => x.Age).ThenBy(x => x.FirstName).ToList().ForEach(x => Console.WriteLine($"{x.FullName} {x.Age}"));


            //TODO: Print the Sum and then the Average of the employees' YearsOfExperience if their YOE is less than or equal to 10 AND Age is greater than 35
            var sum = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Sum(x => x.YearsOfExperience);
            Console.WriteLine(sum);

            Console.WriteLine("Average");
            var average = employees.Where(x => x.YearsOfExperience <= 10 && x.Age > 35).Average(x => x.YearsOfExperience);
            Console.WriteLine(average);
            
            //    //TODO: Add an employee to the end of the list without using employees.Add()
            //employees.Append(new Employee() { FirstName = "Yun", LastName = "Jang" }); //LIST IS TYPE EMPLOYEE
            employees.Append(new Employee("Michael", "Scott", 35, 10)).ToList().ForEach(x => Console.WriteLine($"Fullname: {x.FullName} Age: {x.Age} YOE: {x.YearsOfExperience}"));


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

List<string> videoGames = new List<string>() { "Starcraft", "Warcraft", "MarioParty", "Zelda", "Sonic_The_Hedgehog" };

videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));


