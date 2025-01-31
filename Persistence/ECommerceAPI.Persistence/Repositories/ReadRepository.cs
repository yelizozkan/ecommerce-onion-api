﻿using ECommerceAPI.Application.Repositories;
using ECommerceAPI.Domain.Entities.Common;
using ECommerceAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly ECommerceAPIDbContext _context;
        public ReadRepository(ECommerceAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll() => Table;


        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method) => Table.Where(method);

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method) => await Table.SingleOrDefaultAsync(method);

        public async Task<T> GetByIdAsync(string id)
         => await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
    }
}
