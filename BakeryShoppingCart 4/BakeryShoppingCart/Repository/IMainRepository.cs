using System;
namespace BakeryShoppingCart.Repository
{
    public interface IMainRepository<T>
    {
        public void Save(T entity);

        public void Update(T entity);

        public void Delete(T entity);
        void GetAllUsersByName(string name);
        string GetAllUsersByName(string name);
    }
}
