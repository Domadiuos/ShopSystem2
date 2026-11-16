namespace ShopSystem.Repo
{
    public interface IGeneric<T> where T : class
    {
        //GET All
        Task<IEnumerable<T>> GetAll();
        //GET By Id
        Task<T?> GetById(int id);
        //Delete
        Task<bool> Delete(int id);
        //Add
        Task Add(T entity);
        //Update
        Task Update(T entity);


    }
}
