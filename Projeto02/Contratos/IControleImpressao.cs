using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto02.Entidades;
using Projeto02.Entidades.Tipos;

namespace Projeto02.Contratos
{
    public interface IControleImpressao<T>
    {
        void Imprimir(T obj);

    }
}
