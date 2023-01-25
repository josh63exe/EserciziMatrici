using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace EserciziMatrici
{
    public class ClsMatrice
    {
        static Random rnd = new Random();
        public static void sommaElemMatrice(int[,] m, int r, int c)
        {
            int somma = 0;
            for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                somma += m[i, j];
            Console.WriteLine("Somma elementi matrice: " + somma.ToString());
        }
        public static void caricaMatriceCasuale(int[,] m, int r, int c)
        {
            for (int i = 0; i < r; i++) // Indice Righe
            {
                for (int j = 0; j < c; j++) // Indice Colonne
                    m[i, j] = rnd.Next(1, 100);
            }
        }
        public static void stampaMatrice(int[,] m, int r, int c)
        {
            for (int i = 0; i < r; i++) // Indice Righe
            {
                for (int j = 0; j < c; j++) // Indice Colonne
                    Console.Write(m[i, j].ToString().PadLeft(4));
                Console.WriteLine(); // a capo ad ogni nuova riga
            }
        }

        public static void mediaElemMatrice(int[,] m)
        {
            double media = 0;
            for (int i = 0; i < m.GetLength(0); i++) // GetLength(0) => numero righe
            for (int j = 0; j < m.GetLength(1); j++) // GetLength(1) => numero colonne
                media += m[i, j];
            media = media / (m.GetLength(0) * m.GetLength(1));
            Console.WriteLine("Media elementi matrice: " + media.ToString());
        }

        public static int sommaDP(int[,] m)
        {
            // Gli elementi sulla dp di una matrice quadrata
            // hanno indice uguale (i == j) 
            // quindi posso elaborarli con un solo ciclo FOR 
            int somma = 0;
            for (int i = 0; i < m.GetLength(0); i++)
                somma += m[i, i];
            return somma;
        }

        public static int sommaDS(int[,] m)
        {
            // Gli elementi sulla ds di una matrice quadrata
            // hanno indice (j == r-i-1) 
            // quindi posso elaborarli con un solo ciclo FOR 
            int somma = 0;
            for (int i = 0; i < m.GetLength(0); i++)
                somma += m[i, m.GetLength(0) - i - 1];
            return somma;
        }

        public static void sommaCornice(int[,] m, int r, int c)
        {
            int somma = 0;
            for (int j = 0; j < c; j++)
                somma += (m[0, j] + m[r - 1, j]);
            for (int i = 1; i < r - 1; i++)
                somma += (m[i, 0] + m[i, c - 1]);
            Console.WriteLine("La somma della cornice è: " + somma.ToString());
        }

        public static void caricaVetJcolonna(int[,] m)
        {
            int j = Program.inputN("Inserisci la colonna " +
                                   "da copiare nel vettore");
            int[] a = new int[m.GetLength(0)];
            for (int i = 0; i < m.GetLength(0); i++)
                a[i] = m[i, j];
            ClsVettore.stampaVettore(a, 'V');
        }

        public static void caricaVetIriga(int[,] m)
        {
            int i = Program.inputN("Inserisci la riga " +
                                   "da copiare nel vettore");
            int[] a = new int[m.GetLength(1)];
            for (int j = 0; j < m.GetLength(1); j++)
                a[j] = m[i, j];
            ClsVettore.stampaVettore(a, 'O');
        }

        public static int contaOccorrenze(int[,] m)
        {
            int x = Program.inputN("Inserisci l'elemento da cercare");
            int cont = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            for (int j = 0; j < m.GetLength(1); j++)
                if (m[i, j] == x)
                    cont++;
            return cont;
        }

        public static bool sommaIJ(int[,] m)
        {
            int riga = Program.inputN("Inserisci la riga da sommare");
            int colonna = Program.inputN("Inserisci la colonna da sommare");
            int sommariga = 0;
            int sommacolonna = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                sommariga += m[riga, i];
                sommacolonna += m[i, colonna];
            }
            return sommariga == sommacolonna;
        }

        public static void caricaMatriceSequenza(int[,] m, int r, int c)
        {
            int cont = 1;

            for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                m[i, j] = cont++;
        }

        public static void caricaVettSommaRighe(int[,] m)
        {
            int[] v = new int[m.GetLength(0)];

            for (int i = 0; i < m.GetLength(0); i++)
            for (int j = 0; j < m.GetLength(1); j++)
                v[i] += m[i, j];
            ClsVettore.stampaVettore(v, 'V');
        }

        public static void caricaVettSommaColonne(int[,] m)
        {
            int[] v = new int[m.GetLength(1)];

            for (int j = 0; j < m.GetLength(1); j++)
            for (int i = 0; i < m.GetLength(0); i++)
                v[j] += m[i, j];
            ClsVettore.stampaVettore(v, 'O');
        }

        public static bool verificaElementiUguali(int[,] m)
        {
            bool esci = false;
            int i, j;
            int x = m[0, 0];
            i = 0;
            j = 1;

            do
            {
                if (m[i, j] == x)
                    prosegui(ref i, ref j, m.GetLength(1));
                else
                    esci = true;
            }
            while (!esci && i <= m.GetLength(0) - 1);
            return !esci;
        }

        private static void prosegui(ref int i, ref int j, int c)
        {
            if (j == c - 1)
            {
                i++;
                j = 0;
            }
            else
                j++;
        }

        public static bool verificaElementiOrdinati(int[,] m)
        {
            bool esci = false;
            int i, j;
            int x = m[0, 0];
            i = 0;
            j = 1;

            do
            {
                if (m[i, j] >= x)
                {
                    x = m[i, j];
                    prosegui(ref i, ref j, m.GetLength(1));
                }
                else
                    esci = true;
            }
            while (!esci && i <= m.GetLength(0) - 1);
            return !esci;
        }

        public static bool verificaUnitaria(int[,] m)
        {
            bool esci = false;
            int i, j;
            i = 0;
            j = 0;
            do
            {
                if (i == j)
                {
                    // DIAGONALE PRINCIPALE 
                    if (m[i, j] != 1)
                        esci = true;
                    else
                        prosegui(ref i, ref j, m.GetLength(0));
                }
                else
                {
                    // NON SONO SULLA DIAGONALE PRINCIPALE
                    if (m[i, j] != 0)
                        esci = true;
                    else
                        prosegui(ref i, ref j, m.GetLength(0));
                }
            }
            while (!esci && i <= m.GetLength(0) - 1);

            return !esci;
        }

        public static void caricaMatriceUnitaria(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    if (i == j)
                        m[i, j] = 1;
                    else
                        m[i, j] = 0;
                }
            }
        }

        public static bool verificaCroce(int[,] m)
        {
            bool esci = false;
            int i, j;
            i = 0;
            j = 0;
            int ind = (m.GetLength(0) / 2);
            do
            {
                if (i == ind || j == ind) // Presenza di 1 
                {
                    if (m[i, j] == 1)
                        prosegui(ref i, ref j, m.GetLength(0));
                    else
                        esci = true;
                }
                else // Presenza di 0 
                {
                    if (m[i, j] == 0)
                        prosegui(ref i, ref j, m.GetLength(0));
                    else
                        esci = true;
                }
            }
            while (!esci && i <= m.GetLength(0) - 1);

            return !esci;
        }

        public static void caricaCroce(int[,] m)
        {
            int ind = (m.GetLength(0) / 2);
            for (int i = 0; i < m.GetLength(0); i++)
            for (int j = 0; j < m.GetLength(0); j++)
            {
                if (i == ind || j == ind)
                    m[i, j] = 1;
                else
                    m[i, j] = 0;
            }
        }
        public static void sommaTriangoloSuperioreDP(int[,] m)
        {
            //coordinate triangolo superiore
            //rispetto alla DP
            //
            //  0 <= i <= r-2
            //  i+1 <= j <= r-1
            //
            int somma = 0;
            int r = m.GetLength(0);

            for (int i = 0; i <= r - 2; i++)
            for (int j = i + 1; j <= r - 1; j++)
                somma += m[i, j];
            Console.WriteLine("La somma del TRIA SUP DP è: " +
                              somma.ToString());
        }
        public static bool verificaSpeculareDP(int[,] m)
        {
            bool esci = false;
            int i = 0;
            int j = 1;
            int r = m.GetLength(0);

            do
            {
                if (m[i, j] == m[j, i])
                {
                    if (j == r - 1)
                    {
                        i++;
                        j = i + 1;
                    }
                    else
                        j++;
                }
                else
                    esci = true;
            }
            while (!esci && i <= r - 2);
            return !esci;
        }

        internal static void caricaMatriceCasualeOrdinata(int[,] m, int r, int c)
        {
            int x = 1;

            for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
            {
                m[i, j] = rnd.Next(x, x + 3);
                x = m[i, j];
            }
        }

        internal static void cercaXMatriceOrdinataDisgiunta(int[,] m, int r, int c)
        {
            int x = Program.inputN("Inserisci il valore da cercare");
            int i = 0;
            int j = 0;
            bool esci = false;

            do
            {
                if (m[i, j] >= x)
                    esci = true;
                else
                    prosegui(ref i, ref j, c);
            }
            while (!esci && i <= r - 1);
            if (m[i, j] == x)
                Console.WriteLine("Trovato in posizione " + i.ToString() + " - " + j.ToString());
            else
                Console.WriteLine("Non trovato");
        }

        internal static void cercaXMatriceOrdinataConRipetizioni(int[,] m, int r, int c)
        {
            //rottura di chiave su matrice
            int x = Program.inputN("Inserisci il valore da cercare");
            int i = 0;
            int j = 0;
            bool superato = false;
            bool trovato = false;

            do
            {
                if (m[i, j] == x)
                {
                    trovato = true;
                    Console.WriteLine("Trovato in posizione " + i.ToString() + " - " + j.ToString());
                    prosegui(ref i, ref j, c);
                }
                else
                {
                    if (m[i, j] > x)
                        superato = true;
                    else
                        prosegui(ref i, ref j, c);
                }
            }
            while (!superato && i <= r - 1);
            if (!trovato)
                Console.WriteLine("Non trovato");
        }

        internal static bool matriciUguali(int[,] a, int[,] b)
        {
            bool uguali = true;
            int i = 0;
            int j = 0;
            int r = a.GetLength(0);
            int c = a.GetLength(1);

            do
            {
                if (a[i, j] == b[i, j])
                    prosegui(ref i, ref j, a.GetLength(1));
                else
                    uguali = false;
            }
            while (uguali == false && i <= a.GetLength(0) - 1);
            return uguali;
        }

        internal static void sommelementirighe(int[,] m)
        {
            int r = m.GetLength(0);
            int c = m.GetLength(1);
            int somma = 0;

            for (int i = 0; i < r; i++)
            {
                somma = 0;
                for (int j = 0; j < c; j++)
                    somma += m[i, j];
                Console.WriteLine("La somma della riga " +
                                  i.ToString() +
                                  " è: " +
                                  somma.ToString());
            }
        }

        internal static void sommelementicolonne(int[,] m)
        {
            int r = m.GetLength(0);
            int c = m.GetLength(1);
            int somma = 0;

            for (int j = 0; j < c; j++)
            {
                somma = 0;
                for (int i = 0; i < r; i++)
                    somma += m[i, j];
                Console.WriteLine("La somma della colonna " +
                                  j.ToString() +
                                  " è: " +
                                  somma.ToString());
            }
        }

        internal static int sommaTriangoloInferioreDP(int[,] m)
        {
            //triangolo inferiore rispetto alla DP
            // 1 <= i <= r-1
            // 0 <= j <= i-1
            int somma = 0;
            int r = m.GetLength(0);
            for (int i = 1; i < r - 1; i++)
            for (int j = 0; j < i - 1; j++)
                somma += m[i, j];
            return somma;
        }

        internal static void cercaXinTriangoloInferioreDP(int[,] m)
        {
            int x = Program.inputN("Inserisci il valore da cercare");
            int i = 1;
            int j = 0;
            bool trovato = false;

            do
            {
                if (m[i, j] == x)
                    trovato = true;
                else
                {
                    if (j == i - 1)
                    {
                        i++;
                        j = 0;
                    }
                    else
                        j++;
                }
            }
            while (!trovato && i <= m.GetLength(0) - 1);

            if (trovato)
                Console.WriteLine("Trovato in posizione " + i.ToString() + " - " + j.ToString());
            else
                Console.WriteLine("Non trovato");
        }
        public static void verificaSommaElementiMaxSopraSotto(int[,] m)
        {
            int sommaSopra = 0;
            int sommaSotto = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            for (int j = 0; j < m.GetLength(0); j++)
            {
                if (i < j)
                    sommaSopra += m[i, j];
                else if (i > j)
                    sommaSotto += m[i, j];
            }
            if (sommaSopra > sommaSotto)
                Console.WriteLine("La somma degli elementi sopra la diagonale principale è maggiore");
            else
                Console.WriteLine("La somma degli elementi sotto la diagonale principale è maggiore");
        }
        public static void verificaelementisottoDP(int[,] ints, int i, int i1)
        {
            //Verifica se gli elementi al di sotto della DP di una matrice quadrata A di ordine (r x r) sono tutti uguali tra loro
            bool uguali = true;
            int j = 0;
            do
            {
                if (ints[i, j] == ints[i1, j])
                    j++;
                else
                    uguali = false;
            }
            while (uguali == true && j <= i - 1);
            if (uguali)
                Console.WriteLine("Tutti gli elementi al di sotto della DP sono uguali");
            else
                Console.WriteLine("Non tutti gli elementi al di sotto della DP sono uguali");
        }
        public static void verificaelementisopraDP(int[,] ints, int i, int i1)
        {
            //Verifica se gli elementi al di sopra della DP di una matrice quadrata A di ordine (r x r) sono tutti uguali tra loro
            bool uguali = true;
            int j = 0;
            do
            {
                if (ints[i, j] == ints[i1, j])
                    j++;
                else
                    uguali = false;
            }
            while (uguali == true && j <= i - 1);
            if (uguali)
                Console.WriteLine("Tutti gli elementi al di sopra della DP sono uguali");
            else
                Console.WriteLine("Non tutti gli elementi al di sopra della DP sono uguali");
        }
        public static bool mediaDPmatrici(int[,] m)
        {
            int sommaSopra = 0;
            int sommaSotto = 0;

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(0); j++)
                {
                    if (i < j) //sono sopra la DP
                        sommaSopra += m[i, j];
                    else if (i > j) //sono sotto la DP
                        sommaSotto += m[i, j];
                }
            }
            return sommaSopra == sommaSotto;
        }
        public static bool quadratoMagico(int[,] m)
        {
            //quadrato magico
            //la somma degli elementi di ogni riga, di ogni colonna e delle diagonali è uguale
            bool magico = true;

            int SDP = sommaDP(m); //PIVOT
            int r = m.GetLength(0);
            int i, j;

            if (SDP != sommaDS(m))
                magico = false;
            else
            {
                //Controllo le righe
                i = 0;
                do
                {
                    magico = controllaRiga(m, i, SDP);
                    i++;
                }
                while (magico == true && i <= r - 1);
                if (magico)
                {
                    j = 0;
                    do
                    {
                        magico = controlloColonne(m, j, SDP);
                        j++;
                    }
                    while (i <= r - 1 && magico == true);
                }
            }
            return true;
        }
        static bool controlloColonne(int[,] m, int i, int sdp)
        {
            int somma = 0;
            for (int j = 0; j < m.GetLength(0); j++)
            {
                somma += m[j, i];
            }
            return somma == sdp;
        }
        static bool controllaRiga(int[,] m, int i, int SDP)
        {
            int somma = 0;
            for (int j = 0; j < m.GetLength(0); j++)
            {
                somma += m[i, j];
            }
            return somma == SDP;
        }
    }
}