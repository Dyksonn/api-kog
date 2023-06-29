namespace APIWallet.Domain.Entities
{
    public class Wallet : BaseEntity
    {
        public Wallet()
        {

        }
        public Wallet(int userID, decimal valorAtual, string banco)
        {
            UserID = userID;
            ValorAtual = valorAtual;
            Banco = banco;
        }
        [System.Text.Json.Serialization.JsonIgnore]
        public int Id { get; set; }
        public int UserID { get; set; }
        public decimal ValorAtual { get; set; }
        public string Banco { get; set; }
        public DateTime UltimaAtualizacao { get; set; }
    }
}
