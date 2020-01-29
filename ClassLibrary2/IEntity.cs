using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer
{
    public class IEntity
    {
        public string Id;
    }

    public interface IRepository<T> where T : IEntity
    {
        
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int Id);
    }
    public class Repository<T>:IRepository<T> where T : IEntity
    {
        public void Add(T entity)
        {
            //logik
        }
    }
    

    
    
}
