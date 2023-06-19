namespace SalesManagement
{
    public class CategoriaModel
    {
        private long _id;
        public string _nome;
        
        public long Id{
            get { return _id; }
            set { _id = value; }
        }
        public string Nome{
            get { return _nome; }
            set { _nome = value; }
        }
    }
}