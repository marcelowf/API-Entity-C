using Microsoft.AspNetCore.Mvc;

namespace Trabalho
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoLavanderiaController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Lavanderia Lavanderia)
        {
            using (var _context = new TrabalhoContext())
            {
                _context.Lavanderias.Add(Lavanderia);
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<Lavanderia> Get()
        {
            using (var _context = new TrabalhoContext())
            {
                return _context.Lavanderias.ToList();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Lavanderias.FirstOrDefault(t => t.CodLavanderia == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Lavanderia Lavanderia)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Lavanderias.FirstOrDefault(t => t.CodLavanderia == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(Lavanderia);
                _context.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Lavanderias.FirstOrDefault(t => t.CodLavanderia == id);
                if(item == null)
                {
                    return; 
                }
                _context.Lavanderias.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}