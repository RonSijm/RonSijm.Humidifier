namespace Humidifier.RedshiftServerless
{
    using global::System.Collections.Generic;
    using NamespaceTypes;

    public class Namespace : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveTags, IHaveManageAdminPassword_Boolean, IHaveStringListOfIamRoles, IHaveListOfRedshiftServerlessNamespaceTypesSnapshotCopyConfigurationSnapshotCopyConfigurations, IHaveKmsKeyId, IHaveFinalSnapshotName, IHaveFinalSnapshotRetentionPeriod_Integer, IHaveAdminUserPassword, IHaveAdminPasswordSecretKmsKeyId, IHaveDefaultIamRoleArn, IHaveAdminUsername, IHaveNamespaceName, IHaveNamespaceResourcePolicy_Json, IHaveRedshiftIdcApplicationArn, IHaveDbName, IHaveStringListOfLogExports
    {
        public class Attributes
        {
            public static string Namespace =  "Namespace" ;
        }

        public override string AWSTypeName { get => AWS.RedshiftServerless.Namespace; }
        /// <summary>
        /// ManageAdminPassword
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-manageadminpassword
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public Union<bool, BaseFunction>? ManageAdminPassword { get; set; }
        /// <summary>
        /// IamRoles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-iamroles
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IamRoles { get; set; }
        /// <summary>
        /// SnapshotCopyConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-snapshotcopyconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SnapshotCopyConfiguration
        /// </summary>
        public Union<IReadOnlyList<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration>, IReadOnlyList<Union<Humidifier.RedshiftServerless.NamespaceTypes.SnapshotCopyConfiguration, BaseFunction>>, BaseFunction>? SnapshotCopyConfigurations { get; set; }
        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-kmskeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? KmsKeyId { get; set; }
        /// <summary>
        /// FinalSnapshotName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-finalsnapshotname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? FinalSnapshotName { get; set; }
        /// <summary>
        /// FinalSnapshotRetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-finalsnapshotretentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public Union<int, BaseFunction>? FinalSnapshotRetentionPeriod { get; set; }
        /// <summary>
        /// AdminUserPassword
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-adminuserpassword
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AdminUserPassword { get; set; }
        /// <summary>
        /// AdminPasswordSecretKmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-adminpasswordsecretkmskeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AdminPasswordSecretKmsKeyId { get; set; }
        /// <summary>
        /// DefaultIamRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-defaultiamrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DefaultIamRoleArn { get; set; }
        /// <summary>
        /// AdminUsername
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-adminusername
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? AdminUsername { get; set; }
        public Union<string, BaseFunction>? NamespaceName { get => GivenName; set => GivenName = value; }
        /// <summary>
        /// NamespaceResourcePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-namespaceresourcepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public Union<object, BaseFunction>? NamespaceResourcePolicy { get; set; }
        /// <summary>
        /// RedshiftIdcApplicationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-redshiftidcapplicationarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? RedshiftIdcApplicationArn { get; set; }
        /// <summary>
        /// DbName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-dbname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? DbName { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public Union<IReadOnlyList<Humidifier.Tag>, IReadOnlyList<Union<Humidifier.Tag, BaseFunction>>, BaseFunction>? Tags { get; set; }
        /// <summary>
        /// LogExports
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshiftserverless-namespace.html#cfn-redshiftserverless-namespace-logexports
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogExports { get; set; }
    }

    namespace NamespaceTypes
    {
        public class Namespace : Humidifier.Base.BaseSubResource, IHaveStatus, IHaveCreationDate, IHaveStringListOfIamRoles, IHaveKmsKeyId, IHaveAdminPasswordSecretKmsKeyId, IHaveDefaultIamRoleArn, IHaveAdminPasswordSecretArn, IHaveNamespaceName, IHaveAdminUsername, IHaveNamespaceArn, IHaveDbName, IHaveNamespaceId, IHaveStringListOfLogExports
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-namespace.html#cfn-redshiftserverless-namespace-namespace-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? Status { get; set; }
            /// <summary>
            /// CreationDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-namespace.html#cfn-redshiftserverless-namespace-namespace-creationdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? CreationDate { get; set; }
            /// <summary>
            /// IamRoles
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-namespace.html#cfn-redshiftserverless-namespace-namespace-iamroles
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? IamRoles { get; set; }
            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-namespace.html#cfn-redshiftserverless-namespace-namespace-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? KmsKeyId { get; set; }
            /// <summary>
            /// AdminPasswordSecretKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-namespace.html#cfn-redshiftserverless-namespace-namespace-adminpasswordsecretkmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdminPasswordSecretKmsKeyId { get; set; }
            /// <summary>
            /// DefaultIamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-namespace.html#cfn-redshiftserverless-namespace-namespace-defaultiamrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DefaultIamRoleArn { get; set; }
            /// <summary>
            /// AdminPasswordSecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-namespace.html#cfn-redshiftserverless-namespace-namespace-adminpasswordsecretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdminPasswordSecretArn { get; set; }
            /// <summary>
            /// NamespaceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-namespace.html#cfn-redshiftserverless-namespace-namespace-namespacename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NamespaceName { get; set; }
            /// <summary>
            /// AdminUsername
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-namespace.html#cfn-redshiftserverless-namespace-namespace-adminusername
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? AdminUsername { get; set; }
            /// <summary>
            /// NamespaceArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-namespace.html#cfn-redshiftserverless-namespace-namespace-namespacearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NamespaceArn { get; set; }
            /// <summary>
            /// DbName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-namespace.html#cfn-redshiftserverless-namespace-namespace-dbname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DbName { get; set; }
            /// <summary>
            /// NamespaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-namespace.html#cfn-redshiftserverless-namespace-namespace-namespaceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? NamespaceId { get; set; }
            /// <summary>
            /// LogExports
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-namespace.html#cfn-redshiftserverless-namespace-namespace-logexports
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public Union<IReadOnlyList<string>, IReadOnlyList<Union<string, BaseFunction>>, BaseFunction>? LogExports { get; set; }
        }

        public class SnapshotCopyConfiguration : Humidifier.Base.BaseSubResource, IHaveSnapshotRetentionPeriod_Integer, IHaveDestinationKmsKeyId, IHaveDestinationRegion
        {
            /// <summary>
            /// SnapshotRetentionPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-snapshotcopyconfiguration.html#cfn-redshiftserverless-namespace-snapshotcopyconfiguration-snapshotretentionperiod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public Union<int, BaseFunction>? SnapshotRetentionPeriod { get; set; }
            /// <summary>
            /// DestinationKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-snapshotcopyconfiguration.html#cfn-redshiftserverless-namespace-snapshotcopyconfiguration-destinationkmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationKmsKeyId { get; set; }
            /// <summary>
            /// DestinationRegion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-redshiftserverless-namespace-snapshotcopyconfiguration.html#cfn-redshiftserverless-namespace-snapshotcopyconfiguration-destinationregion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? DestinationRegion { get; set; }
        }
    }
}