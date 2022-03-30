using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listas
{
    class ListaEncadeada
    {
        /// <summary>
        /// Aponta para o primeiro nó da lista
        /// </summary>
        public NoLista Primeiro { get; set; }

        /// <summary>
        /// Construtora padrão
        /// </summary>
        public ListaEncadeada()
        {
            // Garantir que a lista está vazia
            Primeiro = null;
        }

        /// <summary>
        /// Insere um novo nó no inicio da lista
        /// </summary>
        /// <param name="valor"></param>
        public void InserirNo(int valor)
        {
            NoLista novo = new NoLista(valor);

            // Testar se a lista está vazia
            if (Primeiro == null)
            {
                Primeiro = novo;
            }
            else
            {
                novo.Proximo = Primeiro;
                Primeiro = novo;
            }

        }

        /// <summary>
        /// Insere um novo valor no fim da lista
        /// </summary>
        /// <param name="valor"></param>
        public void InserirNoFim(int valor)
        {
            NoLista novo = new NoLista(valor);

            // Testar se a lista está vazia
            if (Primeiro == null)
            {
                Primeiro = novo;
            }
            else
            {
                NoLista navegador = Primeiro;

                while (navegador.Proximo != null)
                {
                    navegador = navegador.Proximo;
                }

                navegador.Proximo = novo;
            }

        }

        public void RemoverNo(int valor)
        {
            NoLista remover = new NoLista(valor);
            remover = null;

            if (Primeiro == null)
            {
                Console.WriteLine("Lista vazia!");
            }
            else
            {
                //Garantir que o Primeiro não perca a referência
                NoLista navegador = Primeiro;

                while ((navegador != null) && (navegador.Proximo != null))
                {
                    if (navegador.Proximo.Informacao == valor)
                    {
                        navegador.Proximo = navegador.Proximo.Proximo;
                        break;
                    }

                    navegador = navegador.Proximo;
                }

            }
        }

        public void Imprimir()
        {
            if (Primeiro != null)
            {
                // Garantir que o Primeiro não perca a referência
                NoLista navegador = Primeiro;

                while (navegador != null)
                {
                    Console.Write(navegador.Informacao + ", ");
                    navegador = navegador.Proximo;
                }
            }
        }
    }
}
