//// See https://aka.ms/new-console-template for more information

////array con cibi
//string[] cibiPreferiti = { "Carne", "Pizza", "Hamburger", "Pasta", "Gelato", "Kebab", "Patatine"};

////lunghezza lista
//Console.WriteLine("lunghezza lista: " + cibiPreferiti.Length);

////stampo la classifica di tutti i cibi
//Console.WriteLine("Classifica migliori cibi:");

//for (int i = 0; i < cibiPreferiti.Length; i++ )
//{
//    Console.WriteLine((i + 1) + "°" + " " + "posto:" + " " + cibiPreferiti[i]);
//};

////migliore e peggiore
//Console.WriteLine("cibo top: " + cibiPreferiti[0]);
//Console.WriteLine("cibo meno top: " + cibiPreferiti[cibiPreferiti.Length - 1]);

////medio
////Console.WriteLine("cibo mezza classifica dispari: " + CibiPreferiti[CibiPreferiti.Length / 2]);
////Console.WriteLine("cibo mezza classifica pari: " + CibiPreferiti[(CibiPreferiti.Length / 2) + 1]);

//if(cibiPreferiti.Length % 2 == 0)
//{
//    //pari
//    int medianaSuperiore = cibiPreferiti.Length / 2;
//    int medianaInferiore = medianaSuperiore - 1;
//    Console.WriteLine("La mediana è: " + cibiPreferiti[medianaInferiore], cibiPreferiti[medianaSuperiore]);
//}
//else
//{
//    //dispari
//    int mediana = cibiPreferiti.Length / 2;
//    Console.WriteLine("La mediana è: " + cibiPreferiti[mediana]);
//}


//********************************************************************************************

//Snack1.L’utente inserisce due numeri in successione.
//Il software stampa il maggiore.


//Console.WriteLine("Inserisci un numero");
//int numero1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Inserisci un altro numero");
//int numero2 = Convert.ToInt32(Console.ReadLine());


//if (numero1 > numero2)
//{
//    Console.WriteLine("Il numero maggiore è " + numero1);
//}
//else if (numero1 < numero2)
//{
//    Console.WriteLine("Il numero maggiore è " + numero2);
//}
//else
//{
//    Console.WriteLine("I numeri sono uguali");
//}

//********************************************************************************************

//Snack2. L’utente inserisce due parole in successione.
//Il software stampa prima la parola più corta, poi la parola più lunga.

//Console.WriteLine("Inserisci una parola");
//string parola1 = Console.ReadLine();

//Console.WriteLine("Inserisci un'altra parola");
//string parola2 = Console.ReadLine();


//if (parola1.Length > parola2.Length)
//{
//    Console.WriteLine("la parola " + parola1 + " è più lunga della parola " + parola2);
//}
//else if (parola1.Length < parola2.Length)
//{
//    Console.WriteLine("la parola " + parola2 + " è più lunga della parola " + parola1);
//}
//else
//{
//    Console.WriteLine("Le parole sono uguali");
//}

//******************************************************************************************************* 

//Snack3.Il software deve chiedere per 10 volte all’utente di inserire un numero.
//Il programma stampa la somma di tutti i numeri inseriti.

//int sommaNumeri = 0;

//for (int i = 0; i < 10; i++)
//{
//    Console.WriteLine("Inserisci un numero");
//    int numeroUtente = Convert.ToInt32(Console.ReadLine());
//    sommaNumeri += numeroUtente;
//};
//return sommaNumeri;



//******************************************************************************************************* 


//Snack4. Calcola la somma e la media dei numeri da 2 a 10.

//int sommaNumeri = 0;
//int mediaNumeri = 0;

//for (int i = 2; i <= 10; i++)
//{
//    sommaNumeri += i;
//    mediaNumeri = sommaNumeri / i;
//};

//return mediaNumeri;


//******************************************************************************************************* 


//Snack5.Il software chiede all’utente di inserire un numero. Se il numero inserito è pari,
//stampa il numero, se è dispari, stampa il numero successivo.


//Console.WriteLine("Inserisci un numero");
//int numeroUtente = Convert.ToInt32(Console.ReadLine());

//if (numeroUtente % 2 == 0)
//{
//    Console.WriteLine("il numero è " + numeroUtente);
//}
//else
//{
//    //dispari
//    Console.WriteLine("il numero è " + (numeroUtente + 1));
//}


//******************************************************************************************************* 


//Snack6.In un array sono contenuti i nomi degli invitati alla festa del grande Gatsby.
//Chiedi all’utente il suo nome e comunicagli se può partecipare o meno alla
//festa.

//string[] invitati = { "Mario", "Carlo", "Luca", "Giovanni" };

//Console.WriteLine("Dimmi il tuo nome");
//string nomeUtente = Console.ReadLine();

//if (invitati.Contains(nomeUtente) )
//{
//    Console.WriteLine("Benvenuto e buona serata");
//}
//else
//{
//    Console.WriteLine("Va via straccione o chiamo le guardie");
//}

//******************************************************************************************************* 

//Snack7.Crea un array vuoto.
//Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo
//nell’array.

