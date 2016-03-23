//namespace SCIPA.Data.Repository
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Data.Entity;
//    using System.Data.Entity.Validation;
//    using System.Linq;
//    using System.Linq.Expressions;
//    using System.Threading.Tasks;

//    //https://github.com/CypressNorth/.NET-EF6-GenericRepository/blob/master/BaseService.cs
//    public abstract class GenericRepository<TObject> : IGenericRepository<TObject>, IDisposable where TObject : class
//    {
//        protected DbContext _context;

//        public GenericRepository(DbContext context)
//        {
//            _context = context;
//        }

//        public void Dispose()
//        {
//            // Clear up references
//            _context.Dispose();
//            _context = null;
//        }

//        public ICollection<TObject> GetAll(params Expression<Func<TObject, object>>[] includeItems)
//        {
//            return _context.Set<TObject>().IncludeManyAsDbQuery(includeItems).ToList();
//        }

//        public async Task<List<TObject>> GetAllAsync(params Expression<Func<TObject, object>>[] includeItems)
//        {
//            return await _context.Set<TObject>().IncludeManyAsDbQuery(includeItems).ToListAsync();
//        }

//        public TObject FindById(object id)
//        {
//            return _context.Set<TObject>().Find(id);
//        }

//        public TObject Find(Expression<Func<TObject, bool>> match,
//            params Expression<Func<TObject, object>>[] includeItems)
//        {
//            return _context.Set<TObject>().IncludeManyAsDbQuery(includeItems).SingleOrDefault(match);
//        }

//        public async Task<TObject> FindAsync(Expression<Func<TObject, bool>> match,
//            params Expression<Func<TObject, object>>[] includeItems)
//        {
//            return await _context.Set<TObject>().IncludeManyAsDbQuery(includeItems).SingleOrDefaultAsync(match);
//        }

//        public ICollection<TObject> FindAll(Expression<Func<TObject, bool>> match,
//            params Expression<Func<TObject, object>>[] includeItems)
//        {
//            return _context.Set<TObject>().IncludeManyAsDbQuery(includeItems).Where(match).ToList();
//        }

//        public async Task<ICollection<TObject>> FindAllAsync(Expression<Func<TObject, bool>> match,
//            params Expression<Func<TObject, object>>[] includeItems)
//        {
//            return await _context.Set<TObject>().IncludeManyAsDbQuery(includeItems).Where(match).ToListAsync();
//        }

//        public TObject Create()
//        {
//            return _context.Set<TObject>().Create();
//        }

//        public void Add(TObject t)
//        {
//            _context.Entry(t).State = EntityState.Added;
//            _context.Set<TObject>().Add(t);
//        }

//        public void AddRange(IEnumerable<TObject> entities)
//        {
//            foreach (var entity in entities)
//                _context.Entry(entity).State = EntityState.Added;

//            _context.Set<TObject>().AddRange(entities);
//        }


//        public void Update(TObject t)
//        {
//            _context.Entry(t).State = EntityState.Modified;
//        }

//        public void Delete(TObject t)
//        {
//            _context.Entry(t).State = EntityState.Deleted;
//            _context.Set<TObject>().Remove(t);
//        }

//        public void DeleteRange(IEnumerable<TObject> entities)
//        {
//            foreach (var entity in entities)
//                _context.Entry(entity).State = EntityState.Deleted;

//            _context.Set<TObject>().RemoveRange(entities);
//        }

//        public int Count()
//        {
//            return _context.Set<TObject>().Count();
//        }

//        public async Task<int> CountAsync()
//        {
//            return await _context.Set<TObject>().CountAsync();
//        }

//        public int Commit()
//        {
//            try
//            {
//                return _context.SaveChanges();
//            }
//            catch (DbEntityValidationException ex)
//            {
//                foreach (var validationError in ex.EntityValidationErrors)
//                {
//                    validationError.ToString();
//                }

//                throw ex;
//            }
//        }

//        public async Task<int> CommitAsync()
//        {
//            return await _context.SaveChangesAsync();
//        }
//    }
//}