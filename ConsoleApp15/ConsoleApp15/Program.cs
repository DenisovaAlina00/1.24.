using System;
public class MainClass
{
    public static void Main()
    {
        double y, x;
        Console.WriteLine("Введите значение х:");
        x=int.Parse(Console.ReadLine());
        y = Math.Sin((3.2 + Math.Sqrt(1 + x)) / 5);
        Console.WriteLine("Ответ:{0}",y);
    }
}
