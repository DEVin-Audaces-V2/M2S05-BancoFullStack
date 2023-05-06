
namespace BancoFullStack.Model
{
    public class Transacao
    {
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public Transacao(decimal valor)
        {
            Valor = valor;
            Data = DateTime.Now;
        }
        public override string ToString(){
            return $"{Data} - {Valor.ToString("C2")}";
        }
    }
}