namespace Application.Models;

public class Game(string tittle, string description, string genre, decimal grade, DateTime creationDate)
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Tittle { get; private set; } = tittle;
    public string Description { get; private set; } = description;
    public string Genre { get; private set; } = genre;
    public decimal Grade {get; private set; } = decimal.Zero;
    public DateTime CreationDate { get; private set; } = DateTime.Today;
}