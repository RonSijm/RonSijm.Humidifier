using System.Collections.Generic;

namespace Humidifier;

public class FFNamedList(List<IResultFactory> results)
{
    public List<IResultFactory> Results { get; set; } = results;
}