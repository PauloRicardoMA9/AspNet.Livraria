using ma9.Business.Interfaces.Repository;
using ma9.Business.Models;
using ma9.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ma9.Data.Repository
{
    public abstract class Repository<TEntidade> : IRepository<TEntidade> where TEntidade : Entidade, new()
    {
        protected readonly ModelsDbContext Db;
        protected readonly DbSet<TEntidade> DbSet;

        protected Repository(ModelsDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntidade>();
        }


        public virtual async Task<IEnumerable<TEntidade>> Buscar(Expression<Func<TEntidade, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }


        public virtual async Task<TEntidade> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }


        public virtual async Task<List<TEntidade>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }


        public virtual async Task Adicionar(TEntidade entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }


        public virtual async Task Atualizar(TEntidade entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }


        public virtual async Task Remover(Guid id)
        {
            DbSet.Remove(new TEntidade() { Id = id });
            await SaveChanges();
        }


        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }


        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
