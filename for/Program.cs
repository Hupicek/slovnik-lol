Dictionary<string, string> ahoj = new Dictionary<string, string>();
Console.WriteLine("zadej velikost slovniku");
int b = Convert.ToInt32(Console.ReadLine());    
for  (int a= 0;a<b; a++)
{
    Console.WriteLine("napis jmeno");
    string? jmeno= Console.ReadLine();
    Console.WriteLine("napis cislo");
    string? cislo= Console.ReadLine();
    ahoj.Add(jmeno, cislo);
}
foreach (var řádek in ahoj)
{
    Console.WriteLine($"klíč: {řádek.Key} hodnota: {řádek.Value}");
}
ahooooooooooooooj