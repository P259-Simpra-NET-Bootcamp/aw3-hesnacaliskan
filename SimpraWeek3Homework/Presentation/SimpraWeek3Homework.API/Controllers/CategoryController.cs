using MediatR;
using Microsoft.AspNetCore.Mvc;
using SimpraWeek3Homework.Application.Features.Commands.Categories.CreateCategory;
using SimpraWeek3Homework.Application.Features.Commands.Categories.RemoveCategory;
using SimpraWeek3Homework.Application.Features.Commands.Categories.UpdateCategory;
using SimpraWeek3Homework.Application.Features.Queries.Categories.GetAllCategory;
using SimpraWeek3Homework.Application.Features.Queries.Categories.GetByIdCategory;
using SimpraWeek3Homework.Application.Repositories.Categories;
using System.Net;

namespace SimpraWeek3Homework.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        readonly private ICategoryReadRepository _categoryReadRepository;
        readonly private ICategoryWriteRepository _categoryWriteRepository;
        readonly IMediator _mediator;

        public CategoryController(ICategoryReadRepository categoryReadRepository, ICategoryWriteRepository categoryWriteRepository, IMediator mediator)
        {
            _categoryReadRepository = categoryReadRepository;
            _categoryWriteRepository = categoryWriteRepository;
            this._mediator = mediator;
        }

        [HttpGet]
        public async Task<List<GetAllCategoryQueryResponse>> Get()
        {
            return await _mediator.Send(new GetAllCategoryQueryRequest());
            
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdCategoryQueryRequest getByIdProductQueryRequest)
        {
            GetByIdCategoryQueryResponse response = await _mediator.Send(getByIdProductQueryRequest);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateCategoryCommandRequest createCategoryCommandRequest)
        {
            CreateCategoryCommandResponse response = await _mediator.Send(createCategoryCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateCategoryCommandRequest updateCategoryCommandRequest)
        {
            UpdateCategoryCommandResponse response = await _mediator.Send(updateCategoryCommandRequest);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveCategoryCommandRequest removeCategoryCommandRequest)
        {
            RemoveCategoryCommandResponse response = await _mediator.Send(removeCategoryCommandRequest);
            return Ok();
        }
    }
}
