using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4;
internal class GeographicalObject
{
    private double X;
    private double Y;
    private string Name;
    private string Description;

    public GeographicalObject(double x, double y, string name, string description)
    {
        X = x;
        Y = y;
        Name = name;
        Description = description;
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine($"Ім'я об'єкту: {Name}\n" +
            $"Координата по Х: {X}\n" +
            $"Координата по Y: {Y}\n" +
            $"Опис: {Description}");
    }
}
