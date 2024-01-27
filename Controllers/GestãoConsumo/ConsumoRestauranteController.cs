using Microsoft.AspNetCore.Mvc;

namespace Trabalho
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumoRestauranteController : Controller
    {
        [HttpPost]
        public void Post([FromBody] ConsumoRestaurante ConsumoRestaurante)
        {
            using (var _context = new TrabalhoContext())
            {
                _context.ConsumoRestaurantes.Add(ConsumoRestaurante);
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<ConsumoRestaurante> Get()
        {
            using (var _context = new TrabalhoContext())
            {
                return _context.ConsumoRestaurantes.ToList();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.ConsumoRestaurantes.FirstOrDefault(t => t.CodConsumoRestaurante == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] ConsumoRestaurante ConsumoRestaurante)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.ConsumoRestaurantes.FirstOrDefault(t => t.CodConsumoRestaurante == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(ConsumoRestaurante);
                _context.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.ConsumoRestaurantes.FirstOrDefault(t => t.CodConsumoRestaurante == id);
                if(item == null)
                {
                    return; 
                }
                _context.ConsumoRestaurantes.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}