using System;

namespace Humidifier;

/// <summary>
/// The intrinsic function Fn::FindInMap returns the value corresponding to keys in a two-level map that is declared in the Mappings section.
/// 
/// Example:
/// 
/// { "Fn::FindInMap" : [ "RegionMap", { "Ref" : "AWS::Region" }, "32"]}
/// 
/// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/intrinsic-function-reference-findinmap.html#w2ab2c21c28c22c11
/// </summary>
public class FnFindInMap : BaseFunction
{
    public string MapName { get; }
    public dynamic TopLevelKey { get; }
    public dynamic SecondLevelKey { get; }

    public FnFindInMap(string mapName, dynamic topLevelKey, dynamic secondLevelKey)
    {
        MapName = mapName ?? throw new ArgumentNullException(nameof(mapName));

        if (topLevelKey == null)
        {
            throw new ArgumentNullException(nameof(topLevelKey));
        }

        if (secondLevelKey == null)
        {
            throw new ArgumentNullException(nameof(secondLevelKey));
        }

        TopLevelKey = topLevelKey;
        SecondLevelKey = secondLevelKey;
    }
}