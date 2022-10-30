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
//Console.WriteLine("La somma è: " + sommaNumeri);



//******************************************************************************************************* 


//Snack4. Calcola la somma e la media dei numeri da 2 a 10.

//int sommaNumeri = 0;
//int mediaNumeri = 0;

//for (int i = 2; i <= 10; i++)
//{
//    sommaNumeri += i;
//};
//mediaNumeri = sommaNumeri / 9;

//Console.WriteLine("La somma è " + sommaNumeri + ", la media è " + mediaNumeri);


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

//bool isUserInList = false;

//for (int i = 0; i < invitati.Length; i++)
//{
//    if (nomeUtente == invitati[i])
//    {
//        isUserInList = true;
//    }
//}
//if (isUserInList)
//{
//    Console.WriteLine("benvenuto/a alla grande festa!");
//}
//else
//{
//    Console.WriteLine("mi spiace ma il tuo nome non è presente nella lista dei partecipanti");
//}

//******************************************************************************************************* 

//Snack7.Crea un array vuoto.
//Chiedi per 6 volte all’utente di inserire un numero, se è dispari inseriscilo
//nell’array.

//int[] arrayNumeri = new int[6];

//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine("Inserisci un numero");
//    int numeroUtente = Convert.ToInt32(Console.ReadLine());

//    if (numeroUtente % 2 != 0)
//    {
//        arrayNumeri[i] = numeroUtente;
//    }

//}

//for (int i = 0; i < arrayNumeri.Length; i++)
//{
//    Console.Write(arrayNumeri[i]);
//}

//******************************************************************************************************* 

//Snack8.Crea un array di numeri interi e fai la somma di tutti gli elementi che sono in
//posizione dispari.

//int[] arrayTest = { 2, 0, 7, 0, 3, 0 };

//int sommaDispari = 0;
//for (int i = 1; i < arrayTest.Length; i+= 2)
//{
//    sommaDispari += arrayTest[i];
//}

//Console.WriteLine("La somma dei numeri in posizione dispari è: " + sommaDispari);

//******************************************************************************************************* 

//Snack9.Crea un array vuoto e chiedi all’utente un numero da inserire nell’array.
//Continua a chiedere i numeri all’utente e a inserirli nell’array, fino a quando la
//somma degli elementi è minore di 50.

//int[] arrayNumeri = new int[50];

//int arraySum = 0;
//int i=0;

//while (arraySum <= 49)
//{
//    Console.WriteLine("Inserisci un numero");
//    int numeroUtente = Convert.ToInt32(Console.ReadLine());
//    if(arraySum < 50)
//    {
//    arrayNumeri[i] = numeroUtente;
//    arraySum += numeroUtente;
//    i++;
//    Console.WriteLine("La somma degli elementi è " + arraySum );
//    }
//    else
//    {
//        Console.WriteLine("Hai sballato");
//    }
//}

//Snack10.Fai inserire un numero, che chiameremo N, all’utente.
//Genera N array, ognuno formato da 10 numeri casuali tra 1 e 100.
//Ogni volta che ne crei uno, stampalo a schermo.

//using System;

//Console.WriteLine("Inserisci una numero");
//int N = Convert.ToInt32(Console.ReadLine());


//for(int i = 0; i < N; i++)
//{
//    int[] arrayCasuale = new int[10];

//    for(int j = 0; j < arrayCasuale.Length; j++)
//    {
//        Random rnd = new Random();
//        arrayCasuale[j] = rnd.Next(1, 100);
//    }
//   Console.WriteLine(arrayCasuale);

//    for (int k = 0; k < arrayCasuale.Length; k++)
//    {
//        if (k < arrayCasuale.Length - 1)
//        {
//            Console.Write(arrayCasuale[k] + " - ");
//        }
//        else
//        {
//            Console.Write(arrayCasuale[k]);
//        }
//    }
//}


//Snack 1
//Dare la possibilità di inserire due parole.
//Verificare tramite una funzione che le due parole abbiano la stessa lunghezza.
//Se hanno la stessa lunghezza, stamparle entrambe, altrimenti stampare la più lunga delle due.


//string wordLengthCheck(string word1, string word2)
//{
//    if (word1.Length > word2.Length)
//    {
//        return word1;
//    }
//    else if (word1.Length < word2.Length)
//    {
//        return word2;
//    }
//    else
//    {
//        return word1 + " e " + word2;
//    }
//}

//Console.WriteLine("Inserisci una parola");
//string parola1 = Console.ReadLine();

//Console.WriteLine("Inserisci un'altra parola");
//string parola2 = Console.ReadLine();

//string finalWord = wordLengthCheck(parola1, parola2);

//Console.WriteLine("la parola richiesta è: " + finalWord);


//Snack 2
//Scrivere una funzione per verificare se un numero è pari o dispari.
//Quindi chiedere un numero all’utente e comunicargli se è pari o dispari.


string evenOrOdd(int numberToCheck)
{
    if (numberToCheck % 2 == 0)
    {
        return "pari";
    }
    else
    {
        return "dispari";
    }
}

Console.WriteLine("Inserisci una numero");
int userNumber = Convert.ToInt32(Console.ReadLine());

string isEvenOrOdd = evenOrOdd(userNumber);

Console.WriteLine("Il numero che hai scelto è: " + isEvenOrOdd);








