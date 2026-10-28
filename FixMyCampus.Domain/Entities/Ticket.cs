

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
    public TicketStatus Status { get; private set; } = TicketStatus.New;
    public int? TechnicianId { get; private set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public Technician? AssignedTechnician {get; private set;}

    public void Assign(int AssignedTechnicianId)
    {
         

        if (Status != TicketStatus.New)
        {

            throw new InvalidOperationException("Ticket cannot be assigned from this status.");

        }
         if(AssignedTechnicianId <= 0)
        {
            throw new InvalidOperationException("invalid technician id ");
        }
         TechnicianId = AssignedTechnicianId;  

        Status = TicketStatus.Assigned;
      
    }
    public void StartProgress()
    {
        if(Status != TicketStatus.Assigned)
        {
            throw new InvalidOperationException("can not assign new to In progress");
        }
        Status = TicketStatus.InProgress;
    }
    public void Resolve()
    {
        if(Status != TicketStatus.InProgress)
        {
            throw new InvalidOperationException("invalid operation ");
        }
        Status = TicketStatus.Resolved;
    }
}
