namespace SalesManagement.Models
{
    public class Cliente
    {
        private long _id;
        private string _nome = "";
        private string _sobrenome = "";
        private string _endereco = "";
        private string _telefone = "";

        public string NomeCompleto()
        {
            return $"{Nome} {Sobrenome}";
        }

        public long Id{
            get { return _id; }
            set { _id = value; }
        }
        public string Nome{
            get { return _nome; }
            set { _nome = value; }
        }
        public string Sobrenome{
            get { return _sobrenome; }
            set { _sobrenome = value; }
        }
        public string Endereco{
            get { return _endereco; }
            set { _endereco = value; }
        }
        public string Telefone{
            get { return _telefone; }
            set { _telefone = value; }
        }

        public override string ToString()
        {
            return $"{Id}\n{Nome}\n{Sobrenome}\n{Endereco}\n{Telefone}";
        }

    }
}