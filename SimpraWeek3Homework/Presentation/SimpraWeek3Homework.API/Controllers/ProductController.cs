using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpraWeek3Homework.Application.Features.Commands.Products.CreateProduct;
using SimpraWeek3Homework.Application.Features.Commands.Products.RemoveProduct;
using SimpraWeek3Homework.Application.Features.Commands.Products.UpdateProduct;
using SimpraWeek3Homework.Application.Features.Queries.Products.GetAllProduct;
using SimpraWeek3Homework.Application.Features.Queries.Products.GetByIdProduct;
using SimpraWeek3Homework.Application.Repositories.Products;
using System.Net;

namespace SimpraWeek3Homework.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        readonly private IProductReadRepository _productReadRepository;
        readonly private IProductWriteRepository _productWriteRepository;
        readonly IMediator _mediator;

        public ProductController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IMediator mediator)
        {
            _productReadRepository = productReadRepository;
            _productWriteRepository = productWriteRepository;
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<List<GetAllProductQueryResponse>> Get()
        {
            return await _mediator.Send(new GetAllProductQueryRequest());
            
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            GetByIdProductQueryResponse response = await _mediator.Send(getByIdProductQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateProductCommandRequest createProductCommandRequest)
        {
            CreateProductCommandResponse response = await _mediator.Send(createProductCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateProductCommandRequest updateProductCommandRequest)
        {
            UpdateProductCommandResponse response = await _mediator.Send(updateProductCommandRequest);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveProductCommandRequest removeProductCommandRequest)
        {
            RemoveProductCommandResponse response = await _mediator.Send(removeProductCommandRequest);
            return Ok();
        }
    }
}
