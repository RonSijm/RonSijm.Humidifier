using System.Collections.Generic;

namespace Humidifier;

public class FFnREFList(List<IResultFactory> results)
{
    public List<IResultFactory> Results { get; set; } = results;
}