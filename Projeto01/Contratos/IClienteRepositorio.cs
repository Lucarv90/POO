using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using Projeto01.Entidades.Tipos;

namespace Projeto01.Contratos
{
    public interface IClienteRepositorio
    {

        void AdicionarCliente(Cliente c);
        List<Cliente> ConsultarClientes();
        List<Cliente> ConsultarClientesPorNome(string nome);
        List<Cliente> ConsultarClientesPorSexo(Sexo sexo);
        List<Cliente> ConsultarClientesEstadoCivil(EstadoCivil estadoCivil);
        Cliente ObterPorID(int idCliente);


    }
}
