namespace SalesManagement
{
    public class CategoriaModel
    {
        private long _id;
        public string _nome;
        
        public int Id{
            get { return _id; }
            set { _id = value; }
        }
        public int Nome{
            get { return _nome; }
            set { _nome = value; }
        }
    }
}