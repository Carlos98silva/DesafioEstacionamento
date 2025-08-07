using DesafioEstacionamento.Models;

Console.WriteLine("Seja bem-vindo ao sistema de estacionamento!");
Console.Write("Digite o preço inicial: ");
double precoInicial = Convert.ToDouble(Console.ReadLine());

Console.Write("Agora digite o preço por hora: ");
double precoPorHora = Convert.ToDouble(Console.ReadLine());

Estacionamento es=new Estacionamento(precoInicial, precoPorHora);

string opcao = string.Empty;
bool ExibirMenu = true;

while (ExibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:\n1 - Cadastrar veículo\n2 - Remover veículo\n3 - Listar veículos\n4 - Encerrar");
    switch (Console.ReadLine())
    {
        case "1":
            es.AdicionarVeiculo();
            break;
        case "2":
            es.RemoverVeiculo();
            break;
        case "3":
            es.ListarVeiculo();
            break;
        case "4":
            ExibirMenu=false;
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
    Console.WriteLine("Pressione uma tecla para continuar.");
    Console.ReadLine();
}
Console.WriteLine("O programa se encerrou!");
 