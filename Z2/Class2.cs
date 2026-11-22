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
string nazwa = Console.ReadLine()!;
ceny.Add(nazwa, 0);
Console.WriteLine("Podaj cenę przedmiotu:");
int cena = int.Parse(Console.ReadLine()!)!;
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