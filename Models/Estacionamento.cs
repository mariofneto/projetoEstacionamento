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
        public List<string> veiculos = new List<string>();

        public void AdicionarVeiculo()
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
        }
        public void RemoverVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Qual a placa do seu veículo? EXEMPLO BASE(XXX-YYYY)");
            var placaInserida = Console.ReadLine().ToUpper();
            var buscarPlaca = veiculos.Contains(placaInserida);

            if (buscarPlaca)
            {
                veiculos.Remove(placaInserida);
                Console.WriteLine("Veiculo removido com sucesso!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Não existe esse veículo no nosso estacionamento!");
            }
        }
        public void ListarVeiculo()
        {
            Console.Clear();
            Console.WriteLine("Temos esses veiculos: ");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
            Console.ReadLine();
        }
    }
}