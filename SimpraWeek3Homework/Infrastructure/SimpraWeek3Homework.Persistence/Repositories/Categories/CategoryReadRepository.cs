using SimpraWeek3Homework.Application.Repositories.Categories;
using SimpraWeek3Homework.Domain.Entities;
using SimpraWeek3Homework.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraWeek3Homework.Persistence.Repositories.Categories
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(SimpraWeek3HomeworkDbContext context) : base(context)
        {
        }
    }
}
