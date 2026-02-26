using Microsoft.AspNetCore.Mvc;
using API_DEMO.Data;
using API_DEMO.Models;

namespace API_DEMO.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly AppDbContext _context;

    public UsersController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Create(Users users)
    {
        _context.Users.Add(users);
        await _context.SaveChangesAsync();
        return Ok(users);
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.Users.ToList());
    }
}