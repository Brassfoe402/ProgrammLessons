using System;

delegate double Oper(double x, double y);
interface ICalc
{
    double Add(double x, double y);
    double Subtract(double x, double y);
    double Multiply(double x, double y);
    double Divide(double x, double y);
}
class Calc : ICalc
{
    public double Add(double x, double y) => x + y;
    public double Subtract(double x, double y) => x - y;
    public double Multiply(double x, double y) => x * y;
    public double Divide(double x, double y) => x / y;
}
class HelloWorld
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Калькулятор: ");
            try
            {
                string[] Input = Console.ReadLine().Split();
                var x = Convert.ToDouble(Input[0]);
                var y = Convert.ToDouble(Input[2]);
                Calc opers = new Calc();
                Oper res;
                switch (Input[1])
                {
                    case "+":
                        res = opers.Add;
                        Ans(res, x, y);
                        break;

                    case "-":
                        res = opers.Subtract;
                        Ans(res, x, y);
                        break;

                    case "*":
                        res = opers.Multiply;
                        Ans(res, x, y);
                        break;

                    case "/":
                        res = opers.Divide;
                        if (y != 0)
                            Ans(res, x, y);
                        else
                            Console.WriteLine("Деление на ноль");
                        break;

                    default:
                        Console.WriteLine("Некорректный ввод операции");
                        break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректный ввод");
            }
            Console.WriteLine("\nДля продолжения нажмите любую клавишу . . .");
            Console.ReadKey();
            Console.Clear();
        }
    }
    static void Ans(Oper res, double x, double y)
    {
        Console.WriteLine($"= {res(x, y)}");
    }
}
