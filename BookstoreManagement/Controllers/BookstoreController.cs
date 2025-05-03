using BookstoreManagement.Communication.Requests;
using BookstoreManagement.Communication.Responses;
using Microsoft.AspNetCore.Mvc;
using ProductClientHub.Communication.Responses;

namespace BookstoreManagement.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BookstoreController : ControllerBase
{
    private static readonly List<ResponseBooksJson> Books = new();

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(Books);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(ResponseBooksJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorMessageJson), StatusCodes.Status404NotFound)]
    public IActionResult GetById(Guid id)
    {
        var book = Books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            return NotFound(new ResponseErrorMessageJson("Livro não encontrado."));
        }

        return Ok(book);
    }

    [HttpPost]
    [ProducesResponseType(typeof(ResponseBooksJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorMessageJson), StatusCodes.Status400BadRequest)]
    public IActionResult Post([FromBody] RequestBooksJson value)
    {
        if (string.IsNullOrWhiteSpace(value.Title) || string.IsNullOrWhiteSpace(value.Author))
        {
            return BadRequest(new ResponseErrorMessageJson("Título e autor são obrigatórios."));
        }

        var newBook = new ResponseBooksJson
        {
            Id = Guid.NewGuid(),
            Title = value.Title,
            Author = value.Author,
            Price = value.Price,
            Stock = value.Stock
        };

        Books.Add(newBook);

        return CreatedAtAction(nameof(GetById), new { id = newBook.Id }, newBook);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorMessageJson), StatusCodes.Status404NotFound)]
    public IActionResult Put(Guid id, [FromBody] RequestBooksJson value)
    {
        var book = Books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            return NotFound(new ResponseErrorMessageJson("Livro não encontrado."));
        }

        book.Title = value.Title;
        book.Author = value.Author;
        book.Price = value.Price;
        book.Stock = value.Stock;

        return Ok(book);
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorMessageJson), StatusCodes.Status404NotFound)]
    public IActionResult Delete(Guid id)
    {
        var book = Books.FirstOrDefault(b => b.Id == id);
        if (book == null)
        {
            return NotFound(new ResponseErrorMessageJson("Livro não encontrado."));
        }

        Books.Remove(book);
        return Ok(new { Message = "Livro removido com sucesso." });
    }
}