//Находим количество шагов которые должен сделать слон чтобы дойти до своего друга.

Console.WriteLine("Введите растояние от слона до друга: ");
int x = int.Parse(Console.ReadLine());
int y = 0;
int z = 0;
int step = 0;
for (step = -1; y != x; step++)
{
    y = y + z;
    z = 0;
    while(z < 5)
    {
        
        if(y + z == x)
        {
            break;
        }
        else
        {
            z++;
        }
 
    }
}

Console.WriteLine("Минимальное количество шагов которые нужно сделать == " + step + " step");
