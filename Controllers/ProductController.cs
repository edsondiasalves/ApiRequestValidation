using Microsoft.AspNetCore.Mvc;
using ApiRequestValidation.Entities;

namespace ApiRequestValidation.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{
    public ActionResult Post(Product product)
    {
         if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(product);
    }
}
