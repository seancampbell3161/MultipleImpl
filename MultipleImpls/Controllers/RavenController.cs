using Microsoft.AspNetCore.Mvc;
using MultipleImpls.Interfaces;
using MultipleImpls.Models;

namespace MultipleImpls.Controllers;

[ApiController]
[Route("[controller]")]
public class RavenController : ControllerBase
{
    private readonly IMessageLogic _messageLogic;

    public RavenController(IMessageLogic messageLogic)
    {
        _messageLogic = messageLogic;
    }

    [HttpPost]
    public IActionResult SendRaven(string message)
    {
        return Ok(_messageLogic.Send(message));
    }
}