using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoEstacionamento.Models
{
    public class Estacionamento
    {
        public decimal precoInicial { get; set; }
        public decimal precoHora { get; set; }
        public static List<Veiculo> veiculos = new List<Veiculo>();
        public Veiculo veiculo { get; set; }

        public void AdicionarVeiculo()
        {
            Console.Clear();
            var veiculo = new Veiculo();
            Console.Write("Qual o valor inicial R$");
            veiculo.valorInicial = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Qual o valor por hora R$");
            veiculo.valorPorHora = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual a placa do seu veículo? EXEMPLO BASE(XXX-YYYY)");
            veiculo.placa = Console.ReadLine().ToUpper();

            veiculos.Add(veiculo);

            Console.WriteLine($"Veículo com placa {veiculo.placa} adicionado com sucesso!!!");
            Console.ReadLine();
            Menu.Escolha();
        }
        public void RemoverVeiculo()
        {
            Console.Clear();
            var veiculo = new Veiculo();
            Console.WriteLine("Quantas horas você ficou?");
            var horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a placa do seu veículo? EXEMPLO BASE(XXX-YYYY)");
            veiculo.placa = Console.ReadLine().ToUpper();
            var buscarPlaca = veiculos.FirstOrDefault(x => x.placa == veiculo.placa);

            if (buscarPlaca != null)
            {
                var pagamento = buscarPlaca.valorInicial + buscarPlaca.valorPorHora * horas;
                veiculos.Remove(buscarPlaca);
                Console.WriteLine($"O veículo {buscarPlaca.placa} foi removido e o preço total foi de: R$ {pagamento}");
            }
            else
            {
                Console.WriteLine("Não existe essa placa no nosso estacionamento, tente novamente!");
            }
            Console.ReadLine();
            Menu.Escolha();
        }
        public void ListarVeiculo()
        {
            if (veiculos.Count >= 1)
            {
                Console.Clear();
                Console.WriteLine("Temos esses veículos no nosso estacionamento: ");
                Console.WriteLine("=============================================");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine($"* {veiculo.placa} *");
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Não temos nenhum veículo no momento, tente adicionar algum!");
            }

            Console.ReadLine();
            Menu.Escolha();
        }
    }
}