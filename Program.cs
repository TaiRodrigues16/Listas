using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEncadeada lista = new ListaEncadeada();

            lista.Imprimir();

            lista.InserirNo(1);
            lista.InserirNo(2);
            lista.InserirNo(3);
            lista.InserirNo(4);
            lista.InserirNo(5);
            lista.InserirNoFim(6);
            lista.InserirNo(7);
            lista.InserirNoFim(8);
            lista.RemoverNo(5);

            Console.WriteLine("Primeira execução do imprimir");
            lista.Imprimir();
            
            Console.WriteLine("");
            Console.WriteLine("Segunda execução do imprimir");
            lista.Imprimir();

            
        }
    }
}
