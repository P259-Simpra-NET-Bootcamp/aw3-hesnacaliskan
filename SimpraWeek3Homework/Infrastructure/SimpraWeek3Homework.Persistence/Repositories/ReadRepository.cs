﻿using Microsoft.EntityFrameworkCore;
using SimpraWeek3Homework.Application.Repositories;
using SimpraWeek3Homework.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SimpraWeek3Homework.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : class
    {
        private readonly SimpraWeek3HomeworkDbContext _context;

        public ReadRepository(SimpraWeek3HomeworkDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll()
            => Table;
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            => Table.Where(method);
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
            => await Table.FirstOrDefaultAsync(method);
        public async Task<T> GetByIdAsync(int id)
            => await Table.FindAsync(id);



    }
}
