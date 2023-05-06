using BancoFullStack.Model;
using BancoFullStack.Service;
using BancoFullStack.Interface;


IClienteService clienteService = new ClienteService();
ITransacaoService transacaoService = new TransacaoService(clienteService);

string opcao;
do{
Console.WriteLine("\n\nBem Vindo ao banco Fullstack, Escolha uma opção para continuar: ");
Console.WriteLine("1 - Abrir Conta");
Console.WriteLine("2 - Consultar Conta");
Console.WriteLine("3 - Listar Todas as contas");
Console.WriteLine("5 - Adicionar Transacao");
Console.WriteLine("6 - Exibir Extrato");
Console.WriteLine("4 - Sair\n");
opcao = Console.ReadLine();
SelecaoMenu(opcao);
}while(opcao != "4");



void SelecaoMenu(string opcao){
  switch(opcao){
    case "1": 
      clienteService.CriarConta();
      break;
    case"2": 
      Console.WriteLine("Digite o Numero da conta:");
      int numeroConta = int.Parse(Console.ReadLine());
      var cliente = clienteService.BuscarClientePorNumeroDeConta(numeroConta);
      if (cliente == null){
        Console.WriteLine("Conta não Cadastrada");
      }
      else{
        Console.WriteLine(cliente.ResumoCliente());
      }
      break;
    case"3":
      clienteService.ExibirClientes();
      break;
    case "4":
      break;
    case "5":
      transacaoService.AdicionarTransacao();
    break;
    case "6":
      transacaoService.ExibirExtrato();
    break;
    default: 
      Console.WriteLine("Opção Inválida");
      break;
  }
}


// clienteService.ExibirClientes();



// var pessoaFisica = new PessoaFisica(1,"Rua ", "123", "456", "Vitor", new DateTime(2005,05,5));

// Console.WriteLine(pessoaFisica.EhMaior());

// Console.ReadLine();