using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziMatrici
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char scelta = ' ';
            int r, c; // r => numero righe | c => numero colonne
            int[,] a; // Dichiarazione matrice 
            int[,] b; // Dichiarazione matrice 

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            do
            {
                scelta = visualizzaMenu();
                switch (scelta)
                {
                    case 'A':
                    case 'a': // Somma elementi matrice 
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasuale(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        ClsMatrice.sommaElemMatrice(a, r, c);
                        break;
                    case 'B':
                    case 'b': // Media elementi matrice
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasuale(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        ClsMatrice.mediaElemMatrice(a);
                        break;
                    case 'C':
                    case 'c': // Somma diagonale principale (matrice quadrata)
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        Console.WriteLine("Somma DP matrice: " +
                                          ClsMatrice.sommaDP(a).ToString());
                        break;
                    case 'D':
                    case 'd': // Media diagonale principale (matrice quadrata)
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        Console.WriteLine("Media DP matrice: " +
                                          ((double)ClsMatrice.sommaDP(a) / r).ToString());
                        break;
                    case 'E':
                    case 'e': // Somma diagonale secondaria (matrice quadrata)
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        Console.WriteLine("Somma DS matrice: " +
                                          ClsMatrice.sommaDS(a).ToString());
                        break;
                    case 'F':
                    case 'f': // Media diagonale secondaria (matrice quadrata)
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        Console.WriteLine("Media DS matrice: " +
                                          ((double)ClsMatrice.sommaDS(a) / r).ToString());
                        break;
                    case 'G':
                    case 'g':
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasuale(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        ClsMatrice.sommaCornice(a, r, c);
                        break;
                    case 'H':
                    case 'h':
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasuale(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        ClsMatrice.caricaVetJcolonna(a);
                        break;
                    case 'I':
                    case 'i':
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasuale(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        ClsMatrice.caricaVetIriga(a);
                        break;
                    case 'L':
                    case 'l':
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasuale(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        Console.WriteLine("Elemento trovato " +
                                          ClsMatrice.contaOccorrenze(a).ToString() +
                                          " volte");
                        break;
                    case 'M':
                    case 'm':
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        if (ClsMatrice.sommaDP(a) == ClsMatrice.sommaDS(a))
                            Console.WriteLine("Somme diagonali uguali");
                        else
                            Console.WriteLine("Somme diagonali diverse");
                        break;
                    case 'N':
                    case 'n':
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        if (ClsMatrice.sommaIJ(a))
                            Console.WriteLine("Somme riga/colonna uguali");
                        else
                            Console.WriteLine("Somme riga/colonna diverse");
                        break;
                    case 'O':
                    case 'o':
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceSequenza(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        break;
                    case 'P':
                    case 'p':
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasuale(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        ClsMatrice.caricaVettSommaRighe(a);
                        break;
                    case 'Q':
                    case 'q':
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasuale(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        ClsMatrice.caricaVettSommaColonne(a);
                        break;
                    case 'R':
                    case 'r':
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasuale(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        if (ClsMatrice.verificaElementiUguali(a))
                            Console.WriteLine("Elementi TUTTI UGUALI");
                        else
                            Console.WriteLine("Elementi NON UGUALI");
                        break;
                    case 'S':
                    case 's':
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceSequenza(a, r, c); // ClsMatrice.caricaMatriceCasuale(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        if (ClsMatrice.verificaElementiOrdinati(a))
                            Console.WriteLine("Elementi ORDINATI");
                        else
                            Console.WriteLine("Elementi NON ORDINATI");
                        break;
                    case 'T':
                    case 't':
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceUnitaria(a); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        if (ClsMatrice.verificaUnitaria(a))
                            Console.WriteLine("Matrice UNITARIA");
                        else
                            Console.WriteLine("Matrice NON UNITARIA");
                        break;
                    case 'U':
                    case 'u':
                        r = inputN("Inserisci numero di righe/colonne (dispari)");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.caricaCroce(a);
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        if (ClsMatrice.verificaCroce(a))
                            Console.WriteLine("Matrice con CROCE");
                        else
                            Console.WriteLine("Matrice senza CROCE");
                        break;
                    case 'V':
                    case 'v':
                        r = inputN("Inserisci numero di righe/colonne (dispari)");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        ClsMatrice.sommaTriangoloSuperioreDP(a);
                        break;
                    case 'Z':
                    case 'z':
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        if (ClsMatrice.verificaSpeculareDP(a))
                            Console.WriteLine("Matrice SPECULARE rispetto DP");
                        else
                            Console.WriteLine("Matrice NON SPECULARE rispetto DP");
                        break;
                    case '1':
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasualeOrdinata(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        break;
                    case '2':
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasualeOrdinata(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        ClsMatrice.cercaXMatriceOrdinataDisgiunta(a, r, c);
                        break;
                    case '3':
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasualeOrdinata(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        ClsMatrice.cercaXMatriceOrdinataConRipetizioni(a, r, c);
                        break;
                    case '4':
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasuale(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        b = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasuale(b, r, c);
                        ClsMatrice.stampaMatrice(b, r, c);
                        if (ClsMatrice.matriciUguali(a, b))
                            Console.WriteLine("Matrici uguali");
                        else
                            Console.WriteLine("Matrici diverse");
                        break;
                    case '5':
                        r = inputN("Inserisci numero di righe");
                        c = inputN("Inserisci numero di colonne");
                        a = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasuale(a, r, c);
                        ClsMatrice.stampaMatrice(a, r, c);
                        b = new int[r, c]; // Istanza della matrice
                        ClsMatrice.caricaMatriceCasuale(b, r, c);
                        ClsMatrice.stampaMatrice(b, r, c);
                        ClsMatrice.sommelementicolonne(a);
                        break;
                    case '7':
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        Console.WriteLine(
                            "La somma degli elementi del triangolo sotto la DP di una matrice quadrata è" +
                            ClsMatrice.sommaTriangoloInferioreDP(a));
                        break;
                    case '8':
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        ClsMatrice.cercaXinTriangoloInferioreDP(a);
                        break;
                    case '9':
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        ClsMatrice.verificaSommaElementiMaxSopraSotto(a);
                        break;
                    case 'k':
                    case 'K':
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        ClsMatrice.verificaelementisottoDP(a, r, r); // QUADRATA
                        break;
                    case 'J':
                    case 'j':
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        ClsMatrice.verificaelementisopraDP(a, r, r); // QUADRATA
                        break;
                    case 'Y':
                    case 'y':
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        if (ClsMatrice.mediaDPmatrici(a))
                            Console.WriteLine(
                                "La media degli elementi della diagonale principale è maggiore della media degli elementi della diagonale secondaria");
                        else
                            Console.WriteLine(
                                "La media degli elementi della diagonale principale è minore della media degli elementi della diagonale secondaria");
                        break;
                    case 'W':
                    case 'w':
                        r = inputN("Inserisci numero di righe/colonne");
                        a = new int[r, r]; // Istanza della matrice QUADRATA
                        ClsMatrice.caricaMatriceCasuale(a, r, r); // QUADRATA
                        ClsMatrice.stampaMatrice(a, r, r); // QUADRATA
                        if (ClsMatrice.quadratoMagico(a))
                            Console.WriteLine("La matrice è un quadrato magico");
                        else
                            Console.WriteLine("La matrice non è un quadrato magico");
                        break;
                    case 'X':
                    case 'x':
                        Console.WriteLine("Arrivederci...");
                        break;
                    default:
                        Console.WriteLine("Scelta non disponibile");
                        break;
                }
                Console.ReadKey();
            }
            while (scelta != 'x' && scelta != 'X');
        }

        public static int inputN(string msg)
        {
            int n;
            do
            {
                Console.Write(msg + ": ");
            }
            while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));
            return n;
        }

        private static char visualizzaMenu()
        {
            char sc;
            Console.Clear();
            Console.WriteLine("--- GESTIONE MATRICI ---");
            Console.WriteLine("A. Somma elementi matrice");
            Console.WriteLine("B. Media elementi matrice");
            Console.WriteLine("C. Somma diagonale principale (matrice quadrata)");
            Console.WriteLine("D. Media diagonale principale (matrice quadrata)");
            Console.WriteLine("E. Somma diagonale secondaria (matrice quadrata)");
            Console.WriteLine("F. Media diagonale secondaria (matrice quadrata)");
            Console.WriteLine("G. Somma cornice matrice");
            Console.WriteLine("H. Copia j-sima colonna matrice in vettore");
            Console.WriteLine("I. Copia i-sima riga matrice in vettore");
            Console.WriteLine("L. Conta occorrenze di un valore in matrice");
            Console.WriteLine("M. Verica somma DP = somma DS (matrice  quadrata)");
            Console.WriteLine("N. Verica somma riga i = somma colonna j (matrice quadrata)");
            Console.WriteLine("O. Carica matrice con valori in sequenza");
            Console.WriteLine("P. Carica vettore colonna con somma righe matrice");
            Console.WriteLine("Q. Carica vettore riga con somma colonne matrice");
            Console.WriteLine("R. Verifica se elementi matrice sono uguali tra loro");
            Console.WriteLine("S. Verifica se elementi matrice sono ordinati crescenti");
            Console.WriteLine("T. Verifica se matrice unitaria (matrice quadrata)");
            Console.WriteLine("U. Verifica se matrice a croce (matrice quadrata)");
            Console.WriteLine("V. Somma elementi triangolo superiore alla DP (matrice quadrata)");
            Console.WriteLine("Z. Verifica se matrice speculare rispetto DP (matrice quadrata)");
            Console.WriteLine("1. Carica matrice con valori casuali ordinati crescenti");
            Console.WriteLine("2. Ricerca x in matrice disgiunta e ordinata");
            Console.WriteLine("3. Ricerca x in matrice con ripetizioni e ordinata");
            Console.WriteLine("4. Verifica ugualglianza di 2 matrici");
            Console.WriteLine(
                "5. Calcolare le somme degli elementi delle righe di una matrice di interi A di ordine (r, x, c) scrivendole in un vettore colonna di interi B di lunghezza r");
            Console.WriteLine(
                "6. Calcolare le somme degli elementi delle righe di una matrice di interi A di ordine (r, x, c) scrivendole in un vettore righe di interi B di lunghezza c");
            Console.WriteLine("7. Somma elementi sotto la PD matrice quadrata (triangolo inferiore)");
            Console.WriteLine("8. Cerca x nel triangolo inferiore alla diagonale principale (matrice quadrata)");
            Console.WriteLine("9. Verifica se maggiore la somma sopra o sotto dp (matrice quadrata)");
            Console.WriteLine(
                "K. Verifica se gli elementi al di sotto della DP di una matrice quadrata A di ordine (r x r) sono tutti uguali tra loro");
            Console.WriteLine(
                "J. Verifica se gli elementi al di sopra della DP di una matrice quadrata A di ordine (r x r) sono tutti maggiori di 0");
            Console.WriteLine(
                "Y. Verifica se la media degli elementi al di sopra della DP di una matrice quadrata A di ordine (r x r) è uguale della media degli elementi al di sotto della DP");
            Console.WriteLine("W. Verifica se il quadrato è magico");
            Console.WriteLine("X. Esci");
            do
            {
                Console.Write("Scelta -> ");
            }
            while (!char.TryParse(Console.ReadLine(), out sc));
            Console.Clear();
            return sc;
        }
    }
}