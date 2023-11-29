using AutoMapper;
using eLibraryApi.Dto;
using eLibraryApi.Interfaces;
using eLibraryApi.Models;
//using eLibraryApi.Repositories;
using Microsoft.AspNetCore.Http;
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
        [HttpGet("{id:int}")]
        [ProducesResponseType(200, Type = typeof(BookDto))]
        [ProducesResponseType(404)]
        public async Task<ActionResult<BookDto>> GetBook(int id)
        {
            if (!await _bookRepository.BookExists(id))
                return NotFound(ModelState);
            var accommodationDto = _mapper.Map<BookDto>(await _bookRepository.GetBookById(id));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(accommodationDto);
        }

        [HttpGet("{name}")]
        [ProducesResponseType(200, Type = typeof(List<BookDto>))]
        public async Task<ActionResult<List<BookDto>>> GetBooks(string name)
        {
            var bookDtos = _mapper.Map<List<BookDto>>(await _bookRepository.GetBooksByName(name));

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            return Ok(bookDtos);
        }

        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> AddBook([FromBody] BookDto bookDto)
        {
            if (bookDto == null)
                return BadRequest(ModelState);

           

            

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

          
            Book book = _mapper.Map<Book>(bookDto);
            

            if (!await _bookRepository.AddBook(book))
            {
                ModelState.AddModelError("error", "Database saving error");
                return StatusCode(500, ModelState);
            }

            return Ok("Succesfully added");

        }

        
    }
}
