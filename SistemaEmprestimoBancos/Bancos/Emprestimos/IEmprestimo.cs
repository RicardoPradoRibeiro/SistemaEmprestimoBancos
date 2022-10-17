using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimoBancos.Bancos.Emprestimos
{
    public interface IEmprestimo
    {
        public void CalcularTjPessoal();
        public void CalcularTjVeicular();
    }
}
