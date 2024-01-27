using Microsoft.AspNetCore.Mvc;

namespace Trabalho
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConsumoLavanderiaController : Controller
    {
        [HttpPost]
        public void Post([FromBody] ConsumoLavanderia ConsumoLavanderia)
        {
            using (var _context = new TrabalhoContext())
            {
                _context.ConsumoLavanderias.Add(ConsumoLavanderia);
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<ConsumoLavanderia> Get()
        {
            using (var _context = new TrabalhoContext())
            {
                return _context.ConsumoLavanderias.ToList();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.ConsumoLavanderias.FirstOrDefault(t => t.CodConsumoLavanderia == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] ConsumoLavanderia ConsumoLavanderia)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.ConsumoLavanderias.FirstOrDefault(t => t.CodConsumoLavanderia == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(ConsumoLavanderia);
                _context.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.ConsumoLavanderias.FirstOrDefault(t => t.CodConsumoLavanderia == id);
                if(item == null)
                {
                    return; 
                }
                _context.ConsumoLavanderias.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}