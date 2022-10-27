// See https://aka.ms/new-console-template for more information

//array con cibi
string[] cibiPreferiti = { "Carne", "Pizza", "Hamburger", "Pasta", "Gelato", "Kebab", "Patatine"};

//lunghezza lista
Console.WriteLine("lunghezza lista: " + cibiPreferiti.Length);

//stampo la classifica di tutti i cibi
Console.WriteLine("Classifica migliori cibi:");

for (int i = 0; i < cibiPreferiti.Length; i++ )
{
    Console.WriteLine((i + 1) + "°" + " " + "posto:" + " " + cibiPreferiti[i]);
};

//migliore e peggiore
Console.WriteLine("cibo top: " + cibiPreferiti[0]);
Console.WriteLine("cibo meno top: " + cibiPreferiti[cibiPreferiti.Length - 1]);

//medio
//Console.WriteLine("cibo mezza classifica dispari: " + CibiPreferiti[CibiPreferiti.Length / 2]);
//Console.WriteLine("cibo mezza classifica pari: " + CibiPreferiti[(CibiPreferiti.Length / 2) + 1]);

if(cibiPreferiti.Length % 2 == 0)
{
    //pari
    int medianaSuperiore = cibiPreferiti.Length / 2;
    int medianaInferiore = medianaSuperiore - 1;
    Console.WriteLine("La mediana è: " + cibiPreferiti[medianaInferiore], cibiPreferiti[medianaSuperiore]);
}
else
{
    //dispari
    int mediana = cibiPreferiti.Length / 2;
    Console.WriteLine("La mediana è: " + cibiPreferiti[mediana]);
}

