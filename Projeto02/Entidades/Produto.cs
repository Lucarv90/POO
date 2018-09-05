using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades.Tipos;

namespace Projeto02.Entidades
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public StatusProduto Status { get; set; }

        public Produto()
        {

        }

        public Produto(int idProduto, string nome, decimal preco, StatusProduto status)
        {
            IdProduto = idProduto;
            Nome = nome;
            Preco = preco;
            Status = status;
        }

        public override string ToString()
        {
            return $"{IdProduto}, {Nome}, {Preco}, {Status}";
        }
    }
}
