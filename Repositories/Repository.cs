using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using dotapi.Models.Repositories;
using Microsoft.EntityFrameworkCore;

namespace dotapi.Repositories
{
	public interface IRepository<T>
		where T : class, IRow
	{
		IQueryable<T> Where(Expression<Func<T, bool>> query);
		void Delete(string Id);
		T Get(string Id);
		T Update(string Id, T model);
		T Create(T model);
	}
	
	public class Repository<T> : IRepository<T>
		where T : class, IRow
	{
		private DatabaseContext Context;
		public Repository(DatabaseContext context)
		{
			this.Context = context;
		}
		
		public IQueryable<T> Where(Expression<Func<T, bool>> query)
		{
			return Context.Set<T>().AsNoTracking().Where(query);
		}
		
		public IQueryable<TResult> Select<TResult>(Expression<Func<T, TResult>> query)
		{
			return Context.Set<T>().AsNoTracking().Select(query);
		}
		
		public T Get(string Id)
		{
			return Where(x=>x.Id == Id).FirstOrDefault();
		}
		
		public T Create(T model)
		{
			var item = Context.Set<T>().Add(model).Entity;
			Context.SaveChanges();
			return item;
		}
		
		public T Update(string Id, T model)
		{
			var table = Context.Set<T>();
			var item = table.FirstOrDefault(x=>x.Id == Id);
			if(item == null)
			{
				throw new KeyNotFoundException($"Could not find {Id}");
			}
			item = model;
			Context.Entry(item).State = EntityState.Modified;
			Context.SaveChanges();
			return Get(Id);
		}
		
		public void Delete(string Id)
		{
			var table = Context.Set<T>();
			var item = table.FirstOrDefault(x=>x.Id == Id);
			table.Remove(item);
			Context.SaveChanges();
		}
	}
}