using HK.PEIS.Domain;
using HK.PEIS.Domain.BaseModel;
using HK.PEIS.Infrastructure.MEF;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Linq.Expressions;

namespace HK.PEIS.Repository
{
    /// <summary>
    /// 仓储的泛型实现类
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public class EFBaseRepository<TEntity> : IRepository<TEntity> where TEntity : AggregateRoot
    {
        [Import(typeof(IEFUnitOfWork))]
        public IEFUnitOfWork UnitOfWork { get; set; }

        public EFBaseRepository()
        {
            //注册MEF
            Regisgter.regisgter().ComposeParts(this);
        }

        public virtual IQueryable<TEntity> Entities
        {
            get { return UnitOfWork.context.Set<TEntity>().AsNoTracking() as IQueryable<TEntity>; }
        }

        public virtual int Insert(TEntity entity)
        {
            UnitOfWork.RegisterNew(entity);
            return UnitOfWork.Commit();
        }

        public virtual int Insert(IEnumerable<TEntity> entities)
        {
            foreach (var obj in entities)
            {
                UnitOfWork.RegisterNew(obj);
            }
            return UnitOfWork.Commit();
        }

        public virtual int Delete(object id)
        {
            var obj = UnitOfWork.context.Set<TEntity>().Find(id);
            if (obj == null)
            {
                return 0;
            }
            UnitOfWork.RegisterDeleted(obj);
            return UnitOfWork.Commit();
        }

        public virtual int Delete(TEntity entity)
        {
            UnitOfWork.RegisterDeleted(entity);
            return UnitOfWork.Commit();
        }

        public virtual int Delete(IEnumerable<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                UnitOfWork.RegisterDeleted(entity);
            }
            return UnitOfWork.Commit();
        }

        public virtual int Update(TEntity entity)
        {
            UnitOfWork.RegisterModified(entity);
            return UnitOfWork.Commit();
        }

        public virtual TEntity GetByKey(object key)
        {
            return UnitOfWork.context.Set<TEntity>().Find(key);
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> express)
        {
            Func<TEntity, bool> lamada = express.Compile();
            return UnitOfWork.context.Set<TEntity>().Where(lamada).AsQueryable<TEntity>();
        }

        public int Delete(Expression<Func<TEntity, bool>> express)
        {
            Func<TEntity, bool> lamada = express.Compile();
            var lstEntity = UnitOfWork.context.Set<TEntity>().Where(lamada);
            foreach (var entity in lstEntity)
            {
                UnitOfWork.RegisterDeleted(entity);
            }
            return UnitOfWork.Commit();
        }
    }
}
