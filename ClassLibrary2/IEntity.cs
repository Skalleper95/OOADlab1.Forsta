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
        IEnumerable<T> List { get; }
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T FindById(int Id);
    }
    public partial class Medlem : IEntity
    {
        public int Id { get; set; }

        public string Medlemsnamn { get; set; }
    }

    /*public class MedlemRepository : IRepository<Medlem>
    {
        Model1_medlemContext;
        public MedlemRepository()
        {
            _medlemContext = new Model1();
        }
        
    }
    */
}
