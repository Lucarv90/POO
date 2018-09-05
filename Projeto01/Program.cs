using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto01.Entidades;
using Projeto01.Entidades.Tipos;
using Projeto01.Contratos;
using Projeto01.Repositorios;


namespace Projeto01
{
    class Program
    {
        static void Main(string[] args)
        {
            IClienteRepositorio rep = null;

            Console.Write("Informe 1(LINQ) ou 2(LAMBDA): ");
            int opcao = int.Parse(Console.ReadLine());


            switch (opcao)
            {
                case 1:
                    rep = new ClienteRepositorioLINQ();
                    break;

                case 2:
                    rep = new ClienteRepositorioLAMBDA();
                    break;

            }

            List<Cliente> lista = new List<Cliente>();

            Cliente c1 = new Cliente(1, "Ana", "ana@gmail.com", Sexo.Feminino, EstadoCivil.Solteiro);
            Cliente c2 = new Cliente(2, "Leo", "Leo@gmail.com", Sexo.Masculino, EstadoCivil.Casado);
            Cliente c3 = new Cliente(3, "Bia", "Bia@gmail.com", Sexo.Feminino, EstadoCivil.Casado);
            Cliente c4 = new Cliente(4, "Rui", "Rui@gmail.com", Sexo.Masculino, EstadoCivil.Divorciado);

            /*
            lista.Add(c1);
            lista.Add(c2);
            lista.Add(c3);
            lista.Add(c4);


            foreach(Cliente c in lista)
            {
                Console.WriteLine("Cliente: " + c.ToString());
            }
            */




            try
            {

                rep.AdicionarCliente(c1);
                rep.AdicionarCliente(c2);
                rep.AdicionarCliente(c3);
                rep.AdicionarCliente(c4);

                Console.WriteLine("Clientes do sexo feminino: ");

                foreach (Cliente c in rep.ConsultarClientesPorSexo(Sexo.Feminino))
                {
                    Console.WriteLine("Cliente: " + c.ToString());
                }








            }
            catch (Exception e)
            {
                Console.WriteLine("Erro....: " + e.Message);
            }


            Console.ReadKey();
        }
    }
}
