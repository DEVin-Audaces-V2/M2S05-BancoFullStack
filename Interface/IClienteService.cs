using BancoFullStack.Model;

namespace BancoFullStack.Interface
{
    public interface IClienteService
    {
        void CriarConta();
        Cliente BuscarClientePorNumeroDeConta(int numeroConta);
        void ExibirClientes();
    }
}