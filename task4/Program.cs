//Находим счастливые числа

Console.WriteLine("Введите число");
int x = int.Parse(Console.ReadLine());
int y = x;
int count = 0;
int count1 = 0;
int count2 = 0;
int i = 0;

for (count = 1; y / 10 != 0; count++)
{
    y = y / 10;
    
}
Console.WriteLine(count);

int[] array = new int[count];
y = x;

for (i = 0; i < count; i++)
{
    int a = y % 10;
    y = y / 10;
    array[i] = a;
}

i = 0;

while (i < count)
{
    if(array[i] == 4)
    {
        count1++;
    }
    else if (array[i] == 7)
    {
        count2++;
    }
    i++;
}

if (count1 + count2 == count)
{
    Console.WriteLine(x + " счастливое число");
    return;
}
else if (count1 == 4 || count1 == 7)
{
    Console.WriteLine(x + " полусчастливое число");
}
else if (count2 == 7 || count2 == 4)
{
    Console.WriteLine(x + " полусчастливое число");
}
else
{
    Console.WriteLine("Число " + x + " явлеется несчастливым");
}



