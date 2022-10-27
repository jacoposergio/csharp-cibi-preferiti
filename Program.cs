// See https://aka.ms/new-console-template for more information

//array con cibi
string[] CibiPreferiti = { "Carne", "Pizza", "Hamburger", "Pasta", "Gelato", "Kebab", "Patatine"};

//lunghezza lista
Console.WriteLine("lunghezza lista: " + CibiPreferiti.Length);

//stampo la classifica di tutti i cibi
Console.WriteLine("Classifica migliori cibi:");

for (int i = 0; i < CibiPreferiti.Length; i++ )
{
    Console.WriteLine((i + 1) + "°" + "" + "posto:" + "" + CibiPreferiti[i]);
};

//migliore e peggiore
Console.WriteLine("cibo top: " + CibiPreferiti[0]);
Console.WriteLine("cibo meno top: " + CibiPreferiti[6]);

//medio
Console.WriteLine("cibo mezza classifica pari: " + CibiPreferiti[CibiPreferiti.Length / 2]);
Console.WriteLine("cibo mezza classifica dispari: " + CibiPreferiti[(CibiPreferiti.Length / 2) + 1]);