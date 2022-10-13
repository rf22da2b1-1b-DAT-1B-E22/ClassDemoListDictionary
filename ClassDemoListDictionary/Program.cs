// See https://aka.ms/new-console-template for more information
using ClassDemoListDictionary;
using ClassDemoListDictionary.model;
using System.Globalization;

Console.WriteLine("Hello, World!");

/*
 * Brug af liste
 */
KundeKatalogListe kundeListe = new KundeKatalogListe();

// laver 5 dummy kunder
for (int i = 0; i < 5; i++)
{
    kundeListe.Add(new Kunde(i, "dummy" + i, $"{i + 1}{i + 1}{i + 2}{i + 2}{i + 3}{i + 3}{i + 4}{i + 4}"));
}


Console.WriteLine("Udeskriver Alle");
foreach (Kunde k in kundeListe.GetAll())
{
    Console.WriteLine("   " +k);
}

Console.WriteLine("Udskriver Kunde med id 3");
Console.WriteLine("   " + kundeListe.GetByNumber(3));


Console.WriteLine("Udskriver Kunde med mobil 22334455");
Console.WriteLine("   " + kundeListe.GetByMobil("22334455"));


Console.WriteLine("Opretter ny kunde");
Kunde nyKunde = new Kunde(10, "Peter", "99887766");
kundeListe.Add(nyKunde);
Console.WriteLine("   " + kundeListe.GetByNumber(10));

Console.WriteLine("Ændre ny kunde");
nyKunde.Name = "Jakob";
kundeListe.Update(nyKunde);
Console.WriteLine("   " + kundeListe.GetByNumber(10));

Console.WriteLine("Sletter ny kunde");
kundeListe.Delete(nyKunde);
Kunde slettetKunde = kundeListe.GetByNumber(10);
if (slettetKunde is null)
{
    Console.WriteLine("   " + "Kunden er slettet");
}
else
{
    Console.WriteLine("   " + "UPS! kunden er ikke slettet " + slettetKunde);
}





Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Dictionary");
Console.WriteLine();


/*
 * Brug af Dictionary
 */
KundeKatalogDictionary kundeDic = new KundeKatalogDictionary();

// laver 5 dummy kunder
for (int i = 0; i < 5; i++)
{
    kundeDic.Add(new Kunde(i, "dummy" + i, $"{i + 5}{i + 5}{i + 4}{i + 4}{i + 3}{i + 3}{i + 2}{i + 2}"));
}


Console.WriteLine("Udeskriver Alle");
foreach (Kunde k in kundeDic.GetAll())
{
    Console.WriteLine("   " + k);
}

Console.WriteLine("Udskriver Kunde med id 3");
Console.WriteLine("   " + kundeDic.GetByNumber(3));


Console.WriteLine("Udskriver Kunde med mobil 88776655");
Console.WriteLine("   " + kundeDic.GetByMobil("88776655"));


Console.WriteLine("Opretter ny kunde");
Kunde nyKundeDic = new Kunde(10, "Peter", "99887766");
kundeDic.Add(nyKundeDic);
Console.WriteLine("   " + kundeDic.GetByNumber(10));

Console.WriteLine("Ændre ny kunde");
nyKundeDic.Name = "Jakob";
kundeDic.Update(nyKundeDic);
Console.WriteLine("   " + kundeDic.GetByNumber(10));

Console.WriteLine("Sletter ny kunde");
kundeDic.Delete(nyKundeDic);
Kunde slettetKundeDic = kundeDic.GetByNumber(10);
if (slettetKundeDic is null)
{
    Console.WriteLine("   " + "Kunden er slettet");
}
else
{
    Console.WriteLine("   " + "UPS! kunden er ikke slettet " + slettetKunde);
}






