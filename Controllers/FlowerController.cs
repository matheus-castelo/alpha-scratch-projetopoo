using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FFCE.Data;
using FFCE.Models;

namespace FFCE.Controllers
{
/* The `[Route("api/[controller]")]` attribute specifies the route template for the
FlowerController. In this case, it sets the base route for the controller to be
"api/flower". */
    [Route("api/[controller]")]
    [ApiController]
    public class FlowerController : ControllerBase
    {
/* The line `private readonly FloricultureDataContext _context;` in the
FlowerController class is declaring a private readonly field named `_context` of
type `FloricultureDataContext`. This field is used to hold an instance of the
`FloricultureDataContext` class, which is typically a database context class
that allows the controller to interact with the underlying database. */
        private readonly FloricultureDataContext _context;

 /* The `public FlowerController(FloricultureDataContext context)` constructor in
 the `FlowerController` class is a constructor method that takes an instance of
 `FloricultureDataContext` as a parameter and assigns it to the private readonly
 field `_context` within the class. This constructor is used to initialize the
 `_context` field with the provided database context instance when an instance
 of the `FlowerController` class is created. This allows the controller to have
 access to the database context and interact with the underlying database when
 handling requests related to flowers. */
        public FlowerController(FloricultureDataContext context)
        {
            _context = context;
        }

/// <summary>
/// This C# function creates a new flower entity in the database and returns a
/// response with the created flower's details.
/// </summary>
/// <param name="Flower">The code snippet you provided is a POST endpoint in a Web
/// API controller that is used to create a new Flower object. The Flower object is
/// received in the request body and is added to the database using Entity Framework
/// Core.</param>
/// <returns>
/// The CreateFlower method is returning an IActionResult. If the flower object is
/// null, it returns a BadRequest response. If the flower object is successfully
/// added to the database and saved, it returns a CreatedAtAction response with the
/// newly created flower object and a reference to the GetFlower method with the
/// flower's id.
/// </returns>
        // POST api/flower
/// <summary>
/// The CreateFlower function in C# receives a Flower object in the request body,
/// adds it to the database, and returns a response with the created Flower object.
/// </summary>
/// <param name="Flower">The code snippet you provided is a method in a controller
/// that handles a POST request to create a new Flower object. The method receives a
/// Flower object in the request body and adds it to the database using Entity
/// Framework Core.</param>
/// <returns>
/// The CreateFlower method is returning an IActionResult. If the flower object is
/// null, it returns a BadRequest response. If the flower object is not null, it
/// adds the flower to the database context and saves the changes asynchronously.
/// Finally, it returns a CreatedAtAction response with the newly created flower
/// object and a reference to the GetFlower method with the flower's id as a route
/// parameter.
/// </returns>
/// <summary>
/// The CreateFlower function in C# receives a Flower object in the request body,
/// adds it to the database, and returns a response with the created Flower object.
/// </summary>
/// <param name="Flower">The code snippet you provided is a method in a controller
/// that handles a POST request to create a new Flower object. The method receives a
/// Flower object in the request body and adds it to the database using Entity
/// Framework Core.</param>
/// <returns>
/// The CreateFlower method is returning an IActionResult. If the flower object is
/// null, it returns a BadRequest response. If the flower object is not null, it
/// adds the flower to the database context and saves the changes asynchronously.
/// Finally, it returns a CreatedAtAction response with the newly created flower
/// object and a reference to the GetFlower method with the flower's id as a route
/// parameter.
/// </returns>
/// <summary>
/// The CreateFlower function in C# receives a Flower object in the request body,
/// adds it to the database, and returns a response with the created Flower object.
/// </summary>
/// <param name="Flower">The code snippet you provided is a method in a controller
/// that handles a POST request to create a new Flower entity. The method receives a
/// Flower object in the request body and adds it to the database using Entity
/// Framework Core.</param>
/// <returns>
/// The method is returning an IActionResult. If the flower object is null, it
/// returns a BadRequest response. If the flower object is not null, it adds the
/// flower to the database context and saves the changes asynchronously. Finally, it
/// returns a CreatedAtAction response with the newly created flower object and a
/// link to the GetFlower action method with the flower's id as a route parameter.
/// </returns>
/// <summary>
/// The CreateFlower function in C# receives a Flower object in the request body,
/// adds it to the database, and returns a response with the created Flower object.
/// </summary>
/// <param name="Flower">The code snippet you provided is a method in a controller
/// that handles the creation of a Flower object. The method is an HTTP POST
/// endpoint that receives a Flower object in the request body.</param>
/// <returns>
/// The CreateFlower method is returning an IActionResult. If the flower object is
/// null, it returns a BadRequest response. If the flower object is not null, it
/// adds the flower to the database context and saves the changes asynchronously.
/// Finally, it returns a CreatedAtAction response with the newly created flower
/// object and a reference to the GetFlower method with the flower's id as a route
/// parameter.
/// </returns>
/// <summary>
/// The CreateFlower function in C# receives a Flower object in the request body,
/// adds it to the database, and returns a response with the created Flower object.
/// </summary>
/// <param name="Flower">The code snippet you provided is a method in a controller
/// that handles a POST request to create a new Flower object. The method receives a
/// Flower object in the request body and adds it to the database using Entity
/// Framework Core.</param>
/// <returns>
/// The method is returning an IActionResult. If the flower object is null, it
/// returns a BadRequest response. If the flower object is not null, it adds the
/// flower to the database context and saves the changes asynchronously. Finally, it
/// returns a CreatedAtAction response with the newly created flower object and a
/// link to the GetFlower action method with the flower's id as a route parameter.
/// </returns>
/// <summary>
/// The CreateFlower function in C# receives a Flower object in the request body,
/// adds it to the database, and returns a response with the created Flower object.
/// </summary>
/// <param name="Flower">The code snippet you provided is a method in a controller
/// that handles a POST request to create a new Flower entity. The method receives a
/// Flower object in the request body and adds it to the database using Entity
/// Framework Core.</param>
/// <returns>
/// The CreateFlower method is returning an IActionResult. If the flower object is
/// null, it returns a BadRequest response. If the flower object is not null, it
/// adds the flower to the database context and saves the changes asynchronously.
/// Finally, it returns a CreatedAtAction response with the newly created flower
/// object and a reference to the GetFlower method with the flower's id as a route
/// parameter.
/// </returns>
/// <summary>
/// The CreateFlower function in C# receives a Flower object in the request body,
/// adds it to the database, and returns a response with the created Flower object.
/// </summary>
/// <param name="Flower">The code snippet you provided is a method in a controller
/// that handles the creation of a Flower object. The method is an HTTP POST
/// endpoint that receives a Flower object in the request body.</param>
/// <returns>
/// The CreateFlower method is returning an IActionResult. If the flower object is
/// null, it returns a BadRequest response. If the flower object is not null, it
/// adds the flower to the database context and saves the changes asynchronously.
/// Finally, it returns a CreatedAtAction response with the newly created flower
/// object and a reference to the GetFlower method with the flower's id as a route
/// parameter.
/// </returns>
        [HttpPost]
        public async Task<IActionResult> CreateFlower([FromBody] Flower flower)
        {
            if (flower == null)
            {
                return BadRequest();
            }

            _context.Flowers.Add(flower);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetFlower), new { id = flower.Id }, flower);
        }

        // GET api/flower/1
