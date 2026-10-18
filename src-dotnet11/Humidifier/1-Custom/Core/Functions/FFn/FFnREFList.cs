using System.Collections.Generic;

namespace Humidifier;

public class FFnREFList(List<IResultFactory> results) : BaseFunction
{
    public List<IResultFactory> Results { get; set; } = results;
}