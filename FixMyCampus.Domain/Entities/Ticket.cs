using System.Collections;
using FixMyCampus.Domain.Enums;


namespace FixMyCampus.Domain.Entities;

public class Ticket
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Building { get; set; } = string.Empty;
    public string Room { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public TicketStatus Status { get;  private set; } = TicketStatus.New;
    public int? TechnicianId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public void Assign()
    {
        if (Status != TicketStatus.New)
        {
            throw new InvalidOperationException("Ticket cannot be assigned from this status.");
        }
        else 
        {
            Status = TicketStatus.Assigned;
        }


    }
}
