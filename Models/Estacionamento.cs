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

        public static void AdicionarVeiculo()
        {
            Console.Clear();
            Console.Write("Qual o valor inicial R$");
            var precoInicial = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Qual o valor por hora R$");
            var precoHora = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Qual a placa do seu veículo? EXEMPLO BASE(XXX-YYYY)");
            var placaInserida = Console.ReadLine().ToUpper();

            veiculos.Add(placaInserida);

            Console.WriteLine($"Veículo com placa {placaInserida} adicionado com sucesso!!!");
            Console.ReadLine();
            Menu.Escolha();
        }
        public static void RemoverVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Qual a placa do seu veículo? EXEMPLO BASE(XXX-YYYY)");
            var placaInserida = Console.ReadLine().ToUpper();
            var buscarPlaca = veiculos.Contains(placaInserida);

            if(buscarPlaca)
            {

            }
            else{
                Console.WriteLine("Não existe essa placa no nosso estacionamento, tente novamente!");
                
            }
            
        }
        public static void ListarVeiculo()
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