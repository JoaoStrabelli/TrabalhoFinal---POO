namespace SalesManagement.Interfaces
{  
    public interface IRepository<T>
        {
            void Create(T entidade);
            void Update(T entidade);
            void Delete(long id);
            T? GetById(long id);
            List<T> GetAll();
        }
}