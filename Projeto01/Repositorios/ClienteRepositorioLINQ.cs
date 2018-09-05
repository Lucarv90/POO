using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using Projeto01.Entidades.Tipos;
using Projeto01.Contratos;

namespace Projeto01.Repositorios
{
    public class ClienteRepositorioLINQ : IClienteRepositorio
    {
        private List<Cliente> listagemClientes;

        public ClienteRepositorioLINQ()
        {
            listagemClientes = new List<Cliente>();
        }        

        public void AdicionarCliente(Cliente c)
        {
            listagemClientes.Add(c);
        }

        public List<Cliente> ConsultarClientes()
        {
            return listagemClientes;
        }

        public List<Cliente> ConsultarClientesEstadoCivil(EstadoCivil estadoCivil)
        {
            return (from c in listagemClientes
                    where c.EstadoCivil == estadoCivil
                    select c).ToList();
        }

        public List<Cliente> ConsultarClientesPorNome(string nome)
        {
            return (from c in listagemClientes
                    where c.Nome.Contains(nome)
                    orderby c.Nome ascending
                    select c).ToList();
        }

        public List<Cliente> ConsultarClientesPorSexo(Sexo sexo)
        {
            return (from c in listagemClientes
                    where c.Sexo == sexo
                    select c).ToList();
        }

        public Cliente ObterPorID(int idCliente)
        {
            return (from c in listagemClientes
                    where c.IdCliente == idCliente
                    select c).FirstOrDefault();
        }
    }
}
