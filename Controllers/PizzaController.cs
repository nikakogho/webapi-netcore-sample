using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace ContosoPizza.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly ILogger<PizzaController> _logger;
        private readonly PizzaService _service;

        public PizzaController(ILogger<PizzaController> logger, PizzaService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public List<Pizza> Get()
        {
            return _service.GetAll();
        }

        [HttpGet("{id:int}")]
        public Pizza Get(int id)
        {
            return _service.GetPizza(id);
        }

        [HttpPost]
        public void AddPizza(int? id, string name, int calories, decimal price) 
        {
            if(id == null) _service.AddPizza(name, calories, price);
            else _service.AddPizza(id.Value, name, calories, price);
        }

        [HttpDelete("{id:int}")]
        public void DeletePizza(int id) 
        {
            _service.DeletePizza(id);
        }

        [HttpPut("{id:int}")]
        public void UpdatePizza(int id, string name, int calories, decimal price)
        {
            _service.UpdatePizza(id, name, calories, price);
        }
    }
}