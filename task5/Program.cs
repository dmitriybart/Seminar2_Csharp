//возведите число А в степень В, все числа натуральные
Console.Write("Введите основание: ");
int a = int.Parse (Console.ReadLine());
Console.Write("Введите степень: ");
int b = int.Parse (Console.ReadLine());
int count = 1;
int sum = a;
if (count<=b)
{while (count < b)
{
    sum = sum*a;
    count++;
}
Console.WriteLine("Ответ: "+sum);
}
else 
Console.WriteLine("Ответ: 1");