using Microsoft.AspNetCore.Mvc;

namespace Trabalho
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumoFrigobarController : Controller
    {
        [HttpPost]
        public void Post([FromBody] ConsumoFrigobar ConsumoFrigobar)
        {
            using (var _context = new TrabalhoContext())
            {
                _context.ConsumoFrigobars.Add(ConsumoFrigobar);
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<ConsumoFrigobar> Get()
        {
            using (var _context = new TrabalhoContext())
            {
                return _context.ConsumoFrigobars.ToList();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.ConsumoFrigobars.FirstOrDefault(t => t.CodConsumoFrigobar == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] ConsumoFrigobar ConsumoFrigobar)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.ConsumoFrigobars.FirstOrDefault(t => t.CodConsumoFrigobar == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(ConsumoFrigobar);
                _context.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.ConsumoFrigobars.FirstOrDefault(t => t.CodConsumoFrigobar == id);
                if(item == null)
                {
                    return; 
                }
                _context.ConsumoFrigobars.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}