using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProject
{
    public class LinqDemo
    {

        public static void QueryOverStrings()
        {
            string[] currentVideoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };

            IEnumerable<string> subset = from g in currentVideoGames
                                         where g.Contains(" ")
                                         orderby g
                                         select g;

            foreach (var s in subset)
            {
                Console.WriteLine("Item:{0}", s);
            }
        }

        public static void OfTypeAsFilter()
        {
            //从ArrayList中提取整数
            ArrayList myStuff = new ArrayList();
            myStuff.AddRange(new object[] { 10, 400, 8, false, new Car(), "string data" });
            var myInts = myStuff.OfType<int>();
            foreach (var i in myInts)
            {
                Console.WriteLine("Int value:{0}", i);
            }
        }

        public static void LINQOverArrayList()
        {
            Console.WriteLine("**********LINQ over ArrayList");

            ArrayList myCards = new ArrayList
            {
                new Car {PetName = "Herry",Color = "Silver",Speed = 100,Make="BMW"},
                new Car {PetName = "Daisy",Color = "Tan",Speed = 90,Make="BMW"},
                new Car { PetName = "Marry",Color = "Black",Speed=55,Make="VM"},
                new Car { PetName = "Clunker",Color = "Rust",Speed=5,Make="Yugo"},
                new Car { PetName = "Melvin",Color = "White",Speed=43,Make="Ford"}
            };

            var myCarsEnum = myCards.OfType<Car>();

            var fastCars = from c in myCarsEnum
                           where c.Speed > 55
                           select c;

            foreach (var car in fastCars)
            {
                Console.WriteLine("{0} is going too fast!", car.PetName);
            }
        }

        public static void GetCountFromQuery()
        {
            string[] currentViedoGames = { "Morrowind", "Uncharted 2", "Fallout 3", "Daxter", "System Shock 2" };
            int numb = (from g in currentViedoGames where g.Length > 6 select g).Count();

            //打印页数
            Console.WriteLine("{0} items honor the LINQ query.", numb);
        }

        #region 维恩图

        public static void DisplayDiff()
        {
            List<string> myCars = new List<string> {"Yugo","Aztec", "BMW" };
            List<string> yourCars = new List<string> {"BMW","Saab","Aztec"};

            var carDiff = (from c in myCars select c)
                .Except(from c2 in yourCars select c2);
            Console.WriteLine("Here is what you don't have,but i do:");
            foreach (var s in carDiff)
            {
                Console.WriteLine(s);
            }
        }

        public static void DisplayIntersection()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carIntersect = (from c in myCars select c)
                .Intersect(from c2 in yourCars select c2);
            Console.WriteLine("Here is what you don't have,but i do:");
            foreach (var s in carIntersect)
            {
                Console.WriteLine(s);
            }
        }

        public static void DisplayUnion()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carIntersect = (from c in myCars select c)
                .Union(from c2 in yourCars select c2);
            Console.WriteLine("Here is what you don't have,but i do:");
            foreach (var s in carIntersect)
            {
                Console.WriteLine(s);
            }
        }

        public static void DisplayConcat()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carIntersect = (from c in myCars select c)
                .Concat(from c2 in yourCars select c2);
            Console.WriteLine("Here is what you don't have,but i do:");
            foreach (var s in carIntersect.Distinct())
            {
                Console.WriteLine(s);
            }
        }

       public static void AggregateOps()
        {
            double[] winterTemps = { 2.0, -21.3, 8, -4, 0, 8.2 };

            // Various aggregation examples. 
            Console.WriteLine("Max temp: {0}",
              (from t in winterTemps select t).Max());

            Console.WriteLine("Min temp: {0}",
              (from t in winterTemps select t).Min());

            Console.WriteLine("Avarage temp: {0}",
              (from t in winterTemps select t).Average());

            Console.WriteLine("Sum of all temps: {0}",
              (from t in winterTemps select t).Sum());
        }

        public static void QueryStringsWithAnonymousMethods()
        {
            Console.WriteLine("***** Using Anonymous Methods *****");

            string[] currentVideoGames = {"Morrowind", "Uncharted 2",
                "Fallout 3", "Daxter", "System Shock 2"};

            // Build the necessary Func<> delegates using anonymous methods.
            Func<string, bool> searchFilter =new Func<string, bool>(str=> str.Contains(" "));
              //delegate (string game) { return game.Contains(" "); };
            Func<string, string> itemToProcess = delegate (string s) { return s; };

            // Pass the delegates into the methods of Enumerable.
            var subset = currentVideoGames.Where(searchFilter)
              .OrderBy(itemToProcess).Select(itemToProcess);

            // Print out the results.
            foreach (var game in subset)
                Console.WriteLine("Item: {0}", game);
            Console.WriteLine();
        }
        #endregion
    }


    public class Car
    {
        public string PetName { get; set; }

        public string Color { get; set; }

        public int Speed { get; set; }
        public string Make { get; set; }
    }
}
