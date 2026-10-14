namespace Humidifier.CleanRooms
{
    using global::System.Collections.Generic;
    using AnalysisTemplateTypes;

    public class AnalysisTemplate : Humidifier.Base.BaseResource, IHaveImpliedResourceName, IHaveName, IHaveTags, IHaveDescription, IHaveFormat, IHaveMembershipIdentifier
    {
        public class Attributes
        {
            public static string CollaborationIdentifier =  "CollaborationIdentifier" ;
            public static string MembershipArn =  "MembershipArn" ;
            public static string Arn =  "Arn" ;
            public static string CollaborationArn =  "CollaborationArn" ;
            public static string AnalysisTemplateIdentifier =  "AnalysisTemplateIdentifier" ;
        }

        public override string AWSTypeName { get => AWS.CleanRooms.AnalysisTemplate; }

        /// <summary>
        /// MembershipIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-membershipidentifier
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic MembershipIdentifier { get; set; }
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Format
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-format
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        [Required]
        public dynamic Format { get; set; }
        /// <summary>
        /// SourceMetadata
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-sourcemetadata
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AnalysisSourceMetadata
        /// </summary>
        public Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSourceMetadata SourceMetadata { get; set; }
        /// <summary>
        /// ErrorMessageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-errormessageconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ErrorMessageConfiguration
        /// </summary>
        public Humidifier.CleanRooms.AnalysisTemplateTypes.ErrorMessageConfiguration ErrorMessageConfiguration { get; set; }
        /// <summary>
        /// AnalysisParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-analysisparameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: AnalysisParameter
        /// </summary>
        public List<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisParameter> AnalysisParameters { get; set; }
        /// <summary>
        /// Schema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-schema
        /// Required: False
        /// UpdateType: Immutable
        /// Type: AnalysisSchema
        /// </summary>
        public Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSchema Schema { get; set; }
        /// <summary>
        /// SyntheticDataParameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-syntheticdataparameters
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SyntheticDataParameters
        /// </summary>
        public Humidifier.CleanRooms.AnalysisTemplateTypes.SyntheticDataParameters SyntheticDataParameters { get; set; }

        /// <summary>
        /// Source
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-source
        /// Required: True
        /// UpdateType: Immutable
        /// Type: AnalysisSource
        /// </summary>
        [Required]
        public Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisSource Source { get; set; }
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cleanrooms-analysistemplate.html#cfn-cleanrooms-analysistemplate-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Humidifier.Tag> Tags { get; set; }
        public dynamic Name { get => GivenName; set => GivenName = value; }
    }

    namespace AnalysisTemplateTypes
    {
        public class AnalysisParameter : Humidifier.Base.BaseSubResource, IHaveName, IHaveType, IHaveDefaultValue
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysisparameter.html#cfn-cleanrooms-analysistemplate-analysisparameter-defaultvalue
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultValue { get; set; }
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysisparameter.html#cfn-cleanrooms-analysistemplate-analysisparameter-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysisparameter.html#cfn-cleanrooms-analysistemplate-analysisparameter-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name { get; set; }
        }

        public class AnalysisSchema : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ReferencedTables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysisschema.html#cfn-cleanrooms-analysistemplate-analysisschema-referencedtables
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ReferencedTables { get; set; }
        }

        public class AnalysisSource : Humidifier.Base.BaseSubResource, IHaveText
        {
            /// <summary>
            /// Artifacts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysissource.html#cfn-cleanrooms-analysistemplate-analysissource-artifacts
            /// Required: False
            /// UpdateType: Immutable
            /// Type: AnalysisTemplateArtifacts
            /// </summary>
            public Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifacts Artifacts { get; set; }
            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysissource.html#cfn-cleanrooms-analysistemplate-analysissource-text
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text { get; set; }
        }

        public class AnalysisSourceMetadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Artifacts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysissourcemetadata.html#cfn-cleanrooms-analysistemplate-analysissourcemetadata-artifacts
            /// Required: True
            /// UpdateType: Mutable
            /// Type: AnalysisTemplateArtifactMetadata
            /// </summary>
            public Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifactMetadata Artifacts { get; set; }
        }

        public class AnalysisTemplateArtifact : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Location
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysistemplateartifact.html#cfn-cleanrooms-analysistemplate-analysistemplateartifact-location
            /// Required: True
            /// UpdateType: Immutable
            /// Type: S3Location
            /// </summary>
            public Humidifier.CleanRooms.AnalysisTemplateTypes.S3Location Location { get; set; }
        }

        public class AnalysisTemplateArtifactMetadata : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// EntryPointHash
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysistemplateartifactmetadata.html#cfn-cleanrooms-analysistemplate-analysistemplateartifactmetadata-entrypointhash
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Hash
            /// </summary>
            public Humidifier.CleanRooms.AnalysisTemplateTypes.Hash EntryPointHash { get; set; }
            /// <summary>
            /// AdditionalArtifactHashes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysistemplateartifactmetadata.html#cfn-cleanrooms-analysistemplate-analysistemplateartifactmetadata-additionalartifacthashes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Hash
            /// </summary>
            public List<Humidifier.CleanRooms.AnalysisTemplateTypes.Hash> AdditionalArtifactHashes { get; set; }
        }

        public class AnalysisTemplateArtifacts : Humidifier.Base.BaseSubResource, IHaveRoleArn
        {
            /// <summary>
            /// AdditionalArtifacts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysistemplateartifacts.html#cfn-cleanrooms-analysistemplate-analysistemplateartifacts-additionalartifacts
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: AnalysisTemplateArtifact
            /// </summary>
            public List<Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact> AdditionalArtifacts { get; set; }
            /// <summary>
            /// EntryPoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysistemplateartifacts.html#cfn-cleanrooms-analysistemplate-analysistemplateartifacts-entrypoint
            /// Required: True
            /// UpdateType: Immutable
            /// Type: AnalysisTemplateArtifact
            /// </summary>
            public Humidifier.CleanRooms.AnalysisTemplateTypes.AnalysisTemplateArtifact EntryPoint { get; set; }
            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-analysistemplateartifacts.html#cfn-cleanrooms-analysistemplate-analysistemplateartifacts-rolearn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn { get; set; }
        }

        public class ColumnClassificationDetails : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ColumnMapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-columnclassificationdetails.html#cfn-cleanrooms-analysistemplate-columnclassificationdetails-columnmapping
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SyntheticDataColumnProperties
            /// </summary>
            public List<Humidifier.CleanRooms.AnalysisTemplateTypes.SyntheticDataColumnProperties> ColumnMapping { get; set; }
        }

        public class ErrorMessageConfiguration : Humidifier.Base.BaseSubResource, IHaveType
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-errormessageconfiguration.html#cfn-cleanrooms-analysistemplate-errormessageconfiguration-type
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type { get; set; }
        }

        public class Hash : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// Sha256
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-hash.html#cfn-cleanrooms-analysistemplate-hash-sha256
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Sha256 { get; set; }
        }

        public class MLSyntheticDataParameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// ColumnClassification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-mlsyntheticdataparameters.html#cfn-cleanrooms-analysistemplate-mlsyntheticdataparameters-columnclassification
            /// Required: True
            /// UpdateType: Immutable
            /// Type: ColumnClassificationDetails
            /// </summary>
            public Humidifier.CleanRooms.AnalysisTemplateTypes.ColumnClassificationDetails ColumnClassification { get; set; }
            /// <summary>
            /// Epsilon
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-mlsyntheticdataparameters.html#cfn-cleanrooms-analysistemplate-mlsyntheticdataparameters-epsilon
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Epsilon { get; set; }
            /// <summary>
            /// MaxMembershipInferenceAttackScore
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-mlsyntheticdataparameters.html#cfn-cleanrooms-analysistemplate-mlsyntheticdataparameters-maxmembershipinferenceattackscore
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MaxMembershipInferenceAttackScore { get; set; }
        }

        public class S3Location : Humidifier.Base.BaseSubResource, IHaveKey, IHaveBucket
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-s3location.html#cfn-cleanrooms-analysistemplate-s3location-bucket
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket { get; set; }
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-s3location.html#cfn-cleanrooms-analysistemplate-s3location-key
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key { get; set; }
        }

        public class SyntheticDataColumnProperties : Humidifier.Base.BaseSubResource, IHaveColumnName, IHaveColumnType
        {
            /// <summary>
            /// ColumnName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-syntheticdatacolumnproperties.html#cfn-cleanrooms-analysistemplate-syntheticdatacolumnproperties-columnname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnName { get; set; }
            /// <summary>
            /// ColumnType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-syntheticdatacolumnproperties.html#cfn-cleanrooms-analysistemplate-syntheticdatacolumnproperties-columntype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ColumnType { get; set; }
            /// <summary>
            /// IsPredictiveValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-syntheticdatacolumnproperties.html#cfn-cleanrooms-analysistemplate-syntheticdatacolumnproperties-ispredictivevalue
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsPredictiveValue { get; set; }
        }

        public class SyntheticDataParameters : Humidifier.Base.BaseSubResource
        {
            /// <summary>
            /// MlSyntheticDataParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cleanrooms-analysistemplate-syntheticdataparameters.html#cfn-cleanrooms-analysistemplate-syntheticdataparameters-mlsyntheticdataparameters
            /// Required: True
            /// UpdateType: Immutable
            /// Type: MLSyntheticDataParameters
            /// </summary>
            public Humidifier.CleanRooms.AnalysisTemplateTypes.MLSyntheticDataParameters MlSyntheticDataParameters { get; set; }
        }
    }
}