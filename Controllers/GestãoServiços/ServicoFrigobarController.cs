using Microsoft.AspNetCore.Mvc;

namespace Trabalho
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoFrigobarController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Frigobar Frigobar)
        {
            using (var _context = new TrabalhoContext())
            {
                _context.Frigobars.Add(Frigobar);
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<Frigobar> Get()
        {
            using (var _context = new TrabalhoContext())
            {
                return _context.Frigobars.ToList();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Frigobars.FirstOrDefault(t => t.CodFrigobar == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Frigobar Frigobar)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Frigobars.FirstOrDefault(t => t.CodFrigobar == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(Frigobar);
                _context.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Frigobars.FirstOrDefault(t => t.CodFrigobar == id);
                if(item == null)
                {
                    return; 
                }
                _context.Frigobars.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}