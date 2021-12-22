namespace RocketSilo.Api.Structures;

public class StructureStatusInventory
{
    public string Good { get; set; } = null!;
    public int Quantity { get; set; }
    public int TargetQuantity { get; set; }
}