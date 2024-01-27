using Microsoft.AspNetCore.Mvc;

namespace Trabalho
{
    [Route("api/[controller]")]
    [ApiController]
    public class CheckOutController : Controller
    {
        [HttpPost]
        public void Post([FromBody] CheckOut CheckOut)
        {
            using (var _context = new TrabalhoContext())
            {
                _context.CheckOuts.Add(CheckOut);
                _context.SaveChanges();
            }
        }

        [HttpGet]
        public List<CheckOut> Get()
        {
            using (var _context = new TrabalhoContext())
            {
                return _context.CheckOuts.ToList();
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.CheckOuts.FirstOrDefault(t => t.CodCheckOut == id);
                if(item == null)
                {
                    return NotFound();
                }
                return new ObjectResult(item);
            }
        }

        [HttpPut("{id}")]
        public void Put(int id,[FromBody] CheckOut CheckOut)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.CheckOuts.FirstOrDefault(t => t.CodCheckOut == id);
                if(item == null)
                {
                    return; 
                }
                _context.Entry(item).CurrentValues.SetValues(CheckOut);
                _context.SaveChanges();
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            using (var _context = new TrabalhoContext())
            {
                var item = _context.CheckOuts.FirstOrDefault(t => t.CodCheckOut == id);
                if(item == null)
                {
                    return; 
                }
                _context.CheckOuts.Remove(item);
                _context.SaveChanges();
            }
        }
    }
}