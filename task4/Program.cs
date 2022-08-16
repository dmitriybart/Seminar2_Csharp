// показать таблицу квадратов чисел от 1 до N

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int count = 0;
int i = 1;
while (count < n);
{
    int result = i*i;
    Console.Write(result + " ");
    count++;
    i++;
}