/// <summary>
/// This C# function retrieves a Flower object by its ID from a database context and
/// returns it as an ActionResult.
/// </summary>
/// <param name="id">The `id` parameter in the `GetFlower` method is used to specify
/// the unique identifier of the flower that the user wants to retrieve from the
/// database. This method is an HTTP GET endpoint that takes an integer `id` as a
/// parameter and returns the corresponding `Flower` object from</param>
/// <returns>
/// The GetFlower method is returning an ActionResult of type Flower. If the flower
/// with the specified id is found in the database, it returns the flower object. If
/// the flower is not found (flower == null), it returns a NotFound response.
/// </returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<Flower>> GetFlower(int id)
        {
            var flower = await _context.Flowers.FindAsync(id);

            if (flower == null)
            {
                return NotFound();
            }

            return flower;
        }

        // PUT api/flower/1
/// <summary>
/// This C# function updates a Flower entity in a database using the HTTP PUT
/// method.
/// </summary>
/// <param name="id">The `id` parameter in the `UpdateFlower` method represents the
/// unique identifier of the flower that you want to update. This identifier is used
/// to locate the specific flower in the database that you wish to modify.</param>
/// <param name="Flower">The `UpdateFlower` method is a HTTP PUT method that updates
/// a Flower entity in the database. The method takes two parameters:</param>
/// <returns>
/// The UpdateFlower method is returning an IActionResult. If the flower Id does not
/// match the id parameter, it will return a BadRequest result. If the flower is
/// successfully updated in the database, it will return a NoContent result.
/// </returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateFlower(int id, [FromBody] Flower flower)
        {
            if (id != flower.Id)
            {
                return BadRequest();
            }

            _context.Entry(flower).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/flower/1
/// <summary>
/// This C# function deletes a flower entity from the database by its ID.
/// </summary>
/// <param name="id">The `id` parameter in the `DeleteFlower` method represents the
/// unique identifier of the flower that is being deleted from the database. This
/// identifier is used to locate the specific flower record in the database so that
/// it can be removed.</param>
/// <returns>
/// NoContent()
/// </returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFlower(int id)
        {
            var flower = await _context.Flowers.FindAsync(id);
            if (flower == null)
            {
                return NotFound();
            }

            _context.Flowers.Remove(flower);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
