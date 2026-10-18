namespace Humidifier.OpenSearchServerless
{
    using global::System.Collections.Generic;
    using CollectionTypes;

    public class Collection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveType, IHaveDescription, IHaveStandbyReplicas, IHaveDeletionProtection, IHaveCollectionGroupName, IHaveOpenSearchServerlessCollectionTypesEncryptionConfigEncryptionConfig, IHaveName, IHaveOpenSearchServerlessCollectionTypesVectorOptionsVectorOptions
    {
        public class Attributes
        {
            public static string FipsEndpoints =  "FipsEndpoints" ;
            public static string KmsKeyArn =  "KmsKeyArn" ;
            public static string CollectionEndpoint =  "CollectionEndpoint" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string DashboardEndpoint =  "DashboardEndpoint" ;
        }

        public override string AWSTypeName { get => AWS.OpenSearchServerless.Collection; }
        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-type
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// StandbyReplicas
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-standbyreplicas
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? StandbyReplicas { get; set; }
        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DeletionProtection { get; set; }
        /// <summary>
        /// CollectionGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-collectiongroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? CollectionGroupName { get; set; }
        /// <summary>
        /// EncryptionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-encryptionconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfig
        /// </summary>
        public Union<Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig, BaseFunction>? EncryptionConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        public Union<string, BaseFunction>? Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// VectorOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-vectoroptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VectorOptions
        /// </summary>
        public Union<Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions, BaseFunction>? VectorOptions { get; set; }
    }

    namespace CollectionTypes
    {
        public class EncryptionConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn, IHaveAWSOwnedKey_Boolean
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collection-encryptionconfig.html#cfn-opensearchserverless-collection-encryptionconfig-kmskeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
            /// <summary>
            /// AWSOwnedKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collection-encryptionconfig.html#cfn-opensearchserverless-collection-encryptionconfig-awsownedkey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public Union<bool, BaseFunction>? AWSOwnedKey { get; set; }
        }

        public class FipsEndpoints : Humidifier.Base.BaseSubResource, IHaveCollectionEndpoint, IHaveDashboardEndpoint
        {
            /// <summary>
            /// CollectionEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collection-fipsendpoints.html#cfn-opensearchserverless-collection-fipsendpoints-collectionendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CollectionEndpoint { get; set; }
            /// <summary>
            /// DashboardEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collection-fipsendpoints.html#cfn-opensearchserverless-collection-fipsendpoints-dashboardendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DashboardEndpoint { get; set; }
        }

        public class VectorOptions : Humidifier.Base.BaseSubResource, IHaveServerlessVectorAcceleration
        {
            /// <summary>
            /// ServerlessVectorAcceleration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collection-vectoroptions.html#cfn-opensearchserverless-collection-vectoroptions-serverlessvectoracceleration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? ServerlessVectorAcceleration { get; set; }
        }
    }
}