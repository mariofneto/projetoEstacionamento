using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projetoEstacionamento.Models
{
    public class Menu
    {
        public static void Escolha()
        {
            Console.Clear();
            Console.WriteLine("Bem-Vindo ao estacionamento mariofneto!");
            Console.WriteLine("========================================");
            Console.WriteLine("Selecione uma das opções:\n");
            Console.WriteLine("1 - Cadastrar Veículo\n2 - Remover Veículo\n3 - Listar Veículos\n4 - Encerrar");
            var opcao = Convert.ToInt32(Console.ReadLine());
            var opcaoEscolhida = (opcao)opcao;
           
            var estacionamento = new Estacionamento();

            switch (opcaoEscolhida)
            {
                case Models.opcao.Cadastrar: estacionamento.AdicionarVeiculo(); break;
                case Models.opcao.Remover: estacionamento.RemoverVeiculo(); break;
                case Models.opcao.Listar: estacionamento.ListarVeiculo(); break;
                case Models.opcao.Encerrar: Environment.Exit(0); break;
                default:
                    Console.Clear();
                    Console.WriteLine("[ERRO] Apenas número de 1 a 4 (aperte ENTER e tente novamente)");
                    Console.ReadLine();
                    break;
            }
        }
    }
}