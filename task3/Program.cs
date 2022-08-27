//Нахождение первого по очередности года с неповторяющими числами.

Console.WriteLine("Введите год c 1000 до 9000: ");
int x = int.Parse(Console.ReadLine());
if(x < 1000 || x > 9000)
{
    Console.WriteLine("Вы ввели некорректный год!!!");
    return;
}


void SearchYear(int year)
{
    for(int y = x + 1;  ; y++)
    {
        int n1 = y % 10;
        int z = y / 10;
        int n2 = z % 10;
        z = z / 10;
        int n3 = z % 10;
        z = z / 10;
        int n4 = z % 10;
        if(n1 != n2 && n1 != n3 && n1 != n4 && n2 != n3 && n2 != n4 && n3 != n4)
        {
            Console.WriteLine("Первый год с неповторяющими числами после заданного == " + y);
            return;
        }
    }
}

SearchYear(x);   