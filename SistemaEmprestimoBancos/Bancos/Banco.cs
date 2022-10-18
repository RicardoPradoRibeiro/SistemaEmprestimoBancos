using SistemaEmprestimoBancos.Conexcao;
using SistemaEmprestimoBancos.Enums;
using SistemaEmprestimoBancos.Main;
using SistemaEmprestimoBancos.MetodosCRUD;
using System.ComponentModel.Design;

namespace SistemaEmprestimoBancos.Bancos
{
    public class Banco
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double TjPessoal { get; set; }
        public double TjVeicular { get; set; }

       

        public static void MostrarBancos()
        {
            Console.WriteLine();
            using (var repo = new BancoEntity())
            {
                IList<Banco> bancos = repo.Bancos();
                foreach (var item in bancos)
                {
                    Console.WriteLine(item);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Precione Enter para voltar.");
            Console.ReadLine();
            Console.Clear();
        }


        public void Menu(int banco)
        {
            Console.WriteLine("Deseja simular com Taxa Pessoal ou Veicular? ");
            int.TryParse(Console.ReadLine(), out int opcao);
            EscolhaModalidade op = (EscolhaModalidade)opcao;
            Console.WriteLine("Qual o valor que deseja Simular?");
            double.TryParse(Console.ReadLine(), out double valor);
            Console.WriteLine("Em quantos anos? ");
            int.TryParse(Console.ReadLine(), out int anos);
            switch (op)
            {
                case EscolhaModalidade.EmprestimoPessoal:
                    using (var repo = new BancoContext())
                    {
                        IList<Banco> bancos = repo.bancos.ToList();

                        foreach (var item in bancos)
                        {
                            if (item.Id == banco)
                            {

                                double a = 1 + (item.TjPessoal / 100);
                                double b = Math.Pow(a, anos);
                                double c = b * valor;
                                Console.WriteLine("Valor total : " + c.ToString("C2"));
                            }
                        }
                    }
                    break;
                case EscolhaModalidade.EmprestimoVeicular:
                    
                    using (var repo = new BancoContext())
                    {
                        IList<Banco> bancos = repo.bancos.ToList();

                        foreach (var item in bancos)
                        {
                            if (item.Id == banco)
                            {

                                double a = 1 + (item.TjVeicular / 100);
                                double b = Math.Pow(a, anos);
                                double c = b * valor;
                                Console.WriteLine("Valor total : " + c.ToString("C2"));
                            }
                        }
                    }
                    break;
            }
            Console.WriteLine("Aperte Enter para sair.");
            Console.ReadLine();
            Console.Clear();
            ProgramMainBancos.ProgramBancos();
        }
        public override string ToString()
        {
            return $"Banco: {Nome}\nTaxa de Juros Pessoal: {TjPessoal}\nTaxa de Juros Veicular: {TjVeicular}";
        }






                                



            







        











    }
}
