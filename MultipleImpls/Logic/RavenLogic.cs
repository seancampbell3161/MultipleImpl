using MultipleImpls.Interfaces;

namespace MultipleImpls.Logic;

public class RavenLogic : IMessageLogic
{
    public string Send(string message) => $"Message sent via Raven: {message}";
}