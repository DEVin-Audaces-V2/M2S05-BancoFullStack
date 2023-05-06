using BancoFullStack.Interface;
using BancoFullStack.Model;

namespace BancoFullStack.Service
{
    public class TransacaoService : ITransacaoService
    {
        private readonly IClienteService _clienteService;
        public TransacaoService(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }
        public void AdicionarTransacao(){
            Console.WriteLine("Digite o número da conta");
            var numeroConta = int.Parse(Console.ReadLine());

            Cliente cliente = _clienteService.BuscarClientePorNumeroDeConta(numeroConta);
            if (cliente == null){
                Console.WriteLine("Conta não Cadastrada");
                return;
            }

            Console.WriteLine("Qual o valor da transação ");
            var valor = decimal.Parse(Console.ReadLine());

            var transacao = new Transacao(valor);

            cliente.Extrato.Add(transacao);

        }
        public void ExibirExtrato ()
        {
            Console.WriteLine("Digite o número da conta");
            var numeroConta = int.Parse(Console.ReadLine());

            Cliente cliente = _clienteService.BuscarClientePorNumeroDeConta(numeroConta);
            if (cliente == null){
                Console.WriteLine("Conta não Cadastrada");
                return;
            }
            decimal saldo = 0;
            foreach(var transacao in cliente.Extrato){
                Console.WriteLine(transacao.ToString());
                saldo += transacao.Valor;
            }
            Console.WriteLine($"O Saldo Calculado é de {saldo.ToString("C2")}");
            Console.WriteLine($"O Saldo da conta é de {cliente.Saldo.ToString("C2")}");
        }
    }
}