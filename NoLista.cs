using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listas
{
    class NoLista
    {
        /// <summary>
        /// Informação a ser guardada
        /// </summary>
        public int Informacao { get; set; }

        /// <summary>
        /// Aponta para o próximo nó da lista
        /// </summary>
        public NoLista Proximo { get; set; }

        /// <summary>
        /// Construtora padrão
        /// </summary>
        public NoLista()
        {
            //Iniciar a informação com um valor qualquer
            Informacao = 0;

            //Garantir que este no novo não tenha próximo
            Proximo = null;
        }

        /// <summary>
        /// Construtora
        /// </summary>
        /// <param name="valor">O valor a seu guardado na informação</param>
        public NoLista(int valor)
        {
            //Iniciar a informação com o valor desejado
            Informacao = valor;

            //Garantir que este no novo não tenha próximo
            Proximo = null;
        }
    }
}
