namespace Humidifier.Route53Resolver
{
    using System.Collections.Generic;

    public class ResolverConfig : Humidifier.Base.BaseResource, IHaveResourceId
    {
        public class Attributes
        {
            public static string OwnerId =  "OwnerId" ;
            public static string AutodefinedReverse =  "AutodefinedReverse" ;
            public static string Id =  "Id" ;
        }

        public override string AWSTypeName { get => AWS.Route53Resolver.ResolverConfig; }

        /// <summary>
        /// ResourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverconfig.html#cfn-route53resolver-resolverconfig-resourceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceId { get; set; }

        /// <summary>
        /// AutodefinedReverseFlag
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverconfig.html#cfn-route53resolver-resolverconfig-autodefinedreverseflag
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AutodefinedReverseFlag { get; set; }
    }
}