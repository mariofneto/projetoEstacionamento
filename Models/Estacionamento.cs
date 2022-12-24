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
        public static List<string> veiculos = new List<string>();
        public Veiculo veiculo { get; set; }

        public void AdicionarVeiculo()
        {
            Console.Clear();
            Console.Write("Qual o valor inicial R$");
            veiculo.valorInicial = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Qual o valor por hora R$");
            veiculo.valorPorHora = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual a placa do seu veículo? EXEMPLO BASE(XXX-YYYY)");
            veiculo.placa = Console.ReadLine().ToUpper();

            veiculos.Add(veiculo.placa);

            Console.WriteLine($"Veículo com placa {veiculo.placa} adicionado com sucesso!!!");
            Console.ReadLine();
            Menu.Escolha();
        }
        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Quantas horas você ficou?");
            var horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a placa do seu veículo? EXEMPLO BASE(XXX-YYYY)");
            veiculo.placa = Console.ReadLine().ToUpper();
            var buscarPlaca = veiculos.FirstOrDefault(veiculo.placa);

            if (buscarPlaca.IndexOf(veiculo.placa) >= 0)
            {
                var pagamento = veiculo.valorInicial + veiculo.valorPorHora * horas;
                veiculos.Remove(veiculo.placa);
                Console.WriteLine($"O veículo {veiculo.placa} foi removido e o preço total foi de: R$ {pagamento}");

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
            Console.Clear();
            Console.WriteLine("Temos esses veículos no nosso estacionamento: ");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"* {veiculo} *");
            }
            Console.ReadLine();
            Menu.Escolha();
        }
    }
}