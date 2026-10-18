namespace Humidifier.Outposts
{
    using global::System.Collections.Generic;

    public class Outpost : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveSiteId, IHaveDescription, IHaveAvailabilityZoneId, IHaveAvailabilityZone, IHaveSupportedHardwareType, IHaveName
    {
        public class Attributes
        {
            public static string OutpostId =  "OutpostId" ;
            public static string OwnerId =  "OwnerId" ;
            public static string SiteArn =  "SiteArn" ;
            public static string OutpostArn =  "OutpostArn" ;
            public static string LifeCycleStatus =  "LifeCycleStatus" ;
        }

        public override string AWSTypeName { get => AWS.Outposts.Outpost; }

        /// <summary>
        /// SiteId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-outpost.html#cfn-outposts-outpost-siteid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SiteId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-outpost.html#cfn-outposts-outpost-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// AvailabilityZoneId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-outpost.html#cfn-outposts-outpost-availabilityzoneid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZoneId { get; set; }
        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-outpost.html#cfn-outposts-outpost-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AvailabilityZone { get; set; }
        /// <summary>
        /// SupportedHardwareType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-outpost.html#cfn-outposts-outpost-supportedhardwaretype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SupportedHardwareType { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-outposts-outpost.html#cfn-outposts-outpost-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
    }
}