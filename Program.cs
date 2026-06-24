using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace LearnCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = 5, b = 2;  // comment 1 line
            /* comment
             2 line */
            Console.WriteLine($"a + b = {a + b}");
            // array
            string[] cars = new string[3];
            cars[0] = "Volvo";
            cars[1] = "BMW";
            cars[2] = "Ford";
            Console.WriteLine($"First car: {cars[0]}");
            Console.WriteLine($"Second car: {cars[1]}");
            Console.WriteLine($"Third car: {cars[2]}");
            // list
            List<int> numbers = new List<int>();
            numbers.Add(64);
            numbers.Add(128);
            numbers.Add(256);
            Console.WriteLine($"First number: {numbers[0]}");
            Console.WriteLine($"Second number: {numbers[1]}");
            Console.WriteLine($"Third number: {numbers[2]}");
            numbers.Remove(128);
            Console.WriteLine($"After removing 128, New second number: {numbers[1]}");
            numbers.Add(100);
            numbers[0] = numbers[1] + numbers[2];
            Console.WriteLine($"The new third number is {numbers[2]}");
            Console.WriteLine($"Total of first number is {numbers[0]}");
            // dictionary
            Dictionary<string, float> products = new Dictionary<string, float>();
            products.Add("Apple", 1.2f);
            products.Add("Banana", 0.5f);
            products.Add("Orange", 0.8f);
            Console.WriteLine($"Apple: ${products["Apple"]}");
            Console.WriteLine($"Banana: ${products["Banana"]}");
            Console.WriteLine($"Orange: ${products["Orange"]}");
            // if else
            if (a > b) Console.WriteLine("Arlight");

            if (products.Count > 10)
            { Console.WriteLine("Products are available."); }
            else
            { Console.WriteLine("No products available."); }

            int age = 15;
            if (age >= 18) Console.WriteLine("You are an adult");
            else if (age >= 13) Console.WriteLine("You are a teenager");
            else Console.WriteLine("You are a child");

            // switch case
            char grade = 'A';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good");
                    break;
                case 'C':
                    Console.WriteLine("Average");
                    break;
                case 'D':
                    Console.WriteLine("Passed");
                    break;
                case 'F':
                    Console.WriteLine("Failed");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }

            // for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"For loop iteration: {i}");
            }

            // while loop
            bool isTrue = true;
            int counter = 0;
            while (isTrue == true)
            {
                Console.WriteLine("Eternity");
                if (counter == 10)
                { isTrue = false; }
                counter++;
            }
            // foreach loop in array
            foreach (string car in cars)
            {
                Console.WriteLine($"Car: {car}");
            }
            // function
            string Hello(string name = "Noname")
            {
                return $"Hellow, {name}!";
            }
            /*tring h = Hello();
            Console.WriteLine(h); */
            Console.WriteLine(Hello("Por"));
            Console.WriteLine(Hello());

            /*string NumberCompare(int x, int y)
            {
                if (x > y) return $"{x} > {y}";
                else if (x < y) return $"{x} < {y}";
                else return $"{x} == {y}";

            }
            Console.WriteLine(NumberCompare(50, 50)); */

            void NumberCompare(int x, int y)
            {
                if (x > y) Console.WriteLine($"{x} > {y}");
                else if (x < y) Console.WriteLine($"{x} < {y}");
                else Console.WriteLine($"{x} == {y}");            
            }
            NumberCompare(20, 50);

            //Player p1 = new Player();
            List<Player> players = new List<Player>();

            for (int i = 0; i < 5; i++)
            {
                players.Add(new Player());
            }

            players.Add(new Player("Por", 100));
            players.Add(new Player("Gai", 50));
            players.Add(new Player("Jor", 40));
            //iplayers.Add(new Player());
            /* players[0].Name = "Por";
            players[0].Level = 100;
            players[1].Name = "Gai";
            players[1].Level = 50;
            players[2].Name = "Jor";
            players[2].Level = 40; */

            foreach (Player pl in players)
                Console.WriteLine($"Player name: {pl.Name}, Level: {pl.Level}");
        }
    }
    class Player
    {
        string name;
        int level;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        // constructor
        public Player(string name = "Unknow", int level = 1)
        {
            this .name = name;  
            this .level = level;
        }
    }
}
