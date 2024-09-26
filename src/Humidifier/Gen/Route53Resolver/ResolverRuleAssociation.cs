namespace Humidifier.Route53Resolver
{
    using System.Collections.Generic;

    public class ResolverRuleAssociation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName
    {
        public class Attributes
        {
            public static string VPCId =  "VPCId" ;
            public static string ResolverRuleId =  "ResolverRuleId" ;
            public static string ResolverRuleAssociationId =  "ResolverRuleAssociationId" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName { get => AWS.Route53Resolver.ResolverRuleAssociation; }

        /// <summary>
        /// VPCId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverruleassociation.html#cfn-route53resolver-resolverruleassociation-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic VPCId { get; set; }

        /// <summary>
        /// ResolverRuleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverruleassociation.html#cfn-route53resolver-resolverruleassociation-resolverruleid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResolverRuleId { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }
}