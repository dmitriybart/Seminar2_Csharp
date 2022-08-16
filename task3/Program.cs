// Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("Введите пятизначное число: ");
int UserNumber = int.Parse(Console.ReadLine());
int divUserNumber = UserNumber/1000;
int Recursiv = (UserNumber%10*10)+(UserNumber%100/10);
if (divUserNumber==Recursiv)
{
    Console.WriteLine("Число " +UserNumber+ " является полиндромом !");
}
else 
{
    Console.WriteLine("Число " +UserNumber+ " НЕ является полиндромом !");
}
