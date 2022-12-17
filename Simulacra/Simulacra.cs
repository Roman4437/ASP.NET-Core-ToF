using System.Net.Mime;
using AutoMapper;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using ToF.WebApi.DataTransferObjects;
using ToF.WebApi.Simulacra.SimulacraTables;

namespace ToF.WebApi.Controllers;

[ApiController]
[Route("/simulacra")]
[Consumes(MediaTypeNames.Application.Json)]
[Produces(MediaTypeNames.Application.Json)]
public class SimulacraController : ControllerBase
{
    private readonly DatabaseContext _context;
    private readonly IMapper _mapper;

    public SimulacraController(DatabaseContext context, IMapper mapper) => 
        (_context, _mapper) = (context, mapper);

    /// <summary>Retrieve all simulacra.</summary>
    /// <response code="200">The received simulacra.</response>
    [HttpGet]
    public async Task<IActionResult> GetAllSimulacra()
    {
        List<SimulacraEntity> simulacra = await _context.Simulacra
            .ToListAsync();

        List<GetSimulacraDTO> getDTO = _mapper.Map<List<GetSimulacraDTO>>(simulacra);

        return Ok(getDTO);
    }
    
    /// <summary>Get a simulacra by name.</summary>
    /// <param name="name">Simulacra name.</param>
    /// <response code="200">The received simulacra.</response>
    /// <response code="404">The simulacra with following name has not been found.</response>
    [HttpGet("{name}")]
    public async Task<IActionResult> GetSimulacraByName([FromRoute] string name)
    {
        SimulacraEntity simulacra = await _context.Simulacra
            .FirstOrDefaultAsync(simulacra => simulacra.Name.ToLower() == name);
        
        if (simulacra is null)
        {
            return NotFound();
        }

        GetSimulacraDTO getDTO = _mapper.Map<GetSimulacraDTO>(simulacra);

        return Ok(getDTO);
    }
    
    /// <summary>Get a simulacra weapon effects list.</summary>
    /// <param name="name">Simulacra name.</param>
    /// <response code="200">The simulacra weapon effects.</response>
    /// <response code="404">The simulacra with following name has not been found.</response>
    [HttpGet("{name}/weapon-effect")]
    public async Task<IActionResult> GetSimulacraWeaponEffects([FromRoute] string name)
    {
        SimulacraEntity simulacra = await _context.Simulacra
            .FirstOrDefaultAsync(simulacra => simulacra.Name.ToLower() == name);
        
        if (simulacra is null)
        {
            return NotFound();
        }

        List<WeaponEffect> weaponEffects = await _context.WeaponEffects
            .Where(effect => effect.SimulacraId == simulacra.SimulacraId)
            .ToListAsync();

        return Ok(weaponEffects);
    }

    /// <summary>Get a simulacra advancements list.</summary>
    /// <param name="name">Simulacra name.</param>
    /// <response code="200">The simulacra advancements.</response>
    /// <response code="404">The simulacra with following name has not been found.</response>
    [HttpGet("{name}/advancements")]
    public async Task<IActionResult> GetSimulacraAdvancements([FromRoute] string name)
    {
        SimulacraEntity simulacra = await _context.Simulacra
            .FirstOrDefaultAsync(simulacra => simulacra.Name.ToLower() == name);
        
        if (simulacra is null)
        {
            return NotFound();
        }

        List<Advancement> advancements = await _context.Advancements
            .Where(effect => effect.SimulacraId == simulacra.SimulacraId)
            .ToListAsync();

        return Ok(advancements);
    }
    
    /// <summary>Get a simulacra recomended matrices list.</summary>
    /// <param name="name">Simulacra name.</param>
    /// <response code="200">The simulacra recomended matrice list.</response>
    /// <response code="404">The simulacra with following name has not been found.</response>
    [HttpGet("{name}/recomended-matrices")]
    public async Task<IActionResult> GetSimulacraRecomendedMatrices([FromRoute] string name)
    {
        SimulacraEntity simulacra = await _context.Simulacra
            .FirstOrDefaultAsync(simulacra => simulacra.Name.ToLower() == name);
        
        if (simulacra is null)
        {
            return NotFound();
        }

        List<RecomendedMatrice> matrices = await _context.RecomendedMatrices
            .Where(effect => effect.SimulacraId == simulacra.SimulacraId)
            .ToListAsync();

        return Ok(matrices);
    }
    
