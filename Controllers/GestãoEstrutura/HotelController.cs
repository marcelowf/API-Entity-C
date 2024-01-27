using Microsoft.AspNetCore.Mvc;

namespace Trabalho
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : Controller
    {
        [HttpPost]
        public void Post([FromBody] Hotel Hotel)
        {
            using (var _context = new TrabalhoContext())
            {
                _context.Hoteis.Add(Hotel);
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<Hotel> Get()
        {
            using (var _context = new TrabalhoContext())
            {
                return _context.Hoteis.ToList();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Hoteis.FirstOrDefault(t => t.CodHotel == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] Hotel Hotel)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Hoteis.FirstOrDefault(t => t.CodHotel == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(Hotel);
                _context.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.Hoteis.FirstOrDefault(t => t.CodHotel == id);
                if(item == null)
                {
                    return; 
                }
                _context.Hoteis.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}