namespace Artela.Client.Models;

public enum DesignType
{
    Fantesi,
    PhotoReal,
    Face
}

public class CatgoryItemModel
{
    public string? Image { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DesignType Design { get; set; }
    public List<ImageItemModel> Images { get; } = new();
}


public class ImageItemModel
{
    public string? Image { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}

