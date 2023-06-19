namespace SalesManagement
{
    public class Cliente
    {
        public long? Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Sobrenome { get; set; } = string.Empty;
        public string Endereco { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        public string NomeCompleto
        {
            get
            {
                return $"{Nome} {Sobrenome}";
            }
        }
    }
}