using SistemaEmprestimoBancos.AreaEmprestimos;
using SistemaEmprestimoBancos.Bancos;
using SistemaEmprestimoBancos.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimoBancos.Main
{
    public class ProgramMainBancos
    {
        public static void ProgramBancos()
        {
            bool sair = false;
            while (sair == false)
            {
                Console.WriteLine("Bem Vindo ao Simulador de Emprestimo ");
                Console.WriteLine();

                Console.WriteLine("1-Ver Taxas de Juros\n2-Fazer uma simulação de Empréstimo\n3-Sair");
                int.TryParse(Console.ReadLine(), out int opcao);
                

                EscolhaMenuPrincipal op = (EscolhaMenuPrincipal)opcao;
                switch (op)
                {
                    case EscolhaMenuPrincipal.VerTaxaJuro:
                        Banco.MostrarBancos();
                        break;
                    case EscolhaMenuPrincipal.SimulacaoEmprestimo:
                        MenuSimulacaoEmprestimos.MenuDeEmprestimo();
                        break;
                    case EscolhaMenuPrincipal.Sair:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Número inválido!Digite novamente.");
                        Console.WriteLine();
                        ProgramBancos();
                        break;
                }
                Console.Clear();
            }
        }
    }
                
}




