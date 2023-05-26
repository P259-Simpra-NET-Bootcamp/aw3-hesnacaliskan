using AutoMapper;
using SimpraWeek3Homework.Application.Features.Queries.Categories.GetAllCategory;
using SimpraWeek3Homework.Application.Features.Queries.Products.GetAllProduct;
using SimpraWeek3Homework.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraWeek3Homework.Application.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Category, GetAllCategoryQueryResponse>().ReverseMap();
            CreateMap<Product, GetAllProductQueryResponse>().ReverseMap();
                
                

        }
    }
}
