using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_and_Lambda
{

    struct Data
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var items = new List<Data>
            {
            new Data { X = 1, Y = 2 },
            new Data { X = 3, Y = 4 },
            new Data { X = 5, Y = 6 },
            new Data { X = 7, Y = 8 },
            new Data { X = 9, Y = 10 },
            };

            //Query syntax
            //var results = from item in items select item.X;

            //Labda syntax
            var results = items.Select(item => item.X);

            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
