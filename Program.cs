// See https://aka.ms/new-console-template for more information


string[] CibiPreferiti = { "Carne", "Pizza", "Hamburger", "Pasta", "Gelato", "Kebab", "Patatine"};


//lunghezza lista
Console.WriteLine("lunghezza lista: " + CibiPreferiti.Length);

//stampo tutti i cibi
Console.WriteLine("Tutti i cibi");
for (int i = 0; i < CibiPreferiti.Length; i++ )
{
    Console.WriteLine(CibiPreferiti[i]);
};

Console.WriteLine("Classifica migliori cibi");
Console.WriteLine("primo posto: " + CibiPreferiti[3]);
Console.WriteLine("secondo posto: " + CibiPreferiti[0]);
Console.WriteLine("terzo posto: " + CibiPreferiti[2]);
Console.WriteLine("quarto posto: " + CibiPreferiti[1]);
Console.WriteLine("quinto posto: " + CibiPreferiti[4]);
Console.WriteLine("sesto posto: " + CibiPreferiti[5]);
Console.WriteLine("settimo posto: " + CibiPreferiti[6]);

Console.WriteLine("cibo top: " + CibiPreferiti[3]);
Console.WriteLine("cibo meno top: " + CibiPreferiti[6]);