namespace Humidifier.DevOpsAgent
{
    using global::System.Collections.Generic;
    using AssetTypes;

    public class Asset : Humidifier.Base.BaseResource, IHaveMetadata
    {
        public class Attributes
        {
            public static string Version =  "Version" ;
            public static string CreatedAt =  "CreatedAt" ;
            public static string Arn =  "Arn" ;
            public static string AssetId =  "AssetId" ;
            public static string UpdatedAt =  "UpdatedAt" ;
        }

        public override string AWSTypeName { get => AWS.DevOpsAgent.Asset; }
        /// <summary>
        /// Zip
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-asset.html#cfn-devopsagent-asset-zip
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Zip { get; set; }

        /// <summary>
        /// AssetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-asset.html#cfn-devopsagent-asset-assettype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AssetType { get; set; }
        /// <summary>
        /// Metadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-asset.html#cfn-devopsagent-asset-metadata
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Metadata { get; set; }
        /// <summary>
        /// Files
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-asset.html#cfn-devopsagent-asset-files
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssetFile
        /// </summary>
        public List<Humidifier.DevOpsAgent.AssetTypes.AssetFile> Files { get; set; }

        /// <summary>
        /// AgentSpaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-devopsagent-asset.html#cfn-devopsagent-asset-agentspaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic AgentSpaceId { get; set; }
    }

    namespace AssetTypes
    {
        public class AssetFile : Humidifier.Base.BaseSubResource, IHavePath, IHaveMetadata
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-asset-assetfile.html#cfn-devopsagent-asset-assetfile-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path { get; set; }
            /// <summary>
            /// ContentText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-asset-assetfile.html#cfn-devopsagent-asset-assetfile-contenttext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentText { get; set; }
            /// <summary>
            /// Metadata
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-asset-assetfile.html#cfn-devopsagent-asset-assetfile-metadata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Metadata { get; set; }
            /// <summary>
            /// ContentBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-devopsagent-asset-assetfile.html#cfn-devopsagent-asset-assetfile-contentbytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContentBytes { get; set; }
        }
    }
}