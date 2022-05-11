using System;           //riferimento alla libreria di base
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)  //entry point
        {
            //for (char paperino='a'; paperino < 'z'; paperino++)
            //    Console.WriteLine(paperino);
            //var a = "aaaa"; //Utilizzo var <nome> per dichiarare una variabile assegnandogli
            //il tipo dell'oggetto che gli sto assegnando come valore
            //int n = 0;
            //for (int i = 0; i < 512; i++)
            //{
            //    if (n == 16)
            //    {
            //        Console.WriteLine();
            //        n = 0;
            //    }
            //    n++;
            //    //Console.Write("{0} ", Convert.ToChar(i));
            //    Console.Write("{0} ", (char)i);  //casting
            //}
            //for (char paperino = 'a'; paperino < 'z'; paperino++)
            //    Console.WriteLine((long)paperino);

 /*
 * Un semplice calcolatore
 * Realizzare un programma che chiede all'utente che tipo di operazione intende
 * svolgere (0-somma, 1-prodotto, 2-divisione, 3-sottrazione, 4-quadrato, 5-media)
 * e poi se somma, prodotto, divisione o sottrazione chiede due valori, se quadrato 
 * chiede un solo valore e se media chiede 10 valori.
 * Utilizzare un vettore di interi o reali (a vostra scelta) per archiviare i valori di input
 * Opzionale:  implementare l'operazione di elevamento a potenza superiore al 2.
 * */
                
           Console.WriteLine("Inserisci il numero del tipo di operazione: 0.Somma, 1.Prodotto, 2.Divisione, 3.Sottrazione, 4.Quadrato, 5.Media");
           int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Inserisci il primo addendo");
                    float fSum1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Inserisci il secondo addendo");
                    float fSum2 = Convert.ToInt32(Console.ReadLine());

                    float fSumRes = fSum1 + fSum2;
                    Console.WriteLine("Il risultato è: {0}", fSumRes);
                    break;

                    case 1:
                    Console.WriteLine("Inserisci il primo fattore");
                    float fProd1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Inserisci il secondo fattore");
                    float fProd2 = Convert.ToInt32(Console.ReadLine());

                    float fProdRes = fProd1 * fProd2;
                    Console.WriteLine("Il risultato è: {0}", fProdRes);
                    break ;

                    case 2:
                    Console.WriteLine("Inserisci il dividendo");
                    float fDiv1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Inserisci il divisore");
                    float fDiv2 = Convert.ToSingle(Console.ReadLine());

                    float fDivRes = fDiv1 / fDiv2;
                    Console.WriteLine("Il risultato è: {0}", fDivRes);
                    break;

                    case 3:
                    Console.WriteLine("Inserisci il minuendo");
                    float fSot1 = Convert.ToSingle(Console.ReadLine());

                    Console.WriteLine("Inserisci il sottraendo");
                    float fSot2 = Convert.ToSingle(Console.ReadLine());

                    float fSotRes = fSot1 - fSot2;
                    Console.WriteLine("Il risultato è: {0}", fSotRes);
                    break;

                    case 4:
                    Console.WriteLine("Inserisci il numero da elevare al quadrato");
                    float fQuad = Convert.ToSingle(Console.ReadLine());

                    fQuad = fQuad * fQuad;
                    Console.WriteLine("Il risultato è: {0}", fQuad);
                    break;

                    case 5:
                    Console.WriteLine("Inserisci 10 numeri");
                    float fAvgSum = 0;
                    for (int i = 0; i < 10; i++)
                    {
                        fAvgSum += Convert.ToSingle(Console.ReadLine());
                    }
                    fAvgSum /= 10;
                    Console.Write("La media dei 10 numeri è: {0}", fAvgSum);
                    break;
            }
        }
    }
}