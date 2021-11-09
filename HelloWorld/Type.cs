using System;

namespace HelloWorld
{
    public class Types
    {
        public Types()
        {
            // Class
            Point p1 = new Point(0, 0);
            Point p2 = new Point(10, 20);

            // Base Classes
            Point a = new Point(10, 20);
            Point b = new Point3D(10, 20, 30);

            // Type Parameters
            Pair<int, string> pair = new(1, "two");
            int i = pair.First;     // TFirst int
            string s = pair.Second; // TSecond string

            // Multiple Interface
            EditBox editBox = new EditBox();
            IControl control = editBox;
            IDataBound dataBound = editBox;

            // Enums
            var turnip = SomeRootVegetable.Turnip;

            var spring = Seasons.Spring;
            var startingOnEquinox = Seasons.Spring | Seasons.Autumn;
            var theYear = Seasons.All;

            // Nulable Types
            int? optionalInt = default;
            optionalInt = 5;
            string? optionalText = default;
            optionalText = "Hello World.";

            // Tuples
            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
            // Output:
            // Sum of 3 elements is 4.5.
        }
    }
}