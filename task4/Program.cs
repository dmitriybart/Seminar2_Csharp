// показать таблицу квадратов чисел от 1 до N

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int count = 1;
while (count <= n);
{
    int result = count*count;
    Console.Write(result + " ");
    count++;
    
}