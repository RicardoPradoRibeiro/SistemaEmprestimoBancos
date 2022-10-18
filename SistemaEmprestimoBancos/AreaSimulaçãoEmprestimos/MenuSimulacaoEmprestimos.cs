using SistemaEmprestimoBancos.Bancos;
using SistemaEmprestimoBancos.Enums;
using SistemaEmprestimoBancos.Main;

namespace SistemaEmprestimoBancos.AreaEmprestimos
{
    public class MenuSimulacaoEmprestimos
    {
        public static void MenuDeEmprestimo()
        {
            bool sair = false;
            while(sair == false)
            {
                Console.WriteLine("Selecione o Banco que deseja fazer uma simulação: ");
                Console.WriteLine("1-Caixa\n2-Itau\n3-Santander\n4-Bradesco\n5-Viacredi\n6-Voltar");
                int.TryParse(Console.ReadLine(), out int opcaoBanco);
                EnumBancos op = (EnumBancos)opcaoBanco;
                switch (op)
                {
                    case EnumBancos.Caixa:
                        var caixa = new Banco();
                        caixa.Menu(opcaoBanco);
                        break;
                    case EnumBancos.Itau:
                        var itau = new Banco();
                        itau.Menu(opcaoBanco);
                        break;
                    case EnumBancos.Santander:
                        var santander = new Banco();
                        santander.Menu(opcaoBanco);
                        break;
                    case EnumBancos.Bradesco:
                        var bradesco = new Banco();
                        bradesco.Menu(opcaoBanco);
                        break;
                    case EnumBancos.Viacredi:
                        var viacredi = new Banco();
                        viacredi.Menu(opcaoBanco);
                        break;
                    case EnumBancos.Voltar:
                        sair = true;
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Digite novamente.");
                        Console.Clear();
                        ProgramMainBancos.ProgramBancos();
                        break;

                }

            }
            
        }

    }
}
