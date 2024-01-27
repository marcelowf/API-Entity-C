using Microsoft.AspNetCore.Mvc;

namespace Trabalho
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckinController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Checkin Checkin)
        {
            using (var _context = new TrabalhoContext())
            {
                _context.Checkins.Add(Checkin);
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<Checkin> Get()
        {
            using (var _context = new TrabalhoContext())
            {
                return _context.Checkins.ToList();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Checkins.FirstOrDefault(t => t.CodCheckin == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Checkin Checkin)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Checkins.FirstOrDefault(t => t.CodCheckin == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(Checkin);
                _context.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Checkins.FirstOrDefault(t => t.CodCheckin == id);
                if(item == null)
                {
                    return; 
                }
                _context.Checkins.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}