using System;

namespace Lab3._1_Student_Information
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] student = { "Rick", "Adam", "Eric", "Tyler", "Aaron", "Chuck", "Manny", "Kathryn", "Eugene", "Brendan", "Jim", "David", "Zach", "Dave", "Riley", "Mike" };
            string[] food = { "Pizza", "Tacos", "Pork Chops", "Baked Potatos", "Steak", "Spaghetti", "Caesar Salad", "Nachos", "BBQ Chicken", "Pulled Pork", "Chicken Parmesan", "BLT", "Cobb Salad", "Ribs", "Bacon Cheese Burger", "Tuna Casserole" };
            string[] title = { "Junior", "Associate", "Senior", "Junior", "Associate", "Senior", "Junior", "Associate", "Senior", "Junior", "Associate", "Senior", "Junior", "Associate", "Senior", "Junior" };

            bool running = true;
            while (running)
            {
                Console.WriteLine($"Welcome to our Dev.Build class. Which student would you like to learn about?");
                Console.Write($"(enter a number 1-16): ");
                string entry = Console.ReadLine();
                int index = int.Parse(entry) - 1;
                if (index < 16)
                {
                    Console.WriteLine();
                    Console.Write($"Student {entry} is {student[index]}. What would you like to know about {student[index]}?\n");
                }
                Console.Write($"(enter favorite food or previous title): ");
                entry = Console.ReadLine();
                while (entry != "favorite food" && entry != "previous title")
                {
                    Console.WriteLine($"That data does not exist. Please try again. (enter favorite food or previous title)");
                    entry = Console.ReadLine();
                }
                if (entry == "favorite food")
                {
                    Console.WriteLine();
                    Console.WriteLine($"{student[index]}'s favorite food is {food[index]}");
                }
                else if (entry == "previous title")
                {
                    Console.WriteLine();
                    Console.WriteLine($"{student[index]}'s previous title is {title[index]}");
                }
                Console.WriteLine();
                Console.WriteLine($"Would you like to know about another student? (enter yes or no): ");
                string cont = Console.ReadLine();
                if (cont == "yes" || cont == "Yes" || cont == "y" || cont == "Y")
                {
                    running = true;
                    {
                        Console.Clear();
                    }
                }
                else if (cont == "no" || cont == "No" || cont == "n" || cont == "N")
                {
                    running = false;
                    {
                        Console.WriteLine();
                        Console.WriteLine($"Thanks!");
                    }
                }
            }
        }
    }
}
