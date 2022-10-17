using SistemaEmprestimoBancos.Bancos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimoBancos.MetodosCRUD
{
    public interface IBancos
    {
        void Adicionar(Banco banco);
        void Atualizar(Banco banco);
        void Remover(Banco banco);
        IList<Banco> Bancos();


    }
}
