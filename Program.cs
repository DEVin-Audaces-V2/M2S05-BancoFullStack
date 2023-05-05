using BancoFullStack.Model;
using BancoFullStack.Service;

ClienteService clienteService = new ClienteService();

clienteService.CriarConta();
clienteService.CriarConta();

clienteService.ExibirClientes();



var pessoaFisica = new PessoaFisica(1,"Rua ", "123", "456", "Vitor", new DateTime(2005,05,5));

Console.WriteLine(pessoaFisica.EhMaior());

Console.ReadLine();