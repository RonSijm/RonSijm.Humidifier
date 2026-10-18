using System.Collections.Generic;

namespace Humidifier;

public class FFNamedList(List<IResultFactory> results) : BaseFunction
{
    public List<IResultFactory> Results { get; set; } = results;
}