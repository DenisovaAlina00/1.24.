using System;
public class MainClass
{
    public static void Main()
    {
        double a, x;
        Console.WriteLine("Введите значение а:");
        a= int.Parse(Console.ReadLine());
        x = Math.Sqrt((2 * a + Math.Sin(3 * a)) / 3.56);
        Console.WriteLine("Ответ:{0}", x);
    }
}

