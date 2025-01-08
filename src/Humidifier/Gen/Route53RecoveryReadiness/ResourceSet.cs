namespace Humidifier.Route53RecoveryReadiness
{
    using System.Collections.Generic;
    using ResourceSetTypes;

    public class ResourceSet : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveResourceSetName
    {
        public class Attributes
        {
            public static string ResourceSetArn =  "ResourceSetArn" ;
        }

        public override string AWSTypeName { get => AWS.Route53RecoveryReadiness.ResourceSet; }

        /// <summary>
        /// ResourceSetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-resourceset.html#cfn-route53recoveryreadiness-resourceset-resourcesettype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic ResourceSetType { get; set; }
        public dynamic ResourceSetName { get => GivenName; set => GivenName = value; }

        /// <summary>
        /// Resources
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-resourceset.html#cfn-route53recoveryreadiness-resourceset-resources
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Resource
        /// </summary>
        [Required]
        public List<Humidifier.Route53RecoveryReadiness.ResourceSetTypes.Resource> Resources { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53recoveryreadiness-resourceset.html#cfn-route53recoveryreadiness-resourceset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }
    }

    namespace ResourceSetTypes
    {
        public class DNSTargetResource : Humidifier.Base.BaseSubResource, IHaveDomainName, IHaveRecordSetId
        {
            /// <summary>
            /// TargetResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-dnstargetresource.html#cfn-route53recoveryreadiness-resourceset-dnstargetresource-targetresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TargetResource
            /// </summary>
            public Humidifier.Route53RecoveryReadiness.ResourceSetTypes.TargetResource TargetResource { get; set; }
            /// <summary>
            /// RecordType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-dnstargetresource.html#cfn-route53recoveryreadiness-resourceset-dnstargetresource-recordtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordType { get; set; }
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-dnstargetresource.html#cfn-route53recoveryreadiness-resourceset-dnstargetresource-domainname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainName { get; set; }
            /// <summary>
            /// HostedZoneArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-dnstargetresource.html#cfn-route53recoveryreadiness-resourceset-dnstargetresource-hostedzonearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostedZoneArn { get; set; }
            /// <summary>
            /// RecordSetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-dnstargetresource.html#cfn-route53recoveryreadiness-resourceset-dnstargetresource-recordsetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordSetId { get; set; }
        }

        public class NLBResource : Humidifier.Base.BaseSubResource, IHaveArn
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-nlbresource.html#cfn-route53recoveryreadiness-resourceset-nlbresource-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn { get; set; }
        }

        public class R53ResourceRecord : Humidifier.Base.BaseSubResource, IHaveDomainName, IHaveRecordSetId
        {
            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-r53resourcerecord.html#cfn-route53recoveryreadiness-resourceset-r53resourcerecord-domainname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainName { get; set; }
            /// <summary>
            /// RecordSetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-r53resourcerecord.html#cfn-route53recoveryreadiness-resourceset-r53resourcerecord-recordsetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordSetId { get; set; }
        }

        public class Resource : Humidifier.Base.BaseSubResource, IHaveResourceArn, IHaveComponentId
        {
            /// <summary>
            /// ResourceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-resource.html#cfn-route53recoveryreadiness-resourceset-resource-resourcearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceArn { get; set; }
            /// <summary>
            /// DnsTargetResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-resource.html#cfn-route53recoveryreadiness-resourceset-resource-dnstargetresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DNSTargetResource
            /// </summary>
            public Humidifier.Route53RecoveryReadiness.ResourceSetTypes.DNSTargetResource DnsTargetResource { get; set; }
            /// <summary>
            /// ReadinessScopes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-resource.html#cfn-route53recoveryreadiness-resourceset-resource-readinessscopes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ReadinessScopes { get; set; }
            /// <summary>
            /// ComponentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-resource.html#cfn-route53recoveryreadiness-resourceset-resource-componentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComponentId { get; set; }
        }

        public class TargetResource : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// R53Resource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-targetresource.html#cfn-route53recoveryreadiness-resourceset-targetresource-r53resource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: R53ResourceRecord
            /// </summary>
            public Humidifier.Route53RecoveryReadiness.ResourceSetTypes.R53ResourceRecord R53Resource { get; set; }
            /// <summary>
            /// NLBResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53recoveryreadiness-resourceset-targetresource.html#cfn-route53recoveryreadiness-resourceset-targetresource-nlbresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NLBResource
            /// </summary>
            public Humidifier.Route53RecoveryReadiness.ResourceSetTypes.NLBResource NLBResource { get; set; }
        }
    }
}