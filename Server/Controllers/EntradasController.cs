using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Parcial2_Lisbeth.Server.DAL;
using Parcial2_Lisbeth.Shared.Models;

namespace Parcial2_Lisbeth.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EntradasController : ControllerBase
    {
        private readonly Contexto _context;

        public EntradasController(Contexto context)
        {
            _context = context;
        }
        public bool Existe(int EntradaId)
        {
            return (_context.Entradas?.Any(e => e.EntradaId == EntradaId)).GetValueOrDefault();
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entradas>>> Obtener()
        {
            if (_context.Entradas == null)
            {
                return NotFound();
            }
            else
            {
                return await _context.Entradas.ToListAsync();
            }
        }
        [HttpGet("{EntradaId}")]
        public async Task<ActionResult<Entradas>> ObtenerEntradas(int EntradaId)
        {
            if (_context.Entradas == null)
            {
                return NotFound();
            }

            var entrada = await _context.Entradas.FindAsync(EntradaId);

            if (entrada == null)
            {
                return NotFound();
            }
            return entrada;
        }

        [HttpPost]
        public async Task<ActionResult<Entradas>> PostEntradas(Entradas entradas)
        {
            if (!Existe(entradas.EntradaId)) {

                Productos? producto = new Productos();
                foreach (var productoConsumido in entradas.EntradasDetalle)
                {
                    producto = _context.Productos.Find(productoConsumido.ProductoId);
                    producto.Existencia -= productoConsumido.CantidadUtilizada;
                    _context.Entry(producto).State = EntityState.Modified;
                    _context.Entry(productoConsumido).State = EntityState.Added;
                }
                _context.Entradas.Add(entradas);
            }
            else
            {
                var entradaAnterior = _context.Entradas.Include(e => e.EntradasDetalle).AsNoTracking()
                .FirstOrDefault(e => e.EntradaId == entradas.EntradaId);

                Productos? producto = new Productos();
                foreach (var productoConsumido in entradaAnterior.EntradasDetalle) {

                    producto = _context.Productos.Find(productoConsumido.ProductoId);
                    producto.Existencia += productoConsumido.CantidadUtilizada;
                    _context.Entry(producto).State = EntityState.Modified;
                }

                producto = _context.Productos.Find(entradaAnterior.ProductoId);
                producto.Existencia -= entradaAnterior.CantidadProducida;
                _context.Entry(producto).State = EntityState.Modified;
                _context.Database.ExecuteSqlRaw($"Eliminar de EntradasDetalle = {entradas.EntradaId}");

                foreach (var productoConsumido in entradas.EntradasDetalle) {

                    producto = _context.Productos.Find(productoConsumido.ProductoId);
                    producto.Existencia -= productoConsumido.CantidadUtilizada;
                    _context.Entry(producto).State = EntityState.Modified;
                    _context.Entry(productoConsumido).State = EntityState.Added;
                }

                producto = _context.Productos.Find(entradas.ProductoId);
                producto.Existencia += entradas.CantidadProducida;
                _context.Entry(producto).State = EntityState.Modified;
                _context.Entradas.Update(entradas);
            }

            await _context.SaveChangesAsync();
            _context.Entry(entradas).State = EntityState.Detached;
            return Ok(entradas);
        }

        [HttpDelete("{EntradaId}")]
        public async Task<IActionResult> EliminarEntrada(int EntradaId)
        {
            if (_context.Entradas == null) {

                return NotFound();
            }

            var entrada = await _context.Entradas.FindAsync(EntradaId);

            if (entrada == null) {

                return NotFound();
            }

            Productos? producto = new Productos();

            foreach (var productoConsumido in entrada.EntradasDetalle) {

                producto = _context.Productos.Find(productoConsumido.ProductoId);
                producto.Existencia -= productoConsumido.CantidadUtilizada;
                _context.Entry(producto).State = EntityState.Modified;
            }

            producto = _context.Productos.Find(entrada.ProductoId);
            producto.Existencia -= entrada.CantidadProducida;
            _context.Entry(producto).State = EntityState.Modified;
            _context.Database.ExecuteSqlRaw($"Eliminar de EntradasDetalle = {entrada.EntradaId}");
            _context.Entradas.Remove(entrada);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
