using SimpraWeek3Homework.Application.Repositories.Products;
using SimpraWeek3Homework.Domain.Entities;
using SimpraWeek3Homework.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraWeek3Homework.Persistence.Repositories.Products
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(SimpraWeek3HomeworkDbContext context) : base(context)
        {
        }
    }
}
