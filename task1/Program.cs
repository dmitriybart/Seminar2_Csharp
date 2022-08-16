// Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine("Введите число: ");
int UserNumber = int.Parse (Console.ReadLine());
if (UserNumber%7==0 && UserNumber%23==0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число НЕ кратно 7 и 23 !");
}