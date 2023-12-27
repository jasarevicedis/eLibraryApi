using AutoMapper;
using eLibraryApi.Dto;
using eLibraryApi.Interfaces;
using eLibraryApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace eLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<CategoryDtoResponse>))]
        public async Task<ActionResult<List<CategoryDtoResponse>>> GetCategories()
        {
            var categoryDtos = _mapper.Map<List<CategoryDtoResponse>>(await _categoryRepository.GetCategories());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(categoryDtos);
        }
        [HttpGet("{id:int}")]
        [ProducesResponseType(200, Type = typeof(CategoryDtoResponse))]
        [ProducesResponseType(404)]
        public async Task<ActionResult<CategoryDtoResponse>> GetCategory(int id)
        {
            if (!await _categoryRepository.CategoryExists(id))
                return NotFound(ModelState);
            var categoryDto = _mapper.Map<CategoryDtoResponse>(await _categoryRepository.GetCategoryById(id));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(categoryDto);
        }

        

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> AddCategory([FromBody] CategoryDtoRequest categoryDto)
        {
            if (categoryDto == null)
                return BadRequest(ModelState);

            if (!ModelState.IsValid)
                return BadRequest(ModelState);


            Category category = _mapper.Map<Category>(categoryDto);


            if (!await _categoryRepository.AddCategory(category))
            {
                ModelState.AddModelError("error", "Database saving error");
                return StatusCode(500, ModelState);
            }

            return Ok("Succesfully added");

        }
    }
}
