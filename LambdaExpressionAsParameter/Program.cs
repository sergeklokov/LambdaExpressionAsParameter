using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaExpressionAsParameter
{
    class Program
    {
        class Item
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            SearchWithLambdas();

            BasicLambdas();

            Console.WriteLine("Press any key..");
            Console.ReadKey();
        }

        static void SearchWithLambdas()
        {
            var items = new List<Item>
            {
                new Item(){ Id = 1, Name = "Adam" },
                new Item(){ Id = 2, Name = "Billy" },
                new Item(){ Id = 3, Name = "Cecil" }
            };

            Console.WriteLine("Length == 5");
            PrintItems(items, x => x.Name.Length == 5);
            Console.WriteLine();

            Console.WriteLine("Id is odd number");
            PrintItems(items, r => r.Id % 2 == 1);
            Console.WriteLine();
        }

        static void PrintItems(List<Item> list, Func<Item, bool> condition)
        {
            var selectedItems = list.Where(condition);

            foreach (var item in selectedItems)
            {
                Console.WriteLine("{0}, {1}", item.Id, item.Name);
            }
        }

        static void BasicLambdas()
        {
            // Part 1: use implicitly-typed lambda expression.
            // ... Assign it to a Func instance.
            Func<int, int> func1 = x => x + 1;
            Console.WriteLine("FUNC1: {0}", func1.Invoke(200));

            // Part 2: use lambda expression with statement body.
            Func<int, int> func2 = x => { return x + 1; };
            Console.WriteLine("FUNC2: {0}", func2.Invoke(200));

            // Part 3: use formal parameters with expression body.
            Func<int, int> func3 = (int x) => x + 1;
            Console.WriteLine("FUNC3: {0}", func3.Invoke(200));

            // Part 4: use parameters with a statement body.
            Func<int, int> func4 = (int x) => { return x + 1; };
            Console.WriteLine("FUNC4: {0}", func4.Invoke(200));



            // Use multiple parameters.
            Func<int, int, int> funcMultiply = (x, y) => x * y;
            // ... No need to call Invoke(), just call lambda directly.
            Console.WriteLine("RESULT: {0}", funcMultiply(20, 2));
        }
    }
}
