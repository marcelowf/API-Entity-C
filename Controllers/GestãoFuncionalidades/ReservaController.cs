using Microsoft.AspNetCore.Mvc;

namespace Trabalho
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Reserva Reserva)
        {
            using (var _context = new TrabalhoContext())
            {
                _context.Reservas.Add(Reserva);
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<Reserva> Get()
        {
            using (var _context = new TrabalhoContext())
            {
                return _context.Reservas.ToList();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Reservas.FirstOrDefault(t => t.CodReserva == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Reserva Reserva)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Reservas.FirstOrDefault(t => t.CodReserva == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(Reserva);
                _context.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Reservas.FirstOrDefault(t => t.CodReserva == id);
                if(item == null)
                {
                    return; 
                }
                _context.Reservas.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}