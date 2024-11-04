using MultipleImpls.Interfaces;

namespace MultipleImpls.Logic;

public class SmsLogic : IMessageLogic
{
    public string Send(string message) => $"Message sent via SMS: {message}";
}