using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EserciziMatrici
{
    internal class ClsVettore
    {
        internal static void stampaVettore(int[] v,char tipo)
        {
            for (int i = 0; i < v.Length; i++)
                if (tipo == 'V')
                    Console.WriteLine(v[i]);
                else
                    Console.Write(v[i] + " ");
            Console.WriteLine();
        }
    }
}
