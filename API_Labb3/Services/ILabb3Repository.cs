namespace API_Labb3.Services
{
    public interface ILabb3Repository<T>
    {
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public T Add(T entity);
        public T Update(T entity);
        public T Delete(T entity);

    }
}
