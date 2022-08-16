// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0
Console.Write("Введите координату Х: ");
int x = int.Parse (Console.ReadLine());

Console.Write("Введите координату Y: ");
int y = int.Parse (Console.ReadLine());

if (x!=0 && y!=0)
{
    if (x > 0 && y > 0)
    {
    Console.WriteLine("Первая четверть.");
    }
    if (x < 0 && y > 0)
    {
    Console.WriteLine("Вторая четверть.");
    }
    if (x < 0 && y < 0)
    {
    Console.WriteLine("Третья четверть");
    }
    if (x > 0 && y < 0)
    {
    Console.WriteLine("Четвёртая четверть");
    }
}
else
{
    Console.WriteLine("Точка не принадлежит ни одной из четвертей плоской системы координат !");
}

