using MediatR;
using SimpraWeek3Homework.Application.Repositories.Categories;
using SimpraWeek3Homework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraWeek3Homework.Application.Features.Queries.Categories.GetByIdCategory
{
    public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQueryRequest, GetByIdCategoryQueryResponse>
    {

        readonly ICategoryReadRepository _categoryReadRepository;
        public GetByIdCategoryQueryHandler(ICategoryReadRepository categoryReadRepository)
        {
            _categoryReadRepository = categoryReadRepository;
        }

        public async Task<GetByIdCategoryQueryResponse> Handle(GetByIdCategoryQueryRequest request, CancellationToken cancellationToken)
        {
            Category category= await _categoryReadRepository.GetByIdAsync(request.Id);
            return new()
            {
                Name = category.Name,
                Order = category.Order,
                CreatedAt = category.CreatedAt,
                CreatedBy = category.CreatedBy,
                UpdatedAt = category.UpdatedAt,
                UpdatedBy = category.UpdatedBy,
            };
        }
    }
}
