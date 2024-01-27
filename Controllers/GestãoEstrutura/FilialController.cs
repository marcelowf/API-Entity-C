using Microsoft.AspNetCore.Mvc;

namespace Trabalho
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilialController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Filial Filial)
        {
            using (var _context = new TrabalhoContext())
            {
                _context.Filiais.Add(Filial);
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<Filial> Get()
        {
            using (var _context = new TrabalhoContext())
            {
                return _context.Filiais.ToList();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Filiais.FirstOrDefault(t => t.CodFilial == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Filial Filial)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Filiais.FirstOrDefault(t => t.CodFilial == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(Filial);
                _context.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Filiais.FirstOrDefault(t => t.CodFilial == id);
                if(item == null)
                {
                    return; 
                }
                _context.Filiais.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}