using MediatR;
using SimpraWeek3Homework.Application.Repositories.Products;
using SimpraWeek3Homework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraWeek3Homework.Application.Features.Queries.Products.GetByIdProduct
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {

        readonly IProductReadRepository _productReadRepository;
        public GetByIdProductQueryHandler(IProductReadRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            Product product = await _productReadRepository.GetByIdAsync(request.Id);
            return new()
            {
                Name = product.Name,
                CategoryId = product.CategoryId,
                Url = product.Url,
                Tag = product.Tag,
                CreatedAt = product.CreatedAt,
                CreatedBy = product.CreatedBy,
                UpdatedAt = product.UpdatedAt,
                UpdatedBy = product.UpdatedBy,               
            };
        }
    }
}
