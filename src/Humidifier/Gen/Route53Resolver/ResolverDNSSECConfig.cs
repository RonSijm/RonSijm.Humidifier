namespace Humidifier.Route53Resolver
{
    using System.Collections.Generic;

    public class ResolverDNSSECConfig : Humidifier.Base.BaseResource, IHaveResourceId
    {
        public class Attributes
        {
            public static string ValidationStatus =  "ValidationStatus" ;
            public static string OwnerId =  "OwnerId" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.Route53Resolver.ResolverDNSSECConfig; }
        /// <summary>
        /// ResourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverdnssecconfig.html#cfn-route53resolver-resolverdnssecconfig-resourceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceId { get; set; }
    }
}