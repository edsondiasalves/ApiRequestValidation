using Microsoft.AspNetCore.Mvc;
using ApiRequestValidation.Entities;

namespace ApiRequestValidation.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    public ActionResult Post(Person person)
    {
         if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(person);
    }
}
