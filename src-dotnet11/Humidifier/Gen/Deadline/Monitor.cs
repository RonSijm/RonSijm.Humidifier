namespace Humidifier.Deadline
{
    using global::System.Collections.Generic;

    public class Monitor : Humidifier.Base.BaseResource, IHaveTags, IHaveIdentityCenterInstanceArn, IHaveSubdomain, IHaveDisplayName, IHaveRoleArn, IHaveIdentityCenterRegion
    {
        public class Attributes
        {
            public static string IdentityCenterApplicationArn =  "IdentityCenterApplicationArn" ;
            public static string Arn =  "Arn" ;
            public static string MonitorId =  "MonitorId" ;
            public static string Url =  "Url" ;
        }

        public override string AWSTypeName { get => AWS.Deadline.Monitor; }

        /// <summary>
        /// IdentityCenterInstanceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-monitor.html#cfn-deadline-monitor-identitycenterinstancearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? IdentityCenterInstanceArn { get; set; }

        /// <summary>
        /// Subdomain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-monitor.html#cfn-deadline-monitor-subdomain
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? Subdomain { get; set; }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-monitor.html#cfn-deadline-monitor-displayname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? DisplayName { get; set; }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-monitor.html#cfn-deadline-monitor-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? RoleArn { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-monitor.html#cfn-deadline-monitor-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// IdentityCenterRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-deadline-monitor.html#cfn-deadline-monitor-identitycenterregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? IdentityCenterRegion { get; set; }
    }
}