// Break and continue to the cicle for 
for(int  i = 1; i < 10; i++)
{
    if(i == 7)
    {
        break;
    };
    Console.WriteLine("Vueltas: " + i);
};

//Break and continue to the cicle while
int f = 0;
while (f < 10)
{
    Console.WriteLine("Num Vueltas: " + f);
    f++;
    if (f == 7)
    {
        //break;
        continue;

    };
};