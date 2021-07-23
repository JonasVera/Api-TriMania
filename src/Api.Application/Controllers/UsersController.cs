using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Api.Domain.Interfaces.Services.User;
using System;

namespace Api.Application.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public async Task<ActionResult> GetAll([FromServices] IUserService service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try{
                return Ok(await service.GetAll());
            } catch (ArgumentException e){
                return StatusCode((int) System.Net.HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
