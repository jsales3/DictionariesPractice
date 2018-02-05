using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //syntax = Dictionary<key data type, value data type> dictionaryName
            Dictionary<string, int> studentGrades = new Dictionary<string, int>()
            {
                {"Kerry", 90 },
                {"Barry", 85 },
                {"Michelle",100 }

            };

            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Snickers" },
                {"A2", "Swedish Fish" },
                {"A3", "Sour Patch Kids" },
                {"A4", "Funyuns" }
            };

            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            //using the add method, let's add drinks to our drink machine
            //This machine uses just a new to vend an item instead of
            //a letter number pair

            drinkMachine.Add(10, "Ginger Ale");
            drinkMachine.Add(11, "Bottled water");
            drinkMachine.Add(12, "Root Beer");
            drinkMachine.Add(13, "Diet Coke");
            drinkMachine.Add(14, "Sprite");
            drinkMachine.Add(15, "Sparkling water");

            //Count is a property. Returns the sixe of the dictionary
            Console.WriteLine(drinkMachine.Count);

            //we have another property called .Key
            foreach(KeyValuePair<int,string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
            }

            foreach(KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Value);
            }

            //create a dictionary for a theatre coat check with 10 elements
            //the will be the number and the value will be the coat style
            //print all values to the console

            Dictionary<int, string> coatCheck = new Dictionary<int, string>()
            {
                {1, "winter coat" },
                {2, "spring coat" },
                {3, "fall coat" },
                {4, "pea coat" },
                {5, "winter coat" },
                {6, "fall coat" },
                {7, "pea coat" },
                {8, "winter coat" },
                {9, "fall coat" },
                {10, "spring coat" }
            };
                foreach(KeyValuePair<int, string> coat in coatCheck)
            {
                Console.WriteLine(coat.Value);
            }



            //create a dictionary for a car valet service with 10 cars
            //the keys will be the customer's last name and the value 
            //will be the car make. Print all keys to the console

            Dictionary<string, string> carValet = new Dictionary<string, string>()
            {
                {"Sales", "Ford" },
                {"Williams", "Toyota" },
                {"James", "Honda" },
                {"Smith", "Ford" },
                {"Gibson", "Audi" },
                {"Thomas", "Toyota" },
                {"Love", "Ford" },
                {"Thompson", "Honda" },
                {"Rose","Audi" },
                {"Wade", "Toyota" }
            };

            foreach(KeyValuePair<string,string> name in carValet)
            {
                Console.WriteLine(name.Key);
            }

            //create a dictionary of 10 zoo animals. The key will be 
            //the animal type and the value will be the number of that 
            //animal type at the zoo. Print the animal with the highest
            //quantity to the console

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>()
            {
                { "Elephant", 10 },
                {"Giraffe", 40 },
                {"Lion",20 },
                {"Tiger", 30 },
                {"Bear", 30},
                {"Monkey",60 },
                {"Goat", 90 },
                {"Kangaroo", 85 },
                {"Sheep",70 },
                {"Pig",75 }

            };
            int high = 0;
            foreach(KeyValuePair<string,int> number in zooAnimals)
            {
                if(number.Value > high)
                {
                    high = number.Value;
                }
                
            }
            foreach(KeyValuePair<string,int> number in zooAnimals)
            {
                if(number.Value == high)
                {
                    Console.WriteLine(number.Key`);
                }
            }
        }
    }
}
