using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4_Interface;
internal class River : IGeographicalObject
{
    private double X;
    private double Y;
    private string Name;
    private string Description;
    private double Length;
    private double Speed;

    public River(double x, double y, string name, string description, double length, double speed)
    {
        X = x;
        Y = y;
        Name = name ;
        Description = description;
        Length = length;
        Speed = speed;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Ім'я об'єкту: {Name}\n" +
            $"Координата по Х: {X}\n" +
            $"Координата по Y: {Y}\n" +
            $"Опис: {Description}\n" +
            $"Довжина річки: {Length}\n" +
            $"Швидкість річки: {Speed}");
    }
}
