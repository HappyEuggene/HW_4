using HW_4_Interface;
using static HW_4_Interface.Constants;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Console.Write("Введіть ваш об'єкт(River/Mountain): ");
        string chosenObject = Console.ReadLine();

        Console.Write("Введіть координату Х: ");
        double x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введіть координату Y: ");
        double y = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введіть опис вашого об'єкту: ");
        string description = Console.ReadLine();

        switch (chosenObject)
        {
            case Choice.river:
            Console.Write("Введіть ім'я річки: ");
            string name = Console.ReadLine();

            Console.Write("Введіть швидкість річки: ");
            double speed = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введіть довжину річки: ");
            double length = Convert.ToInt32(Console.ReadLine());

            River river = new River(x, y, name, description, length, speed);
            river.ShowInfo();
            break;

            case Choice.mountain:
            Console.Write("Введіть ім'я гори: ");
            name = Console.ReadLine();

            Console.Write("Введіть найвищу точку гори: ");
            double peak = Convert.ToInt32(Console.ReadLine());

            Mountain mountain = new Mountain(x, y, name, description, peak);
            mountain.ShowInfo();
            break;
        }
    }
}