using Application.Logic;
using Application.LogicInterfaces;
using Domain;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace WebApi_.Controllers;

[ApiController]
[Route("[controller]")]
public class ToyController:ControllerBase
{
    private readonly IToyLogic ToyLogic;

    public ToyController(IToyLogic toyLogic)
    {
        this.ToyLogic=toyLogic;
    }
    [HttpPost, Route("Toy")]
    public async Task<ActionResult> CreateAsync([FromBody] NewToyDTO newToyDto)
    {
        try
        {
            Console.WriteLine("i got to controller");
            Toy toy = await ToyLogic.CreateAsync(newToyDto);
            return Ok(toy);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}