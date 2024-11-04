using Microsoft.AspNetCore.Mvc;
using MultipleImpls.Interfaces;

namespace MultipleImpls.Controllers;

[ApiController]
[Route("[controller]")]
public class SmsController : ControllerBase
{
    private readonly IMessageLogic _messageLogic;
    
    public SmsController(IMessageLogic messageLogic)
    {
        _messageLogic = messageLogic;
    }

    [HttpPost]
    public IActionResult SendSms(string message)
    {
        return Ok(_messageLogic.Send(message));
    }
}