namespace Domain.DTOs;

public class NewToyDTO
{
    public int id{ get; set; }
    public string Name{ get; set; }
    public string Color{ get; set; }
    public string Condition{ get; set; }
    public bool IsFavourite{ get; set; }
    public int ownerId { get; set; }

    public NewToyDTO(int id, string Name, string Color, string Condition, bool isFavourite,int ownerId)
    {
        this.id = id;
        this.Color = Color;
        this.Condition = Condition;
        this.Name = Name;
        this.ownerId = ownerId;
        this.IsFavourite = isFavourite;
    }
}