    /// <summary>Get a simulacra abilities list.</summary>
    /// <param name="name">Simulacra name.</param>
    /// <response code="200">The simulacra abilities list.</response>
    /// <response code="404">The simulacra with following name has not been found.</response>
    [HttpGet("{name}/abilities")]
    public async Task<IActionResult> GetSimulacraAbilities([FromRoute] string name)
    {
        SimulacraEntity simulacra = await _context.Simulacra
            .FirstOrDefaultAsync(simulacra => simulacra.Name.ToLower() == name);
        
        if (simulacra is null)
        {
            return NotFound();
        }

        List<Ability> abilities = await _context.Abilities
            .Where(effect => effect.SimulacraId == simulacra.SimulacraId)
            .ToListAsync();

        return Ok(abilities);
    }
    
    /// <summary>Get a simulacra favorite gifts list.</summary>
    /// <param name="name">Simulacra name.</param>
    /// <response code="200">The simulacra favorite gifts.</response>
    /// <response code="404">The simulacra with following name has not been found.</response>
    [HttpGet("{name}/favorite-gifts")]
    public async Task<IActionResult> GetSimulacraFavoriteGifts([FromRoute] string name)
    {
        SimulacraEntity simulacra = await _context.Simulacra
            .FirstOrDefaultAsync(simulacra => simulacra.Name.ToLower() == name);
        
        if (simulacra is null)
        {
            return NotFound();
        }

        List<FavoriteGift> gifts = await _context.FavoriteGifts
            .Where(effect => effect.SimulacraId == simulacra.SimulacraId)
            .ToListAsync();

        return Ok(gifts);
    }
    
    /// <summary>Add a new simulacra.</summary>
    /// <param name="createDTO">Simulacra name.</param>
    /// <response code="200">The simulacra has been successfully added.</response>
    /// <response code="400">All fields are required.</response>
    [HttpPost]
    public async Task<IActionResult> CreateSimulacra([FromBody] CreateSimulacraDTO createDTO)
    {
        SimulacraEntity newSimulacra = _mapper.Map<SimulacraEntity>(createDTO);

        _context.Simulacra.Add(newSimulacra);
        await _context.SaveChangesAsync();

        ShortSimulacraDTO shortDTO = _mapper.Map<ShortSimulacraDTO>(newSimulacra);
    
        return Ok(shortDTO);
    }
    
    /// <summary>Update a simulacra by id.</summary>
    /// <param name="id">Simulacra id.</param>
    /// <param name="updateDTO">Simulacra name.</param>
    /// <response code="204">The simulacra has been successfully updated.</response>
    /// <response code="400">All fields are required.</response>
    /// <response code="404">The simulacra with matching id has not been found.</response>
    [HttpPut("{id:guid}")]
    public async Task<IActionResult> UpdateSimulacra([FromRoute] Guid id, [FromBody] UpdateSimulacraDTO updateDTO)
    {
        SimulacraEntity outdatedSimulacra = await _context.Simulacra
            .SingleOrDefaultAsync(simulacra => simulacra.SimulacraId == id);

        if (outdatedSimulacra is null)
        {
            return NotFound();
        }
        
        _mapper.Map(updateDTO, outdatedSimulacra);
        
        await _context.SaveChangesAsync();
    
        return NoContent();
    }

    /// <summary>Remove a simulacra by id.</summary>
    /// <param name="id">Simulacra id.</param>
    /// <response code="200">Successfully removed.</response>
    /// <response code="404">The simulacra with matching id has not been found.</response>
    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteSimulacra([FromRoute] Guid id)
    {
        SimulacraEntity simulacraToDelete = await _context.Simulacra
            .SingleOrDefaultAsync(simulacra => simulacra.SimulacraId == id);

        if (simulacraToDelete is null)
        {
            return NotFound();
        }

        _context.Remove(simulacraToDelete);
        await _context.SaveChangesAsync();

        ShortSimulacraDTO shortDTO = _mapper.Map<ShortSimulacraDTO>(simulacraToDelete);
        
        return Ok(shortDTO);
    }
}