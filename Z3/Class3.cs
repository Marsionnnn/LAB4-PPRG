List<string> plecak = new List<string>
{
    "Miecz",
    "Mikstura",
    "Mapa"
};
 
Console.WriteLine("Zawartość plecaka:");
 
foreach (string przedmiot in plecak)
{
    Console.WriteLine(przedmiot);
}
 
Console.WriteLine("Liczba przedmiotów w plecaku: " + plecak.Count);
 
Console.WriteLine("Podaj nazwę nowego przedmiotu:");
string newItem = Console.ReadLine();
 
while (string.IsNullOrEmpty(newItem))
{
    Console.WriteLine("Nie podano nazwy przedmiotu. Podaj nazwę nowego przedmiotu:");
    newItem = Console.ReadLine();
}
 
plecak.Add(newItem);
Console.WriteLine("Dodano przedmiot do plecaka: " + newItem);
 
Console.WriteLine("Podaj nazwę przedmiotu do usunięcia:");
string itemToDelete = Console.ReadLine();
 
while (string.IsNullOrEmpty(itemToDelete))
{
    Console.WriteLine("Nie podano nazwy przedmiotu. Podaj nazwę przedmiotu do usunięcia:");
    itemToDelete = Console.ReadLine();
}
 
if (plecak.Contains(itemToDelete))
{
    plecak.Remove(itemToDelete);
    Console.WriteLine("Usunięto przedmiot z plecaka: " + itemToDelete);
}
else
{
    Console.WriteLine("Nie znaleziono przedmiotu w plecaku: " + itemToDelete);
}
 
Console.WriteLine("Zawartość plecaka po zmianach:");
 
foreach (string przedmiot in plecak)
{
    Console.WriteLine(przedmiot);
}
 
Console.WriteLine("Liczba przedmiotów w plecaku po zmianach: " + plecak.Count);