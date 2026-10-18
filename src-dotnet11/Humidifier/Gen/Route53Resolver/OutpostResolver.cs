namespace Humidifier.Route53Resolver
{
    using global::System.Collections.Generic;

    public class OutpostResolver : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveInstanceCount_Integer, IHaveOutpostArn, IHavePreferredInstanceType, IHaveName
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string CreationTime =  "CreationTime" ;
            public static string ModificationTime =  "ModificationTime" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string CreatorRequestId =  "CreatorRequestId" ;
            public static string StatusMessage =  "StatusMessage" ;
        }

        public override string AWSTypeName { get => AWS.Route53Resolver.OutpostResolver; }
        /// <summary>
        /// InstanceCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-outpostresolver.html#cfn-route53resolver-outpostresolver-instancecount
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? InstanceCount { get; set; }

        /// <summary>
        /// OutpostArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-outpostresolver.html#cfn-route53resolver-outpostresolver-outpostarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? OutpostArn { get; set; }

        /// <summary>
        /// PreferredInstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-outpostresolver.html#cfn-route53resolver-outpostresolver-preferredinstancetype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? PreferredInstanceType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-outpostresolver.html#cfn-route53resolver-outpostresolver-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}