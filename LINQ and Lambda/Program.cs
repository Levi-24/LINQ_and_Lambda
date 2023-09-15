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
            new Data { X = 9, Y = 2 },
            new Data { X = 3, Y = 4 },
            new Data { X = 5, Y = 6 },
            new Data { X = 7, Y = 8 },
            new Data { X = 1, Y = 10 },
            };

            //Selection
            //Query syntax
            //var results = from item in items select item.X;

            //Labda syntax
            var results = items.Select(item => item.X);

            //Projection
            //Query syntax
            //var dblresults = from item in items
            //                 select new
            //                 {
            //                     X2 = item.X * 2,
            //                     Y2 = item.Y * 2
            //                 };

            //Lambda syntax
            var dblresults = items.Select(item => new
            {
                X2 = item.X * 2,
                Y2 = item.Y * 2
            });

            //Filtering
            //Query syntax
            //var smlresult = from item in items where item.X < 6 select item.X;

            //Lambda syntax
            var smlresult = items.Where(item => item.X < 6).Select(item => item.X);

            //Order by
            //Query syntax
            //items orderby item.X descending
            //var orderresult = from item in items orderby item.X ascending select item.X;

            //Lambda syntax
            //items.OrderByDescending(item => item.X)
            var orderresult = items.OrderBy(item => item.X).Select(item => item.X);


            //Output
            //Selection
            foreach (var item in results)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Projection
            foreach (var item in dblresults)
            {
                Console.WriteLine($"{item.X2} - {item.Y2}");
            }

            Console.WriteLine();

            //Filtering
            foreach (var item in smlresult)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            //Order by
            foreach (var item in orderresult)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
