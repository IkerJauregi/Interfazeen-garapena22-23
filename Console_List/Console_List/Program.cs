// See https://aka.ms/new-console-template for more information
using Console_List;

Console.WriteLine("Hello, World!");
List<Datuak> datuak = new List<Datuak>();
datuak.Add(new Datuak("Aulkia"));
datuak.Add(new Datuak("Laranja"));

Datuak barria = new Datuak("Sagarra");
datuak.Add(barria);

for (int i = 0; i < datuak.Count; i++)
{
    Console.WriteLine(datuak[i].Izena);
}
Console.ReadLine();
    foreach (Datuak datua in datuak)
{
    Console.WriteLine(datua.Izena);
}
Console.ReadLine();
Console.WriteLine(Datuak.DatuenZerrenda(datuak));