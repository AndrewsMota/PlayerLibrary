namespace Domain.Models;

public sealed record Game
{
    public Guid Id { get; } = Guid.NewGuid();
    public required string Tittle { get; init; }
    public string? Description { get; init; }
    public required string Genre { get; init; }
    public decimal Grade { get; init; }
    public DateTime CreationDate { get; private set; } = DateTime.Now;
}