using projetoEstacionamento.Models;

bool ficarNoMenu = true;

while (ficarNoMenu)
{
    Console.Clear();
    Console.WriteLine("Bem-Vindo ao estacionamento mariofneto!");
    Console.WriteLine("========================================");
    Console.WriteLine("Selecione uma das opções:\n");
    Console.WriteLine("1 - Cadastrar Veículo\n2 - Remover Veículo\n3 - Listar Veículos\n4 - Encerrar");
    string opcao = Console.ReadLine();

    Estacionamento veiculo = new Estacionamento();

    switch (opcao)
    {
        case "1": veiculo.AdicionarVeiculo(); break;
        case "2": veiculo.RemoverVeiculo(); break;
        case "3": veiculo.ListarVeiculo(); break;
        case "4": ficarNoMenu = false; break;
        default:
            Console.Clear();
            Console.WriteLine("[ERRO] Apenas número de 1 a 4 (aperte ENTER e tente novamente)");
            Console.ReadLine();
            break;
    }
}

