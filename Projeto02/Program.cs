using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades;
using Projeto02.Entidades.Tipos;
using Projeto02.Controles;
using Projeto02.Contratos;

namespace Projeto02
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto(1, "Celular", 500, StatusProduto.Disponivel);

            ControleImpressaoProduto cip = new ControleImpressaoProduto();
            cip.Imprimir(p);




            Console.ReadKey();

        }
    }
}
