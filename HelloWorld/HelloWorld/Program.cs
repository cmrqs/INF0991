using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld;

class Program
{
    // Alteração realizada por Carlos
    static void Main(string[] args)
    {
        // Outra alteração realizada por Carlos
        // Outras alterações realizadas por isabelle.
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Integer Types (signed):");
        sbyte sb = 20;
        short s = -32;
        int i = -1;
        long l = -3000;

        Console.WriteLine("sbyte -------\t" + sb + "\t sizeof = " + sizeof(sbyte) + " Bytes");
        Console.WriteLine("short -------\t" + s + "\t sizeof = " + sizeof(short) + " Bytes");
        Console.WriteLine("int   -------\t" + i + "\t sizeof = " + sizeof(int) + " Bytes");
        Console.WriteLine("long  -------\t" + l + "\t sizeof = " + sizeof(long) + " Bytes");

        // Alteracao realizada por Isabelle
        Console.WriteLine("Linhas a mais no código -- Isabelle");

        // Adicionando mais alteracoes trabalho 2
        Console.WriteLine("Commit Version 1.0 ");
        Results r = new Results();
        r.PrintResults();
    }
}
