using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericController<TEntity> : ControllerBase where TEntity : class
    {
        private readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;
 
        public GenericController(DbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await _dbSet.ToListAsync();
            return Ok(data);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) return NotFound();
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TEntity entity)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();

            // Получаем ключ только после сохранения
            var keyProperty = typeof(TEntity).GetProperty("Id");
            var entityId = keyProperty?.GetValue(entity);

            return CreatedAtAction(nameof(Get), new { id = entityId }, entity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] TEntity entity)
        {
            if (id != GetEntityKey(entity)) return BadRequest();
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity == null) return NotFound();
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        private int GetEntityKey(TEntity entity)
        {
            var keyProperty = typeof(TEntity).GetProperty("Id");
            return (int)(keyProperty?.GetValue(entity) ?? throw new Exception("Key 'Id' not found"));
        }
    }
}
