namespace APIWallet.Domain.Entities
{
    public class User : BaseEntity
    {
        public User()
        {

        }
        public User(int id, string nome, DateTime nascimento, string cpf)
        {
            Id = id;
            Nome = nome;
            Nascimento = nascimento;
            CPF = cpf;
        }
        [System.Text.Json.Serialization.JsonIgnore]
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Nascimento { get; set; }
        public string CPF { get; set; }
    }
}
