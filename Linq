using System;
using System.Linq;
class HelloWorld
{
    static void Main()
    {
        var nums = (from n in Console.ReadLine().Split()
            select int.Parse(n)).ToList();
        Printer(nums);

        Console.WriteLine("Удаление отрицательных элементов . . . ");

        nums.RemoveAll(x => x < 0);
        Printer(nums);
    }
    static void Printer(IEnumerable<int> nums)
    {
        var even = from n in nums
            where n % 2 == 0
            select n;

        var plus = from n in nums
            where n > 0
            select n;

        var nozero = from n in nums
            where n != 0
            select n;

        Console.WriteLine($@"
min: {nums.Min()}
max: {nums.Max()}
кол-во четных: {even.Count()}
кол-во положительных: {plus.Count()}
кол-во ненулевых: {nozero.Count()}
");
    }
}
