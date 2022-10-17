using SistemaEmprestimoBancos.Bancos;
using SistemaEmprestimoBancos.Conexcao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimoBancos.MetodosCRUD
{
    public class BancoEntity : IBancos, IDisposable//Classe onde apenas o Admin vai ter acesso, para incluir novas parcerias de bancos. 
    {
        private BancoContext contexto;

        public BancoEntity()
        {
            contexto = new BancoContext();
        }


        public void Adicionar(Banco banco)
        {
            contexto.Add(banco);
            
            contexto.SaveChanges();
        }
        public void Remover(Banco banco)
        {
            contexto.Remove(banco);
            
            contexto.SaveChanges();
        }

        public void Atualizar(Banco banco)
        {
            contexto.Update(banco);
           

            contexto.SaveChanges();
        }

        public IList<Banco> Bancos()
        {
            return contexto.bancos.ToList();
        }

        public void Dispose()
        {
            contexto.Dispose();
        }

    }
}
