using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> favFoods = new List<string>() {"pizza", "alfredo", "chicken", "sushi", "broccoli", };
            //Console.WriteLine(favFoods[0]);
            //Console.WriteLine(favFoods[4]);

            //List<string> badFoods = new List<string>();
            //badFoods[0] = "onions";
            //badFoods[1] = "mushrooms";
            //badFoods[2] = "liver";
            //badFoods[3] = "Pig Feet";




            //List<int> luckyNums = new List<int>();
            //luckyNums.Add(13);
            //luckyNums.Add(0);
            //luckyNums.Add(44);
            //luckyNums.Add(7);

            //List<string> favMovies = new List<string>() { "Uptown Girls", "Pursuit of Happyness", "Big Daddy" };
            //favMovies.Insert(0, "The Big Sick");
            //for (int counter = 0; counter < favMovies.Count; counter++)
            //{
            //    Console.WriteLine(favMovies[counter]);
            //}

            //foreach (string movie in favMovies)
            //{
            //    Console.WriteLine(movie);
            //}

            //favMovies.Remove("Uptwon Girls");
            //favMovies.Remove("Pursuit of Hapyyness");

            //foreach (string film in favMovies)
            //{
            //    Console.WriteLine(film);
            //}

            //List<string> animals = new List<string>();
            //animals.Add("cat");
            //animals.Add("dog");
            //animals.Add("giraffe");
            //animals.Add("bird");
            //animals.Add("pig");
            //foreach (string name in animals)
            //{
            //    Console.WriteLine(name);
            //}

            //List<bool> boolList = new List<bool>() { true, false, false, true, false };
            //foreach (bool item in boolList)
            //{
            //    Console.WriteLine(item);

            //    if (item == true)
            //    {
            //        Console.WriteLine("Better bring an umbrella");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No rain today, enjoy the sun!");
            //    }
            //}

            //List<int> numbers = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };  //do RemoveAt and insert for these numbers!!
            
            ////foreach (int num in numbers)
            ////{
            ////    Console.WriteLine(num);
            ////}
            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));

            //numbers.Remove(77);
            //numbers.Remove(32);
            //numbers.Remove(6);

            //Console.WriteLine(numbers.Contains(23));
            //Console.WriteLine(numbers.Contains(77));
            //Console.WriteLine(numbers.Contains(15));

            List<string> dogs = new List<string>();      //Insert

            dogs.Add("spaniel"); 
            dogs.Add("beagle"); 
            dogs.Insert(1, "dalmatian"); 

            foreach (string dog in dogs) 
            {
                Console.WriteLine(dog);
            }

            dogs.RemoveAt(1);
            foreach (string dog in dogs)
            {
                Console.WriteLine(dog);
            }

            //object           //key, value//name       //creating new object of type key, value
            Dictionary<int, string> coatCheck = new Dictionary<int, string>();



        }

    }
}
