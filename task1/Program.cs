//Найти сколько плиток потребуется для укладки театральной площади.

Console.WriteLine("Введите сторону квадратной плитки: ");
float a = float.Parse(Console.ReadLine());
Console.WriteLine("Введите длину площади: ");
float n = float.Parse(Console.ReadLine());
Console.WriteLine("Введите ширину площади: ");
float m = float.Parse(Console.ReadLine());
float n1 = 0;
float m1 = 0;

float LengthSquare(float one, float two)
{
    if(one % two == 0)
    {
        n1 = one / two;
        Console.WriteLine("Количество рядов плиток по длине площади == " + n1);
    }
    else
    {
        n1 = (one / two) + 1;
        var temp = (int)n1;
        n1 = temp;
        Console.WriteLine("Количество рядов плиток по длине площади == " + n1);
    }
    return n1;
}

float WidthSquare(float one, float two)
{
    if(one % two == 0)
    {
        m1 = one / two;
        Console.WriteLine("Количество рядов плиток по длине площади == " + m1);
    }
    else
    {
        m1 = (one / two) + 1;
        var temp = (int)m1;
        m1 = temp;
        Console.WriteLine("Количество рядов плиток по длине площади == " + temp);
    }
    return m1;
}
LengthSquare(n, a);
WidthSquare(m, a);
float s = n1 * m1;
Console.WriteLine("Количество плиток которые нужно использовать == " + s);