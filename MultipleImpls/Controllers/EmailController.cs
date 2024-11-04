using Microsoft.AspNetCore.Mvc;
using MultipleImpls.Interfaces;

namespace MultipleImpls.Controllers;

[ApiController]
[Route("[controller]")]
public class EmailController : ControllerBase
{
    private readonly IMessageLogic _messageLogic;

    public EmailController(IMessageLogic messageLogic)
    {
        _messageLogic = messageLogic;
    }
    
    [HttpPost]
    public IActionResult SendEmail(string message)
    {
        return Ok(_messageLogic.Send(message));
    }
}