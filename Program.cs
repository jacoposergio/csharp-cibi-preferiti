// See https://aka.ms/new-console-template for more information


string[] CibiPreferiti = { "Carne", "Pizza", "Hamburger", "Pasta", "Gelato", "Kebab", "Patatine"};


//lunghezza lista
Console.WriteLine("lunghezza lista: " + CibiPreferiti.Length);

//stampo tutti i cibi
Console.WriteLine("Classifica migliori cibi:");
for (int i = 0; i < CibiPreferiti.Length; i++ )
{
    Console.WriteLine((i + 1) + "°" + "" + "posto:" + "" + CibiPreferiti[i]);
};

//Console.WriteLine("Classifica migliori cibi");
//Console.WriteLine("primo posto: " + CibiPreferiti[0]);
//Console.WriteLine("secondo posto: " + CibiPreferiti[1]);
//Console.WriteLine("terzo posto: " + CibiPreferiti[2]);
//Console.WriteLine("quarto posto: " + CibiPreferiti[3]);
//Console.WriteLine("quinto posto: " + CibiPreferiti[4]);
//Console.WriteLine("sesto posto: " + CibiPreferiti[5]);
//Console.WriteLine("settimo posto: " + CibiPreferiti[6]);

Console.WriteLine("cibo top: " + CibiPreferiti[0]);
Console.WriteLine("cibo meno top: " + CibiPreferiti[6]);

Console.WriteLine("cibo mezza classifica pari: " + CibiPreferiti[CibiPreferiti.Length / 2]);
Console.WriteLine("cibo mezza classifica dispari: " + CibiPreferiti[(CibiPreferiti.Length / 2) + 1]);