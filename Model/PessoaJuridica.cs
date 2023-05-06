

namespace BancoFullStack.Model
{
    public class PessoaJuridica : Cliente
    {
        public string CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string InscricaoEstadual { get; set; }

        public PessoaJuridica()
        {
            
        }

        public PessoaJuridica(int numeroConta, string endereco, string telefone,
                            string cnpj, string razaoSocial, string inscricaoEstadual) 
                            :base (numeroConta, endereco,telefone)
        {
            CNPJ = cnpj;
            RazaoSocial = razaoSocial;
            InscricaoEstadual = inscricaoEstadual;
        }
        public override string ResumoCliente(){
            return $"{base.ResumoCliente()}| CNPJ: {CNPJ}| Razão Social: {RazaoSocial}| IE:  {InscricaoEstadual}" ;
        }
    }
}