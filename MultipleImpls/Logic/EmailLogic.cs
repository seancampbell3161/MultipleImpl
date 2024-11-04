using MultipleImpls.Interfaces;

namespace MultipleImpls.Logic;

public class EmailLogic : IMessageLogic
{
    public string Send(string message) => $"Message sent via Email: {message}";
}