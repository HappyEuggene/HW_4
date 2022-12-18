using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4;
internal class River : GeographicalObject
{
    private double Speed;
    private double Length;

    public River(double speed, double length, double x, double y, string name, string description) : base(x, y, name, description)
    {
        Speed = speed;
        Length = length;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Довжина річки: {Length}\n" +
            $"Швидкість річки: {Speed}");
    }
}
