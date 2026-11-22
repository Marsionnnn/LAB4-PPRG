Dictionary<string, int> ceny = new Dictionary<string, int>
{
    { "Miecz", 100 },
    { "Tarcza", 75 },
    { "Mikstura", 20 }
};
foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: {para.Value} sztuk złota");
}
Console.WriteLine("Podaj nazwę przedmiotu, który chcesz dodać do sklepu:");
string nazwa;

while (true)
{
    Console.WriteLine("Podaj nazwę przedmiotu:");
    nazwa = Console.ReadLine()!;

    if (string.IsNullOrWhiteSpace(nazwa))
    {
        Console.WriteLine("Nieprawidłowa nazwa. Spróbuj ponownie.");
        continue;
    }

    if (ceny.ContainsKey(nazwa))
    {
        Console.WriteLine("Przedmiot już istnieje. Spróbuj ponownie.");
        continue;
    }

    break;
}
ceny.Add(nazwa, 0);
Console.WriteLine("Podaj cenę przedmiotu:");
int cena;
while (true)
{
    if (int.TryParse(Console.ReadLine(), out cena) && cena > 0)
    {
        break;
    }
    else
    {
        Console.WriteLine("Nieprawidłowa cena. Spróbuj ponownie.");
    }
}
ceny[nazwa] = cena;
if (ceny.ContainsKey(nazwa))
{
    Console.WriteLine($"Dodano przedmiot");
}
else
{
    Console.WriteLine($"Nie udało się dodać przedmiotu: {nazwa}");
}
KeyValuePair<string, int> przedmiot = new KeyValuePair<string, int>(nazwa, cena);
Console.WriteLine($"Dodano przedmiot: {przedmiot.Key} o cenie {przedmiot.Value} sztuk złota");
foreach (KeyValuePair<string, int> para in ceny)
{
    Console.WriteLine($"{para.Key}: {para.Value} sztuk złota");
}