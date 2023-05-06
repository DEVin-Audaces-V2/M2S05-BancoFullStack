

namespace BancoFullStack.Model
{
    public abstract class Cliente
    {
        public int NumeroConta { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public decimal Saldo { get { return GetSaldo();} private set{} }
        public List<Transacao> Extrato { get; set; }

        public decimal GetSaldo(){
            decimal saldo = 0;
            foreach(var transacao in Extrato){
                saldo += transacao.Valor;
            }

            return saldo;
        }
      
        public Cliente()
        {
            Extrato = new List<Transacao>();
        }

        public Cliente(int numeroConta, string endereco, string telefone) :this()
        {
            NumeroConta = numeroConta;
            Endereco = endereco;
            Telefone = telefone;
            Saldo = 0;
        }

        public virtual string ResumoCliente(){
            return $"Numero Conta: {NumeroConta} | End: {Endereco} | Tel: {Telefone} | Saldo: {Saldo.ToString("C2")}";
        }
    }
}