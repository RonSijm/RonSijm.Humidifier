namespace Humidifier.IoTSiteWise
{
    using global::System.Collections.Generic;
    using AssetTypes;

    public class Asset : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveAssetModelId, IHaveAssetDescription, IHaveListOfIoTSiteWiseAssetTypesAssetPropertyAssetProperties, IHaveAssetExternalId, IHaveAssetName, IHaveListOfIoTSiteWiseAssetTypesAssetHierarchyAssetHierarchies, IHaveDescription
    {
        public class Attributes
        {
            public static string AssetArn =  "AssetArn" ;
            public static string AssetId =  "AssetId" ;
        }

        public override string AWSTypeName { get => AWS.IoTSiteWise.Asset; }

        /// <summary>
        /// AssetModelId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-asset.html#cfn-iotsitewise-asset-assetmodelid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public Union<string, BaseFunction>? AssetModelId { get; set; }
        /// <summary>
        /// AssetDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-asset.html#cfn-iotsitewise-asset-assetdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AssetDescription { get; set; }

        [Ignore]
        public Union<string, BaseFunction>? Description { get => AssetDescription; set => AssetDescription = value; }
        /// <summary>
        /// AssetProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-asset.html#cfn-iotsitewise-asset-assetproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssetProperty
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTSiteWise.AssetTypes.AssetProperty>, IReadOnlyList<Union<Humidifier.IoTSiteWise.AssetTypes.AssetProperty, BaseFunction>>, BaseFunction>? AssetProperties { get; set; }
        /// <summary>
        /// AssetExternalId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-asset.html#cfn-iotsitewise-asset-assetexternalid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AssetExternalId { get; set; }
        public Union<string, BaseFunction>? AssetName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-asset.html#cfn-iotsitewise-asset-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// AssetHierarchies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotsitewise-asset.html#cfn-iotsitewise-asset-assethierarchies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: AssetHierarchy
        /// </summary>
        public Union<IReadOnlyList<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy>, IReadOnlyList<Union<Humidifier.IoTSiteWise.AssetTypes.AssetHierarchy, BaseFunction>>, BaseFunction>? AssetHierarchies { get; set; }
    }

    namespace AssetTypes
    {
        public class AssetHierarchy : Humidifier.Base.BaseSubResource, IHaveLogicalId, IHaveExternalId, IHaveId, IHaveChildAssetId
        {
            /// <summary>
            /// LogicalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-asset-assethierarchy.html#cfn-iotsitewise-asset-assethierarchy-logicalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogicalId { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-asset-assethierarchy.html#cfn-iotsitewise-asset-assethierarchy-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-asset-assethierarchy.html#cfn-iotsitewise-asset-assethierarchy-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// ChildAssetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-asset-assethierarchy.html#cfn-iotsitewise-asset-assethierarchy-childassetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ChildAssetId { get; set; }
        }

        public class AssetProperty : Humidifier.Base.BaseSubResource, IHaveLogicalId, IHaveAlias, IHaveExternalId, IHaveId, IHaveUnit, IHaveNotificationState
        {
            /// <summary>
            /// LogicalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-asset-assetproperty.html#cfn-iotsitewise-asset-assetproperty-logicalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? LogicalId { get; set; }
            /// <summary>
            /// Alias
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-asset-assetproperty.html#cfn-iotsitewise-asset-assetproperty-alias
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Alias { get; set; }
            /// <summary>
            /// ExternalId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-asset-assetproperty.html#cfn-iotsitewise-asset-assetproperty-externalid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ExternalId { get; set; }
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-asset-assetproperty.html#cfn-iotsitewise-asset-assetproperty-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Id { get; set; }
            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-asset-assetproperty.html#cfn-iotsitewise-asset-assetproperty-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Unit { get; set; }
            /// <summary>
            /// NotificationState
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotsitewise-asset-assetproperty.html#cfn-iotsitewise-asset-assetproperty-notificationstate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NotificationState { get; set; }
        }
    }
}