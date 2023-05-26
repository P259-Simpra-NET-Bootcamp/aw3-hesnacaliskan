using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraWeek3Homework.Application.Features.Queries.Products.GetByIdProduct
{
    public class GetByIdProductQueryResponse
    {
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Tag { get; set; }
    }
}
