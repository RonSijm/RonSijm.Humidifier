namespace Humidifier.DSQL
{
    using global::System.Collections.Generic;
    using ClusterTypes;

    public class Cluster : Humidifier.Base.BaseResource, IHaveTags, IHavePolicyDocument, IHaveKmsEncryptionKey, IHaveDeletionProtectionEnabled_Boolean, IHaveDSQLClusterTypesMultiRegionPropertiesMultiRegionProperties
    {
        public class Attributes
        {
            public static string Status =  "Status" ;
            public static string PolicyVersion =  "PolicyVersion" ;
            public static string ResourceArn =  "ResourceArn" ;
            public static string Identifier =  "Identifier" ;
            public static string VpcEndpointServiceName =  "VpcEndpointServiceName" ;
            public static string VpcEndpoint =  "VpcEndpoint" ;
            public static string Endpoint =  "Endpoint" ;
            public static string EncryptionDetails =  "EncryptionDetails" ;
            public static string CreationTime =  "CreationTime" ;
        }

        public override string AWSTypeName { get => AWS.DSQL.Cluster; }
        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dsql-cluster.html#cfn-dsql-cluster-policydocument
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? PolicyDocument { get; set; }
        /// <summary>
        /// KmsEncryptionKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dsql-cluster.html#cfn-dsql-cluster-kmsencryptionkey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsEncryptionKey { get; set; }
        /// <summary>
        /// DeletionProtectionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dsql-cluster.html#cfn-dsql-cluster-deletionprotectionenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? DeletionProtectionEnabled { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dsql-cluster.html#cfn-dsql-cluster-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// MultiRegionProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dsql-cluster.html#cfn-dsql-cluster-multiregionproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MultiRegionProperties
        /// </summary>
        public Union<Humidifier.DSQL.ClusterTypes.MultiRegionProperties, BaseFunction>? MultiRegionProperties { get; set; }
    }

    namespace ClusterTypes
    {
        public class EncryptionDetails : Humidifier.Base.BaseSubResource, IHaveEncryptionType, IHaveEncryptionStatus, IHaveKmsKeyArn
        {
            /// <summary>
            /// EncryptionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dsql-cluster-encryptiondetails.html#cfn-dsql-cluster-encryptiondetails-encryptiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionType { get; set; }
            /// <summary>
            /// EncryptionStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dsql-cluster-encryptiondetails.html#cfn-dsql-cluster-encryptiondetails-encryptionstatus
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? EncryptionStatus { get; set; }
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dsql-cluster-encryptiondetails.html#cfn-dsql-cluster-encryptiondetails-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyArn { get; set; }
        }

        public class MultiRegionProperties : Humidifier.Base.BaseSubResource, IHaveStringListOfClusters, IHaveWitnessRegion
        {
            /// <summary>
            /// Clusters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dsql-cluster-multiregionproperties.html#cfn-dsql-cluster-multiregionproperties-clusters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? Clusters { get; set; }
            /// <summary>
            /// WitnessRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dsql-cluster-multiregionproperties.html#cfn-dsql-cluster-multiregionproperties-witnessregion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? WitnessRegion { get; set; }
        }
    }
}