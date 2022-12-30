
using Application.LogicInterfaces;
using Domain;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;


namespace WebApi_.Controllers;
[ApiController]
[Route("[controller]")]
public class ChildController:ControllerBase
{
    private readonly IChildLogic ChildLogic;
    public ChildController(IChildLogic childLogic)
    {
        ChildLogic = childLogic;
       
    }

    [HttpPost, Route("Children")]
    public async Task<ActionResult> CreateAsync([FromBody] NewChildDTO newChildDto)
    {
        try
        {
            Console.WriteLine("i got to controller");
            Child child = await ChildLogic.CreateAsync(newChildDto);
            return Ok(child);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}