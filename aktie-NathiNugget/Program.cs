using aktie_NathiNugget;
using System.Diagnostics.CodeAnalysis;

internal class Program
{
    [ExcludeFromCodeCoverage]
    private static void Main(string[] args)
    {
        AktieManager aktieManager = new AktieManager();
        Console.WriteLine(aktieManager.TotalAfkast());
    }
}