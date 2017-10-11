using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace Domain.Services.Database
{
    public interface IDatabaseService<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        //Task<TEntity> CreateAsync(TEntity entity);
        void Delete(TEntity entity);
        void Delete(int id);
        void Update(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        TEntity FindById(int id);
    }


    /// <summary>
    /// For use *ONLY* by other Services in the Domain.Services Assembly...
    /// Currently in abeyance. Next Stage requires production style unit testing.
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class DatabaseService<TEntity> : IDatabaseService<TEntity> where TEntity : class
    {
        private ApplicationContext _context;
        private DbSet<TEntity> _entities;

        public DatabaseService(ApplicationContext context)
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public void Create(TEntity entity)
        {
            if(entity == null)
            {
                throw new ArgumentNullException("In DatabaseService => void Create(TEntity entity)");
            }
            _entities.Add(entity);
            _context.SaveChangesAsync();            
        }

        /// <summary>
        /// In abeyance 
        /// </summary>
        /// <param name="entity"></param>
        //public Task<TEntity> CreateAsync(TEntity entity)
        //{
        //    if (entity == null)
        //    {
        //        throw new ArgumentNullException("In DatabaseService => void CreateAsync(TEntity entity)");
        //    }
        //    _entities.AddAsync(entity);
        //    _context.SaveChangesAsync();
        //    // Return entity from dbase here
        //    return _entities.
        //}

        /// Add object attach logic
        public void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("In DatabaseService => void Delete(TEntity entity)");
            }
            _context.Remove(entity);
            _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException("In DatabaseService => void Delete(int id)");
        }

        public TEntity FindById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("In DatabaseService => void Update(TEntity entity)");
            }
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChangesAsync();
        }

        public Task<TEntity> UpdateAsync(TEntity entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
