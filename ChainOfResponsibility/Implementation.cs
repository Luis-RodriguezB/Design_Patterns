namespace ChainOfResponsibility;

/// <summary>
/// Handler Interface
/// </summary>
public interface ISupportHandler
{
    void SetNextHandler(ISupportHandler handler);
    void HandleTicket(Ticket ticket);
}

/// <summary>
/// Abstract base class for concrete handlers
/// </summary>
public abstract class SupportHandlerBase : ISupportHandler
{
    private ISupportHandler _nextHandler;

    public void SetNextHandler(ISupportHandler handler)
    {
        _nextHandler = handler;
    }

    public virtual void HandleTicket(Ticket ticket)
    {
        if (CanHandleTicket(ticket))
        {
            Handle(ticket);
        } 
        else if(_nextHandler != null)
        {
            _nextHandler.HandleTicket(ticket);
        } 
        else
        {
            Console.WriteLine("Ticket cannot be handle.");
        }
    }

    protected abstract bool CanHandleTicket(Ticket ticket);
    protected abstract void Handle(Ticket ticket);
}

/// <summary>
/// Concrete handler: Level 1 Support
/// </summary>
public class Level1SupportHandler : SupportHandlerBase
{
    protected override bool CanHandleTicket(Ticket ticket)
    {
        return ticket.Severity == Severity.Low;
    }

    protected override void Handle(Ticket ticket)
    {
        Console.WriteLine("Level 1 Support handles the ticket.");
        // Handle the ticket at Level 1 Support
    }
}

/// <summary>
/// Concrete handler: Level 2 Support
/// </summary>
public class Level2SupportHandler : SupportHandlerBase
{
    protected override bool CanHandleTicket(Ticket ticket)
    {
        return ticket.Severity == Severity.Medium;
    }

    protected override void Handle(Ticket ticket)
    {
        Console.WriteLine("Level 2 Support handles the ticket.");
        // Handle the ticket at Level 2 Support
    }
}

/// <summary>
/// Concrete handler: Level 1 Support
/// </summary>
public class Level3SupportHandler : SupportHandlerBase
{
    protected override bool CanHandleTicket(Ticket ticket)
    {
        return ticket.Severity == Severity.High;
    }

    protected override void Handle(Ticket ticket)
    {
        Console.WriteLine("Level 3 Support handles the ticket.");
        // Handle the ticket at Level 3 Support
    }
}

/// <summary>
/// Ticket Class
/// </summary>
public class Ticket
{
    public Severity Severity { get; set; }
}
/// <summary>
/// Enum representing severity levels of tickets
/// </summary>
public enum Severity
{
    Low,
    Medium,
    High
}