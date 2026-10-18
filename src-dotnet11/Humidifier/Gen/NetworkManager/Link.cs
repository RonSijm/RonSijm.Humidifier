namespace Humidifier.NetworkManager
{
    using global::System.Collections.Generic;
    using LinkTypes;

    public class Link : Humidifier.Base.BaseResource, IHaveTags, IHaveSiteId, IHaveType, IHaveGlobalNetworkId, IHaveDescription, IHaveNetworkManagerLinkTypesBandwidthBandwidth, IHaveProvider
    {
        public class Attributes
        {
            public static string LinkArn =  "LinkArn" ;
            public static string State =  "State" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string LinkId =  "LinkId" ;
        }

        public override string AWSTypeName { get => AWS.NetworkManager.Link; }

        /// <summary>
        /// SiteId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-link.html#cfn-networkmanager-link-siteid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? SiteId { get; set; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-link.html#cfn-networkmanager-link-type
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Type { get; set; }

        /// <summary>
        /// GlobalNetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-link.html#cfn-networkmanager-link-globalnetworkid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? GlobalNetworkId { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-link.html#cfn-networkmanager-link-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }

        /// <summary>
        /// Bandwidth
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-link.html#cfn-networkmanager-link-bandwidth
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Bandwidth
        /// </summary>
        [Required]
        public Union<Humidifier.NetworkManager.LinkTypes.Bandwidth, BaseFunction>? Bandwidth { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-link.html#cfn-networkmanager-link-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// Provider
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-networkmanager-link.html#cfn-networkmanager-link-provider
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Provider { get; set; }
    }

    namespace LinkTypes
    {
        public class Bandwidth : Humidifier.Base.BaseSubResource, IHaveDownloadSpeed_Integer, IHaveUploadSpeed_Integer
        {
            /// <summary>
            /// DownloadSpeed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-link-bandwidth.html#cfn-networkmanager-link-bandwidth-downloadspeed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? DownloadSpeed { get; set; }
            /// <summary>
            /// UploadSpeed
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-networkmanager-link-bandwidth.html#cfn-networkmanager-link-bandwidth-uploadspeed
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? UploadSpeed { get; set; }
        }
    }
}