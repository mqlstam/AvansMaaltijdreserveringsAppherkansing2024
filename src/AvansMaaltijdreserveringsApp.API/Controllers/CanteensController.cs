using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using AvansMaaltijdreserveringsApp.Domain.Interfaces;
using AvansMaaltijdreserveringsApp.Domain.Models;

namespace AvansMaaltijdreserveringsApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CanteensController : ControllerBase
    {
        private readonly ICanteenRepository _canteenRepository;

        public CanteensController(ICanteenRepository canteenRepository)
        {
            _canteenRepository = canteenRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Canteen>>> GetCanteens()
        {
            var canteens = await _canteenRepository.GetAllCanteensAsync();
            return Ok(canteens);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Canteen>> GetCanteen(int id)
        {
            var canteen = await _canteenRepository.GetCanteenByIdAsync(id);
            if (canteen == null)
            {
                return NotFound();
            }
            return Ok(canteen);
        }

        [HttpPost]
        public async Task<ActionResult<Canteen>> CreateCanteen(Canteen canteen)
        {
            await _canteenRepository.AddCanteenAsync(canteen);
            return CreatedAtAction(nameof(GetCanteen), new { id = canteen.Id }, canteen);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCanteen(int id, Canteen canteen)
        {
            if (id != canteen.Id)
            {
                return BadRequest();
            }
            await _canteenRepository.UpdateCanteenAsync(canteen);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCanteen(int id)
        {
            await _canteenRepository.DeleteCanteenAsync(id);
            return NoContent();
        }
    }
}