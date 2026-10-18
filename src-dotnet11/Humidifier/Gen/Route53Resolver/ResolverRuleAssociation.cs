namespace Humidifier.Route53Resolver
{
    using global::System.Collections.Generic;

    public class ResolverRuleAssociation : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveVPCId, IHaveResolverRuleId, IHaveName
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
        public Union<string, BaseFunction>? VPCId { get; set; }

        /// <summary>
        /// ResolverRuleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverruleassociation.html#cfn-route53resolver-resolverruleassociation-resolverruleid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? ResolverRuleId { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}