using Artela.Client.Models;

namespace Artela.Client.Services;

public class GalleryContext
{
    public List<CatgoryItemModel> Catgories = new()
    {
        new()
        {
            Name = "دیوار کوب"
        },
        new()
        {
            Name = "گردن بند"
        }
    };
}