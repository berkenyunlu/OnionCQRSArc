using OnionArcApi.Domain.Common;

namespace OnionArcApi.Domain.Entities;

public class Brand : EntityBase
{
    public Brand()
    {

    }
    public Brand(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
}
