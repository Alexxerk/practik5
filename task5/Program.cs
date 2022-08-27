//Находим сколько денег потрбуется занять у однополчанина.

Console.WriteLine("Введите цену за один банан: ");
int k = int.Parse(Console.ReadLine());
Console.WriteLine("Введите нужное количество бананов: ");
int w = int.Parse(Console.ReadLine());
Console.WriteLine("Введите сколько денег у солдата: ");
int n = int.Parse(Console.ReadLine());

int x = w * k - n;

if (x > 0)
{
    Console.WriteLine(x + " == такую сумму нужно одолжить");
}
else if (x < 0)
{
    Console.WriteLine(" == столько денег останется после покупки бананов" + -x);
}
else if (x == 0)
{
    Console.WriteLine("Kоличество денег у солдата == количеству денег необходимых на покупку бананов");
}