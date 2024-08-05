using System.Collections.Generic;

namespace Humidifier.Interfaces;

public interface IHaveTags : IResourceInterface
{
    public List<Tag> Tags { get; set; }
}