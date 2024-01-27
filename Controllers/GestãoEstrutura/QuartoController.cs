using Microsoft.AspNetCore.Mvc;

namespace Trabalho
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuartoController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Quarto Quarto)
        {
            using (var _context = new TrabalhoContext())
            {
                _context.Quartos.Add(Quarto);
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<Quarto> Get()
        {
            using (var _context = new TrabalhoContext())
            {
                return _context.Quartos.ToList();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Quartos.FirstOrDefault(t => t.CodQuarto == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Quarto Quarto)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Quartos.FirstOrDefault(t => t.CodQuarto == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(Quarto);
                _context.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Quartos.FirstOrDefault(t => t.CodQuarto == id);
                if(item == null)
                {
                    return; 
                }
                _context.Quartos.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}