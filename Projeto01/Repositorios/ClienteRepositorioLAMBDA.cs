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
    public class ClienteRepositorioLAMBDA : IClienteRepositorio
    {
        private List<Cliente> listagemClientes;

        public ClienteRepositorioLAMBDA()
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
            return listagemClientes
                 .Where(c => c.EstadoCivil == estadoCivil)
                 .OrderBy(c => c.Nome)
                 .ToList();
        }

        public List<Cliente> ConsultarClientesPorNome(string nome)
        {
            return listagemClientes
                 .Where(c => c.Nome.Contains(nome))
                 .OrderBy(c => c.Nome)
                 .ToList();
        }

        public List<Cliente> ConsultarClientesPorSexo(Sexo sexo)
        {
            return listagemClientes
                 .Where(c => c.Sexo == sexo)
                 .OrderBy(c => c.Nome)
                 .ToList();
        }

        public Cliente ObterPorID(int idCliente)
        {
            return listagemClientes
                .FirstOrDefault(c => c.IdCliente == idCliente);
        }
    }
}
