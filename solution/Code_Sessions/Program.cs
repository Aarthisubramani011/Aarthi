using System;

Console.Write("Enter an value:");
int nInput = Convert.ToInt32(Console.ReadLine());
while (nInput != 1)
{
    Console.Write( nInput +" ");
    if (nInput % 2 == 0)
    {
        nInput = nInput / 2;
    }
    else
    {
        nInput = nInput * 3 +1;
    }
}
Console.WriteLine(nInput);
