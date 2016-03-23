using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SCIPA.Data.Repository
{
    public interface IGenericRepository<TObject>
    {
        ICollection<TObject> GetAll(params Expression<Func<TObject, object>>[] includeItems);

        Task<List<TObject>> GetAllAsync(params Expression<Func<TObject, object>>[] includeItems);


        TObject FindById(object id);

        TObject Find(Expression<Func<TObject, bool>> match,
            params Expression<Func<TObject, object>>[] includeItems);


        Task<TObject> FindAsync(Expression<Func<TObject, bool>> match,
            params Expression<Func<TObject, object>>[] includeItems);


        ICollection<TObject> FindAll(Expression<Func<TObject, bool>> match,
           params Expression<Func<TObject, object>>[] includeItems);


        Task<ICollection<TObject>> FindAllAsync(Expression<Func<TObject, bool>> match,
            params Expression<Func<TObject, object>>[] includeItems);


        TObject Create();


        void Add(TObject t);

        void AddRange(IEnumerable<TObject> entities);


        void Update(TObject t);

        void Delete(TObject t);

        void DeleteRange(IEnumerable<TObject> entities);

        int Count();

        Task<int> CountAsync();

        int Commit();

        Task<int> CommitAsync();

    }
}