using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_4;
internal class Mountain : GeographicalObject
{
    private double HighestPoint;

    public Mountain(double highestPoint, double x, double y, string name, string description) : base(x, y, name, description)
    {
        HighestPoint = highestPoint;
    }

    public override void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine($"Найвища точка: {HighestPoint}");
    }
}
