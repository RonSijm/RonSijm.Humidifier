namespace Humidifier.AppSync
{
    using global::System.Collections.Generic;
    using SourceApiAssociationTypes;

    public class SourceApiAssociation : Humidifier.Base.BaseResource, IHaveDescription, IHaveAppSyncSourceApiAssociationTypesSourceApiAssociationConfigSourceApiAssociationConfig, IHaveMergedApiIdentifier, IHaveSourceApiIdentifier
    {
        public class Attributes
        {
            public static string AssociationArn =  "AssociationArn" ;
            public static string MergedApiId =  "MergedApiId" ;
            public static string SourceApiArn =  "SourceApiArn" ;
            public static string LastSuccessfulMergeDate =  "LastSuccessfulMergeDate" ;
            public static string SourceApiAssociationStatusDetail =  "SourceApiAssociationStatusDetail" ;
            public static string MergedApiArn =  "MergedApiArn" ;
            public static string AssociationId =  "AssociationId" ;
            public static string SourceApiAssociationStatus =  "SourceApiAssociationStatus" ;
            public static string SourceApiId =  "SourceApiId" ;
        }

        public override string AWSTypeName { get => AWS.AppSync.SourceApiAssociation; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-sourceapiassociation.html#cfn-appsync-sourceapiassociation-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? Description { get; set; }
        /// <summary>
        /// SourceApiAssociationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-sourceapiassociation.html#cfn-appsync-sourceapiassociation-sourceapiassociationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SourceApiAssociationConfig
        /// </summary>
        public Union<Humidifier.AppSync.SourceApiAssociationTypes.SourceApiAssociationConfig, BaseFunction>? SourceApiAssociationConfig { get; set; }
        /// <summary>
        /// MergedApiIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-sourceapiassociation.html#cfn-appsync-sourceapiassociation-mergedapiidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? MergedApiIdentifier { get; set; }
        /// <summary>
        /// SourceApiIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-sourceapiassociation.html#cfn-appsync-sourceapiassociation-sourceapiidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public Union<string, BaseFunction>? SourceApiIdentifier { get; set; }
    }

    namespace SourceApiAssociationTypes
    {
        public class SourceApiAssociationConfig : Humidifier.Base.BaseSubResource, IHaveMergeType
        {
            /// <summary>
            /// MergeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-sourceapiassociation-sourceapiassociationconfig.html#cfn-appsync-sourceapiassociation-sourceapiassociationconfig-mergetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public Union<string, BaseFunction>? MergeType { get; set; }
        }
    }
}