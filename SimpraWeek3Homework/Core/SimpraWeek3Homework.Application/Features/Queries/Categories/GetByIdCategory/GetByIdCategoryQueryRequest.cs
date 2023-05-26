﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraWeek3Homework.Application.Features.Queries.Categories.GetByIdCategory
{
    public class GetByIdCategoryQueryRequest :IRequest<GetByIdCategoryQueryResponse>
    {
        public int Id { get; set; }
    }
}
