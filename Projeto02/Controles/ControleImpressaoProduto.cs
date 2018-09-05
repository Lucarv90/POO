using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades;
using Projeto02.Contratos;

namespace Projeto02.Controles
{
    public class ControleImpressaoProduto : IControleImpressao<Produto>
    {
        public void Imprimir(Produto obj)
        {
            Console.WriteLine("Produto..........: " + obj.ToString());
        }
    }
}
