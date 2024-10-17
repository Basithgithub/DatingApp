using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API;

[ApiController]
[Route("api/[controller]")]
public class UsersController(DataContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers(){

        var Users = await context.Users.ToListAsync();

        return Ok(Users);
    }

        [HttpGet("{id:int}")]
    public async Task<ActionResult<IEnumerable<AppUser>>> GetUsersById(int id){

        var Users = await context.Users.FindAsync(id);

        if(Users == null) return NotFound();

        return Ok(Users);
    }
}