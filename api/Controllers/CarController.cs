using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using api.Entities;

namespace api.Controllers;

[ApiController]
[Route("[controller]")]
public class CarController : ControllerBase
{
    private readonly ICarService _carService;
    private readonly IMapper _mapper;


    public CarController(ICarService carService, IMapper mapper)
    {
        _mapper = mapper;
        _carService = carService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CarEntity>>> GetAllCars()
    {
        var cars = await _carService.GetAll();

        if (cars == null || !cars.Any())
        {
            return NoContent();
        }

        var result = _mapper.Map<IEnumerable<CarEntity>>(cars);
        return Ok(result);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<IEnumerable<CarEntity>>> Get(int id)
    {
        var cars = await _carService.Get(id);

        if (cars == null || !cars.Any())
        {
            return NotFound();
        }

        return Ok(cars);
    }

    [HttpPost]
    public async Task<IActionResult> Register(CarEntity car)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = await _carService.Register(car);

            if (result)
            {
                return Ok(true);
            }
            else
            {
                return StatusCode(500, "Error interno"); 
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Error interno: " + ex.Message);
        }
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            var result = await _carService.Delete(id);

            if (result)
            {
                return Ok(true);
            }
            else
            {
                return StatusCode(500, "Error interno");
            }
        }
        catch (Exception)
        {
            throw new Exception("Ha ocurrido un error");
        }
    }

    [HttpPatch]
    public async Task<IActionResult> Edit(CarEntity car)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            var result = await _carService.Edit(car);

            if (result)
            {
                return Ok(true);
            }
            else
            {
                return StatusCode(500, "Error interno");
            }
        }
        catch (Exception ex)
        {
            return StatusCode(500, "Error interno: " + ex.Message);
        }
    }


}
