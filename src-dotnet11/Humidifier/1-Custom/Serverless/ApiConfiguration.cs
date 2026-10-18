using System.Collections.Generic;

namespace Humidifier.Serverless.ApiTypes;

public class CorsConfiguration
{
    public Union<string, BaseFunction>? AllowMethods { get; set; }
    public Union<string, BaseFunction>? AllowHeaders { get; set; }
    public Union<string, BaseFunction>? AllowOrigin { get; set; }
    public Union<string, BaseFunction>? MaxAge { get; set; }
    public Union<bool, BaseFunction>? AllowCredentials { get; set; }
}

public class EndpointConfiguration
{
    public Union<string, BaseFunction>? IpAddressType { get; set; }
    public Union<string, BaseFunction>? Type { get; set; }
    public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? VPCEndpointIds { get; set; }
}
