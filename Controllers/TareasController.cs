using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using todolist_api.Modelos;

namespace todolist_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TareasController : ControllerBase
    {
        private readonly TareasContext _context;

        public TareasController(TareasContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("crear")]
        
        public async Task<IActionResult>NuevaTarea(Tareas tareas)
        { //AGREGA NUEVA TAREA A LA BASE DE DATOS
            await _context.Tareas.AddAsync(tareas);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpGet]
        [Route("lista")]
        public async Task<ActionResult<IEnumerable<Tareas>>>ListaTareas()
        {
            var tareas = await _context.Tareas.ToListAsync();

            return Ok(tareas);
        }

        [HttpGet]
        [Route("ver")]
        public async Task<IActionResult> VerTarea(int id)
        {
            Tareas tarea = await _context.Tareas.FindAsync(id);

            if (tarea == null)
            {
                return NotFound();
            }
            return Ok(tarea);
        }

        [HttpPut]
        [Route("editar")]
        public async Task<IActionResult>EditarTarea(int id, Tareas tarea)
        {
            var tareaExistente = await _context.Tareas.FindAsync(id);

            tareaExistente!.titulo = tarea.titulo;
            tareaExistente.tarea = tarea.tarea;
            tareaExistente.completado = tarea.completado;

            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete]
        [Route("eliminar")]
        public async Task<IActionResult>EliminarTarea(int id)
        {
            var TareaBorrada = await _context.Tareas.FindAsync(id);

            _context.Tareas.Remove(TareaBorrada!);

            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
