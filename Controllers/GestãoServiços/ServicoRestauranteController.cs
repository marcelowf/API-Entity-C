using Microsoft.AspNetCore.Mvc;

namespace Trabalho
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoRestauranteController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Restaurante Restaurante)
        {
            using (var _context = new TrabalhoContext())
            {
                _context.Restaurantes.Add(Restaurante);
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<Restaurante> Get()
        {
            using (var _context = new TrabalhoContext())
            {
                return _context.Restaurantes.ToList();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Restaurantes.FirstOrDefault(t => t.CodRestaurante == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Restaurante Restaurante)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Restaurantes.FirstOrDefault(t => t.CodRestaurante == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(Restaurante);
                _context.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Restaurantes.FirstOrDefault(t => t.CodRestaurante == id);
                if(item == null)
                {
                    return; 
                }
                _context.Restaurantes.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}