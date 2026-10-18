namespace Humidifier.DataSync
{
    using global::System.Collections.Generic;
    using LocationNFSTypes;

    public class LocationNFS : Humidifier.Base.BaseResource, IHaveTags, IHaveSubdirectory, IHaveServerHostname, IHaveDataSyncLocationNFSTypesMountOptionsMountOptions, IHaveDataSyncLocationNFSTypesOnPremConfigOnPremConfig
    {
        public class Attributes
        {
            public static string LocationUri =  "LocationUri" ;
            public static string LocationArn =  "LocationArn" ;
        }

        public override string AWSTypeName { get => AWS.DataSync.LocationNFS; }
        /// <summary>
        /// Subdirectory
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationnfs.html#cfn-datasync-locationnfs-subdirectory
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Subdirectory { get; set; }
        /// <summary>
        /// ServerHostname
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationnfs.html#cfn-datasync-locationnfs-serverhostname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? ServerHostname { get; set; }
        /// <summary>
        /// MountOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationnfs.html#cfn-datasync-locationnfs-mountoptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MountOptions
        /// </summary>
        public Union<Humidifier.DataSync.LocationNFSTypes.MountOptions, BaseFunction>? MountOptions { get; set; }

        /// <summary>
        /// OnPremConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationnfs.html#cfn-datasync-locationnfs-onpremconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: OnPremConfig
        /// </summary>
        [Required]
        public Union<Humidifier.DataSync.LocationNFSTypes.OnPremConfig, BaseFunction>? OnPremConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-datasync-locationnfs.html#cfn-datasync-locationnfs-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
    }

    namespace LocationNFSTypes
    {
        public class MountOptions : Humidifier.Base.BaseSubResource, IHaveVersion
        {
            /// <summary>
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationnfs-mountoptions.html#cfn-datasync-locationnfs-mountoptions-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Version { get; set; }
        }

        public class OnPremConfig : Humidifier.Base.BaseSubResource, IHaveStringListOfAgentArns
        {
            /// <summary>
            /// AgentArns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-datasync-locationnfs-onpremconfig.html#cfn-datasync-locationnfs-onpremconfig-agentarns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? AgentArns { get; set; }
        }
    }
}