using Odev_1.Classes;

GenelMudur genelMudur = new GenelMudur();
genelMudur.Maas = 80000;

Mudur mudur = new Mudur();
mudur.Maas = 60000;

Yazilimci yazilimci = new Yazilimci();
yazilimci.Maas = 40000;

Stajyer stajyer = new Stajyer();
stajyer.Maas = 5000;

List<Calisan> calisanlar = new List<Calisan>() { genelMudur, mudur,yazilimci, stajyer };

decimal toplamMaas = 0;

foreach ( var calisan in calisanlar)
{
    toplamMaas += calisan.Maas;
}
Console.WriteLine($"\nToplam Maas: {toplamMaas} TL");
