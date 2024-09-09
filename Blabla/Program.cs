// See https://aka.ms/new-console-template for more information
using aktie_NathiNugget;


Console.WriteLine("Hello, World!");
Aktie a = new Aktie("NVDA", 10, 12, 500);
Console.WriteLine(a.Afkast());

AktieManager aktieManager = new AktieManager();
Console.WriteLine(aktieManager.TotalAfkast());