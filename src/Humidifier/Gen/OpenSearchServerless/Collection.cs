namespace Humidifier.OpenSearchServerless
{
    using global::System.Collections.Generic;
    using CollectionTypes;

    public class Collection : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveType, IHaveDeletionProtection
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
        public dynamic Type { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }
        /// <summary>
        /// StandbyReplicas
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-standbyreplicas
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StandbyReplicas { get; set; }
        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DeletionProtection { get; set; }
        /// <summary>
        /// CollectionGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-collectiongroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CollectionGroupName { get; set; }
        /// <summary>
        /// EncryptionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-encryptionconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EncryptionConfig
        /// </summary>
        public Humidifier.OpenSearchServerless.CollectionTypes.EncryptionConfig EncryptionConfig { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// VectorOptions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opensearchserverless-collection.html#cfn-opensearchserverless-collection-vectoroptions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VectorOptions
        /// </summary>
        public Humidifier.OpenSearchServerless.CollectionTypes.VectorOptions VectorOptions { get; set; }
    }

    namespace CollectionTypes
    {
        public class EncryptionConfig : Humidifier.Base.BaseSubResource, IHaveKmsKeyArn
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collection-encryptionconfig.html#cfn-opensearchserverless-collection-encryptionconfig-kmskeyarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn { get; set; }
            /// <summary>
            /// AWSOwnedKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collection-encryptionconfig.html#cfn-opensearchserverless-collection-encryptionconfig-awsownedkey
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic AWSOwnedKey { get; set; }
        }

        public class FipsEndpoints : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// CollectionEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collection-fipsendpoints.html#cfn-opensearchserverless-collection-fipsendpoints-collectionendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CollectionEndpoint { get; set; }
            /// <summary>
            /// DashboardEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collection-fipsendpoints.html#cfn-opensearchserverless-collection-fipsendpoints-dashboardendpoint
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DashboardEndpoint { get; set; }
        }

        public class VectorOptions : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ServerlessVectorAcceleration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-opensearchserverless-collection-vectoroptions.html#cfn-opensearchserverless-collection-vectoroptions-serverlessvectoracceleration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServerlessVectorAcceleration { get; set; }
        }
    }
}