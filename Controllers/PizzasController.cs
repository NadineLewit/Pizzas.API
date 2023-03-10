using Pizzas.Api.Models;
using Microsoft.AspNetCore.Mvc;
namespace Pizzas.Api.Controllers{

[ApiController]
[Route("api/[controller]")]
public class PizzasController : ControllerBase{
  
    [HttpGet]
    public IActionResult GetAll() 
    {
        return Ok(BD.ObtenerPizzas());
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id) 
    {
        return Ok(BD.ObtenerPizzas());
    }

    [HttpPost]
    public IActionResult Create(Pizza pizza) 
    {
        return Ok(BD.ObtenerPizzas());
    }
    
    [HttpPut("{id}")]
    public IActionResult Update(int id, Pizza pizza) 
    {
        return Ok(BD.ObtenerPizzas());
    }

    [HttpDelete("{id}")]
  public IActionResult DeleteById(int id) 
  {
        return Ok(BD.ObtenerPizzas());
  }



    
    }
}