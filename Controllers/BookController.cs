using AutoMapper;
using eLibraryApi.Dto;
using eLibraryApi.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace eLibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookController(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<BookDto>))]
        public async Task<ActionResult<List<BookDto>>> GetBooks()
        {
            var bookDtos = _mapper.Map<List<BookDto>>(await _bookRepository.GetBooks());

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(bookDtos);
        }
    }
}
