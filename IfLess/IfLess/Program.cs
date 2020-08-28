using System;
using System.Collections.Generic;
using System.Linq;

namespace IfLess
{
    class Program
    {
        static void Edit()
        {
            Console.WriteLine("Edit");
        }

        static void Add()
        {
            Console.WriteLine("Add");
        }

        static void Delete()
        {
            Console.WriteLine("Delete");
        }

        static void Main(string[] args)
        {
            var measureActions = new MeasureAction[]
            {
                new MeasureAction(m => m == "Add", () => Add()),
                new MeasureAction(m => m == "Edit", () => Edit()),
                new MeasureAction(m => m == "Delete", () => Delete()),
                new MeasureAction(m => true, () => Delete())
            };
            var action = "Add";

            measureActions.First(x => x.CanAppply(action)).Action();
            action = "Edit";
            measureActions.First(x => x.CanAppply(action)).Action();
            action = "default";
            measureActions.First(x => x.CanAppply(action)).Action();
            Console.Read();
        }
    }
}
