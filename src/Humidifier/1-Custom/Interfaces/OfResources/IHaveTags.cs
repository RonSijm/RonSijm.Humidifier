using System.Collections.Generic;

namespace Humidifier.Interfaces;

public interface IHaveTags
{
    public List<Tag> Tags { get; set; }
}