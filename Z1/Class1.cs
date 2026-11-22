using System;

namespace Company.ClassLibrary1;

public class Class1
{
int[] zlotoWTurach = { 5, 12, 0, 8, 15 };
length = zlotoWTurach.Length;
Console.WriteLine("Liczba tur: " + length);
Console.WriteLine("Ilośc złota w każdej turze:");
for (int i = 0; i < length; i++)
{
    Console.WriteLine("Tura " + (i + 1) + ": " + zlotoWTurach[i] + " złota");
}
int sumaZlota = 0;
for (int i = 0; i < length; i++)
{
    sumaZlota += zlotoWTurach[i];
}
Console.WriteLine("Suma złota: " + sumaZlota);
Console.WriteLine("Średnia złota na turę: " + (double)sumaZlota / length);
Console.WriteLine("Ilość tur w których zdobyto więcej niż 10 złota:");
int iloscTur = 0;
for (int i = 0; i < length; i++)
{
    if (zlotoWTurach[i] > 10)
    {
        iloscTur++;
    }
}
Console.WriteLine("Ilość tur w których zdobyto więcej niż 10 złota: " + iloscTur);
Console.WriteLine("Ilość złota w każdej turze na odwrót:");
for (int i = length - 1; i >= 0; i--)
{
    Console.WriteLine("Tura " + (i + 1) + ": " + zlotoWTurach[i] + " złota");
}   
}
